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

namespace RS485Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComPortItemInit();
        }
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
        
    }
}
