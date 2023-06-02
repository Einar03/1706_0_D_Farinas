namespace _1706x_Spectrometre
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl2PortTxt = new System.Windows.Forms.Label();
            this.lbl2BdTxt = new System.Windows.Forms.Label();
            this.lbl2NbBitsTxt = new System.Windows.Forms.Label();
            this.lblParityTxt = new System.Windows.Forms.Label();
            this.lbl2StopBitTxt = new System.Windows.Forms.Label();
            this.lbl2HandshakeTxt = new System.Windows.Forms.Label();
            this.cboPortTxt = new System.Windows.Forms.ComboBox();
            this.btnApplyPortSettings = new System.Windows.Forms.Button();
            this.btnCancelPortSettings = new System.Windows.Forms.Button();
            this.nudBaudRate = new System.Windows.Forms.NumericUpDown();
            this.nudNbBits = new System.Windows.Forms.NumericUpDown();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboStopBit = new System.Windows.Forms.ComboBox();
            this.cboHandShake = new System.Windows.Forms.ComboBox();
            this.btnUpdatePort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbBits)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl2PortTxt
            // 
            this.lbl2PortTxt.AutoSize = true;
            this.lbl2PortTxt.Location = new System.Drawing.Point(30, 9);
            this.lbl2PortTxt.Name = "lbl2PortTxt";
            this.lbl2PortTxt.Size = new System.Drawing.Size(26, 13);
            this.lbl2PortTxt.TabIndex = 1;
            this.lbl2PortTxt.Text = "Port";
            // 
            // lbl2BdTxt
            // 
            this.lbl2BdTxt.AutoSize = true;
            this.lbl2BdTxt.Location = new System.Drawing.Point(121, 9);
            this.lbl2BdTxt.Name = "lbl2BdTxt";
            this.lbl2BdTxt.Size = new System.Drawing.Size(50, 13);
            this.lbl2BdTxt.TabIndex = 2;
            this.lbl2BdTxt.Text = "Baudrate";
            // 
            // lbl2NbBitsTxt
            // 
            this.lbl2NbBitsTxt.AutoSize = true;
            this.lbl2NbBitsTxt.Location = new System.Drawing.Point(193, 6);
            this.lbl2NbBitsTxt.Name = "lbl2NbBitsTxt";
            this.lbl2NbBitsTxt.Size = new System.Drawing.Size(78, 13);
            this.lbl2NbBitsTxt.TabIndex = 3;
            this.lbl2NbBitsTxt.Text = "Nombre de bits";
            // 
            // lblParityTxt
            // 
            this.lblParityTxt.AutoSize = true;
            this.lblParityTxt.Location = new System.Drawing.Point(301, 9);
            this.lblParityTxt.Name = "lblParityTxt";
            this.lblParityTxt.Size = new System.Drawing.Size(63, 13);
            this.lblParityTxt.TabIndex = 4;
            this.lblParityTxt.Text = "Bit de parité";
            // 
            // lbl2StopBitTxt
            // 
            this.lbl2StopBitTxt.AutoSize = true;
            this.lbl2StopBitTxt.Location = new System.Drawing.Point(396, 9);
            this.lbl2StopBitTxt.Name = "lbl2StopBitTxt";
            this.lbl2StopBitTxt.Size = new System.Drawing.Size(57, 13);
            this.lbl2StopBitTxt.TabIndex = 5;
            this.lbl2StopBitTxt.Text = "Bit de stop";
            // 
            // lbl2HandshakeTxt
            // 
            this.lbl2HandshakeTxt.AutoSize = true;
            this.lbl2HandshakeTxt.Location = new System.Drawing.Point(488, 9);
            this.lbl2HandshakeTxt.Name = "lbl2HandshakeTxt";
            this.lbl2HandshakeTxt.Size = new System.Drawing.Size(62, 13);
            this.lbl2HandshakeTxt.TabIndex = 6;
            this.lbl2HandshakeTxt.Text = "Handshake";
            // 
            // cboPortTxt
            // 
            this.cboPortTxt.FormattingEnabled = true;
            this.cboPortTxt.Location = new System.Drawing.Point(10, 35);
            this.cboPortTxt.Name = "cboPortTxt";
            this.cboPortTxt.Size = new System.Drawing.Size(87, 21);
            this.cboPortTxt.TabIndex = 13;
            // 
            // btnApplyPortSettings
            // 
            this.btnApplyPortSettings.Location = new System.Drawing.Point(399, 111);
            this.btnApplyPortSettings.Name = "btnApplyPortSettings";
            this.btnApplyPortSettings.Size = new System.Drawing.Size(75, 23);
            this.btnApplyPortSettings.TabIndex = 14;
            this.btnApplyPortSettings.Text = "Appliquer";
            this.btnApplyPortSettings.UseVisualStyleBackColor = true;
            this.btnApplyPortSettings.Click += new System.EventHandler(this.BtnApplyPortSettings_Click);
            // 
            // btnCancelPortSettings
            // 
            this.btnCancelPortSettings.Location = new System.Drawing.Point(487, 111);
            this.btnCancelPortSettings.Name = "btnCancelPortSettings";
            this.btnCancelPortSettings.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPortSettings.TabIndex = 15;
            this.btnCancelPortSettings.Text = "Annuler";
            this.btnCancelPortSettings.UseVisualStyleBackColor = true;
            this.btnCancelPortSettings.Click += new System.EventHandler(this.BtnCancelPortSettings_Click);
            // 
            // nudBaudRate
            // 
            this.nudBaudRate.Location = new System.Drawing.Point(103, 35);
            this.nudBaudRate.Maximum = new decimal(new int[] {
            921600,
            0,
            0,
            0});
            this.nudBaudRate.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBaudRate.Name = "nudBaudRate";
            this.nudBaudRate.Size = new System.Drawing.Size(87, 20);
            this.nudBaudRate.TabIndex = 16;
            this.nudBaudRate.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudNbBits
            // 
            this.nudNbBits.Location = new System.Drawing.Point(196, 35);
            this.nudNbBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNbBits.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNbBits.Name = "nudNbBits";
            this.nudNbBits.Size = new System.Drawing.Size(87, 20);
            this.nudNbBits.TabIndex = 17;
            this.nudNbBits.Tag = "";
            this.nudNbBits.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(289, 35);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(87, 21);
            this.cboParity.TabIndex = 18;
            // 
            // cboStopBit
            // 
            this.cboStopBit.FormattingEnabled = true;
            this.cboStopBit.Location = new System.Drawing.Point(382, 35);
            this.cboStopBit.Name = "cboStopBit";
            this.cboStopBit.Size = new System.Drawing.Size(87, 21);
            this.cboStopBit.TabIndex = 19;
            // 
            // cboHandShake
            // 
            this.cboHandShake.FormattingEnabled = true;
            this.cboHandShake.Location = new System.Drawing.Point(475, 35);
            this.cboHandShake.Name = "cboHandShake";
            this.cboHandShake.Size = new System.Drawing.Size(99, 21);
            this.cboHandShake.TabIndex = 20;
            // 
            // btnUpdatePort
            // 
            this.btnUpdatePort.Location = new System.Drawing.Point(12, 94);
            this.btnUpdatePort.Name = "btnUpdatePort";
            this.btnUpdatePort.Size = new System.Drawing.Size(110, 43);
            this.btnUpdatePort.TabIndex = 21;
            this.btnUpdatePort.Text = "Update Port list";
            this.btnUpdatePort.UseVisualStyleBackColor = true;
            this.btnUpdatePort.Click += new System.EventHandler(this.BtnUpdatePort_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 149);
            this.Controls.Add(this.btnUpdatePort);
            this.Controls.Add(this.cboHandShake);
            this.Controls.Add(this.cboStopBit);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.nudNbBits);
            this.Controls.Add(this.nudBaudRate);
            this.Controls.Add(this.btnCancelPortSettings);
            this.Controls.Add(this.btnApplyPortSettings);
            this.Controls.Add(this.cboPortTxt);
            this.Controls.Add(this.lbl2HandshakeTxt);
            this.Controls.Add(this.lbl2StopBitTxt);
            this.Controls.Add(this.lblParityTxt);
            this.Controls.Add(this.lbl2NbBitsTxt);
            this.Controls.Add(this.lbl2BdTxt);
            this.Controls.Add(this.lbl2PortTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Configuration du Port Série";
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbBits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2PortTxt;
        private System.Windows.Forms.Label lbl2BdTxt;
        private System.Windows.Forms.Label lbl2NbBitsTxt;
        private System.Windows.Forms.Label lblParityTxt;
        private System.Windows.Forms.Label lbl2StopBitTxt;
        private System.Windows.Forms.Label lbl2HandshakeTxt;
        private System.Windows.Forms.ComboBox cboPortTxt;
        private System.Windows.Forms.Button btnApplyPortSettings;
        private System.Windows.Forms.Button btnCancelPortSettings;
        private System.Windows.Forms.NumericUpDown nudBaudRate;
        private System.Windows.Forms.NumericUpDown nudNbBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboStopBit;
        private System.Windows.Forms.ComboBox cboHandShake;
        private System.Windows.Forms.Button btnUpdatePort;
    }
}