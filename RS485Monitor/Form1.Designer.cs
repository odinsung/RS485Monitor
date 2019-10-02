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
            this.textBoxTRSMsg = new System.Windows.Forms.TextBox();
            this.labelTRS = new System.Windows.Forms.Label();
            this.labelPISC = new System.Windows.Forms.Label();
            this.panelPISC = new System.Windows.Forms.Panel();
            this.textBoxPISCMsg = new System.Windows.Forms.TextBox();
            this.comboBoxPISCPort = new System.Windows.Forms.ComboBox();
            this.buttonPISCClose = new System.Windows.Forms.Button();
            this.buttonPISCOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTRSIFCallPickUpStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTRSEmgDevCnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxTRSAlmDev = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPISCEmgDevCnt = new System.Windows.Forms.TextBox();
            this.listBoxPISCAlmDev = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonTRSCallPickUpStatus_Call = new System.Windows.Forms.RadioButton();
            this.radioButtonTRSCallPickUpStatus_NotCall = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDateTimeNow = new System.Windows.Forms.Label();
            this.timerShowDateTime = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddFakeAlarmDev = new System.Windows.Forms.Button();
            this.buttonDebugClearAlmDev = new System.Windows.Forms.Button();
            this.panelTRS.SuspendLayout();
            this.panelPISC.SuspendLayout();
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
            this.panelTRS.Controls.Add(this.buttonDebugClearAlmDev);
            this.panelTRS.Controls.Add(this.buttonAddFakeAlarmDev);
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
            this.panelTRS.Size = new System.Drawing.Size(648, 610);
            this.panelTRS.TabIndex = 2;
            // 
            // textBoxTRSMsg
            // 
            this.textBoxTRSMsg.BackColor = System.Drawing.Color.White;
            this.textBoxTRSMsg.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTRSMsg.Location = new System.Drawing.Point(13, 419);
            this.textBoxTRSMsg.Multiline = true;
            this.textBoxTRSMsg.Name = "textBoxTRSMsg";
            this.textBoxTRSMsg.ReadOnly = true;
            this.textBoxTRSMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTRSMsg.Size = new System.Drawing.Size(620, 173);
            this.textBoxTRSMsg.TabIndex = 2;
            this.textBoxTRSMsg.Text = "雙擊滑鼠清除訊息";
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
            this.panelPISC.Controls.Add(this.listBoxPISCAlmDev);
            this.panelPISC.Controls.Add(this.textBoxPISCEmgDevCnt);
            this.panelPISC.Controls.Add(this.textBox1);
            this.panelPISC.Controls.Add(this.textBoxPISCMsg);
            this.panelPISC.Controls.Add(this.comboBoxPISCPort);
            this.panelPISC.Controls.Add(this.label6);
            this.panelPISC.Controls.Add(this.label5);
            this.panelPISC.Controls.Add(this.buttonPISCClose);
            this.panelPISC.Controls.Add(this.label4);
            this.panelPISC.Controls.Add(this.buttonPISCOpen);
            this.panelPISC.Location = new System.Drawing.Point(666, 33);
            this.panelPISC.Name = "panelPISC";
            this.panelPISC.Size = new System.Drawing.Size(657, 610);
            this.panelPISC.TabIndex = 2;
            // 
            // textBoxPISCMsg
            // 
            this.textBoxPISCMsg.BackColor = System.Drawing.Color.White;
            this.textBoxPISCMsg.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPISCMsg.Location = new System.Drawing.Point(13, 419);
            this.textBoxPISCMsg.Multiline = true;
            this.textBoxPISCMsg.Name = "textBoxPISCMsg";
            this.textBoxPISCMsg.ReadOnly = true;
            this.textBoxPISCMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPISCMsg.Size = new System.Drawing.Size(627, 173);
            this.textBoxPISCMsg.TabIndex = 2;
            this.textBoxPISCMsg.Text = "雙擊滑鼠清除訊息";
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
            // textBoxTRSEmgDevCnt
            // 
            this.textBoxTRSEmgDevCnt.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTRSEmgDevCnt.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTRSEmgDevCnt.Location = new System.Drawing.Point(190, 91);
            this.textBoxTRSEmgDevCnt.Name = "textBoxTRSEmgDevCnt";
            this.textBoxTRSEmgDevCnt.ReadOnly = true;
            this.textBoxTRSEmgDevCnt.Size = new System.Drawing.Size(302, 23);
            this.textBoxTRSEmgDevCnt.TabIndex = 4;
            this.textBoxTRSEmgDevCnt.Text = "0";
            this.textBoxTRSEmgDevCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(11, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alarm Device";
            // 
            // listBoxTRSAlmDev
            // 
            this.listBoxTRSAlmDev.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTRSAlmDev.FormattingEnabled = true;
            this.listBoxTRSAlmDev.ItemHeight = 22;
            this.listBoxTRSAlmDev.Location = new System.Drawing.Point(190, 120);
            this.listBoxTRSAlmDev.Name = "listBoxTRSAlmDev";
            this.listBoxTRSAlmDev.Size = new System.Drawing.Size(302, 92);
            this.listBoxTRSAlmDev.TabIndex = 5;
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
            // textBoxPISCEmgDevCnt
            // 
            this.textBoxPISCEmgDevCnt.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPISCEmgDevCnt.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPISCEmgDevCnt.Location = new System.Drawing.Point(185, 91);
            this.textBoxPISCEmgDevCnt.Name = "textBoxPISCEmgDevCnt";
            this.textBoxPISCEmgDevCnt.ReadOnly = true;
            this.textBoxPISCEmgDevCnt.Size = new System.Drawing.Size(302, 23);
            this.textBoxPISCEmgDevCnt.TabIndex = 4;
            this.textBoxPISCEmgDevCnt.Text = "0";
            this.textBoxPISCEmgDevCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxPISCAlmDev
            // 
            this.listBoxPISCAlmDev.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPISCAlmDev.FormattingEnabled = true;
            this.listBoxPISCAlmDev.ItemHeight = 22;
            this.listBoxPISCAlmDev.Location = new System.Drawing.Point(185, 120);
            this.listBoxPISCAlmDev.Name = "listBoxPISCAlmDev";
            this.listBoxPISCAlmDev.Size = new System.Drawing.Size(302, 92);
            this.listBoxPISCAlmDev.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Audio Volume";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(185, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(302, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "16";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(10, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "TRS Call Pick Up Status";
            // 
            // radioButtonTRSCallPickUpStatus_Call
            // 
            this.radioButtonTRSCallPickUpStatus_Call.AutoSize = true;
            this.radioButtonTRSCallPickUpStatus_Call.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonTRSCallPickUpStatus_Call.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonTRSCallPickUpStatus_Call.Location = new System.Drawing.Point(330, 236);
            this.radioButtonTRSCallPickUpStatus_Call.Name = "radioButtonTRSCallPickUpStatus_Call";
            this.radioButtonTRSCallPickUpStatus_Call.Size = new System.Drawing.Size(122, 20);
            this.radioButtonTRSCallPickUpStatus_Call.TabIndex = 6;
            this.radioButtonTRSCallPickUpStatus_Call.Text = "無線電接聽中";
            this.radioButtonTRSCallPickUpStatus_Call.UseVisualStyleBackColor = true;
            this.radioButtonTRSCallPickUpStatus_Call.CheckedChanged += new System.EventHandler(this.radioButtonTRSCallPickUpStatus_Call_CheckedChanged);
            // 
            // radioButtonTRSCallPickUpStatus_NotCall
            // 
            this.radioButtonTRSCallPickUpStatus_NotCall.AutoSize = true;
            this.radioButtonTRSCallPickUpStatus_NotCall.Checked = true;
            this.radioButtonTRSCallPickUpStatus_NotCall.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonTRSCallPickUpStatus_NotCall.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonTRSCallPickUpStatus_NotCall.Location = new System.Drawing.Point(190, 236);
            this.radioButtonTRSCallPickUpStatus_NotCall.Name = "radioButtonTRSCallPickUpStatus_NotCall";
            this.radioButtonTRSCallPickUpStatus_NotCall.Size = new System.Drawing.Size(122, 20);
            this.radioButtonTRSCallPickUpStatus_NotCall.TabIndex = 6;
            this.radioButtonTRSCallPickUpStatus_NotCall.TabStop = true;
            this.radioButtonTRSCallPickUpStatus_NotCall.Text = "無線電未接聽";
            this.radioButtonTRSCallPickUpStatus_NotCall.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(10, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "現在日期時間";
            // 
            // labelDateTimeNow
            // 
            this.labelDateTimeNow.AutoSize = true;
            this.labelDateTimeNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDateTimeNow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTimeNow.ForeColor = System.Drawing.Color.Blue;
            this.labelDateTimeNow.Location = new System.Drawing.Point(187, 280);
            this.labelDateTimeNow.Name = "labelDateTimeNow";
            this.labelDateTimeNow.Size = new System.Drawing.Size(202, 24);
            this.labelDateTimeNow.TabIndex = 3;
            this.labelDateTimeNow.Text = "2019/10/02 12:00:00";
            // 
            // timerShowDateTime
            // 
            this.timerShowDateTime.Interval = 1000;
            this.timerShowDateTime.Tick += new System.EventHandler(this.timerShowDateTime_Tick);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(458, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 33);
            this.label9.TabIndex = 3;
            this.label9.Text = "(若Alarm Device清單為空白，無法選擇「無線電接聽中」)";
            // 
            // buttonAddFakeAlarmDev
            // 
            this.buttonAddFakeAlarmDev.Location = new System.Drawing.Point(497, 120);
            this.buttonAddFakeAlarmDev.Name = "buttonAddFakeAlarmDev";
            this.buttonAddFakeAlarmDev.Size = new System.Drawing.Size(135, 21);
            this.buttonAddFakeAlarmDev.TabIndex = 7;
            this.buttonAddFakeAlarmDev.Text = "Debug: Add Alarm Dev";
            this.buttonAddFakeAlarmDev.UseVisualStyleBackColor = true;
            this.buttonAddFakeAlarmDev.Click += new System.EventHandler(this.buttonAddFakeAlarmDev_Click);
            // 
            // buttonDebugClearAlmDev
            // 
            this.buttonDebugClearAlmDev.Location = new System.Drawing.Point(497, 147);
            this.buttonDebugClearAlmDev.Name = "buttonDebugClearAlmDev";
            this.buttonDebugClearAlmDev.Size = new System.Drawing.Size(135, 21);
            this.buttonDebugClearAlmDev.TabIndex = 7;
            this.buttonDebugClearAlmDev.Text = "Debug: Clear Alarm Dev";
            this.buttonDebugClearAlmDev.UseVisualStyleBackColor = true;
            this.buttonDebugClearAlmDev.Click += new System.EventHandler(this.buttonDebugClearAlmDev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 655);
            this.Controls.Add(this.labelPISC);
            this.Controls.Add(this.labelTRS);
            this.Controls.Add(this.panelPISC);
            this.Controls.Add(this.panelTRS);
            this.Name = "Form1";
            this.Text = "CEMU600 - TRS & PISC RS485 Monitor";
            this.panelTRS.ResumeLayout(false);
            this.panelTRS.PerformLayout();
            this.panelPISC.ResumeLayout(false);
            this.panelPISC.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Button buttonAddFakeAlarmDev;
        private System.Windows.Forms.Button buttonDebugClearAlmDev;
    }
}

