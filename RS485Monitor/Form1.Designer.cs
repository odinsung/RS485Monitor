namespace RS485Monitor
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxTRSPort = new System.Windows.Forms.ComboBox();
            this.buttonTRSOpen = new System.Windows.Forms.Button();
            this.buttonTRSClose = new System.Windows.Forms.Button();
            this.panelTRS = new System.Windows.Forms.Panel();
            this.labelTRSWait = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxTRSRspDelayMs = new System.Windows.Forms.TextBox();
            this.buttonTRSSendRsp = new System.Windows.Forms.Button();
            this.buttonClrTRSMsg = new System.Windows.Forms.Button();
            this.buttonTRSDebugClrAlmDev = new System.Windows.Forms.Button();
            this.buttonTRSDebugAddAlmDev = new System.Windows.Forms.Button();
            this.radioButtonTRSCallPickUpStatus_NotCall = new System.Windows.Forms.RadioButton();
            this.radioButtonTRSCallPickUpStatus_Call = new System.Windows.Forms.RadioButton();
            this.listBoxTRSAlmDev = new System.Windows.Forms.ListBox();
            this.textBoxTRSEmgDevCnt = new System.Windows.Forms.TextBox();
            this.textBoxTRSIFCallPickUpStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDateTimeNow = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTRSMsg = new System.Windows.Forms.TextBox();
            this.labelTRS = new System.Windows.Forms.Label();
            this.labelPISC = new System.Windows.Forms.Label();
            this.panelPISC = new System.Windows.Forms.Panel();
            this.comboBoxIpMac = new System.Windows.Forms.ComboBox();
            this.buttonAskIpMac = new System.Windows.Forms.Button();
            this.labelPISCWait = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonPISCSendRsp = new System.Windows.Forms.Button();
            this.textBoxPISCRspDelayMs = new System.Windows.Forms.TextBox();
            this.buttonClrPISCMsg = new System.Windows.Forms.Button();
            this.comboBoxSetAudioVolume = new System.Windows.Forms.ComboBox();
            this.buttonPISCDebugClrPEHSta = new System.Windows.Forms.Button();
            this.buttonPISCDebugAddPEHSta = new System.Windows.Forms.Button();
            this.buttonPISCDebugClrAlmDev = new System.Windows.Forms.Button();
            this.buttonPISCDebugAddAlmDev = new System.Windows.Forms.Button();
            this.listBoxPEHStatus = new System.Windows.Forms.ListBox();
            this.listBoxPISCAlmDev = new System.Windows.Forms.ListBox();
            this.textBoxDevErrCnt = new System.Windows.Forms.TextBox();
            this.textBoxPISCEmgDevCnt = new System.Windows.Forms.TextBox();
            this.textBoxPEIStatus3 = new System.Windows.Forms.TextBox();
            this.textBoxPEIStatus2 = new System.Windows.Forms.TextBox();
            this.textBoxPEIStatus1 = new System.Windows.Forms.TextBox();
            this.textBoxPEIStatus0 = new System.Windows.Forms.TextBox();
            this.textBoxAudioVolume = new System.Windows.Forms.TextBox();
            this.textBoxPISCMsg = new System.Windows.Forms.TextBox();
            this.comboBoxPISCPort = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPISCClose = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPISCOpen = new System.Windows.Forms.Button();
            this.timerShowDateTime = new System.Windows.Forms.Timer(this.components);
            this.textBoxFakeAppData = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonFakeData = new System.Windows.Forms.Button();
            this.groupBoxFakeDataTargetSel = new System.Windows.Forms.GroupBox();
            this.radioButtonFakeDataToPISC = new System.Windows.Forms.RadioButton();
            this.radioButtonFakeDataToTRS = new System.Windows.Forms.RadioButton();
            this.buttonDemoFakeDataToTRS = new System.Windows.Forms.Button();
            this.buttonDemoFakeDataToPISC = new System.Windows.Forms.Button();
            this.timerTRSRspDelay = new System.Windows.Forms.Timer(this.components);
            this.timerPISCRspDelay = new System.Windows.Forms.Timer(this.components);
            this.textBoxPiscRxRaw = new System.Windows.Forms.TextBox();
            this.textBoxTrsRxRaw = new System.Windows.Forms.TextBox();
            this.buttonClrPiscRaw = new System.Windows.Forms.Button();
            this.buttonClrTrsRaw = new System.Windows.Forms.Button();
            this.buttonDemoFakeIpMacTableToPISC = new System.Windows.Forms.Button();
            this.buttonDemoFake99IpMacTableToPISC = new System.Windows.Forms.Button();
            this.buttonDemoFake65IpMacTableToPISC = new System.Windows.Forms.Button();
            this.panelTRS.SuspendLayout();
            this.panelPISC.SuspendLayout();
            this.groupBoxFakeDataTargetSel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTRSPort
            // 
            this.comboBoxTRSPort.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxTRSPort.FormattingEnabled = true;
            this.comboBoxTRSPort.Location = new System.Drawing.Point(13, 13);
            this.comboBoxTRSPort.Name = "comboBoxTRSPort";
            this.comboBoxTRSPort.Size = new System.Drawing.Size(122, 29);
            this.comboBoxTRSPort.TabIndex = 0;
            // 
            // buttonTRSOpen
            // 
            this.buttonTRSOpen.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTRSOpen.Location = new System.Drawing.Point(141, 10);
            this.buttonTRSOpen.Name = "buttonTRSOpen";
            this.buttonTRSOpen.Size = new System.Drawing.Size(131, 33);
            this.buttonTRSOpen.TabIndex = 1;
            this.buttonTRSOpen.Text = "Open";
            this.buttonTRSOpen.UseVisualStyleBackColor = true;
            this.buttonTRSOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonTRSClose
            // 
            this.buttonTRSClose.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTRSClose.Location = new System.Drawing.Point(278, 9);
            this.buttonTRSClose.Name = "buttonTRSClose";
            this.buttonTRSClose.Size = new System.Drawing.Size(131, 33);
            this.buttonTRSClose.TabIndex = 1;
            this.buttonTRSClose.Text = "Close";
            this.buttonTRSClose.UseVisualStyleBackColor = true;
            this.buttonTRSClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelTRS
            // 
            this.panelTRS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTRS.Controls.Add(this.labelTRSWait);
            this.panelTRS.Controls.Add(this.label19);
            this.panelTRS.Controls.Add(this.textBoxTRSRspDelayMs);
            this.panelTRS.Controls.Add(this.buttonTRSSendRsp);
            this.panelTRS.Controls.Add(this.buttonClrTRSMsg);
            this.panelTRS.Controls.Add(this.buttonTRSDebugClrAlmDev);
            this.panelTRS.Controls.Add(this.buttonTRSDebugAddAlmDev);
            this.panelTRS.Controls.Add(this.radioButtonTRSCallPickUpStatus_NotCall);
            this.panelTRS.Controls.Add(this.radioButtonTRSCallPickUpStatus_Call);
            this.panelTRS.Controls.Add(this.listBoxTRSAlmDev);
            this.panelTRS.Controls.Add(this.textBoxTRSEmgDevCnt);
            this.panelTRS.Controls.Add(this.textBoxTRSIFCallPickUpStatus);
            this.panelTRS.Controls.Add(this.label3);
            this.panelTRS.Controls.Add(this.label9);
            this.panelTRS.Controls.Add(this.label2);
            this.panelTRS.Controls.Add(this.labelDateTimeNow);
            this.panelTRS.Controls.Add(this.label8);
            this.panelTRS.Controls.Add(this.label7);
            this.panelTRS.Controls.Add(this.label1);
            this.panelTRS.Controls.Add(this.textBoxTRSMsg);
            this.panelTRS.Controls.Add(this.comboBoxTRSPort);
            this.panelTRS.Controls.Add(this.buttonTRSClose);
            this.panelTRS.Controls.Add(this.buttonTRSOpen);
            this.panelTRS.Location = new System.Drawing.Point(12, 33);
            this.panelTRS.Name = "panelTRS";
            this.panelTRS.Size = new System.Drawing.Size(648, 823);
            this.panelTRS.TabIndex = 2;
            // 
            // labelTRSWait
            // 
            this.labelTRSWait.AutoSize = true;
            this.labelTRSWait.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTRSWait.Location = new System.Drawing.Point(184, 412);
            this.labelTRSWait.Name = "labelTRSWait";
            this.labelTRSWait.Size = new System.Drawing.Size(225, 35);
            this.labelTRSWait.TabIndex = 12;
            this.labelTRSWait.Text = "請等待延遲…";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(219, 571);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "延遲回覆時間(毫秒ms)";
            // 
            // textBoxTRSRspDelayMs
            // 
            this.textBoxTRSRspDelayMs.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTRSRspDelayMs.Location = new System.Drawing.Point(219, 590);
            this.textBoxTRSRspDelayMs.Name = "textBoxTRSRspDelayMs";
            this.textBoxTRSRspDelayMs.Size = new System.Drawing.Size(127, 27);
            this.textBoxTRSRspDelayMs.TabIndex = 10;
            this.textBoxTRSRspDelayMs.Text = "200";
            this.textBoxTRSRspDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTRSRspDelayMs.TextChanged += new System.EventHandler(this.textBoxTRSRspDelayMs_TextChanged);
            // 
            // buttonTRSSendRsp
            // 
            this.buttonTRSSendRsp.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTRSSendRsp.Location = new System.Drawing.Point(15, 546);
            this.buttonTRSSendRsp.Name = "buttonTRSSendRsp";
            this.buttonTRSSendRsp.Size = new System.Drawing.Size(198, 71);
            this.buttonTRSSendRsp.TabIndex = 9;
            this.buttonTRSSendRsp.Text = "主動傳送Response";
            this.buttonTRSSendRsp.UseVisualStyleBackColor = true;
            this.buttonTRSSendRsp.Click += new System.EventHandler(this.buttonTRSSendRsp_Click);
            // 
            // buttonClrTRSMsg
            // 
            this.buttonClrTRSMsg.Location = new System.Drawing.Point(497, 603);
            this.buttonClrTRSMsg.Name = "buttonClrTRSMsg";
            this.buttonClrTRSMsg.Size = new System.Drawing.Size(135, 24);
            this.buttonClrTRSMsg.TabIndex = 8;
            this.buttonClrTRSMsg.Text = "清除訊息";
            this.buttonClrTRSMsg.UseVisualStyleBackColor = true;
            this.buttonClrTRSMsg.Click += new System.EventHandler(this.buttonClrMsg_Click);
            // 
            // buttonTRSDebugClrAlmDev
            // 
            this.buttonTRSDebugClrAlmDev.Location = new System.Drawing.Point(497, 163);
            this.buttonTRSDebugClrAlmDev.Name = "buttonTRSDebugClrAlmDev";
            this.buttonTRSDebugClrAlmDev.Size = new System.Drawing.Size(135, 34);
            this.buttonTRSDebugClrAlmDev.TabIndex = 7;
            this.buttonTRSDebugClrAlmDev.Text = "Debug: Clear Alarm Dev";
            this.buttonTRSDebugClrAlmDev.UseVisualStyleBackColor = true;
            this.buttonTRSDebugClrAlmDev.Click += new System.EventHandler(this.buttonDebugClearAlmDev_Click);
            // 
            // buttonTRSDebugAddAlmDev
            // 
            this.buttonTRSDebugAddAlmDev.Location = new System.Drawing.Point(498, 120);
            this.buttonTRSDebugAddAlmDev.Name = "buttonTRSDebugAddAlmDev";
            this.buttonTRSDebugAddAlmDev.Size = new System.Drawing.Size(135, 37);
            this.buttonTRSDebugAddAlmDev.TabIndex = 7;
            this.buttonTRSDebugAddAlmDev.Text = "Debug: Add Alarm Dev";
            this.buttonTRSDebugAddAlmDev.UseVisualStyleBackColor = true;
            this.buttonTRSDebugAddAlmDev.Click += new System.EventHandler(this.buttonAddFakeAlarmDev_Click);
            // 
            // radioButtonTRSCallPickUpStatus_NotCall
            // 
            this.radioButtonTRSCallPickUpStatus_NotCall.AutoSize = true;
            this.radioButtonTRSCallPickUpStatus_NotCall.Checked = true;
            this.radioButtonTRSCallPickUpStatus_NotCall.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonTRSCallPickUpStatus_NotCall.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonTRSCallPickUpStatus_NotCall.Location = new System.Drawing.Point(190, 242);
            this.radioButtonTRSCallPickUpStatus_NotCall.Name = "radioButtonTRSCallPickUpStatus_NotCall";
            this.radioButtonTRSCallPickUpStatus_NotCall.Size = new System.Drawing.Size(122, 20);
            this.radioButtonTRSCallPickUpStatus_NotCall.TabIndex = 6;
            this.radioButtonTRSCallPickUpStatus_NotCall.TabStop = true;
            this.radioButtonTRSCallPickUpStatus_NotCall.Text = "無線電未接聽";
            this.radioButtonTRSCallPickUpStatus_NotCall.UseVisualStyleBackColor = true;
            // 
            // radioButtonTRSCallPickUpStatus_Call
            // 
            this.radioButtonTRSCallPickUpStatus_Call.AutoSize = true;
            this.radioButtonTRSCallPickUpStatus_Call.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonTRSCallPickUpStatus_Call.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonTRSCallPickUpStatus_Call.Location = new System.Drawing.Point(330, 242);
            this.radioButtonTRSCallPickUpStatus_Call.Name = "radioButtonTRSCallPickUpStatus_Call";
            this.radioButtonTRSCallPickUpStatus_Call.Size = new System.Drawing.Size(122, 20);
            this.radioButtonTRSCallPickUpStatus_Call.TabIndex = 6;
            this.radioButtonTRSCallPickUpStatus_Call.Text = "無線電接聽中";
            this.radioButtonTRSCallPickUpStatus_Call.UseVisualStyleBackColor = true;
            this.radioButtonTRSCallPickUpStatus_Call.CheckedChanged += new System.EventHandler(this.radioButtonTRSCallPickUpStatus_Call_CheckedChanged);
            // 
            // listBoxTRSAlmDev
            // 
            this.listBoxTRSAlmDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTRSAlmDev.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTRSAlmDev.FormattingEnabled = true;
            this.listBoxTRSAlmDev.ItemHeight = 22;
            this.listBoxTRSAlmDev.Location = new System.Drawing.Point(190, 120);
            this.listBoxTRSAlmDev.Name = "listBoxTRSAlmDev";
            this.listBoxTRSAlmDev.Size = new System.Drawing.Size(302, 90);
            this.listBoxTRSAlmDev.TabIndex = 5;
            // 
            // textBoxTRSEmgDevCnt
            // 
            this.textBoxTRSEmgDevCnt.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTRSEmgDevCnt.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTRSEmgDevCnt.Location = new System.Drawing.Point(190, 91);
            this.textBoxTRSEmgDevCnt.Name = "textBoxTRSEmgDevCnt";
            this.textBoxTRSEmgDevCnt.ReadOnly = true;
            this.textBoxTRSEmgDevCnt.Size = new System.Drawing.Size(302, 23);
            this.textBoxTRSEmgDevCnt.TabIndex = 4;
            this.textBoxTRSEmgDevCnt.Text = "00";
            this.textBoxTRSEmgDevCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTRSIFCallPickUpStatus
            // 
            this.textBoxTRSIFCallPickUpStatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTRSIFCallPickUpStatus.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTRSIFCallPickUpStatus.Location = new System.Drawing.Point(190, 62);
            this.textBoxTRSIFCallPickUpStatus.Name = "textBoxTRSIFCallPickUpStatus";
            this.textBoxTRSIFCallPickUpStatus.ReadOnly = true;
            this.textBoxTRSIFCallPickUpStatus.Size = new System.Drawing.Size(302, 23);
            this.textBoxTRSIFCallPickUpStatus.TabIndex = 4;
            this.textBoxTRSIFCallPickUpStatus.Text = "無任何通話進行中";
            this.textBoxTRSIFCallPickUpStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(9, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alarm Device";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(458, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 46);
            this.label9.TabIndex = 3;
            this.label9.Text = "(若Alarm Device清單為空白或者已有通話正在進行中，無法選擇「無線電接聽中」)";
            this.label9.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emergency Device Count";
            // 
            // labelDateTimeNow
            // 
            this.labelDateTimeNow.AutoSize = true;
            this.labelDateTimeNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDateTimeNow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTimeNow.ForeColor = System.Drawing.Color.Blue;
            this.labelDateTimeNow.Location = new System.Drawing.Point(187, 286);
            this.labelDateTimeNow.Name = "labelDateTimeNow";
            this.labelDateTimeNow.Size = new System.Drawing.Size(202, 24);
            this.labelDateTimeNow.TabIndex = 3;
            this.labelDateTimeNow.Text = "2019/10/02 12:00:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(10, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "現在日期時間";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(10, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "TRS Call Pick Up Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRSIF Call Pick Up Status";
            // 
            // textBoxTRSMsg
            // 
            this.textBoxTRSMsg.BackColor = System.Drawing.Color.White;
            this.textBoxTRSMsg.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTRSMsg.Location = new System.Drawing.Point(13, 633);
            this.textBoxTRSMsg.Multiline = true;
            this.textBoxTRSMsg.Name = "textBoxTRSMsg";
            this.textBoxTRSMsg.ReadOnly = true;
            this.textBoxTRSMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTRSMsg.Size = new System.Drawing.Size(620, 173);
            this.textBoxTRSMsg.TabIndex = 2;
            this.textBoxTRSMsg.TextChanged += new System.EventHandler(this.textBoxMsg_TextChanged);
            this.textBoxTRSMsg.DoubleClick += new System.EventHandler(this.textBoxMsg_DoubleClick);
            // 
            // labelTRS
            // 
            this.labelTRS.AutoSize = true;
            this.labelTRS.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTRS.Location = new System.Drawing.Point(12, 9);
            this.labelTRS.Name = "labelTRS";
            this.labelTRS.Size = new System.Drawing.Size(46, 21);
            this.labelTRS.TabIndex = 3;
            this.labelTRS.Text = "TRS";
            // 
            // labelPISC
            // 
            this.labelPISC.AutoSize = true;
            this.labelPISC.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPISC.Location = new System.Drawing.Point(662, 9);
            this.labelPISC.Name = "labelPISC";
            this.labelPISC.Size = new System.Drawing.Size(52, 21);
            this.labelPISC.TabIndex = 3;
            this.labelPISC.Text = "PISC";
            // 
            // panelPISC
            // 
            this.panelPISC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPISC.Controls.Add(this.comboBoxIpMac);
            this.panelPISC.Controls.Add(this.buttonAskIpMac);
            this.panelPISC.Controls.Add(this.labelPISCWait);
            this.panelPISC.Controls.Add(this.label20);
            this.panelPISC.Controls.Add(this.buttonPISCSendRsp);
            this.panelPISC.Controls.Add(this.textBoxPISCRspDelayMs);
            this.panelPISC.Controls.Add(this.buttonClrPISCMsg);
            this.panelPISC.Controls.Add(this.comboBoxSetAudioVolume);
            this.panelPISC.Controls.Add(this.buttonPISCDebugClrPEHSta);
            this.panelPISC.Controls.Add(this.buttonPISCDebugAddPEHSta);
            this.panelPISC.Controls.Add(this.buttonPISCDebugClrAlmDev);
            this.panelPISC.Controls.Add(this.buttonPISCDebugAddAlmDev);
            this.panelPISC.Controls.Add(this.listBoxPEHStatus);
            this.panelPISC.Controls.Add(this.listBoxPISCAlmDev);
            this.panelPISC.Controls.Add(this.textBoxDevErrCnt);
            this.panelPISC.Controls.Add(this.textBoxPISCEmgDevCnt);
            this.panelPISC.Controls.Add(this.textBoxPEIStatus3);
            this.panelPISC.Controls.Add(this.textBoxPEIStatus2);
            this.panelPISC.Controls.Add(this.textBoxPEIStatus1);
            this.panelPISC.Controls.Add(this.textBoxPEIStatus0);
            this.panelPISC.Controls.Add(this.textBoxAudioVolume);
            this.panelPISC.Controls.Add(this.textBoxPISCMsg);
            this.panelPISC.Controls.Add(this.comboBoxPISCPort);
            this.panelPISC.Controls.Add(this.label17);
            this.panelPISC.Controls.Add(this.label6);
            this.panelPISC.Controls.Add(this.label16);
            this.panelPISC.Controls.Add(this.label10);
            this.panelPISC.Controls.Add(this.label5);
            this.panelPISC.Controls.Add(this.buttonPISCClose);
            this.panelPISC.Controls.Add(this.label14);
            this.panelPISC.Controls.Add(this.label13);
            this.panelPISC.Controls.Add(this.label12);
            this.panelPISC.Controls.Add(this.label11);
            this.panelPISC.Controls.Add(this.label15);
            this.panelPISC.Controls.Add(this.label4);
            this.panelPISC.Controls.Add(this.buttonPISCOpen);
            this.panelPISC.Location = new System.Drawing.Point(666, 33);
            this.panelPISC.Name = "panelPISC";
            this.panelPISC.Size = new System.Drawing.Size(657, 823);
            this.panelPISC.TabIndex = 2;
            // 
            // comboBoxIpMac
            // 
            this.comboBoxIpMac.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIpMac.FormattingEnabled = true;
            this.comboBoxIpMac.Location = new System.Drawing.Point(17, 484);
            this.comboBoxIpMac.Name = "comboBoxIpMac";
            this.comboBoxIpMac.Size = new System.Drawing.Size(470, 27);
            this.comboBoxIpMac.TabIndex = 16;
            // 
            // buttonAskIpMac
            // 
            this.buttonAskIpMac.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAskIpMac.ForeColor = System.Drawing.Color.Blue;
            this.buttonAskIpMac.Location = new System.Drawing.Point(498, 479);
            this.buttonAskIpMac.Name = "buttonAskIpMac";
            this.buttonAskIpMac.Size = new System.Drawing.Size(139, 33);
            this.buttonAskIpMac.TabIndex = 15;
            this.buttonAskIpMac.Text = "Ask IP-MAC";
            this.buttonAskIpMac.UseVisualStyleBackColor = true;
            this.buttonAskIpMac.Click += new System.EventHandler(this.buttonAskIpMac_Click);
            // 
            // labelPISCWait
            // 
            this.labelPISCWait.AutoSize = true;
            this.labelPISCWait.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPISCWait.Location = new System.Drawing.Point(235, 418);
            this.labelPISCWait.Name = "labelPISCWait";
            this.labelPISCWait.Size = new System.Drawing.Size(225, 35);
            this.labelPISCWait.TabIndex = 14;
            this.labelPISCWait.Text = "請等待延遲…";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(217, 571);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(164, 16);
            this.label20.TabIndex = 13;
            this.label20.Text = "延遲回覆時間(毫秒ms)";
            // 
            // buttonPISCSendRsp
            // 
            this.buttonPISCSendRsp.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPISCSendRsp.Location = new System.Drawing.Point(13, 546);
            this.buttonPISCSendRsp.Name = "buttonPISCSendRsp";
            this.buttonPISCSendRsp.Size = new System.Drawing.Size(198, 71);
            this.buttonPISCSendRsp.TabIndex = 12;
            this.buttonPISCSendRsp.Text = "主動傳送Response";
            this.buttonPISCSendRsp.UseVisualStyleBackColor = true;
            this.buttonPISCSendRsp.Click += new System.EventHandler(this.buttonPISCSendRsp_Click);
            // 
            // textBoxPISCRspDelayMs
            // 
            this.textBoxPISCRspDelayMs.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPISCRspDelayMs.Location = new System.Drawing.Point(218, 590);
            this.textBoxPISCRspDelayMs.Name = "textBoxPISCRspDelayMs";
            this.textBoxPISCRspDelayMs.Size = new System.Drawing.Size(125, 27);
            this.textBoxPISCRspDelayMs.TabIndex = 11;
            this.textBoxPISCRspDelayMs.Text = "200";
            this.textBoxPISCRspDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPISCRspDelayMs.TextChanged += new System.EventHandler(this.textBoxPISCRspDelayMs_TextChanged);
            // 
            // buttonClrPISCMsg
            // 
            this.buttonClrPISCMsg.Location = new System.Drawing.Point(502, 603);
            this.buttonClrPISCMsg.Name = "buttonClrPISCMsg";
            this.buttonClrPISCMsg.Size = new System.Drawing.Size(138, 24);
            this.buttonClrPISCMsg.TabIndex = 8;
            this.buttonClrPISCMsg.Text = "清除訊息";
            this.buttonClrPISCMsg.UseVisualStyleBackColor = true;
            this.buttonClrPISCMsg.Click += new System.EventHandler(this.buttonClrMsg_Click);
            // 
            // comboBoxSetAudioVolume
            // 
            this.comboBoxSetAudioVolume.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSetAudioVolume.FormattingEnabled = true;
            this.comboBoxSetAudioVolume.Location = new System.Drawing.Point(185, 421);
            this.comboBoxSetAudioVolume.Name = "comboBoxSetAudioVolume";
            this.comboBoxSetAudioVolume.Size = new System.Drawing.Size(101, 32);
            this.comboBoxSetAudioVolume.TabIndex = 8;
            this.comboBoxSetAudioVolume.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetAudioVolume_SelectedIndexChanged);
            // 
            // buttonPISCDebugClrPEHSta
            // 
            this.buttonPISCDebugClrPEHSta.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPISCDebugClrPEHSta.Location = new System.Drawing.Point(498, 357);
            this.buttonPISCDebugClrPEHSta.Name = "buttonPISCDebugClrPEHSta";
            this.buttonPISCDebugClrPEHSta.Size = new System.Drawing.Size(142, 32);
            this.buttonPISCDebugClrPEHSta.TabIndex = 7;
            this.buttonPISCDebugClrPEHSta.Text = "Debug: Clear PEH Status";
            this.buttonPISCDebugClrPEHSta.UseVisualStyleBackColor = true;
            this.buttonPISCDebugClrPEHSta.Click += new System.EventHandler(this.buttonDebugClearPEHStatus_Click);
            // 
            // buttonPISCDebugAddPEHSta
            // 
            this.buttonPISCDebugAddPEHSta.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPISCDebugAddPEHSta.Location = new System.Drawing.Point(497, 319);
            this.buttonPISCDebugAddPEHSta.Name = "buttonPISCDebugAddPEHSta";
            this.buttonPISCDebugAddPEHSta.Size = new System.Drawing.Size(142, 32);
            this.buttonPISCDebugAddPEHSta.TabIndex = 7;
            this.buttonPISCDebugAddPEHSta.Text = "Debug: Add PEH Status";
            this.buttonPISCDebugAddPEHSta.UseVisualStyleBackColor = true;
            this.buttonPISCDebugAddPEHSta.Click += new System.EventHandler(this.buttonDebugAddFake_Click);
            // 
            // buttonPISCDebugClrAlmDev
            // 
            this.buttonPISCDebugClrAlmDev.Location = new System.Drawing.Point(498, 163);
            this.buttonPISCDebugClrAlmDev.Name = "buttonPISCDebugClrAlmDev";
            this.buttonPISCDebugClrAlmDev.Size = new System.Drawing.Size(141, 34);
            this.buttonPISCDebugClrAlmDev.TabIndex = 6;
            this.buttonPISCDebugClrAlmDev.Text = "Debug: Clear Alarm Dev";
            this.buttonPISCDebugClrAlmDev.UseVisualStyleBackColor = true;
            this.buttonPISCDebugClrAlmDev.Click += new System.EventHandler(this.buttonPISCClearAlarmDev_Click);
            // 
            // buttonPISCDebugAddAlmDev
            // 
            this.buttonPISCDebugAddAlmDev.Location = new System.Drawing.Point(499, 120);
            this.buttonPISCDebugAddAlmDev.Name = "buttonPISCDebugAddAlmDev";
            this.buttonPISCDebugAddAlmDev.Size = new System.Drawing.Size(141, 37);
            this.buttonPISCDebugAddAlmDev.TabIndex = 6;
            this.buttonPISCDebugAddAlmDev.Text = "Debug: Add Alarm Dev";
            this.buttonPISCDebugAddAlmDev.UseVisualStyleBackColor = true;
            this.buttonPISCDebugAddAlmDev.Click += new System.EventHandler(this.buttonPISCAddFakeAlarmDev_Click);
            // 
            // listBoxPEHStatus
            // 
            this.listBoxPEHStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPEHStatus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPEHStatus.FormattingEnabled = true;
            this.listBoxPEHStatus.ItemHeight = 22;
            this.listBoxPEHStatus.Location = new System.Drawing.Point(185, 319);
            this.listBoxPEHStatus.Name = "listBoxPEHStatus";
            this.listBoxPEHStatus.Size = new System.Drawing.Size(302, 90);
            this.listBoxPEHStatus.TabIndex = 5;
            // 
            // listBoxPISCAlmDev
            // 
            this.listBoxPISCAlmDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPISCAlmDev.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPISCAlmDev.FormattingEnabled = true;
            this.listBoxPISCAlmDev.ItemHeight = 22;
            this.listBoxPISCAlmDev.Location = new System.Drawing.Point(185, 120);
            this.listBoxPISCAlmDev.Name = "listBoxPISCAlmDev";
            this.listBoxPISCAlmDev.Size = new System.Drawing.Size(302, 90);
            this.listBoxPISCAlmDev.TabIndex = 5;
            // 
            // textBoxDevErrCnt
            // 
            this.textBoxDevErrCnt.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDevErrCnt.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxDevErrCnt.Location = new System.Drawing.Point(185, 284);
            this.textBoxDevErrCnt.Name = "textBoxDevErrCnt";
            this.textBoxDevErrCnt.ReadOnly = true;
            this.textBoxDevErrCnt.Size = new System.Drawing.Size(302, 23);
            this.textBoxDevErrCnt.TabIndex = 4;
            this.textBoxDevErrCnt.Text = "00";
            this.textBoxDevErrCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPISCEmgDevCnt
            // 
            this.textBoxPISCEmgDevCnt.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPISCEmgDevCnt.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPISCEmgDevCnt.Location = new System.Drawing.Point(185, 91);
            this.textBoxPISCEmgDevCnt.Name = "textBoxPISCEmgDevCnt";
            this.textBoxPISCEmgDevCnt.ReadOnly = true;
            this.textBoxPISCEmgDevCnt.Size = new System.Drawing.Size(302, 23);
            this.textBoxPISCEmgDevCnt.TabIndex = 4;
            this.textBoxPISCEmgDevCnt.Text = "00";
            this.textBoxPISCEmgDevCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPEIStatus3
            // 
            this.textBoxPEIStatus3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPEIStatus3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPEIStatus3.Location = new System.Drawing.Point(536, 242);
            this.textBoxPEIStatus3.Name = "textBoxPEIStatus3";
            this.textBoxPEIStatus3.ReadOnly = true;
            this.textBoxPEIStatus3.Size = new System.Drawing.Size(101, 27);
            this.textBoxPEIStatus3.TabIndex = 4;
            this.textBoxPEIStatus3.Text = "Online";
            this.textBoxPEIStatus3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPEIStatus2
            // 
            this.textBoxPEIStatus2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPEIStatus2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPEIStatus2.Location = new System.Drawing.Point(419, 242);
            this.textBoxPEIStatus2.Name = "textBoxPEIStatus2";
            this.textBoxPEIStatus2.ReadOnly = true;
            this.textBoxPEIStatus2.Size = new System.Drawing.Size(101, 27);
            this.textBoxPEIStatus2.TabIndex = 4;
            this.textBoxPEIStatus2.Text = "Online";
            this.textBoxPEIStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPEIStatus1
            // 
            this.textBoxPEIStatus1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPEIStatus1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPEIStatus1.Location = new System.Drawing.Point(302, 242);
            this.textBoxPEIStatus1.Name = "textBoxPEIStatus1";
            this.textBoxPEIStatus1.ReadOnly = true;
            this.textBoxPEIStatus1.Size = new System.Drawing.Size(101, 27);
            this.textBoxPEIStatus1.TabIndex = 4;
            this.textBoxPEIStatus1.Text = "Online";
            this.textBoxPEIStatus1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPEIStatus0
            // 
            this.textBoxPEIStatus0.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPEIStatus0.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPEIStatus0.Location = new System.Drawing.Point(185, 242);
            this.textBoxPEIStatus0.Name = "textBoxPEIStatus0";
            this.textBoxPEIStatus0.ReadOnly = true;
            this.textBoxPEIStatus0.Size = new System.Drawing.Size(101, 27);
            this.textBoxPEIStatus0.TabIndex = 4;
            this.textBoxPEIStatus0.Text = "Online";
            this.textBoxPEIStatus0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAudioVolume
            // 
            this.textBoxAudioVolume.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAudioVolume.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAudioVolume.Location = new System.Drawing.Point(185, 62);
            this.textBoxAudioVolume.Name = "textBoxAudioVolume";
            this.textBoxAudioVolume.ReadOnly = true;
            this.textBoxAudioVolume.Size = new System.Drawing.Size(302, 23);
            this.textBoxAudioVolume.TabIndex = 4;
            this.textBoxAudioVolume.Text = "16";
            this.textBoxAudioVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPISCMsg
            // 
            this.textBoxPISCMsg.BackColor = System.Drawing.Color.White;
            this.textBoxPISCMsg.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPISCMsg.Location = new System.Drawing.Point(13, 633);
            this.textBoxPISCMsg.Multiline = true;
            this.textBoxPISCMsg.Name = "textBoxPISCMsg";
            this.textBoxPISCMsg.ReadOnly = true;
            this.textBoxPISCMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPISCMsg.Size = new System.Drawing.Size(627, 173);
            this.textBoxPISCMsg.TabIndex = 2;
            this.textBoxPISCMsg.TextChanged += new System.EventHandler(this.textBoxMsg_TextChanged);
            this.textBoxPISCMsg.DoubleClick += new System.EventHandler(this.textBoxMsg_DoubleClick);
            // 
            // comboBoxPISCPort
            // 
            this.comboBoxPISCPort.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxPISCPort.FormattingEnabled = true;
            this.comboBoxPISCPort.Location = new System.Drawing.Point(13, 13);
            this.comboBoxPISCPort.Name = "comboBoxPISCPort";
            this.comboBoxPISCPort.Size = new System.Drawing.Size(122, 29);
            this.comboBoxPISCPort.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(12, 428);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "Set Audio Volume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Audio Volume";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(11, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "PEH Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(12, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "PEI Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(11, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alarm Device";
            // 
            // buttonPISCClose
            // 
            this.buttonPISCClose.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPISCClose.Location = new System.Drawing.Point(278, 9);
            this.buttonPISCClose.Name = "buttonPISCClose";
            this.buttonPISCClose.Size = new System.Drawing.Size(131, 33);
            this.buttonPISCClose.TabIndex = 1;
            this.buttonPISCClose.Text = "Close";
            this.buttonPISCClose.UseVisualStyleBackColor = true;
            this.buttonPISCClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(561, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Car12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(449, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Car7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(329, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Car6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(215, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Car1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(13, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Device Error Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(10, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emergency Device Count";
            // 
            // buttonPISCOpen
            // 
            this.buttonPISCOpen.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPISCOpen.Location = new System.Drawing.Point(141, 10);
            this.buttonPISCOpen.Name = "buttonPISCOpen";
            this.buttonPISCOpen.Size = new System.Drawing.Size(131, 33);
            this.buttonPISCOpen.TabIndex = 1;
            this.buttonPISCOpen.Text = "Open";
            this.buttonPISCOpen.UseVisualStyleBackColor = true;
            this.buttonPISCOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // timerShowDateTime
            // 
            this.timerShowDateTime.Interval = 1000;
            this.timerShowDateTime.Tick += new System.EventHandler(this.timerShowDateTime_Tick);
            // 
            // textBoxFakeAppData
            // 
            this.textBoxFakeAppData.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFakeAppData.Location = new System.Drawing.Point(307, 895);
            this.textBoxFakeAppData.Name = "textBoxFakeAppData";
            this.textBoxFakeAppData.Size = new System.Drawing.Size(967, 30);
            this.textBoxFakeAppData.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(13, 874);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(346, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "測試資料: 模擬 TRSIF 傳送給 TRS 或 PISC 的資料";
            // 
            // buttonFakeData
            // 
            this.buttonFakeData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonFakeData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFakeData.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonFakeData.Location = new System.Drawing.Point(154, 895);
            this.buttonFakeData.Name = "buttonFakeData";
            this.buttonFakeData.Size = new System.Drawing.Size(149, 49);
            this.buttonFakeData.TabIndex = 6;
            this.buttonFakeData.Text = "傳送測試資料";
            this.buttonFakeData.UseVisualStyleBackColor = false;
            this.buttonFakeData.Click += new System.EventHandler(this.buttonFakeData_Click);
            // 
            // groupBoxFakeDataTargetSel
            // 
            this.groupBoxFakeDataTargetSel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxFakeDataTargetSel.Controls.Add(this.radioButtonFakeDataToPISC);
            this.groupBoxFakeDataTargetSel.Controls.Add(this.radioButtonFakeDataToTRS);
            this.groupBoxFakeDataTargetSel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxFakeDataTargetSel.Location = new System.Drawing.Point(12, 895);
            this.groupBoxFakeDataTargetSel.Name = "groupBoxFakeDataTargetSel";
            this.groupBoxFakeDataTargetSel.Size = new System.Drawing.Size(136, 93);
            this.groupBoxFakeDataTargetSel.TabIndex = 7;
            this.groupBoxFakeDataTargetSel.TabStop = false;
            this.groupBoxFakeDataTargetSel.Text = "傳送對象選擇";
            // 
            // radioButtonFakeDataToPISC
            // 
            this.radioButtonFakeDataToPISC.AutoSize = true;
            this.radioButtonFakeDataToPISC.Location = new System.Drawing.Point(29, 55);
            this.radioButtonFakeDataToPISC.Name = "radioButtonFakeDataToPISC";
            this.radioButtonFakeDataToPISC.Size = new System.Drawing.Size(55, 17);
            this.radioButtonFakeDataToPISC.TabIndex = 0;
            this.radioButtonFakeDataToPISC.Text = "PISC";
            this.radioButtonFakeDataToPISC.UseVisualStyleBackColor = true;
            // 
            // radioButtonFakeDataToTRS
            // 
            this.radioButtonFakeDataToTRS.AutoSize = true;
            this.radioButtonFakeDataToTRS.Checked = true;
            this.radioButtonFakeDataToTRS.Location = new System.Drawing.Point(29, 32);
            this.radioButtonFakeDataToTRS.Name = "radioButtonFakeDataToTRS";
            this.radioButtonFakeDataToTRS.Size = new System.Drawing.Size(50, 17);
            this.radioButtonFakeDataToTRS.TabIndex = 0;
            this.radioButtonFakeDataToTRS.TabStop = true;
            this.radioButtonFakeDataToTRS.Text = "TRS";
            this.radioButtonFakeDataToTRS.UseVisualStyleBackColor = true;
            // 
            // buttonDemoFakeDataToTRS
            // 
            this.buttonDemoFakeDataToTRS.Location = new System.Drawing.Point(154, 950);
            this.buttonDemoFakeDataToTRS.Name = "buttonDemoFakeDataToTRS";
            this.buttonDemoFakeDataToTRS.Size = new System.Drawing.Size(149, 38);
            this.buttonDemoFakeDataToTRS.TabIndex = 8;
            this.buttonDemoFakeDataToTRS.Text = "產生測試資料(to TRS)";
            this.buttonDemoFakeDataToTRS.UseVisualStyleBackColor = true;
            this.buttonDemoFakeDataToTRS.Click += new System.EventHandler(this.buttonDemoFakeDataToTRS_Click);
            // 
            // buttonDemoFakeDataToPISC
            // 
            this.buttonDemoFakeDataToPISC.Location = new System.Drawing.Point(309, 950);
            this.buttonDemoFakeDataToPISC.Name = "buttonDemoFakeDataToPISC";
            this.buttonDemoFakeDataToPISC.Size = new System.Drawing.Size(149, 38);
            this.buttonDemoFakeDataToPISC.TabIndex = 8;
            this.buttonDemoFakeDataToPISC.Text = "產生測試資料(to PISC)";
            this.buttonDemoFakeDataToPISC.UseVisualStyleBackColor = true;
            this.buttonDemoFakeDataToPISC.Click += new System.EventHandler(this.buttonDemoFakeDataToPISC_Click);
            // 
            // timerTRSRspDelay
            // 
            this.timerTRSRspDelay.Interval = 1000;
            this.timerTRSRspDelay.Tick += new System.EventHandler(this.timerTRSRspDelay_Tick);
            // 
            // timerPISCRspDelay
            // 
            this.timerPISCRspDelay.Interval = 1000;
            this.timerPISCRspDelay.Tick += new System.EventHandler(this.timerPISCRspDelay_Tick);
            // 
            // textBoxPiscRxRaw
            // 
            this.textBoxPiscRxRaw.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPiscRxRaw.Location = new System.Drawing.Point(1343, 62);
            this.textBoxPiscRxRaw.Multiline = true;
            this.textBoxPiscRxRaw.Name = "textBoxPiscRxRaw";
            this.textBoxPiscRxRaw.ReadOnly = true;
            this.textBoxPiscRxRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPiscRxRaw.Size = new System.Drawing.Size(400, 438);
            this.textBoxPiscRxRaw.TabIndex = 9;
            this.textBoxPiscRxRaw.TextChanged += new System.EventHandler(this.textBoxMsg_TextChanged);
            // 
            // textBoxTrsRxRaw
            // 
            this.textBoxTrsRxRaw.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrsRxRaw.Location = new System.Drawing.Point(1343, 558);
            this.textBoxTrsRxRaw.Multiline = true;
            this.textBoxTrsRxRaw.Name = "textBoxTrsRxRaw";
            this.textBoxTrsRxRaw.ReadOnly = true;
            this.textBoxTrsRxRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTrsRxRaw.Size = new System.Drawing.Size(400, 444);
            this.textBoxTrsRxRaw.TabIndex = 10;
            this.textBoxTrsRxRaw.TextChanged += new System.EventHandler(this.textBoxMsg_TextChanged);
            // 
            // buttonClrPiscRaw
            // 
            this.buttonClrPiscRaw.Location = new System.Drawing.Point(1345, 25);
            this.buttonClrPiscRaw.Name = "buttonClrPiscRaw";
            this.buttonClrPiscRaw.Size = new System.Drawing.Size(86, 22);
            this.buttonClrPiscRaw.TabIndex = 11;
            this.buttonClrPiscRaw.Text = "clear pisc raw";
            this.buttonClrPiscRaw.UseVisualStyleBackColor = true;
            this.buttonClrPiscRaw.Click += new System.EventHandler(this.buttonClrPiscRaw_Click);
            // 
            // buttonClrTrsRaw
            // 
            this.buttonClrTrsRaw.Location = new System.Drawing.Point(1343, 530);
            this.buttonClrTrsRaw.Name = "buttonClrTrsRaw";
            this.buttonClrTrsRaw.Size = new System.Drawing.Size(86, 22);
            this.buttonClrTrsRaw.TabIndex = 12;
            this.buttonClrTrsRaw.Text = "clear trs raw";
            this.buttonClrTrsRaw.UseVisualStyleBackColor = true;
            this.buttonClrTrsRaw.Click += new System.EventHandler(this.buttonClrTrsRaw_Click);
            // 
            // buttonDemoFakeIpMacTableToPISC
            // 
            this.buttonDemoFakeIpMacTableToPISC.Location = new System.Drawing.Point(464, 950);
            this.buttonDemoFakeIpMacTableToPISC.Name = "buttonDemoFakeIpMacTableToPISC";
            this.buttonDemoFakeIpMacTableToPISC.Size = new System.Drawing.Size(229, 38);
            this.buttonDemoFakeIpMacTableToPISC.TabIndex = 13;
            this.buttonDemoFakeIpMacTableToPISC.Text = "產生測試IP-MAC資料(to PISC)";
            this.buttonDemoFakeIpMacTableToPISC.UseVisualStyleBackColor = true;
            this.buttonDemoFakeIpMacTableToPISC.Click += new System.EventHandler(this.buttonDemoFakeIpMacTableToPISC_Click);
            // 
            // buttonDemoFake99IpMacTableToPISC
            // 
            this.buttonDemoFake99IpMacTableToPISC.Location = new System.Drawing.Point(699, 950);
            this.buttonDemoFake99IpMacTableToPISC.Name = "buttonDemoFake99IpMacTableToPISC";
            this.buttonDemoFake99IpMacTableToPISC.Size = new System.Drawing.Size(229, 38);
            this.buttonDemoFake99IpMacTableToPISC.TabIndex = 13;
            this.buttonDemoFake99IpMacTableToPISC.Text = "產生99筆測試IP-MAC資料(to PISC)";
            this.buttonDemoFake99IpMacTableToPISC.UseVisualStyleBackColor = true;
            this.buttonDemoFake99IpMacTableToPISC.Click += new System.EventHandler(this.buttonDemoFake99IpMacTableToPISC_Click);
            // 
            // buttonDemoFake65IpMacTableToPISC
            // 
            this.buttonDemoFake65IpMacTableToPISC.Location = new System.Drawing.Point(934, 950);
            this.buttonDemoFake65IpMacTableToPISC.Name = "buttonDemoFake65IpMacTableToPISC";
            this.buttonDemoFake65IpMacTableToPISC.Size = new System.Drawing.Size(229, 38);
            this.buttonDemoFake65IpMacTableToPISC.TabIndex = 14;
            this.buttonDemoFake65IpMacTableToPISC.Text = "產生65筆測試IP-MAC資料(to PISC)";
            this.buttonDemoFake65IpMacTableToPISC.UseVisualStyleBackColor = true;
            this.buttonDemoFake65IpMacTableToPISC.Click += new System.EventHandler(this.buttonDemoFake65IpMacTableToPISC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1764, 1014);
            this.Controls.Add(this.buttonDemoFake65IpMacTableToPISC);
            this.Controls.Add(this.buttonDemoFake99IpMacTableToPISC);
            this.Controls.Add(this.buttonDemoFakeIpMacTableToPISC);
            this.Controls.Add(this.buttonClrTrsRaw);
            this.Controls.Add(this.buttonClrPiscRaw);
            this.Controls.Add(this.textBoxTrsRxRaw);
            this.Controls.Add(this.textBoxPiscRxRaw);
            this.Controls.Add(this.buttonDemoFakeDataToPISC);
            this.Controls.Add(this.buttonDemoFakeDataToTRS);
            this.Controls.Add(this.groupBoxFakeDataTargetSel);
            this.Controls.Add(this.buttonFakeData);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxFakeAppData);
            this.Controls.Add(this.labelPISC);
            this.Controls.Add(this.labelTRS);
            this.Controls.Add(this.panelPISC);
            this.Controls.Add(this.panelTRS);
            this.Name = "Form1";
            this.Text = "EMU3000 - TRS & PISC RS485 Monitor - Baudrate = 19200, n, 8, 1";
            this.panelTRS.ResumeLayout(false);
            this.panelTRS.PerformLayout();
            this.panelPISC.ResumeLayout(false);
            this.panelPISC.PerformLayout();
            this.groupBoxFakeDataTargetSel.ResumeLayout(false);
            this.groupBoxFakeDataTargetSel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTRSPort;
        private System.Windows.Forms.Button buttonTRSOpen;
        private System.Windows.Forms.Button buttonTRSClose;
        private System.Windows.Forms.Panel panelTRS;
        private System.Windows.Forms.TextBox textBoxTRSMsg;
        private System.Windows.Forms.Label labelTRS;
        private System.Windows.Forms.Label labelPISC;
        private System.Windows.Forms.Panel panelPISC;
        private System.Windows.Forms.TextBox textBoxPISCMsg;
        private System.Windows.Forms.ComboBox comboBoxPISCPort;
        private System.Windows.Forms.Button buttonPISCClose;
        private System.Windows.Forms.Button buttonPISCOpen;
        private System.Windows.Forms.ListBox listBoxTRSAlmDev;
        private System.Windows.Forms.TextBox textBoxTRSEmgDevCnt;
        private System.Windows.Forms.TextBox textBoxTRSIFCallPickUpStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPISCAlmDev;
        private System.Windows.Forms.TextBox textBoxPISCEmgDevCnt;
        private System.Windows.Forms.TextBox textBoxAudioVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonTRSCallPickUpStatus_Call;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonTRSCallPickUpStatus_NotCall;
        private System.Windows.Forms.Label labelDateTimeNow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerShowDateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonTRSDebugAddAlmDev;
        private System.Windows.Forms.Button buttonTRSDebugClrAlmDev;
        private System.Windows.Forms.Button buttonPISCDebugClrAlmDev;
        private System.Windows.Forms.Button buttonPISCDebugAddAlmDev;
        private System.Windows.Forms.TextBox textBoxDevErrCnt;
        private System.Windows.Forms.TextBox textBoxPEIStatus3;
        private System.Windows.Forms.TextBox textBoxPEIStatus2;
        private System.Windows.Forms.TextBox textBoxPEIStatus1;
        private System.Windows.Forms.TextBox textBoxPEIStatus0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBoxPEHStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonPISCDebugClrPEHSta;
        private System.Windows.Forms.Button buttonPISCDebugAddPEHSta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxSetAudioVolume;
        private System.Windows.Forms.TextBox textBoxFakeAppData;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonFakeData;
        private System.Windows.Forms.GroupBox groupBoxFakeDataTargetSel;
        private System.Windows.Forms.RadioButton radioButtonFakeDataToPISC;
        private System.Windows.Forms.RadioButton radioButtonFakeDataToTRS;
        private System.Windows.Forms.Button buttonClrTRSMsg;
        private System.Windows.Forms.Button buttonClrPISCMsg;
        private System.Windows.Forms.Button buttonDemoFakeDataToTRS;
        private System.Windows.Forms.Button buttonDemoFakeDataToPISC;
        private System.Windows.Forms.Button buttonTRSSendRsp;
        private System.Windows.Forms.TextBox textBoxTRSRspDelayMs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonPISCSendRsp;
        private System.Windows.Forms.TextBox textBoxPISCRspDelayMs;
        private System.Windows.Forms.Timer timerTRSRspDelay;
        private System.Windows.Forms.Timer timerPISCRspDelay;
        private System.Windows.Forms.Label labelTRSWait;
        private System.Windows.Forms.Label labelPISCWait;
        private System.Windows.Forms.TextBox textBoxPiscRxRaw;
        private System.Windows.Forms.TextBox textBoxTrsRxRaw;
        private System.Windows.Forms.Button buttonClrPiscRaw;
        private System.Windows.Forms.Button buttonClrTrsRaw;
        private System.Windows.Forms.ComboBox comboBoxIpMac;
        private System.Windows.Forms.Button buttonAskIpMac;
        private System.Windows.Forms.Button buttonDemoFakeIpMacTableToPISC;
        private System.Windows.Forms.Button buttonDemoFake99IpMacTableToPISC;
        private System.Windows.Forms.Button buttonDemoFake65IpMacTableToPISC;
    }
}

