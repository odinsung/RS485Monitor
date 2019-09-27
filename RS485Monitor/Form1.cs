using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using RS485Monitor.Class;

namespace RS485Monitor
{
    public partial class Form1 : Form
    {
        TRS gTRS = new TRS();
        PISC gPISC = new PISC();
        enum Role
        {
            TRS,
            PISC
        }

        public Form1()
        {
            InitializeComponent();
            ComPortItemInit();
            gTRS.ReceiveDone += GTRS_ReceiveDone;
            gTRS.ErrorOccur += GTRS_ErrorOccur;
            gPISC.ReceiveDone += GPISC_ReceiveDone;
            gPISC.ErrorOccur += GPISC_ErrorOccur;
        }

        private void GPISC_ErrorOccur(object sender, PICom.ErrorEventArgs e)
        {
            Msg(e.ErrorMessage, Role.PISC);
        }

        private void GPISC_ReceiveDone(object sender, EventArgs e)
        {
            
        }

        private void GTRS_ErrorOccur(object sender, PICom.ErrorEventArgs e)
        {
            Msg(e.ErrorMessage, Role.TRS);
        }

        private void GTRS_ReceiveDone(object sender, EventArgs e)
        {
            
        }
        #region Msg Functions
        private void Msg(String str, Role role)
        {
            try
            {
                if (role == Role.TRS)
                {
                    textBoxTRSMsg.Invoke(new EventHandler(delegate
                    {
                        textBoxTRSMsg.Text += str + Environment.NewLine;
                    }));
                }
                else
                {
                    textBoxPISCMsg.Invoke(new EventHandler(delegate
                    {
                        textBoxPISCMsg.Text += str + Environment.NewLine;
                    }));
                }
            }
            catch (InvalidOperationException)
            {
            }
        }
        #endregion
        private void ComPortItemInit()
        {
            ComPortComboBoxInit(comboBoxTRSPort);
            ComPortComboBoxInit(comboBoxPISCPort);
        }
        private void ComPortComboBoxInit(ComboBox cbxPort)
        {
            cbxPort.Items.Clear();
            foreach (String portName in SerialPort.GetPortNames())
            {
                cbxPort.Items.Add(portName);
            }
            if (cbxPort.Items.Count != 0)
            {
                cbxPort.SelectedIndex = 0;
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e) // 開啟 Com Port
        {
            Button btn = (Button)sender;
            Role r = btn == buttonTRSOpen ? Role.TRS : Role.PISC;
            String portName = r == Role.TRS ? comboBoxTRSPort.Text : comboBoxPISCPort.Text;
            if ((r == Role.TRS? gTRS.Open(portName) : gPISC.Open(portName)))
            {
                Msg("開啟成功!", r);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) // 關閉 Com Port
        {
            Button btn = (Button)sender;
            Role r = btn == buttonTRSClose ? Role.TRS : Role.PISC;
            if (r == Role.TRS) { gTRS.Close();  }
            else { gPISC.Close();  }
            Msg("關閉成功", r);
        }

        private void textBoxMsg_DoubleClick(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Clear();
        }
    }
}
