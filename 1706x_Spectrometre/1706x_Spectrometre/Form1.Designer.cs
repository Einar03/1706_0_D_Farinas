namespace _1706x_Spectrometre
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCCT = new System.Windows.Forms.Label();
            this.lbCRI = new System.Windows.Forms.Label();
            this.lbLUX = new System.Windows.Forms.Label();
            this.lblongeurdonde = new System.Windows.Forms.Label();
            this.tbCCT = new System.Windows.Forms.TextBox();
            this.tbCRI = new System.Windows.Forms.TextBox();
            this.tbLUX = new System.Windows.Forms.TextBox();
            this.tblongueurdonde = new System.Windows.Forms.TextBox();
            this.plSpectrum = new System.Windows.Forms.Panel();
            this.tbITime = new System.Windows.Forms.TextBox();
            this.lbITime = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb360 = new System.Windows.Forms.Label();
            this.lb760 = new System.Windows.Forms.Label();
            this.btAffiche = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.gbaffiche = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblSerialPortStateTxt = new System.Windows.Forms.Label();
            this.lblBdTxt = new System.Windows.Forms.Label();
            this.lblNbBitsTxt = new System.Windows.Forms.Label();
            this.lblParityBitsTxt = new System.Windows.Forms.Label();
            this.lblStopBitsTxt = new System.Windows.Forms.Label();
            this.lblHandshakeTxt = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portSérieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationDuPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblBd = new System.Windows.Forms.Label();
            this.lblNbBits = new System.Windows.Forms.Label();
            this.lblParityBit = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblHandshake = new System.Windows.Forms.Label();
            this.lblPortTxt = new System.Windows.Forms.Label();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMovingAverageValue = new System.Windows.Forms.NumericUpDown();
            this.gbaffiche.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovingAverageValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCCT
            // 
            this.lbCCT.AutoSize = true;
            this.lbCCT.Location = new System.Drawing.Point(36, 43);
            this.lbCCT.Name = "lbCCT";
            this.lbCCT.Size = new System.Drawing.Size(28, 13);
            this.lbCCT.TabIndex = 0;
            this.lbCCT.Text = "CCT";
            // 
            // lbCRI
            // 
            this.lbCRI.AutoSize = true;
            this.lbCRI.Location = new System.Drawing.Point(39, 69);
            this.lbCRI.Name = "lbCRI";
            this.lbCRI.Size = new System.Drawing.Size(25, 13);
            this.lbCRI.TabIndex = 1;
            this.lbCRI.Text = "CRI";
            // 
            // lbLUX
            // 
            this.lbLUX.AutoSize = true;
            this.lbLUX.Location = new System.Drawing.Point(36, 95);
            this.lbLUX.Name = "lbLUX";
            this.lbLUX.Size = new System.Drawing.Size(28, 13);
            this.lbLUX.TabIndex = 2;
            this.lbLUX.Text = "LUX";
            // 
            // lblongeurdonde
            // 
            this.lblongeurdonde.AutoSize = true;
            this.lblongeurdonde.Location = new System.Drawing.Point(46, 121);
            this.lblongeurdonde.Name = "lblongeurdonde";
            this.lblongeurdonde.Size = new System.Drawing.Size(18, 13);
            this.lblongeurdonde.TabIndex = 3;
            this.lblongeurdonde.Text = "λp";
            // 
            // tbCCT
            // 
            this.tbCCT.Location = new System.Drawing.Point(70, 40);
            this.tbCCT.Name = "tbCCT";
            this.tbCCT.ReadOnly = true;
            this.tbCCT.Size = new System.Drawing.Size(124, 20);
            this.tbCCT.TabIndex = 4;
            // 
            // tbCRI
            // 
            this.tbCRI.Location = new System.Drawing.Point(70, 66);
            this.tbCRI.Name = "tbCRI";
            this.tbCRI.ReadOnly = true;
            this.tbCRI.Size = new System.Drawing.Size(124, 20);
            this.tbCRI.TabIndex = 5;
            // 
            // tbLUX
            // 
            this.tbLUX.Location = new System.Drawing.Point(70, 92);
            this.tbLUX.Name = "tbLUX";
            this.tbLUX.ReadOnly = true;
            this.tbLUX.Size = new System.Drawing.Size(124, 20);
            this.tbLUX.TabIndex = 6;
            // 
            // tblongueurdonde
            // 
            this.tblongueurdonde.Location = new System.Drawing.Point(70, 118);
            this.tblongueurdonde.Name = "tblongueurdonde";
            this.tblongueurdonde.ReadOnly = true;
            this.tblongueurdonde.Size = new System.Drawing.Size(124, 20);
            this.tblongueurdonde.TabIndex = 7;
            // 
            // plSpectrum
            // 
            this.plSpectrum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plSpectrum.Location = new System.Drawing.Point(34, 22);
            this.plSpectrum.Name = "plSpectrum";
            this.plSpectrum.Size = new System.Drawing.Size(400, 240);
            this.plSpectrum.TabIndex = 8;
            // 
            // tbITime
            // 
            this.tbITime.Location = new System.Drawing.Point(70, 144);
            this.tbITime.Name = "tbITime";
            this.tbITime.ReadOnly = true;
            this.tbITime.Size = new System.Drawing.Size(124, 20);
            this.tbITime.TabIndex = 10;
            // 
            // lbITime
            // 
            this.lbITime.AutoSize = true;
            this.lbITime.Location = new System.Drawing.Point(28, 147);
            this.lbITime.Name = "lbITime";
            this.lbITime.Size = new System.Drawing.Size(36, 13);
            this.lbITime.TabIndex = 9;
            this.lbITime.Text = "I-Time";
            // 
            // lb360
            // 
            this.lb360.AutoSize = true;
            this.lb360.Location = new System.Drawing.Point(31, 265);
            this.lb360.Name = "lb360";
            this.lb360.Size = new System.Drawing.Size(25, 13);
            this.lb360.TabIndex = 12;
            this.lb360.Text = "360";
            // 
            // lb760
            // 
            this.lb760.AutoSize = true;
            this.lb760.Location = new System.Drawing.Point(409, 265);
            this.lb760.Name = "lb760";
            this.lb760.Size = new System.Drawing.Size(25, 13);
            this.lb760.TabIndex = 13;
            this.lb760.Text = "760";
            // 
            // btAffiche
            // 
            this.btAffiche.Location = new System.Drawing.Point(42, 182);
            this.btAffiche.Name = "btAffiche";
            this.btAffiche.Size = new System.Drawing.Size(154, 61);
            this.btAffiche.TabIndex = 14;
            this.btAffiche.Text = "Affiche Val";
            this.btAffiche.UseVisualStyleBackColor = true;
            this.btAffiche.Click += new System.EventHandler(this.BtAffiche_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(15, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(13, 13);
            this.lb1.TabIndex = 11;
            this.lb1.Text = "1";
            // 
            // gbaffiche
            // 
            this.gbaffiche.Controls.Add(this.lb760);
            this.gbaffiche.Controls.Add(this.lb360);
            this.gbaffiche.Controls.Add(this.lb1);
            this.gbaffiche.Controls.Add(this.plSpectrum);
            this.gbaffiche.Location = new System.Drawing.Point(218, 12);
            this.gbaffiche.Name = "gbaffiche";
            this.gbaffiche.Size = new System.Drawing.Size(459, 297);
            this.gbaffiche.TabIndex = 15;
            this.gbaffiche.TabStop = false;
            this.gbaffiche.Text = "Affichage graphique";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // lblSerialPortStateTxt
            // 
            this.lblSerialPortStateTxt.AutoSize = true;
            this.lblSerialPortStateTxt.Location = new System.Drawing.Point(82, 337);
            this.lblSerialPortStateTxt.Name = "lblSerialPortStateTxt";
            this.lblSerialPortStateTxt.Size = new System.Drawing.Size(56, 13);
            this.lblSerialPortStateTxt.TabIndex = 16;
            this.lblSerialPortStateTxt.Text = "PortStatus";
            // 
            // lblBdTxt
            // 
            this.lblBdTxt.AutoSize = true;
            this.lblBdTxt.Location = new System.Drawing.Point(208, 337);
            this.lblBdTxt.Name = "lblBdTxt";
            this.lblBdTxt.Size = new System.Drawing.Size(50, 13);
            this.lblBdTxt.TabIndex = 17;
            this.lblBdTxt.Text = "Baudrate";
            // 
            // lblNbBitsTxt
            // 
            this.lblNbBitsTxt.AutoSize = true;
            this.lblNbBitsTxt.Location = new System.Drawing.Point(264, 337);
            this.lblNbBitsTxt.Name = "lblNbBitsTxt";
            this.lblNbBitsTxt.Size = new System.Drawing.Size(78, 13);
            this.lblNbBitsTxt.TabIndex = 18;
            this.lblNbBitsTxt.Text = "Nombre de bits";
            // 
            // lblParityBitsTxt
            // 
            this.lblParityBitsTxt.AutoSize = true;
            this.lblParityBitsTxt.Location = new System.Drawing.Point(348, 337);
            this.lblParityBitsTxt.Name = "lblParityBitsTxt";
            this.lblParityBitsTxt.Size = new System.Drawing.Size(68, 13);
            this.lblParityBitsTxt.TabIndex = 19;
            this.lblParityBitsTxt.Text = "Bits de parité";
            // 
            // lblStopBitsTxt
            // 
            this.lblStopBitsTxt.AutoSize = true;
            this.lblStopBitsTxt.Location = new System.Drawing.Point(422, 337);
            this.lblStopBitsTxt.Name = "lblStopBitsTxt";
            this.lblStopBitsTxt.Size = new System.Drawing.Size(62, 13);
            this.lblStopBitsTxt.TabIndex = 20;
            this.lblStopBitsTxt.Text = "Bits de stop";
            // 
            // lblHandshakeTxt
            // 
            this.lblHandshakeTxt.AutoSize = true;
            this.lblHandshakeTxt.Location = new System.Drawing.Point(501, 337);
            this.lblHandshakeTxt.Name = "lblHandshakeTxt";
            this.lblHandshakeTxt.Size = new System.Drawing.Size(62, 13);
            this.lblHandshakeTxt.TabIndex = 21;
            this.lblHandshakeTxt.Text = "Handshake";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portSérieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portSérieToolStripMenuItem
            // 
            this.portSérieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationDuPortToolStripMenuItem,
            this.initialiserToolStripMenuItem,
            this.arreterToolStripMenuItem});
            this.portSérieToolStripMenuItem.Name = "portSérieToolStripMenuItem";
            this.portSérieToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.portSérieToolStripMenuItem.Text = "Port Série";
            // 
            // configurationDuPortToolStripMenuItem
            // 
            this.configurationDuPortToolStripMenuItem.Name = "configurationDuPortToolStripMenuItem";
            this.configurationDuPortToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.configurationDuPortToolStripMenuItem.Text = "Configuration du Port";
            this.configurationDuPortToolStripMenuItem.Click += new System.EventHandler(this.ConfigurationDuPortToolStripMenuItem_Click);
            // 
            // initialiserToolStripMenuItem
            // 
            this.initialiserToolStripMenuItem.Name = "initialiserToolStripMenuItem";
            this.initialiserToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.initialiserToolStripMenuItem.Text = "Open Port";
            this.initialiserToolStripMenuItem.Click += new System.EventHandler(this.InitialiserToolStripMenuItem_Click);
            // 
            // arreterToolStripMenuItem
            // 
            this.arreterToolStripMenuItem.Name = "arreterToolStripMenuItem";
            this.arreterToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.arreterToolStripMenuItem.Text = "Close Port";
            this.arreterToolStripMenuItem.Click += new System.EventHandler(this.ArreterToolStripMenuItem_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(153, 354);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(10, 13);
            this.lblPort.TabIndex = 23;
            this.lblPort.Text = "-";
            // 
            // lblBd
            // 
            this.lblBd.AutoSize = true;
            this.lblBd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBd.Location = new System.Drawing.Point(208, 354);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(10, 13);
            this.lblBd.TabIndex = 24;
            this.lblBd.Text = "-";
            this.lblBd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNbBits
            // 
            this.lblNbBits.AutoSize = true;
            this.lblNbBits.Location = new System.Drawing.Point(266, 354);
            this.lblNbBits.Name = "lblNbBits";
            this.lblNbBits.Size = new System.Drawing.Size(10, 13);
            this.lblNbBits.TabIndex = 25;
            this.lblNbBits.Text = "-";
            // 
            // lblParityBit
            // 
            this.lblParityBit.AutoSize = true;
            this.lblParityBit.Location = new System.Drawing.Point(348, 354);
            this.lblParityBit.Name = "lblParityBit";
            this.lblParityBit.Size = new System.Drawing.Size(10, 13);
            this.lblParityBit.TabIndex = 26;
            this.lblParityBit.Text = "-";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(422, 354);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(10, 13);
            this.lblStopBits.TabIndex = 27;
            this.lblStopBits.Text = "-";
            // 
            // lblHandshake
            // 
            this.lblHandshake.AutoSize = true;
            this.lblHandshake.Location = new System.Drawing.Point(501, 354);
            this.lblHandshake.Name = "lblHandshake";
            this.lblHandshake.Size = new System.Drawing.Size(10, 13);
            this.lblHandshake.TabIndex = 28;
            this.lblHandshake.Text = "-";
            // 
            // lblPortTxt
            // 
            this.lblPortTxt.AutoSize = true;
            this.lblPortTxt.Location = new System.Drawing.Point(153, 337);
            this.lblPortTxt.Name = "lblPortTxt";
            this.lblPortTxt.Size = new System.Drawing.Size(26, 13);
            this.lblPortTxt.TabIndex = 29;
            this.lblPortTxt.Text = "Port";
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Location = new System.Drawing.Point(87, 354);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(10, 13);
            this.lblPortStatus.TabIndex = 30;
            this.lblPortStatus.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Valeur de filtrage";
            // 
            // nudMovingAverageValue
            // 
            this.nudMovingAverageValue.Location = new System.Drawing.Point(67, 277);
            this.nudMovingAverageValue.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMovingAverageValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMovingAverageValue.Name = "nudMovingAverageValue";
            this.nudMovingAverageValue.Size = new System.Drawing.Size(112, 20);
            this.nudMovingAverageValue.TabIndex = 32;
            this.nudMovingAverageValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 385);
            this.Controls.Add(this.nudMovingAverageValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPortStatus);
            this.Controls.Add(this.lblPortTxt);
            this.Controls.Add(this.lblHandshake);
            this.Controls.Add(this.lblStopBits);
            this.Controls.Add(this.lblParityBit);
            this.Controls.Add(this.lblNbBits);
            this.Controls.Add(this.lblBd);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHandshakeTxt);
            this.Controls.Add(this.lblStopBitsTxt);
            this.Controls.Add(this.lblParityBitsTxt);
            this.Controls.Add(this.lblNbBitsTxt);
            this.Controls.Add(this.lblBdTxt);
            this.Controls.Add(this.lblSerialPortStateTxt);
            this.Controls.Add(this.gbaffiche);
            this.Controls.Add(this.btAffiche);
            this.Controls.Add(this.tbITime);
            this.Controls.Add(this.lbITime);
            this.Controls.Add(this.tblongueurdonde);
            this.Controls.Add(this.tbLUX);
            this.Controls.Add(this.tbCRI);
            this.Controls.Add(this.tbCCT);
            this.Controls.Add(this.lblongeurdonde);
            this.Controls.Add(this.lbLUX);
            this.Controls.Add(this.lbCRI);
            this.Controls.Add(this.lbCCT);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Spectrometre";
            this.gbaffiche.ResumeLayout(false);
            this.gbaffiche.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovingAverageValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCCT;
        private System.Windows.Forms.Label lbCRI;
        private System.Windows.Forms.Label lbLUX;
        private System.Windows.Forms.Label lblongeurdonde;
        private System.Windows.Forms.TextBox tbCCT;
        private System.Windows.Forms.TextBox tbCRI;
        private System.Windows.Forms.TextBox tbLUX;
        private System.Windows.Forms.TextBox tblongueurdonde;
        private System.Windows.Forms.Panel plSpectrum;
        private System.Windows.Forms.TextBox tbITime;
        private System.Windows.Forms.Label lbITime;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label lb360;
        private System.Windows.Forms.Label lb760;
        private System.Windows.Forms.Button btAffiche;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.GroupBox gbaffiche;
        private System.Windows.Forms.Label lblSerialPortStateTxt;
        private System.Windows.Forms.Label lblBdTxt;
        private System.Windows.Forms.Label lblNbBitsTxt;
        private System.Windows.Forms.Label lblParityBitsTxt;
        private System.Windows.Forms.Label lblStopBitsTxt;
        private System.Windows.Forms.Label lblHandshakeTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portSérieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationDuPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initialiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreterToolStripMenuItem;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblBd;
        private System.Windows.Forms.Label lblNbBits;
        private System.Windows.Forms.Label lblParityBit;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblHandshake;
        private System.Windows.Forms.Label lblPortTxt;
        private System.Windows.Forms.Label lblPortStatus;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMovingAverageValue;
    }
}

