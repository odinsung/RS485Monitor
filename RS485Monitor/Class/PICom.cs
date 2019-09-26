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

    }

    public class TRS : PICom
    {
        public TRS()
        {

        }
    }

    public class PISC : PICom
    {
        public PISC()
        {

        }
    }

    
}
