
namespace TelemetriePITA
{
	partial class AdvanceConfig
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelDatarate = new System.Windows.Forms.Label();
			this.comboCR = new System.Windows.Forms.ComboBox();
			this.labelCR = new System.Windows.Forms.Label();
			this.comboSF = new System.Windows.Forms.ComboBox();
			this.labelSF = new System.Windows.Forms.Label();
			this.comboModul = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboFreq = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBand = new System.Windows.Forms.ComboBox();
			this.numericPTX = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericPTX)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericPTX);
			this.groupBox1.Controls.Add(this.label13);
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
			this.groupBox1.Size = new System.Drawing.Size(350, 199);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Parametre Transmission";
			// 
			// labelDatarate
			// 
			this.labelDatarate.AutoSize = true;
			this.labelDatarate.Location = new System.Drawing.Point(299, 170);
			this.labelDatarate.Name = "labelDatarate";
			this.labelDatarate.Size = new System.Drawing.Size(42, 13);
			this.labelDatarate.TabIndex = 15;
			this.labelDatarate.Text = "0 bits/s";
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
			this.comboCR.Location = new System.Drawing.Point(116, 140);
			this.comboCR.Name = "comboCR";
			this.comboCR.Size = new System.Drawing.Size(121, 21);
			this.comboCR.TabIndex = 12;
			this.comboCR.Visible = false;
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
			this.comboSF.Location = new System.Drawing.Point(116, 113);
			this.comboSF.Name = "comboSF";
			this.comboSF.Size = new System.Drawing.Size(121, 21);
			this.comboSF.TabIndex = 10;
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
			// comboModul
			// 
			this.comboModul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModul.FormattingEnabled = true;
			this.comboModul.Items.AddRange(new object[] {
            "FSK",
            "LoRa"});
			this.comboModul.Location = new System.Drawing.Point(116, 32);
			this.comboModul.Name = "comboModul";
			this.comboModul.Size = new System.Drawing.Size(121, 21);
			this.comboModul.TabIndex = 0;
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
			// comboFreq
			// 
			this.comboFreq.FormattingEnabled = true;
			this.comboFreq.Items.AddRange(new object[] {
            "433",
            "868"});
			this.comboFreq.Location = new System.Drawing.Point(116, 59);
			this.comboFreq.Name = "comboFreq";
			this.comboFreq.Size = new System.Drawing.Size(121, 21);
			this.comboFreq.TabIndex = 2;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fréquence (Mhz)";
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
			this.comboBand.Location = new System.Drawing.Point(116, 86);
			this.comboBand.Name = "comboBand";
			this.comboBand.Size = new System.Drawing.Size(121, 21);
			this.comboBand.TabIndex = 4;
			// 
			// numericPTX
			// 
			this.numericPTX.Location = new System.Drawing.Point(116, 168);
			this.numericPTX.Name = "numericPTX";
			this.numericPTX.Size = new System.Drawing.Size(121, 20);
			this.numericPTX.TabIndex = 17;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(10, 170);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(103, 13);
			this.label13.TabIndex = 16;
			this.label13.Text = "Puissance TX (dBm)";
			// 
			// AdvanceConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 430);
			this.Controls.Add(this.groupBox1);
			this.Name = "AdvanceConfig";
			this.Text = "AdvanceConfig";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericPTX)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelDatarate;
		public System.Windows.Forms.ComboBox comboCR;
		private System.Windows.Forms.Label labelCR;
		public System.Windows.Forms.ComboBox comboSF;
		private System.Windows.Forms.Label labelSF;
		public System.Windows.Forms.ComboBox comboModul;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox comboFreq;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.ComboBox comboBand;
		private System.Windows.Forms.NumericUpDown numericPTX;
		private System.Windows.Forms.Label label13;
	}
}