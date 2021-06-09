
namespace TelemetriePITA
{
	partial class Config
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
			this.comboModul = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboFreq = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBand = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelDatarate = new System.Windows.Forms.Label();
			this.comboCR = new System.Windows.Forms.ComboBox();
			this.labelCR = new System.Windows.Forms.Label();
			this.comboSF = new System.Windows.Forms.ComboBox();
			this.labelSF = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.removeFrame = new System.Windows.Forms.Button();
			this.addFrame = new System.Windows.Forms.Button();
			this.flpFrame = new System.Windows.Forms.FlowLayoutPanel();
			this.removeData = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.labelFrameRate = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.flpData = new System.Windows.Forms.FlowLayoutPanel();
			this.labelFrameSize = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.addData = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.labelEIRP = new System.Windows.Forms.Label();
			this.labelERP = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.labelRange = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.numericMargin = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.numericGRX = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.numericGTX = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.numericPTX = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.comboModule = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMargin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericGRX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericGTX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPTX)).BeginInit();
			this.SuspendLayout();
			// 
			// comboModul
			// 
			this.comboModul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModul.FormattingEnabled = true;
			this.comboModul.Items.AddRange(new object[] {
            "FSK",
            "LoRa"});
			this.comboModul.Location = new System.Drawing.Point(109, 32);
			this.comboModul.Name = "comboModul";
			this.comboModul.Size = new System.Drawing.Size(121, 21);
			this.comboModul.TabIndex = 0;
			this.comboModul.SelectedIndexChanged += new System.EventHandler(this.comboModul_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Modulation";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fréquence (Mhz)";
			// 
			// comboFreq
			// 
			this.comboFreq.FormattingEnabled = true;
			this.comboFreq.Items.AddRange(new object[] {
            "433",
            "868"});
			this.comboFreq.Location = new System.Drawing.Point(109, 59);
			this.comboFreq.Name = "comboFreq";
			this.comboFreq.Size = new System.Drawing.Size(121, 21);
			this.comboFreq.TabIndex = 2;
			this.comboFreq.TextChanged += new System.EventHandler(this.comboFreq_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 5;
			// 
			// comboBand
			// 
			this.comboBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBand.FormattingEnabled = true;
			this.comboBand.Items.AddRange(new object[] {
            "125",
            "250",
            "500"});
			this.comboBand.Location = new System.Drawing.Point(109, 86);
			this.comboBand.Name = "comboBand";
			this.comboBand.Size = new System.Drawing.Size(121, 21);
			this.comboBand.TabIndex = 4;
			this.comboBand.TextChanged += new System.EventHandler(this.comboBand_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "étalement spectral";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelDatarate);
			this.groupBox1.Controls.Add(this.comboCR);
			this.groupBox1.Controls.Add(this.labelCR);
			this.groupBox1.Controls.Add(this.comboSF);
			this.groupBox1.Controls.Add(this.labelSF);
			this.groupBox1.Controls.Add(this.comboModul);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboFreq);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBand);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(511, 172);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Parametre Transmission";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// labelDatarate
			// 
			this.labelDatarate.AutoSize = true;
			this.labelDatarate.Location = new System.Drawing.Point(282, 143);
			this.labelDatarate.Name = "labelDatarate";
			this.labelDatarate.Size = new System.Drawing.Size(42, 13);
			this.labelDatarate.TabIndex = 15;
			this.labelDatarate.Text = "0 bits/s";
			this.labelDatarate.Click += new System.EventHandler(this.labelDatarate_Click);
			// 
			// comboCR
			// 
			this.comboCR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboCR.FormattingEnabled = true;
			this.comboCR.Items.AddRange(new object[] {
            "4/5",
            "4/6",
            "4/7",
            "4/8"});
			this.comboCR.Location = new System.Drawing.Point(109, 140);
			this.comboCR.Name = "comboCR";
			this.comboCR.Size = new System.Drawing.Size(121, 21);
			this.comboCR.TabIndex = 12;
			this.comboCR.Visible = false;
			this.comboCR.SelectedIndexChanged += new System.EventHandler(this.comboCR_SelectedIndexChanged);
			// 
			// labelCR
			// 
			this.labelCR.AutoSize = true;
			this.labelCR.Location = new System.Drawing.Point(10, 143);
			this.labelCR.Name = "labelCR";
			this.labelCR.Size = new System.Drawing.Size(66, 13);
			this.labelCR.TabIndex = 13;
			this.labelCR.Text = "Coding Rate";
			this.labelCR.Visible = false;
			// 
			// comboSF
			// 
			this.comboSF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSF.FormattingEnabled = true;
			this.comboSF.Location = new System.Drawing.Point(109, 113);
			this.comboSF.Name = "comboSF";
			this.comboSF.Size = new System.Drawing.Size(121, 21);
			this.comboSF.TabIndex = 10;
			this.comboSF.SelectedIndexChanged += new System.EventHandler(this.comboSF_SelectedIndexChanged);
			// 
			// labelSF
			// 
			this.labelSF.AutoSize = true;
			this.labelSF.Location = new System.Drawing.Point(10, 116);
			this.labelSF.Name = "labelSF";
			this.labelSF.Size = new System.Drawing.Size(56, 13);
			this.labelSF.TabIndex = 11;
			this.labelSF.Text = "Débit / SF";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.removeFrame);
			this.groupBox2.Controls.Add(this.addFrame);
			this.groupBox2.Controls.Add(this.flpFrame);
			this.groupBox2.Controls.Add(this.removeData);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.labelFrameRate);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.labelFrameSize);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.addData);
			this.groupBox2.Location = new System.Drawing.Point(12, 190);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(971, 401);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Parametre Trame";
			// 
			// removeFrame
			// 
			this.removeFrame.Location = new System.Drawing.Point(125, 80);
			this.removeFrame.Name = "removeFrame";
			this.removeFrame.Size = new System.Drawing.Size(113, 23);
			this.removeFrame.TabIndex = 23;
			this.removeFrame.Text = "Retirer une trame";
			this.removeFrame.UseVisualStyleBackColor = true;
			this.removeFrame.Click += new System.EventHandler(this.removeFrame_Click);
			// 
			// addFrame
			// 
			this.addFrame.Location = new System.Drawing.Point(9, 80);
			this.addFrame.Name = "addFrame";
			this.addFrame.Size = new System.Drawing.Size(113, 23);
			this.addFrame.TabIndex = 22;
			this.addFrame.Text = "Ajouter une trame";
			this.addFrame.UseVisualStyleBackColor = true;
			this.addFrame.Click += new System.EventHandler(this.addFrame_Click);
			// 
			// flpFrame
			// 
			this.flpFrame.AutoScroll = true;
			this.flpFrame.Location = new System.Drawing.Point(9, 19);
			this.flpFrame.Name = "flpFrame";
			this.flpFrame.Size = new System.Drawing.Size(950, 55);
			this.flpFrame.TabIndex = 21;
			// 
			// removeData
			// 
			this.removeData.Location = new System.Drawing.Point(125, 348);
			this.removeData.Name = "removeData";
			this.removeData.Size = new System.Drawing.Size(113, 23);
			this.removeData.TabIndex = 20;
			this.removeData.Text = "Retirer une donnée";
			this.removeData.UseVisualStyleBackColor = true;
			this.removeData.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(282, 378);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(70, 13);
			this.label12.TabIndex = 19;
			this.label12.Text = "Debit frame : ";
			// 
			// labelFrameRate
			// 
			this.labelFrameRate.AutoEllipsis = true;
			this.labelFrameRate.AutoSize = true;
			this.labelFrameRate.Location = new System.Drawing.Point(358, 378);
			this.labelFrameRate.Name = "labelFrameRate";
			this.labelFrameRate.Size = new System.Drawing.Size(142, 13);
			this.labelFrameRate.TabIndex = 18;
			this.labelFrameRate.Text = "0 par seconde (en moyenne)";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.flpData);
			this.groupBox3.Location = new System.Drawing.Point(6, 109);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(959, 233);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Données à transmettre";
			// 
			// flpData
			// 
			this.flpData.AutoScroll = true;
			this.flpData.Location = new System.Drawing.Point(9, 19);
			this.flpData.Name = "flpData";
			this.flpData.Size = new System.Drawing.Size(944, 208);
			this.flpData.TabIndex = 7;
			// 
			// labelFrameSize
			// 
			this.labelFrameSize.AutoEllipsis = true;
			this.labelFrameSize.AutoSize = true;
			this.labelFrameSize.Location = new System.Drawing.Point(86, 378);
			this.labelFrameSize.Name = "labelFrameSize";
			this.labelFrameSize.Size = new System.Drawing.Size(32, 13);
			this.labelFrameSize.TabIndex = 9;
			this.labelFrameSize.Text = "0 bits";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 378);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(74, 13);
			this.label11.TabIndex = 8;
			this.label11.Text = "Taille Trame : ";
			// 
			// addData
			// 
			this.addData.Location = new System.Drawing.Point(6, 348);
			this.addData.Name = "addData";
			this.addData.Size = new System.Drawing.Size(113, 23);
			this.addData.TabIndex = 6;
			this.addData.Text = "Ajouter une donnée";
			this.addData.UseVisualStyleBackColor = true;
			this.addData.Click += new System.EventHandler(this.addItem_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.labelEIRP);
			this.groupBox4.Controls.Add(this.labelERP);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.labelRange);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.numericMargin);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.numericGRX);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.numericGTX);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.numericPTX);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.comboModule);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Location = new System.Drawing.Point(530, 13);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(453, 171);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Portée";
			// 
			// labelEIRP
			// 
			this.labelEIRP.AutoSize = true;
			this.labelEIRP.Location = new System.Drawing.Point(315, 85);
			this.labelEIRP.Name = "labelEIRP";
			this.labelEIRP.Size = new System.Drawing.Size(48, 13);
			this.labelEIRP.TabIndex = 17;
			this.labelEIRP.Text = "0 dBmW";
			// 
			// labelERP
			// 
			this.labelERP.AutoSize = true;
			this.labelERP.Location = new System.Drawing.Point(315, 61);
			this.labelERP.Name = "labelERP";
			this.labelERP.Size = new System.Drawing.Size(48, 13);
			this.labelERP.TabIndex = 16;
			this.labelERP.Text = "0 dBmW";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(268, 85);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 13);
			this.label19.TabIndex = 15;
			this.label19.Text = "EIRP : ";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(268, 61);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(38, 13);
			this.label18.TabIndex = 14;
			this.label18.Text = "ERP : ";
			// 
			// labelRange
			// 
			this.labelRange.AutoSize = true;
			this.labelRange.Location = new System.Drawing.Point(106, 155);
			this.labelRange.Name = "labelRange";
			this.labelRange.Size = new System.Drawing.Size(30, 13);
			this.labelRange.TabIndex = 13;
			this.labelRange.Text = "0 km";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(6, 155);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(94, 13);
			this.label17.TabIndex = 12;
			this.label17.Text = "Portée théorique : ";
			// 
			// numericMargin
			// 
			this.numericMargin.Location = new System.Drawing.Point(113, 124);
			this.numericMargin.Name = "numericMargin";
			this.numericMargin.Size = new System.Drawing.Size(120, 20);
			this.numericMargin.TabIndex = 11;
			this.numericMargin.ValueChanged += new System.EventHandler(this.numericMargin_ValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(5, 126);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(59, 13);
			this.label16.TabIndex = 10;
			this.label16.Text = "Marge (dB)";
			// 
			// numericGRX
			// 
			this.numericGRX.Location = new System.Drawing.Point(113, 98);
			this.numericGRX.Name = "numericGRX";
			this.numericGRX.Size = new System.Drawing.Size(120, 20);
			this.numericGRX.TabIndex = 9;
			this.numericGRX.ValueChanged += new System.EventHandler(this.numericGRX_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(5, 100);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(90, 13);
			this.label15.TabIndex = 8;
			this.label15.Text = "Gain Ant RX (dBi)";
			// 
			// numericGTX
			// 
			this.numericGTX.Location = new System.Drawing.Point(113, 72);
			this.numericGTX.Name = "numericGTX";
			this.numericGTX.Size = new System.Drawing.Size(120, 20);
			this.numericGTX.TabIndex = 7;
			this.numericGTX.ValueChanged += new System.EventHandler(this.numericGTX_ValueChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(5, 74);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(89, 13);
			this.label14.TabIndex = 6;
			this.label14.Text = "Gain Ant TX (dBi)";
			// 
			// numericPTX
			// 
			this.numericPTX.Location = new System.Drawing.Point(113, 46);
			this.numericPTX.Name = "numericPTX";
			this.numericPTX.Size = new System.Drawing.Size(120, 20);
			this.numericPTX.TabIndex = 5;
			this.numericPTX.ValueChanged += new System.EventHandler(this.numericPTX_ValueChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(103, 13);
			this.label13.TabIndex = 4;
			this.label13.Text = "Puissance TX (dBm)";
			// 
			// comboModule
			// 
			this.comboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModule.FormattingEnabled = true;
			this.comboModule.Items.AddRange(new object[] {
            "SX1276"});
			this.comboModule.Location = new System.Drawing.Point(113, 19);
			this.comboModule.Name = "comboModule";
			this.comboModule.Size = new System.Drawing.Size(121, 21);
			this.comboModule.TabIndex = 2;
			this.comboModule.SelectedIndexChanged += new System.EventHandler(this.comboModule_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "Module";
			// 
			// Config
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 599);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Config";
			this.Text = "Configuration simple";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMargin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericGRX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericGTX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPTX)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.ComboBox comboModul;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox comboFreq;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.ComboBox comboBand;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.ComboBox comboSF;
		private System.Windows.Forms.Label labelSF;
		public System.Windows.Forms.ComboBox comboCR;
		private System.Windows.Forms.Label labelCR;
		private System.Windows.Forms.Label labelDatarate;
		private System.Windows.Forms.Label labelFrameSize;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.FlowLayoutPanel flpData;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label labelFrameRate;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label labelRange;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown numericMargin;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown numericGRX;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown numericGTX;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown numericPTX;
		private System.Windows.Forms.Label label13;
		public System.Windows.Forms.ComboBox comboModule;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labelEIRP;
		private System.Windows.Forms.Label labelERP;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button removeFrame;
		private System.Windows.Forms.Button addFrame;
		private System.Windows.Forms.FlowLayoutPanel flpFrame;
		private System.Windows.Forms.Button removeData;
		private System.Windows.Forms.Button addData;
	}
}