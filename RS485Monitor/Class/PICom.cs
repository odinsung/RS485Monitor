using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace RS485Monitor.Class
{
    public class PICom
    {
        private SerialPort Port = new SerialPort();
        private int RxState = 0;
        private Byte BCC = 0;
        private Byte[] AppDataBuf = new Byte[256];
        private int AppDataPtr = 0;
        private bool AppDataOverflow = false;
        protected String AppData = String.Empty;
        public Byte[] RawBuf = new Byte[256];
        public int RawPtr = 0;

        public PICom() // 建構子
        {
            Port.DataReceived += Port_DataReceived;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e) // 接收資料的事件處理
        {
            Byte c = 0;
            while(Port.BytesToRead > 0)
            {
                c = (Byte)Port.ReadByte();
                RawBuf[RawPtr++] = c;
                switch (RxState)
                {
                    case 0: //---------------------------------------- Receive DLE (0x10)
                        if (c == 0x10)
                        {
                            RxState = 1;
                        }
                        else
                        {
                            ThrowErrorEvent("Rx 1st DLE Error (0x" + c.ToString("X2") + ")");
                        }
                        break;
                    case 1: //---------------------------------------- Receive STX (0x02)
                        if (c == 0x02)
                        {
                            RxState = 2;
                            BCC = 0;
                            AppDataPtr = 0;
                        }
                        else
                        {
                            ThrowErrorEvent("Rx 1st STX Error (0x" + c.ToString("X2") + ")");
                            RxState = 0;
                        }
                        break;
                    case 2: //---------------------------------------- Receive Application Data & DLE
                        if (c == 0x10)
                        {
                            RxState = 3;
                            if (AppDataOverflow)
                            {
                                AppDataOverflow = false;
                                ThrowErrorEvent("App Data Overflow!");
                            }
                        }
                        else
                        {
                            if (AppDataPtr < 256)
                            {
                                AppDataBuf[AppDataPtr++] = c;
                            }
                            else
                            {
                                AppDataOverflow = true;
                            }                            
                            BCC ^= c;
                        }
                        break;
                    case 3: //---------------------------------------- Receive ETX (0x03)
                        if (c == 0x03)
                        {
                            RxState = 4;
                        }
                        else
                        {
                            ThrowErrorEvent("Rx ETX Error (0x" + c.ToString("X2") + ")");
                            RxState = 0;
                        }
                        break;
                    case 4: //---------------------------------------- Receive BCC
                        if (c == BCC)
                        {
                            AppData = System.Text.Encoding.ASCII.GetString(AppDataBuf, 0, AppDataPtr);
                            ThrowReceiveDoneEvent();
                        }
                        else
                        {
                            ThrowErrorEvent("BCC Error (0x" + BCC.ToString("X2") + "/0x" + c.ToString("X2") + ")");
                        }
                        RxState = 0;
                        break;
                    default:
                        RxState = 0; // Reset state
                        break;
                }
            }
        }
        protected void Port_SendPacket(String messageType, String data)
        {
            Byte bcc = 0;
            Byte[] buf = new Byte[256];
            if (messageType.Length != 2)
            {
                ThrowErrorEvent("Sending fails. Message Type Error");
                return;
            }
            buf[0] = 0x10; // DLE
            buf[1] = 0x02; // STX
            buf[2] = (Byte)messageType[0]; bcc ^= buf[2];
            buf[3] = (Byte)messageType[1]; bcc ^= buf[3];
            for(int i=0; i<data.Length; i++)
            {
                buf[i + 4] = (Byte)data[i];
                bcc ^= buf[i + 4];
            }
            buf[4 + data.Length] = 0x10;
            buf[5 + data.Length] = 0x03;
            buf[6 + data.Length] = bcc;
            if (Port.IsOpen)
            {
                Port.DiscardOutBuffer();
                Port.DiscardInBuffer();
                Port.Write(buf, 0, 6 + data.Length);
                // Flush RawBuf[]
                RawPtr = 0;
                Array.Clear(RawBuf, 0, 256);
            }
            else
            {
                ThrowErrorEvent("Serial Port is Not Opened");
            }
        }

        public bool Open(String portName) // 開啟 Com Port
        {
            bool isOk = false;
            Port.BaudRate = 19200;
            try
            {
                Port.Parity = Parity.None;
                Port.DataBits = 8;
                Port.StopBits = StopBits.One;
                Port.DtrEnable = false;
                Port.RtsEnable = false;
                Port.PortName = portName;
                Port.ReceivedBytesThreshold = 1;
                Port.Open();
                isOk = true;
            }
            catch (Exception e)
            {
                ThrowErrorEvent(e.Message);
                isOk = false;
            }
            return isOk;
        }
        public void Close() // 關閉 Com Port
        {
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }

        #region Event Related
        public class ErrorEventArgs : EventArgs
        {
            public String ErrorMessage { get; set; }
        }
        public event EventHandler<ErrorEventArgs> ErrorOccur;
        public event EventHandler<EventArgs> ReceiveDone;
        protected virtual void ThrowErrorEvent(String errmsg)
        {
            ErrorEventArgs e = new ErrorEventArgs();
            e.ErrorMessage = errmsg;
            ErrorOccur?.Invoke(this, e);
        }
        protected virtual void ThrowReceiveDoneEvent()
        {
            EventArgs e = new EventArgs();
            ReceiveDone?.Invoke(this, e);
        }
        #endregion
    }

    public class TRS : PICom
    {
        private bool TRSIFCallPickUpStatus = false;
        private int EmergencyDeviceCount = 0;
        private List<String> AlarmDevice = new List<String>();

        public TRS()
        {
            // PICom 丟出的 ReceiveDone 事件，觸發處理函式 TRS_ReceiveDone()
            ReceiveDone += TRS_ReceiveDone;
        }

        public bool GetTRSIFCallPickUpStatus()
        {
            return TRSIFCallPickUpStatus;
        }
        public int GetEmergencyDeviceCount()
        {
            return EmergencyDeviceCount;
        }
        public String GetAlarmDevice(int index)
        {
            String devName = String.Empty;
            if (index < EmergencyDeviceCount)
            {
                devName = AlarmDevice[index];
            }
            return devName;
        }

        public void SendResponse(bool IsTRSCalling, DateTime dateTime)
        {
            String data = String.Empty;
            data = IsTRSCalling ? "0" : "1";
            data += dateTime.Year.ToString("D4") + dateTime.Month.ToString("D2") + dateTime.Day.ToString("D2");
            data += dateTime.Hour.ToString("D2") + dateTime.Minute.ToString("D2") + dateTime.Second.ToString("D2");
            Port_SendPacket("B0", data);
        }

        private void TRS_ReceiveDone(object sender, EventArgs e) // PICom.ReceiveDone Event Handler
        {
            int pehCnt = 0;
            bool isTalking = false;
            if (AppData.Substring(0, 2) == "30") // Message Type = "30"?
            {
                isTalking = AppData.Substring(2, 1) == "0" ? true : false; // true = There is at least one talking in this PI-system.
                if (int.TryParse(AppData.Substring(3, 2), out pehCnt))
                {
                    if (pehCnt <= 20 && AppData.Length == (5 + pehCnt * 6)) // Check parameter format and AppData length.
                    {
                        TRSIFCallPickUpStatus = isTalking;
                        EmergencyDeviceCount = pehCnt;
                        AlarmDevice.Clear();
                        for (int i = 0; i < EmergencyDeviceCount; i++) // Get Calling PEH Information. (Ex: "C01D02")
                        {
                            AlarmDevice.Add(AppData.Substring(5 + i * 6, 6)); // Offset = i*6+5, Length=6
                        }
                        ThrowTRSIFRequestEvent();
                        return;
                    }
                    else
                    {
                        ThrowErrorEvent("Call PEH Count or Data Length Error");
                    }
                }
                else
                {
                    ThrowErrorEvent("Call PEH Count Parsing Error");
                }
            }
            else
            {
                ThrowErrorEvent("Message Type Error (" + AppData.Substring(0, 2) + ")");
            }
        }

        public event EventHandler<EventArgs> TRSIFRequest;
        protected virtual void ThrowTRSIFRequestEvent()
        {
            EventArgs e = new EventArgs();
            TRSIFRequest?.Invoke(this, e);
        }
    }

    public class PISC : PICom
    {
        private int AudioVolume = 0;
        private int EmergencyDeviceCount = 0;
        private List<String> AlarmDevice = new List<String>();
        private int[] PEIStatus = new int[4];
        private int DeviceErrorCount = 0;
        private List<String> PEHStatus = new List<String>();

        public PISC()
        {
            // PICom 丟出的 ReceiveDone 事件，觸發處理函式 PISC_ReceiveDone()
            ReceiveDone += PISC_ReceiveDone;
        }

        public int GetAudioVolume()
        {
            return AudioVolume;
        }
        public int GetEmergencyDeviceCount()
        {
            return EmergencyDeviceCount;
        }
        public String GetAlarmDevice(int index)
        {
            String devName = String.Empty;
            if (index < EmergencyDeviceCount)
            {
                devName = AlarmDevice[index];
            }
            return devName;
        }
        public int GetPEIStatus(int index)
        {
            return index < 4 ? PEIStatus[index] : -1;
        }
        public int GetDeviceErrorCount()
        {
            return DeviceErrorCount;
        }
        public String GetPEHStatus(int index)
        {
            String peh = String.Empty;
            if (index < DeviceErrorCount)
            {
                peh = PEHStatus[index];
            }
            return peh;
        }


        private void PISC_ReceiveDone(object sender, EventArgs e)
        {
            int vol = 0;
            int emgCnt = 0;
            int devErrCnt = 0;
            int[] peiSta = new int[4];
            String str = String.Empty;
            if (AppData.Substring(0, 2) != "40")                                 { ThrowErrorEvent("Message Type Error");               return; }
            if (!int.TryParse(AppData.Substring(2, 2), out vol))                 { ThrowErrorEvent("Audio Volume Parsing Error");       return; }
            if (!int.TryParse(AppData.Substring(4, 2), out emgCnt))              { ThrowErrorEvent("Calling PEH Parsing Error");        return; }
            if (emgCnt > 20)                                                     { ThrowErrorEvent("Calling PEH Count Error");          return; }
            if (!int.TryParse(AppData.Substring(10+emgCnt*6, 2), out devErrCnt)) { ThrowErrorEvent("Device Error Count Parsing Error"); return; }
            if (devErrCnt > 65)                                                  { ThrowErrorEvent("Device Error Count Error");         return; }
            if (AppData.Length != (12 + 6 * emgCnt + 6 * devErrCnt))             { ThrowErrorEvent("App Data Length Error");            return; }
            str = AppData.Substring(6 + 6 * emgCnt, 4);
            for(int i=0; i<4; i++)
            {
                if (!int.TryParse(AppData.Substring(6 + 6 * emgCnt + i, 1), out peiSta[i]))
                {
                    ThrowErrorEvent("PEI Status Error");
                    return;
                }
            }
            AudioVolume = vol; //----------------------------------------------------- (1) Audio Volume
            EmergencyDeviceCount = emgCnt; //----------------------------------------- (2) Calling PEH Count
            AlarmDevice.Clear(); //--------------------------------------------------- (3) Calling PEH
            str = AppData.Substring(6, emgCnt * 6);
            for(int i=0; i<EmergencyDeviceCount; i++)
            {
                AlarmDevice.Add(str.Substring(i * 6, 6));
            }
            Array.Copy(peiSta, PEIStatus, 4); //-------------------------------------- (4) PEI Status
            DeviceErrorCount = devErrCnt; //------------------------------------------ (5) Device Error Count
            PEHStatus.Clear(); //----------------------------------------------------- (6) PEH Status
            str = AppData.Substring(12 + 6 * emgCnt, devErrCnt * 6);
            for(int i=0; i<devErrCnt; i++)
            {
                PEHStatus.Add(str.Substring(i * 6, 6));
            }
            ThrowReportISStatusEvent();
        }

        public event EventHandler<EventArgs> ReportISStatus;
        protected virtual void ThrowReportISStatusEvent()
        {
            EventArgs e = new EventArgs();
            ReportISStatus?.Invoke(this, e);
        }
    }

    
}
