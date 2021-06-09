
namespace TelemetriePITA
{
	partial class Telemetry
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telemetry));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entréeBrutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.receivStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.transcStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.progBarSignalQuality = new System.Windows.Forms.ToolStripProgressBar();
			this.receptionDbValue = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.modulationText = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolModul = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
			this.freqText = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolFreq = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolBand = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel13 = new System.Windows.Forms.ToolStripStatusLabel();
			this.bitrateText = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolRate = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusDataRate = new System.Windows.Forms.ToolStripStatusLabel();
			this.serialPort = new System.IO.Ports.SerialPort(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.configToolStripMenuItem,
            this.vueToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(1480, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.sauvegarderToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// ouvrirToolStripMenuItem
			// 
			this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
			this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.ouvrirToolStripMenuItem.Text = "Ouvrir";
			// 
			// sauvegarderToolStripMenuItem
			// 
			this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
			this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.sauvegarderToolStripMenuItem.Text = "Enregistrer";
			// 
			// enregistrerSousToolStripMenuItem
			// 
			this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
			this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous...";
			this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "Config";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
			// 
			// vueToolStripMenuItem
			// 
			this.vueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entréeBrutToolStripMenuItem});
			this.vueToolStripMenuItem.Name = "vueToolStripMenuItem";
			this.vueToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.vueToolStripMenuItem.Text = "Vue";
			// 
			// entréeBrutToolStripMenuItem
			// 
			this.entréeBrutToolStripMenuItem.Name = "entréeBrutToolStripMenuItem";
			this.entréeBrutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.entréeBrutToolStripMenuItem.Text = "Entrée brut";
			this.entréeBrutToolStripMenuItem.Click += new System.EventHandler(this.entréeBrutToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.receivStatus,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.transcStatus,
            this.toolStripStatusLabel5,
            this.progBarSignalQuality,
            this.receptionDbValue,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel6,
            this.modulationText,
            this.toolModul,
            this.toolStripStatusLabel8,
            this.freqText,
            this.toolFreq,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel11,
            this.toolBand,
            this.toolStripStatusLabel13,
            this.bitrateText,
            this.toolStripStatusLabel7,
            this.toolRate,
            this.toolStripStatusLabel9,
            this.statusDataRate});
			this.statusStrip1.Location = new System.Drawing.Point(0, 558);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1480, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
			this.toolStripStatusLabel1.Text = "état récépteur : ";
			this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
			// 
			// receivStatus
			// 
			this.receivStatus.BackColor = System.Drawing.Color.Red;
			this.receivStatus.Name = "receivStatus";
			this.receivStatus.Size = new System.Drawing.Size(70, 17);
			this.receivStatus.Text = "Déconnecté";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Enabled = false;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(31, 17);
			this.toolStripStatusLabel3.Text = "    |   ";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(78, 17);
			this.toolStripStatusLabel4.Text = "état émetteur";
			// 
			// transcStatus
			// 
			this.transcStatus.BackColor = System.Drawing.Color.Red;
			this.transcStatus.Name = "transcStatus";
			this.transcStatus.Size = new System.Drawing.Size(70, 17);
			this.transcStatus.Text = "Déconnecté";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(116, 17);
			this.toolStripStatusLabel5.Text = "   Qualité réception : ";
			this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
			// 
			// progBarSignalQuality
			// 
			this.progBarSignalQuality.BackColor = System.Drawing.SystemColors.Control;
			this.progBarSignalQuality.Name = "progBarSignalQuality";
			this.progBarSignalQuality.Size = new System.Drawing.Size(100, 16);
			this.progBarSignalQuality.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// receptionDbValue
			// 
			this.receptionDbValue.Name = "receptionDbValue";
			this.receptionDbValue.Size = new System.Drawing.Size(30, 17);
			this.receptionDbValue.Text = "0 dB";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
			this.toolStripStatusLabel2.Text = "                               ";
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(75, 17);
			this.toolStripStatusLabel6.Text = "Modulation :";
			// 
			// modulationText
			// 
			this.modulationText.Name = "modulationText";
			this.modulationText.Size = new System.Drawing.Size(0, 17);
			// 
			// toolModul
			// 
			this.toolModul.Name = "toolModul";
			this.toolModul.Size = new System.Drawing.Size(25, 17);
			this.toolModul.Text = "      ";
			// 
			// toolStripStatusLabel8
			// 
			this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
			this.toolStripStatusLabel8.Size = new System.Drawing.Size(77, 17);
			this.toolStripStatusLabel8.Text = "   Fréquence :";
			// 
			// freqText
			// 
			this.freqText.Name = "freqText";
			this.freqText.Size = new System.Drawing.Size(0, 17);
			// 
			// toolFreq
			// 
			this.toolFreq.Name = "toolFreq";
			this.toolFreq.Size = new System.Drawing.Size(22, 17);
			this.toolFreq.Text = "     ";
			// 
			// toolStripStatusLabel10
			// 
			this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
			this.toolStripStatusLabel10.Size = new System.Drawing.Size(120, 17);
			this.toolStripStatusLabel10.Text = "   Étalement Spéctral :";
			// 
			// toolStripStatusLabel11
			// 
			this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
			this.toolStripStatusLabel11.Size = new System.Drawing.Size(0, 17);
			// 
			// toolBand
			// 
			this.toolBand.Name = "toolBand";
			this.toolBand.Size = new System.Drawing.Size(19, 17);
			this.toolBand.Text = "    ";
			// 
			// toolStripStatusLabel13
			// 
			this.toolStripStatusLabel13.Name = "toolStripStatusLabel13";
			this.toolStripStatusLabel13.Size = new System.Drawing.Size(41, 17);
			this.toolStripStatusLabel13.Text = "Débit :";
			// 
			// bitrateText
			// 
			this.bitrateText.Name = "bitrateText";
			this.bitrateText.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel7
			// 
			this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
			this.toolStripStatusLabel7.Size = new System.Drawing.Size(0, 17);
			// 
			// toolRate
			// 
			this.toolRate.Name = "toolRate";
			this.toolRate.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel9
			// 
			this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
			this.toolStripStatusLabel9.Size = new System.Drawing.Size(19, 17);
			this.toolStripStatusLabel9.Text = "    ";
			// 
			// statusDataRate
			// 
			this.statusDataRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.statusDataRate.Name = "statusDataRate";
			this.statusDataRate.Size = new System.Drawing.Size(69, 17);
			this.statusDataRate.Text = "frame/sec : ";
			this.statusDataRate.Click += new System.EventHandler(this.toolStripStatusLabel12_Click);
			// 
			// serialPort
			// 
			this.serialPort.PortName = "COM3";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBox1);
			this.splitContainer1.Panel2Collapsed = true;
			this.splitContainer1.Size = new System.Drawing.Size(1480, 534);
			this.splitContainer1.SplitterDistance = 1061;
			this.splitContainer1.TabIndex = 5;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.comboBox1);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1474, 29);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "PORT :";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(52, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(179, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Lancer l\'acquisition";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(293, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Stopper l\'acquisition";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.12889F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72727F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1474, 501);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(96, 100);
			this.textBox1.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.CheckFileExists = false;
			this.openFileDialog1.DefaultExt = "csv";
			this.openFileDialog1.FileName = "signal";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// Telemetry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1480, 580);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Telemetry";
			this.Text = "Telemetrie";
			this.Load += new System.EventHandler(this.Telemetry_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel receivStatus;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel transcStatus;
		private System.Windows.Forms.ToolStripProgressBar progBarSignalQuality;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.ToolStripStatusLabel receptionDbValue;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
		private System.Windows.Forms.ToolStripStatusLabel modulationText;
		private System.Windows.Forms.ToolStripStatusLabel toolModul;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
		private System.Windows.Forms.ToolStripStatusLabel freqText;
		private System.Windows.Forms.ToolStripStatusLabel toolFreq;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
		private System.Windows.Forms.ToolStripStatusLabel toolBand;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel13;
		private System.Windows.Forms.ToolStripStatusLabel bitrateText;
		private System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.ToolStripMenuItem vueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entréeBrutToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
		private System.Windows.Forms.ToolStripStatusLabel toolRate;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
		private System.Windows.Forms.ToolStripStatusLabel statusDataRate;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
	}
}