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
        private bool IsAnyOneTalking = false;
        private int CallingPEHCount = 0;
        private List<String> CallingPEH = new List<String>();

        public TRS()
        {
            // PICom 丟出的 ReceiveDone 事件，觸發處理函式 TRS_ReceiveDone()
            ReceiveDone += TRS_ReceiveDone;
        }

        public bool IsTalking()
        {
            return IsAnyOneTalking;
        }
        public int GetCallingPEHCount()
        {
            return CallingPEHCount;
        }
        public String GetCallingPEHInfo(int index)
        {
            String peh = String.Empty;
            if (index < CallingPEHCount)
            {
                peh = CallingPEH[index];
            }
            return peh;
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
                        IsAnyOneTalking = isTalking;
                        CallingPEHCount = pehCnt;
                        CallingPEH.Clear();
                        for (int i = 0; i < CallingPEHCount; i++) // Get Calling PEH Information. (Ex: "C01D02")
                        {
                            CallingPEH.Add(AppData.Substring(5 + i * 6, 6)); // Offset = i*6+5, Length=6
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
        public PISC()
        {
            // PICom 丟出的 ReceiveDone 事件，觸發處理函式 PISC_ReceiveDone()
            ReceiveDone += PISC_ReceiveDone;
        }

        private void PISC_ReceiveDone(object sender, EventArgs e)
        {
            
        }

        public event EventHandler<EventArgs> ReportISStatus;
        protected virtual void ThrowReportISStatusEvent()
        {
            EventArgs e = new EventArgs();
            ReportISStatus?.Invoke(this, e);
        }
    }

    
}
