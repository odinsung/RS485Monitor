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
        int SetAudioVolume = -1; // Set Audio Volume (1 to 16), -1 = No Command.
        enum Role
        {
            TRS,
            PISC
        }

        public Form1()
        {
            InitializeComponent();
            ComPortItemInit(); // 掃描可用的序列埠，初始化下拉式選單等序列埠相關物件

            // 註冊 TRS 事件處理函式
            gTRS.Evt_TrsifRequest    += TRS_EventHandler_TrsifRequest;  // 事件: 收到來自 TRSIF 的 Request
            gTRS.Evt_ErrorOccur      += TRS_EventHandler_ErrorOccur;    // 事件: 發生錯誤  (參數: 錯誤訊息)
            gTRS.Evt_DataSent        += TRS_EventHandler_DataSent;      // 事件: 資料已送出 (參數: 送出的資料 byte array & array length)

            // 註冊 PISC 事件處理函式
            gPISC.Evt_ReportIsStatus += PISC_EventHandler_ReportIsStatus;
            gPISC.Evt_ErrorOccur     += PISC_EventHandler_ErrorOccur;
            gPISC.Evt_DataSent       += PISC_EventHandler_DataSent;
            gPISC.Evt_RspIpMacTable  += PISC_EventHandler_RspIpMacTable;

            ComboBox_SetAudioVolume_Init();
            labelDateTimeNow.Text = System.DateTime.Now.ToString();
            timerShowDateTime.Enabled = true;
            WindowState = FormWindowState.Maximized;
            //Msg("雙擊滑鼠以清除訊息", Role.TRS);
            //Msg("雙擊滑鼠以清除訊息", Role.PISC);

            // 隱藏 Debug buttons
            buttonTRSDebugAddAlmDev.Visible = false;
            buttonTRSDebugClrAlmDev.Visible = false;
            buttonPISCDebugAddAlmDev.Visible = false;
            buttonPISCDebugClrAlmDev.Visible = false;
            buttonPISCDebugAddPEHSta.Visible = false;
            buttonPISCDebugClrPEHSta.Visible = false;

            labelTRSWait.Visible = false;
            labelPISCWait.Visible = false;

            buttonTRSClose.Enabled = false;
            buttonPISCClose.Enabled = false;
        }

        private void TRS_EventHandler_TrsifRequest(object sender, EventArgs e) // 收到 TRSIF 發出的 Request 之事件處理
        {
            DumpReceivedPacket(Role.TRS);
            //panelTRS.Enabled = false;
            try
            {
                labelTRSWait.Invoke(new EventHandler(
                    delegate
                    {
                        TRS_ShowTrsifRequest();
                        labelTRSWait.Visible = true;
                        timerTRSRspDelay.Enabled = true; // Send response after delay time.
                    }));
            }
            catch (InvalidOperationException) { }
         }
        private void buttonTRSSendRsp_Click(object sender, EventArgs e) // TRS 主動傳送回覆封包 (Response)
        {
            TRS_SendResponse();
        }
        private void timerTRSRspDelay_Tick(object sender, EventArgs e) // TRS 傳送回覆封包 (Response) 延遲時間到: 開始傳送!
        {
            TRS_SendResponse();
            labelTRSWait.Visible = false;
            panelTRS.Enabled = true;
            timerTRSRspDelay.Enabled = false;
        }
        private void TRS_ShowTrsifRequest() // 將 TRSIF Request 內的資訊顯示在 UI 上
        {
            bool trsifCallPickUpStatus = false;
            int emergencyDeviceCount = 0;
            trsifCallPickUpStatus = gTRS.GetTRSIFCallPickUpStatus();
            textBoxTRSIFCallPickUpStatus.Text = trsifCallPickUpStatus ? "通話進行中" : "無任何通話進行中";
            emergencyDeviceCount = gTRS.GetEmergencyDeviceCount();
            textBoxTRSEmgDevCnt.Text = emergencyDeviceCount.ToString("D2");
            listBoxTRSAlmDev.Items.Clear();
            for (int i = 0; i < emergencyDeviceCount; i++)
            {
                listBoxTRSAlmDev.Items.Add(gTRS.GetAlarmDevice(i));
            }
        }
        private void TRS_SendResponse() // 傳送 Response
        {
            gTRS.SendResponse(radioButtonTRSCallPickUpStatus_Call.Checked, System.DateTime.Now);
        }
        private void TRS_EventHandler_DataSent(object sender, PICom.DataSentEventArgs e) // 收到來自 TRS 送出資料的事件，將送出的封包內容 Dump 出來
        {
            Msg("送出封包: ", e.DataSent, e.DataSentLen, Role.TRS);
        }
        private void TRS_EventHandler_ErrorOccur(object sender, PICom.ErrorEventArgs e) // 收到 TRS 發出的錯誤訊息之事件處理
        {
            Msg(e.ErrorMessage, Role.TRS);
            DumpRawBuf(Role.TRS);
        }
        private void DumpRawBuf(Role r)
        {
            int len = 0;
            Byte[] buf = new byte[4096];
            if (r == Role.TRS)
            {
                gTRS.GetRawBuf(ref buf, ref len);
            }
            else
            {
                gPISC.GetRawBuf(ref buf, ref len);
            }
            if (len != 0)
            {
                ShowRaw(buf, len, r);
            }
        }
        private void ShowRaw(Byte[] buf, int len, Role r)
        {
            string str = "[";
            DateTime t = System.DateTime.Now;
            str += t.Hour.ToString("D2") + ":" + t.Minute.ToString("D2") + ":" + t.Second.ToString("D2") + "." + t.Millisecond.ToString("D3") + "]" + Environment.NewLine;
            for (int i=0; i<len; i++)
            {
                str += buf[i].ToString("X2") + " ";
            }
            str += Environment.NewLine;
            if (r == Role.TRS)
            {
                try
                {
                    textBoxPiscRxRaw.Invoke(new EventHandler(
                        delegate
                        {
                            textBoxTrsRxRaw.Text += str;
                        }));
                }
                catch (InvalidOperationException) { }
            }
            else
            {
                try
                {
                    textBoxPiscRxRaw.Invoke(new EventHandler(
                        delegate
                        {
                            textBoxPiscRxRaw.Text += str;
                        }));
                }catch (InvalidOperationException) { }                
            }
        }
        private void PISC_EventHandler_ReportIsStatus(object sender, EventArgs e) // 收到 TRSIF 發出的 Request 之事件處理
        {
            DumpReceivedPacket(Role.PISC);
            //panelPISC.Enabled = false;
            try
            {
                labelPISCWait.Invoke(new EventHandler(
                    delegate
                    {
                        PISC_ShowReportIsStatus();
                        labelPISCWait.Visible = true;
                        timerPISCRspDelay.Enabled = true;
                    }));
            }
            catch (InvalidOperationException) { }
        }
        private void PISC_EventHandler_RspIpMacTable(object sender, EventArgs e) // 收到 TRSIF 回覆的 IP-MAC 表
        {
            DumpReceivedPacket(Role.PISC);
            PISC_ShowRspIpMacTable();
        }

        private void buttonPISCSendRsp_Click(object sender, EventArgs e) // PISC 主動傳送回覆封包 (Response)
        {
            PISC_SendResponse();
        }
        private void timerPISCRspDelay_Tick(object sender, EventArgs e) // PISC 傳送回覆封包 (Response) 延遲時間到: 開始傳送!
        {
            PISC_SendResponse();
            labelPISCWait.Visible = false;
            panelPISC.Enabled = true;
            timerPISCRspDelay.Enabled = false;
        }
        private void PISC_ShowReportIsStatus()
        {
            int audioVolume = 0;
            int emergencyDeviceCount = 0;
            int[] peiStatus = new int[4];
            int deviceErrorCount = 0;

            // 取得 Request 中的各個參數
            audioVolume = gPISC.GetAudioVolume();
            emergencyDeviceCount = gPISC.GetEmergencyDeviceCount();
            for (int i = 0; i < 4; i++)
            {
                peiStatus[i] = gPISC.GetPEIStatus(i);
            }
            deviceErrorCount = gPISC.GetDeviceErrorCount();

            // 顯示在 UI 上
            textBoxAudioVolume.Text = audioVolume.ToString("D2");
            textBoxPISCEmgDevCnt.Text = emergencyDeviceCount.ToString("D2");
            listBoxPISCAlmDev.Items.Clear();
            for (int i = 0; i < emergencyDeviceCount; i++)
            {
                listBoxPISCAlmDev.Items.Add(gPISC.GetAlarmDevice(i));
            }
            textBoxPEIStatus0.Text = PEIStatusName(peiStatus[0]);
            textBoxPEIStatus1.Text = PEIStatusName(peiStatus[1]);
            textBoxPEIStatus2.Text = PEIStatusName(peiStatus[2]);
            textBoxPEIStatus3.Text = PEIStatusName(peiStatus[3]);
            textBoxDevErrCnt.Text = deviceErrorCount.ToString("D2");
            listBoxPEHStatus.Items.Clear();
            for (int i = 0; i < deviceErrorCount; i++)
            {
                listBoxPEHStatus.Items.Add(gPISC.GetPEHStatus(i));
            }
        }
        private void PISC_ShowRspIpMacTable()
        {
            int ipMacCnt = 0;
            ipMacCnt = gPISC.GetIpMacCount();
            comboBoxIpMac.Items.Clear();
            for(int i=0; i<ipMacCnt; i++)
            {
                comboBoxIpMac.Items.Add((i+1).ToString("D2") + ": " + gPISC.GetIpMac(i));
            }
            if (ipMacCnt > 0)
            {
                comboBoxIpMac.SelectedIndex = 0;
            }
            comboBoxIpMac.Focus();
        }
        private void PISC_SendResponse()
        {
            // 傳送 Response
            if (SetAudioVolume < 0 || SetAudioVolume > 10)
            {
                SetAudioVolume = -1; // 不改變音量
            }
            gPISC.SendResponse(SetAudioVolume);
            SetAudioVolume = -1; // 送給 TRSIF 之後，就清為 -1
        }
        
        private void PISC_EventHandler_DataSent(object sender, PICom.DataSentEventArgs e) // 收到來自 PISC 送出資料的事件，將送出的封包內容 Dump 出來
        {
            Msg("送出封包: ", e.DataSent, e.DataSentLen, Role.PISC);
        }
        private void PISC_EventHandler_ErrorOccur(object sender, PICom.ErrorEventArgs e) // 收到 PISC 發出的錯誤訊息之事件處理
        {
            Msg(e.ErrorMessage, Role.PISC);
            DumpRawBuf(Role.PISC);
        }

        private void DumpReceivedPacket(Role r) // 將收到的封包內容顯示在訊息窗中
        {
            Byte[] pkt = r == Role.TRS ? gTRS.RawBuf : gPISC.RawBuf;
            int length = r == Role.TRS ? gTRS.RawPtr : gPISC.RawPtr;
            Msg("收到封包: ", pkt, length, r);
            DumpRawBuf(r); // 不論收到封包格式是否正確，都把 Raw data dump 出來
            // Reset Raw Buffer Pointer
            if (r == Role.TRS) { gTRS.RawPtr = 0; }
            else { gPISC.RawPtr = 0; }
        }

        private void Msg(String str, Role role) // 顯示 Debug 訊息
        {
            TextBox tb = role == Role.TRS ? textBoxTRSMsg : textBoxPISCMsg;
            DateTime t = System.DateTime.Now;
            try
            {
                tb.Invoke(new EventHandler(
                    delegate
                    {
                        tb.Text += "[" + t.Hour.ToString("D2") + ":" + t.Minute.ToString("D2") + ":" + t.Second.ToString("D2") + "]  " +
                                str + Environment.NewLine;
                    }));
            }
            catch (InvalidOperationException) { }
        }
        private void Msg(String prefixString, Byte[] pkt, int length, Role role) // 顯示封包內容
        {
            String str = prefixString;
            TextBox tb = role == Role.TRS ? textBoxTRSMsg : textBoxPISCMsg;
            DateTime t = System.DateTime.Now;
            for (int i=0; i<length; i++)
            {
                switch (pkt[i])
                {
                    case Byte b when i == (length - 1):
                        str += "[0x" + b.ToString("X2") + "]";
                        break;
                    case Byte b when pkt[i] == 0x10:
                        str += "[DLE]";
                        break;
                    case Byte b when pkt[i] == 0x02:
                        str += "[STX]";
                        break;
                    case Byte b when pkt[i] == 0x03:
                        str += "[ETX]";
                        break;
                    case Byte b when pkt[i] >= 0x20 && pkt[i] <= 0x7e:
                        str += ((Char)b).ToString();
                        break;
                    default:
                        str += "[0x" + pkt[i].ToString("X2") + "]";
                        break;
                }
            }
            try
            {
                tb.Invoke(new EventHandler(
                    delegate
                    {
                        tb.Text += "[" + t.Hour.ToString("D2") + ":" + t.Minute.ToString("D2") + ":" + t.Second.ToString("D2") + "]  " +
                                str + Environment.NewLine;
                    }));
            }
            catch (InvalidOperationException) { }
        }
        
        private void ComPortItemInit() // 序列埠相關物件初始化
        {
            ComPortComboBoxInit(comboBoxTRSPort);
            ComPortComboBoxInit(comboBoxPISCPort);
        }
        private void ComPortComboBoxInit(ComboBox cbxPort) // 序列埠選擇下拉式選單初始化
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

        private void ComboBox_SetAudioVolume_Init() // 設定音量下拉式選單初始化
        {
            comboBoxSetAudioVolume.Items.Clear();
            for(int i=1; i<= 10; i++)
            {
                comboBoxSetAudioVolume.Items.Add(i.ToString("D2"));
            }
            comboBoxSetAudioVolume.SelectedIndex = 9;
        }

        private void buttonOpen_Click(object sender, EventArgs e) // 開啟 Com Port
        {
            Button btn = (Button)sender;
            Role r = btn == buttonTRSOpen ? Role.TRS : Role.PISC;
            String portName = r == Role.TRS ? comboBoxTRSPort.Text : comboBoxPISCPort.Text;
            if ((r == Role.TRS? gTRS.Open(portName) : gPISC.Open(portName)))
            {
                Msg("開啟成功!", r);
                if (r == Role.TRS)
                {
                    buttonTRSOpen.Enabled = false;
                    buttonTRSClose.Enabled = true;
                }
                else
                {
                    buttonPISCOpen.Enabled = false;
                    buttonPISCClose.Enabled = true;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) // 關閉 Com Port
        {
            Button btn = (Button)sender;
            Role r = btn == buttonTRSClose ? Role.TRS : Role.PISC;
            if (r == Role.TRS) 
            {
                gTRS.Close();
                buttonTRSOpen.Enabled = true;
                buttonTRSClose.Enabled = false;
            }
            else
            {
                gPISC.Close();
                buttonPISCOpen.Enabled = true;
                buttonPISCClose.Enabled = false;
            }
            Msg("關閉成功", r);
        }

        private void textBoxMsg_DoubleClick(object sender, EventArgs e) // 清除訊息窗
        {
            ((TextBox)sender).Clear();
        }

        private void timerShowDateTime_Tick(object sender, EventArgs e) // 每秒刷新現在日期時間顯示
        {
            labelDateTimeNow.Text = System.DateTime.Now.ToString();
        }

        private void radioButtonTRSCallPickUpStatus_Call_CheckedChanged(object sender, EventArgs e) // 若候隊子機清單為空白或已有通話正在進行中，不可選擇「無線電已接聽」
        {
            //if (listBoxTRSAlmDev.Items.Count == 0 || textBoxTRSIFCallPickUpStatus.Text == "通話進行中")
            //{
            //    radioButtonTRSCallPickUpStatus_NotCall.Checked = true;
            //}
        }

        private void buttonAddFakeAlarmDev_Click(object sender, EventArgs e) // Debug: 增加假的候隊子機名單
        {
            int emergencyDevCnt = 0;
            if (int.TryParse(textBoxTRSEmgDevCnt.Text, out emergencyDevCnt))
            {
                if (emergencyDevCnt < 99)
                {
                    listBoxTRSAlmDev.Items.Add("CXXDXX");
                    emergencyDevCnt++;
                    textBoxTRSEmgDevCnt.Text = emergencyDevCnt.ToString("D2");
                }               
            }
        }

        private void buttonDebugClearAlmDev_Click(object sender, EventArgs e) // Debug: 清除候隊子機清單
        {
            listBoxTRSAlmDev.Items.Clear();
            radioButtonTRSCallPickUpStatus_NotCall.Checked = true;
            textBoxTRSEmgDevCnt.Text = "00";
        }

        private void buttonPISCAddFakeAlarmDev_Click(object sender, EventArgs e) // Debug: 增加假的候隊子機名單
        {
            int emergencyDevCnt = 0;
            if (int.TryParse(textBoxPISCEmgDevCnt.Text, out emergencyDevCnt))
            {
                if (emergencyDevCnt < 99)
                {
                    listBoxPISCAlmDev.Items.Add("CXXDXX");
                    emergencyDevCnt++;
                    textBoxPISCEmgDevCnt.Text = emergencyDevCnt.ToString("D2");
                }
            }
        }

        private void buttonPISCClearAlarmDev_Click(object sender, EventArgs e) // Debug: 清除候隊子機清單
        {
            listBoxPISCAlmDev.Items.Clear();
            textBoxPISCEmgDevCnt.Text = "00";
        }

        private void buttonDebugAddFake_Click(object sender, EventArgs e) // Debug: 增加假的異常子機名單
        {
            int devErrCnt = 0;
            if (int.TryParse(textBoxDevErrCnt.Text, out devErrCnt))
            {
                if (devErrCnt < 99)
                {
                    listBoxPEHStatus.Items.Add("CXXDXX");
                    devErrCnt++;
                    textBoxDevErrCnt.Text = devErrCnt.ToString("D2");
                }
            }
        }

        private void buttonDebugClearPEHStatus_Click(object sender, EventArgs e) // Debug: 清除異常子機清單
        {
            listBoxPEHStatus.Items.Clear();
            textBoxDevErrCnt.Text = "00";
        }

        private void comboBoxSetAudioVolume_SelectedIndexChanged(object sender, EventArgs e) // 改變欲設定的音量 (Set Audio Volume)
        {
            SetAudioVolume = comboBoxSetAudioVolume.SelectedIndex + 1;
        }

        private void buttonFakeData_Click(object sender, EventArgs e) // 模擬 TRSIF 資料傳入
        {
            Byte[] pkt = new Byte[4096];
            Byte bcc = 0;
            int length = 0;
            int ptr = 0;
            String str = textBoxFakeAppData.Text;
            length = str.Length;
            Role r = radioButtonFakeDataToTRS.Checked ? Role.TRS : Role.PISC;
            if (length > 4096)
            {
                Msg("資料長度太長！", r);
            }
            else if (length != 0)
            {
                pkt[ptr++] = 0x10;
                pkt[ptr++] = 0x02;
                for(int i=0; i<length; i++)
                {
                    pkt[ptr++] = (Byte)str[i];
                    bcc ^= (Byte)str[i];
                }
                pkt[ptr++] = 0x10;
                pkt[ptr++] = 0x03;
                pkt[ptr++] = bcc;
                if (radioButtonFakeDataToTRS.Checked)
                {
                    gTRS.Fake_DataReceived(pkt, ptr);
                }
                else
                {
                    gPISC.Fake_DataReceived(pkt, ptr);
                }
            }

        }

        private String PEIStatusName(int peiStaCode)
        {
            String str = String.Empty;
            switch (peiStaCode)
            {
                case 0: str = "Online"; break;
                case 1: str = "Time out"; break;
                case 2: str = "Other error"; break;
                default: str = "Unknown error"; break;
            }
            return str;
        }

        private void buttonClrMsg_Click(object sender, EventArgs e) // 清除訊息窗
        {
            if (((Button)sender).Name == "buttonClrTRSMsg")
            {
                textBoxTRSMsg.Clear();
            }
            else
            {
                textBoxPISCMsg.Clear();
            }
        }

        private void buttonDemoFakeDataToTRS_Click(object sender, EventArgs e) // 測試資料: TO TRS
        {
            textBoxFakeAppData.Text = "30102C01D02C03D05";
        }

        private void buttonDemoFakeDataToPISC_Click(object sender, EventArgs e) // 測試資料: TO PISC
        {
            textBoxFakeAppData.Text = "400902C01D03wC03D05c102001C10D06";
        }
        private void buttonDemoFakeIpMacTableToPISC_Click(object sender, EventArgs e) // 測試資料 IP-MAC 表格: TO PISC
        {
            //textBoxFakeAppData.Text = "34313031 43304138 30313637 41414242 43434444 45303032";
            textBoxFakeAppData.Text = "4101C0A80167AABBCCDDE002";
        }
        private void buttonDemoFake99IpMacTableToPISC_Click(object sender, EventArgs e) // 測試資料 99 筆 IP-MAC 表格: TO PISC
        {
            int i = 0;
            Byte idx = 0x01;
            String s = "C0A80600AABBCCDDEE00";
            String x = "4199";
            for (i=0; i<99; i++)
            {
                s = "C0A806" + idx.ToString("X2") + "AABBCCDDEE" + idx.ToString("X2");
                x += s;
                idx++;
            }
            textBoxFakeAppData.Text = x;
        }
        private void buttonDemoFake65IpMacTableToPISC_Click(object sender, EventArgs e) // 測試資料 65 筆 IP-MAC 表格: TO PISC
        {
            int i = 0;
            Byte idx = 0x01;
            String s = "C0A80600AABBCCDDEE00";
            String x = "4165";
            for (i = 0; i < 65; i++)
            {
                s = "C0A806" + idx.ToString("X2") + "AABBCCDDEE" + idx.ToString("X2");
                x += s;
                idx++;
            }
            textBoxFakeAppData.Text = x;
        }

        private void textBoxMsg_TextChanged(object sender, EventArgs e) // 讓訊息窗的游標位置始終保持在最後面
        {
            TextBox msg = (TextBox)sender;
            msg.SelectionStart = msg.TextLength;
            msg.ScrollToCaret();
        }

        private void textBoxTRSRspDelayMs_TextChanged(object sender, EventArgs e) // 設定 TRS 傳送回覆封包延遲時間(ms)
        {
            int delayMs = 0;
            try
            {
                delayMs = Convert.ToInt32(textBoxTRSRspDelayMs.Text);
                if (delayMs >= 5000)
                {
                    textBoxTRSRspDelayMs.Text = "5000";
                    delayMs = 5000;
                }
                timerTRSRspDelay.Interval = delayMs;
            }catch(Exception ex)
            {
                Msg(ex.Message, Role.TRS);
            }
        }

        private void textBoxPISCRspDelayMs_TextChanged(object sender, EventArgs e) // 設定 PISC 傳送回覆封包延遲時間(ms)
        {
            int delayMs = 0;
            try
            {
                delayMs = Convert.ToInt32(textBoxPISCRspDelayMs.Text);
                if (delayMs >= 5000)
                {
                    textBoxPISCRspDelayMs.Text = "5000";
                    delayMs = 5000;
                }
                timerPISCRspDelay.Interval = delayMs;
            }catch(Exception ex)
            {
                Msg(ex.Message, Role.PISC);
            }
        }

        private void buttonClrPiscRaw_Click(object sender, EventArgs e)
        {
            textBoxPiscRxRaw.Clear();
        }

        private void buttonClrTrsRaw_Click(object sender, EventArgs e)
        {
            textBoxTrsRxRaw.Clear();
        }

        private void buttonAskIpMac_Click(object sender, EventArgs e) // Ask IP-MAC
        {
            //comboBoxIpMac.Items.Clear();
            gPISC.SendAskIpMacTable();
        }

        
    }
}
