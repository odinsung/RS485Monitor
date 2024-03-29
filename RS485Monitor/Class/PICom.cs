﻿using System;
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
        private Byte[] AppDataBuf = new Byte[4096];
        private int AppDataPtr = 0;
        private bool AppDataOverflow = false;
        protected String AppData = String.Empty;
        public Byte[] RawBuf = new Byte[4096];
        public int RawPtr = 0;

        public PICom() // 建構子
        {
            Port.DataReceived += Port_DataReceived;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e) // 接收資料的事件處理
        {
            Byte[] data = new Byte[4096];
            int length = 0;
            if (Port.BytesToRead > 0)
            {
                length = Port.BytesToRead;

                //data[0] = (Byte)Port.ReadByte();
                //ReceivedDataHandler(data, 1);


                for(int i=0; i<length; i++)
                {
                    data[i] = (Byte)Port.ReadByte();
                }
                ReceivedDataHandler(data, length);
            }
        }
        public void Fake_DataReceived(Byte[] fakeData, int length) // 用假資料來測試(模擬序列埠接收到資料)
        {
            ReceivedDataHandler(fakeData, length);
        }
        public void GetRawBuf(ref Byte[] buf, ref int len) 
        {
            Array.Copy(RawBuf, 0, buf, 0, RawPtr);
            len = RawPtr;
            RawPtr = 0;
            Array.Clear(RawBuf, 0, len);
        }
        private void ReceivedDataHandler(Byte[] rxData, int length) // 接收資料解析 (Received Data Parsing)
        {
            Byte c = 0;
            for(int i=0; i<length; i++)
            {
                c = rxData[i];
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
                        }else if (c == 0x10)
                        {
                            // Do nothing
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
                            if (AppDataPtr < 4096)
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
                            //AppData = System.Text.Encoding.ASCII.GetString(AppDataBuf, 0, AppDataPtr);
                            //ThrowReceiveDoneEvent();
                            //RxState = 0;
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
                            RxState = 0;
                        }
                        else if (c == 0x10) // workaround: sometimes BCC is missed
                        {
                            AppData = System.Text.Encoding.ASCII.GetString(AppDataBuf, 0, AppDataPtr);
                            ThrowReceiveDoneEvent();
                            RxState = 1;
                            ThrowErrorEvent("BCC Missed");
                        }
                        else
                        {
                            ThrowErrorEvent("BCC Error (0x" + BCC.ToString("X2") + "/0x" + c.ToString("X2") + ")");
                            RxState = 0;
                        }
                        //RxState = 0;
                        break;
                    default:
                        RxState = 0; // Reset state
                        break;
                }
            }
        }

        protected void Port_SendPacket(String messageType, String data) // 送出回應封包
        {
            Byte bcc = 0;
            Byte[] buf = new Byte[4096];
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
            ThrowDataSentEvent(buf, 7 + data.Length);
            if (Port.IsOpen)
            {
                Port.DiscardOutBuffer();
                Port.DiscardInBuffer();
                Port.Write(buf, 0, 7 + data.Length);
                // Flush RawBuf[]
                RawPtr = 0;
                Array.Clear(RawBuf, 0, 4096);
            }
            else
            {
                ThrowErrorEvent("Data is not sent. Serial Port is Not Opened");
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
        // 事件[發生錯誤]的參數定義
        public class ErrorEventArgs : EventArgs
        {
            public String ErrorMessage { get; set; }
            public ErrorEventArgs(String errmsg)
            {
                ErrorMessage = errmsg;
            }
        }
        // 事件[送出資料]的參數定義 : (準備要送出的資料陣列, 資料陣列的長度)
        public class DataSentEventArgs : EventArgs
        {
            public Byte[] DataSent;
            public int DataSentLen = 0;
            public DataSentEventArgs(Byte[] data, int length)
            {
                DataSent = data;
                DataSentLen = length;
            }
        }
        public event EventHandler<ErrorEventArgs> Evt_ErrorOccur; // 事件[發生錯誤]:宣告
        public event EventHandler<EventArgs> ReceiveDone; // 事件[接收完成]:宣告
        public event EventHandler<DataSentEventArgs> Evt_DataSent; // 事件[送出資料]:宣告
        protected virtual void ThrowErrorEvent(String errmsg) // 事件[發生錯誤]:丟出事件的函式
        {
            ErrorEventArgs e = new ErrorEventArgs(errmsg);
            Evt_ErrorOccur?.Invoke(this, e);
        }
        protected virtual void ThrowReceiveDoneEvent() // 事件[接收完成]:丟出事件的函式
        {
            EventArgs e = new EventArgs();
            ReceiveDone?.Invoke(this, e);
        }
        protected virtual void ThrowDataSentEvent(Byte[] data, int length) // 事件[送出資料]:丟出事件的函式
        {
            DataSentEventArgs e = new DataSentEventArgs(data, length);
            Evt_DataSent?.Invoke(this, e);
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

        public event EventHandler<EventArgs> Evt_TrsifRequest;
        protected virtual void ThrowTRSIFRequestEvent()
        {
            EventArgs e = new EventArgs();
            Evt_TrsifRequest?.Invoke(this, e);
        }
    }

    public class PISC : PICom
    {
        private int AudioVolume = 0; // 子機音量
        private int EmergencyDeviceCount = 0; // 呼叫子機數量
        private List<String> AlarmDevice = new List<String>(); // 呼叫子機名稱
        private int[] PEIStatus = new int[4]; // 主機(PEI/PEIH)狀態
        private int DeviceErrorCount = 0; // 斷線子機數量
        private List<String> PEHStatus = new List<String>(); // 斷線子機名稱
        private int[] HUBStatus = new int[12]; // HUB狀態(0:online, 1:timeout)

        private int IpMacCnt = 0;
        private List<String> IpMacTable = new List<String>();

        private const int AlarmDeviceStrLen = 7; // Length of string of each Alarm Device.
        private const int PEHStatusStrLen = 6; // Length of string of each PEH Status.
        private const int EmergencyDeviceCountMax = 20; // Maximum number of Emergency Device Count.
        private const int DeviceErrorCountMax = 65; // Maximum number of Device Error Count.


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
        public int GetHUBStatus(int index)
        {
            return index < 12 ? HUBStatus[index] : -1;
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

        public int GetIpMacCount()
        {
            return IpMacCnt;
        }
        public String GetIpMac(int index)
        {
            String ipmac = String.Empty;
            if (index < IpMacCnt)
            {
                ipmac = IpMacTable[index];
            }
            return ipmac;
        }


        public void SendResponse(int setAudioVolume)
        {
            String data = setAudioVolume >= 0 && setAudioVolume <= 10 ? setAudioVolume.ToString("D2") : "FF";
            Port_SendPacket("C0", data);
        }

        public void SendAskIpMacTable()
        {
            Port_SendPacket("C1", "");
        }


        private void PISC_ReceiveDone(object sender, EventArgs e)
        {
            int vol = 0;
            int emgCnt = 0;
            int devErrCnt = 0;
            int[] peiSta = new int[4];
            int[] hubSta = new int[12];
            String str = String.Empty;

            int ipMacCnt = 0;

            try
            {
                if (AppData.Length < 2) 
                { 
                    ThrowErrorEvent("Message Length Error"); 
                    return;
                }
                str = AppData.Substring(0, 2);
                if (str == "40") // Report IS Status
                {
                    if (!int.TryParse(AppData.Substring(2, 2), out vol))
                    {
                        ThrowErrorEvent("Audio Volumn Parsing Error");
                        return;
                    }
                    if (!int.TryParse(AppData.Substring(4, 2), out emgCnt)) 
                    { 
                        ThrowErrorEvent("Calling PEH Parsing Error"); 
                        return; 
                    }
                    if (emgCnt > EmergencyDeviceCountMax) 
                    { 
                        ThrowErrorEvent("Calling PEH Count Error");
                        return;
                    }
                    if (!int.TryParse(AppData.Substring(10 + emgCnt * AlarmDeviceStrLen, 2), out devErrCnt))
                    { 
                        ThrowErrorEvent("Device Error Count Parsing Error");
                        return;
                    }
                    if (devErrCnt > DeviceErrorCountMax)
                    { 
                        ThrowErrorEvent("Device Error Count Error");
                        return;
                    }
                    if (AppData.Length != (24 + AlarmDeviceStrLen * emgCnt + PEHStatusStrLen * devErrCnt))
                    {
                        //ThrowErrorEvent("App Data Length Error");
                        int l = 24 + AlarmDeviceStrLen * emgCnt + PEHStatusStrLen * devErrCnt;
                        string s = "AppDataLen=" + AppData.Length.ToString() + ", should be " + l.ToString() +
                            ", emgCnt=" + emgCnt.ToString() + ", devErrCnt=" + devErrCnt.ToString();
                        ThrowErrorEvent(s);
                        return;
                    }
                    str = AppData.Substring(6 + AlarmDeviceStrLen * emgCnt, 4);
                    for (int i = 0; i < 4; i++)
                    {
                        if (!int.TryParse(AppData.Substring(6 + AlarmDeviceStrLen * emgCnt + i, 1), out peiSta[i]))
                        {
                            ThrowErrorEvent("PEI Status Error");
                            return;
                        }
                    }
                    for(int i = 0; i < 12; i++)
                    {
                        if (!int.TryParse(AppData.Substring(12+AlarmDeviceStrLen*emgCnt+PEHStatusStrLen*devErrCnt+i, 1), out hubSta[i]))
                        {
                            ThrowErrorEvent("HUB Status Error");
                            return;
                        }
                    }
                    AudioVolume = vol; //----------------------------------------------------- (1) Audio Volume
                    EmergencyDeviceCount = emgCnt; //----------------------------------------- (2) Calling PEH Count
                    AlarmDevice.Clear(); //--------------------------------------------------- (3) Calling PEH
                    str = AppData.Substring(6, emgCnt * AlarmDeviceStrLen);
                    for (int i = 0; i < EmergencyDeviceCount; i++)
                    {
                        AlarmDevice.Add(str.Substring(i * AlarmDeviceStrLen, AlarmDeviceStrLen));
                    }
                    Array.Copy(peiSta, PEIStatus, 4); //-------------------------------------- (4) PEI Status
                    DeviceErrorCount = devErrCnt; //------------------------------------------ (5) Device Error Count
                    PEHStatus.Clear(); //----------------------------------------------------- (6) PEH Status
                    str = AppData.Substring(12 + emgCnt * AlarmDeviceStrLen, devErrCnt * PEHStatusStrLen);
                    for (int i = 0; i < devErrCnt; i++)
                    {
                        PEHStatus.Add(str.Substring(i * PEHStatusStrLen, PEHStatusStrLen));
                    }
                    Array.Copy(hubSta, HUBStatus, 12); //------------------------------------- (7) HUB Status
                    ThrowReportISStatusEvent();
                }
                else if (str == "41") // Response IP-MAC Table
                {
                    if (!int.TryParse(AppData.Substring(2, 2), out ipMacCnt))
                    {
                        ThrowErrorEvent("IP-MAC Count Parsing Error");
                        return;
                    }
                    if (ipMacCnt > 99)
                    {
                        ThrowErrorEvent("IP-MAC Count Error");
                        return;
                    }
                    if (AppData.Length != (4 + 20 * ipMacCnt))
                    {
                        ThrowErrorEvent("App Data Length Error");
                        return;
                    }
                    IpMacCnt = ipMacCnt;
                    str = AppData.Substring(4, 20 * ipMacCnt);
                    for (int i = 0; i < IpMacCnt; i++)
                    {
                        IpMacTable.Add(str.Substring(i * 20, 20));
                    }
                    ThrowResponseIpMacTableEvent();
                }
                else
                {
                    ThrowErrorEvent("Message Type Error");
                }                
            }
            catch(Exception ex)
            {
                ThrowErrorEvent(ex.Message);
            }
        }

        public event EventHandler<EventArgs> Evt_ReportIsStatus;
        protected virtual void ThrowReportISStatusEvent()
        {
            EventArgs e = new EventArgs();
            Evt_ReportIsStatus?.Invoke(this, e);
        }

        public event EventHandler<EventArgs> Evt_RspIpMacTable;

        protected virtual void ThrowResponseIpMacTableEvent()
        {
            EventArgs e = new EventArgs();
            Evt_RspIpMacTable?.Invoke(this, e);
        }

    }

    
}
