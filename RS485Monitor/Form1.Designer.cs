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
            this.comboBoxTRSPort = new System.Windows.Forms.ComboBox();
            this.buttonTRSOpen = new System.Windows.Forms.Button();
            this.buttonTRSClose = new System.Windows.Forms.Button();
            this.panelTRS = new System.Windows.Forms.Panel();
            this.labelTRS = new System.Windows.Forms.Label();
            this.textBoxTRSMsg = new System.Windows.Forms.TextBox();
            this.labelPISC = new System.Windows.Forms.Label();
            this.panelPISC = new System.Windows.Forms.Panel();
            this.textBoxPISCMsg = new System.Windows.Forms.TextBox();
            this.comboBoxPISCPort = new System.Windows.Forms.ComboBox();
            this.buttonPISCClose = new System.Windows.Forms.Button();
            this.buttonPISCOpen = new System.Windows.Forms.Button();
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
            // 
            // panelTRS
            // 
            this.panelTRS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTRS.Controls.Add(this.textBoxTRSMsg);
            this.panelTRS.Controls.Add(this.comboBoxTRSPort);
            this.panelTRS.Controls.Add(this.buttonTRSClose);
            this.panelTRS.Controls.Add(this.buttonTRSOpen);
            this.panelTRS.Location = new System.Drawing.Point(12, 33);
            this.panelTRS.Name = "panelTRS";
            this.panelTRS.Size = new System.Drawing.Size(631, 588);
            this.panelTRS.TabIndex = 2;
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
            // textBoxTRSMsg
            // 
            this.textBoxTRSMsg.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTRSMsg.Location = new System.Drawing.Point(13, 419);
            this.textBoxTRSMsg.Multiline = true;
            this.textBoxTRSMsg.Name = "textBoxTRSMsg";
            this.textBoxTRSMsg.ReadOnly = true;
            this.textBoxTRSMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTRSMsg.Size = new System.Drawing.Size(601, 147);
            this.textBoxTRSMsg.TabIndex = 2;
            // 
            // labelPISC
            // 
            this.labelPISC.AutoSize = true;
            this.labelPISC.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPISC.Location = new System.Drawing.Point(659, 9);
            this.labelPISC.Name = "labelPISC";
            this.labelPISC.Size = new System.Drawing.Size(52, 21);
            this.labelPISC.TabIndex = 3;
            this.labelPISC.Text = "PISC";
            // 
            // panelPISC
            // 
            this.panelPISC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPISC.Controls.Add(this.textBoxPISCMsg);
            this.panelPISC.Controls.Add(this.comboBoxPISCPort);
            this.panelPISC.Controls.Add(this.buttonPISCClose);
            this.panelPISC.Controls.Add(this.buttonPISCOpen);
            this.panelPISC.Location = new System.Drawing.Point(663, 33);
            this.panelPISC.Name = "panelPISC";
            this.panelPISC.Size = new System.Drawing.Size(631, 588);
            this.panelPISC.TabIndex = 2;
            // 
            // textBoxPISCMsg
            // 
            this.textBoxPISCMsg.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPISCMsg.Location = new System.Drawing.Point(13, 419);
            this.textBoxPISCMsg.Multiline = true;
            this.textBoxPISCMsg.Name = "textBoxPISCMsg";
            this.textBoxPISCMsg.ReadOnly = true;
            this.textBoxPISCMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPISCMsg.Size = new System.Drawing.Size(601, 147);
            this.textBoxPISCMsg.TabIndex = 2;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 637);
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
    }
}

