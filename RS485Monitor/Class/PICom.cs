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
        protected String AppData = String.Empty;
        public Byte[] RawBuf = new Byte[256];
        public int RawPtr = 0;
        private String _Message = "";
        public String Message
        {
            get
            {
                String tmp = _Message;
                _Message = String.Empty;
                return tmp;
            }
        }
        public PICom()
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
                        break;
                    case 1: //---------------------------------------- Receive STX (0x02)
                        if (c == 0x02)
                        {
                            RxState = 2;
                            BCC = 0;
                            AppDataPtr = 0;
                        }
                        break;
                    case 2: //---------------------------------------- Receive Application Data & DLE
                        if (c == 0x10)
                        {
                            RxState = 3;
                        }
                        else
                        {
                            if (AppDataPtr < 256)
                            {
                                AppDataBuf[AppDataPtr++] = c;
                            }                            
                            BCC ^= c;
                        }
                        break;
                    case 3: //---------------------------------------- Receive ETX (0x03)
                        if (c == 0x03)
                        {
                            RxState = 4;
                        }
                        break;
                    case 4: //---------------------------------------- Receive BCC
                        if (c == BCC)
                        {
                            AppData = System.Text.Encoding.ASCII.GetString(AppDataBuf, 0, AppDataPtr);
                            ThrowReceveDoneEvent();
                        }
                        RxState = 0;
                        break;
                    default:
                        RxState = 0; // Reset state
                        break;
                }
            }
        }

        public bool Open(String portName)
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
                _Message = e.Message;
                isOk = false;
            }
            return isOk;
        }
        public void Close()
        {
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }

        public event EventHandler<EventArgs> ReceiveDone;
        protected virtual void ThrowReceveDoneEvent()
        {
            EventArgs e = new EventArgs();
            ReceiveDone?.Invoke(this, e);
        }
        


       
    }

    public class TRS : PICom
    {
        private List<String> AlarmDevice = new List<string>();
        private bool CallPickupStatus = false;
        private int EmergencyDeviceCount = 0;

        public TRS()
        {
            ReceiveDone += TRS_ReceiveDone;
        }

        private void TRS_ReceiveDone(object sender, EventArgs e)
        {
            
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

        }
    }

    
}
