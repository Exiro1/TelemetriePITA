using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelemetriePITA
{
	public partial class Config : Form
	{




		List<int[]> sensitivity;


		public Config(string filename)
		{
			sensitivity = new List<int[]>();
			sensitivity.Add(new int[] { -123, -126, -129, -132, -133, -136 });
			sensitivity.Add(new int[] { -120, -123, -126, -128, -130, -133 });
			sensitivity.Add(new int[] { -116, -119, -122, -125, -128, -130 });

			InitializeComponent();
			recoverData(filename);

			

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void comboModul_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((comboModul.SelectedIndex == 1))
			{
				comboSF.Items.Clear();
				comboSF.Items.Add("SF7");
				comboSF.Items.Add("SF8");
				comboSF.Items.Add("SF9");
				comboSF.Items.Add("SF10");
				comboSF.Items.Add("SF11");
				comboSF.Items.Add("SF12");
				comboCR.Visible = true;
				labelCR.Visible = true;
				labelSF.Text = "SF";



			}
			else
			{
				comboSF.Items.Clear();
				comboSF.Items.Add("600");
				comboSF.Items.Add("900");
				comboSF.Items.Add("1200");
				comboSF.Items.Add("2400");
				comboSF.Items.Add("4800");
				comboSF.Items.Add("9600");
				comboCR.Visible = false;
				labelCR.Visible = false;
				labelSF.Text = "Débit";
				comboBand.Items.Remove("500");

			}
			UpdateData(sender,e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//labelDatarate.Text = ((double)( ((comboSF.SelectedIndex + 7) * 4/(comboCR.SelectedIndex + 5.0))/ (Math.Pow(2, comboSF.SelectedIndex + 7)/(double.Parse(comboBand.Text.Replace(".",","))*1000)))).ToString()+ " bits/s";
		}

		private void labelDatarate_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void addItem_Click(object sender, EventArgs e)
		{
			if (panelDataList.Count < 18)
			{
				addDataConfig();
			}
			else
			{

			}
		}

		public int getDataNbr()
		{
			return panelDataList.Count;
		}
		public ConfigData getConfigData(int i)
		{
			return new ConfigData(textDataList[i].Text, textDataUnitList[i].Text,(int) numDataList[i].Value,textDataOffsetList[i].Text,checkBoxList[i].Checked);
		}

		List<Panel> panelDataList = new List<Panel>();
		List<NumericUpDown> numDataList = new List<NumericUpDown>();
		List<TextBox> textDataList = new List<TextBox>();
		List<TextBox> textDataUnitList = new List<TextBox>();
		List<TextBox> textDataOffsetList = new List<TextBox>();
		List<CheckBox> checkBoxList = new List<CheckBox>();

		int frameSize = 0;
		double frameRate = 0;
		double dataRate = 0;

		public double calculateDataRate()
		{
			try
			{
				return ((double)(((comboSF.SelectedIndex + 7) * 4 / (comboCR.SelectedIndex + 5.0)) / (Math.Pow(2, comboSF.SelectedIndex + 7) / (double.Parse(comboBand.Text.Replace(".", ",")) * 1000))));

			}
			catch (Exception e)
			{
				return 0;
			}
			}

		public void UpdateData(object sender, EventArgs e)
		{
			frameSize = calculateFrameSize();
			dataRate = calculateDataRate();
			labelFrameSize.Text = string.Format("{0:N2}", frameSize) + " bits/frame (en moyenne)";
			labelDatarate.Text = string.Format("{0:N2}", dataRate) + " bits/s";
			frameRate = dataRate / frameSize;
			labelFrameRate.Text = string.Format("{0:N2}", frameRate) + " frame par seconde (en moyenne)";
			calculateRange();
		}





		public int calculateFrameSize()
		{
			int size = 0;

			
			//GPS
			if(comboGPS.SelectedIndex == 1)
			{
				size += (64+16)/5;
			}
			else if(comboGPS.SelectedIndex == 2)
			{
				size += (64 + 16) / 3;
			}
			else if(comboGPS.SelectedIndex == 3)
			{
				size += (64 + 16);
			}

			int maxTime = timeMax.Value.Hour * 60 * 60 + timeMax.Value.Minute * 60 + timeMax.Value.Second;

			//TIME
			if (comboTime.SelectedIndex == 1)
			{
				size += (int) Math.Ceiling((Math.Log10(maxTime)/Math.Log10(2))) ;
			}
			else if (comboTime.SelectedIndex == 2)
			{
				size += (int)Math.Ceiling((Math.Log10(maxTime*10) / Math.Log10(2)));
			}
			else if (comboTime.SelectedIndex == 3)
			{
				size += (int)Math.Ceiling((Math.Log10(maxTime*100) / Math.Log10(2)));
			}
			else if (comboTime.SelectedIndex == 4)
			{
				size += (int)Math.Ceiling((Math.Log10(maxTime*1000) / Math.Log10(2)));
			}
			int sep = 0;

			if (comboSepar.SelectedIndex == 1)
			{
				sep = 1;
			}
			else if (comboSepar.SelectedIndex == 2)
			{
				sep = 1;
			}
			else if (comboSepar.SelectedIndex == 3)
			{
				sep = 2;
			}
			if(comboGPS.SelectedIndex != 0)
			{
				size += sep;
			}
			if (comboTime.SelectedIndex != 0)
			{
				size += sep;
			}

			foreach (NumericUpDown num in numDataList)
			{
				size += (int) num.Value + sep;
			}

			return size;
		}


		public int getFactor()
		{
			return (int) Math.Pow(10, (comboTime.SelectedIndex-1));
		}


		public void addDataConfig()
		{
			panelDataList.Add(new System.Windows.Forms.Panel());
			numDataList.Add(new System.Windows.Forms.NumericUpDown());
			textDataList.Add(new System.Windows.Forms.TextBox());
			textDataUnitList.Add(new System.Windows.Forms.TextBox());
			textDataOffsetList.Add(new System.Windows.Forms.TextBox());
			checkBoxList.Add(new CheckBox());

			Label newlabelData = new System.Windows.Forms.Label();
			numDataList.Last().ValueChanged += new System.EventHandler(UpdateData);

			this.flowLayoutPanel1.Controls.Add(panelDataList.Last());

			panelDataList.Last().Controls.Add(numDataList.Last());
			panelDataList.Last().Controls.Add(textDataList.Last());
			panelDataList.Last().Controls.Add(newlabelData);
			panelDataList.Last().Controls.Add(textDataUnitList.Last());
			panelDataList.Last().Controls.Add(textDataOffsetList.Last());
			panelDataList.Last().Controls.Add(checkBoxList.Last());

			panelDataList.Last().Location = new System.Drawing.Point(3, 3);
			panelDataList.Last().Name = "panelData"+ panelDataList.Count;
			panelDataList.Last().Size = new System.Drawing.Size(460, 28);
			panelDataList.Last().TabIndex = panelDataList.Count;

			numDataList.Last().Location = new System.Drawing.Point(258, 4);
			numDataList.Last().Name = "numericData"+numDataList.Count;
			numDataList.Last().Size = new System.Drawing.Size(60, 20);
			numDataList.Last().TabIndex = 2;

			textDataList.Last().Location = new System.Drawing.Point(5, 3);
			textDataList.Last().Name = "textBoxData"+textDataList.Count;
			textDataList.Last().Size = new System.Drawing.Size(100, 20);
			textDataList.Last().TabIndex = 1;
			textDataList.Last().Text = "nom";

			textDataUnitList.Last().Location = new System.Drawing.Point(115, 3);
			textDataUnitList.Last().Name = "textBoxDataUnit" + textDataList.Count;
			textDataUnitList.Last().Size = new System.Drawing.Size(80, 20);
			textDataUnitList.Last().TabIndex = 3;
			textDataUnitList.Last().Text = "unité";

			textDataOffsetList.Last().Location = new System.Drawing.Point(325, 3);
			textDataOffsetList.Last().Name = "textBoxDataOffset" + textDataList.Count;
			textDataOffsetList.Last().Size = new System.Drawing.Size(70, 20);
			textDataOffsetList.Last().TabIndex = 4;
			textDataOffsetList.Last().Text = "formule (a*x+b)";

			checkBoxList.Last().Location = new System.Drawing.Point(400, 3);
			checkBoxList.Last().Name = "checkbox" + textDataList.Count;
			checkBoxList.Last().Size = new System.Drawing.Size(60, 20);
			checkBoxList.Last().TabIndex = 4;
			checkBoxList.Last().Text = "signé";


			newlabelData.AutoSize = true;
			newlabelData.Location = new System.Drawing.Point(200, 6);
			newlabelData.Name = "labelData"+textDataList.Count;
			newlabelData.Size = new System.Drawing.Size(57, 13);
			newlabelData.TabIndex = 0;
			newlabelData.Text = "Taille (bits)";

			panelDataList.Last().ResumeLayout(false);
			panelDataList.Last().PerformLayout();

		}
		public int getSensibility(int sf, int bw)
		{   
			if(sf>-1 && bw > -1 && sf < 6 && bw < 3)
				return (int) sensitivity[bw].GetValue(sf);

			return -130;
		}

		public double getFreq()
		{
			try
			{
				return double.Parse(comboFreq.Text);
			}catch(Exception e)
			{
				return 1;
			}
		}
		public int getBand()
		{
			try
			{
				return comboBand.SelectedIndex;
			}
			catch (Exception e)
			{
				return 1;
			}
		}
		public int getRate()
		{
			try
			{
				return comboSF.SelectedIndex; //0-5
			}
			catch (Exception e)
			{
				return 0;
			}
		}
		public int getCR()
		{
			try
			{
				return comboCR.SelectedIndex; //0-3
			}
			catch (Exception e)
			{
				return 0;
			}
		}
		public int getPTX()
		{
			try
			{
				if(numericPTX.Value <= 14)
				return (int) numericPTX.Value; //0-3

				return 13;
			}
			catch (Exception e)
			{
				return 13;
			}
		}
		public double getMod()
		{
			try
			{
				return comboModul.SelectedIndex; //0-3
			}
			catch (Exception e)
			{
				return 0;
			}
		}
		public double calculateRange()
		{
			double range = 0;
			double pathLoss = (double) numericPTX.Value + (double) numericGTX.Value + (double) numericGRX.Value - getSensibility(getRate(), getBand()) -(double) numericMargin.Value;
			double freq = getFreq();
			range = Math.Pow(10, (pathLoss - 32.45 - 20 * Math.Log10(freq)) / 20);

			labelRange.Text = string.Format("{0:N4}",range) + " km";
			labelEIRP.Text = ((double)numericPTX.Value + (double)numericGTX.Value)+ " dBm ou "+ string.Format("{0:N3}",Math.Pow(10,((double)numericPTX.Value + (double)numericGTX.Value)/10))+" mW";
			labelERP.Text = ((double)numericPTX.Value + (double)numericGTX.Value -2.15) + " dBm ou " + string.Format("{0:N3}", Math.Pow(10, ((double)numericPTX.Value + (double)numericGTX.Value -2.15)/10))+" mW";


			return range;
		}


		public byte[] getPattern()
		{
			byte[] b = new byte[3];
			b[0] = 9;
			b[1] = 9;
			b[2] = 11;
			return b;
		}


		private void numericPTX_ValueChanged(object sender, EventArgs e)
		{
			calculateRange();
		}

		private void numericGTX_ValueChanged(object sender, EventArgs e)
		{
			calculateRange();
		}

		private void numericGRX_ValueChanged(object sender, EventArgs e)
		{
			calculateRange();

		}

		private void numericMargin_ValueChanged(object sender, EventArgs e)
		{
			calculateRange();
		}

		private void comboModule_SelectedIndexChanged(object sender, EventArgs e)
		{
			calculateRange();
		}

		private void Config_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
			saveData("lastConf.xml");




		}

		public void recoverData(string filename)
		{
			XMLParser parser = new XMLParser();

			ConfigObj obj = parser.deserializeConfig(filename);

			comboModul.SelectedIndex = obj.Modulation;
			comboCR.SelectedIndex = obj.CR;
			comboSF.SelectedIndex = obj.SF;
			
			comboGPS.SelectedIndex = obj.GPS;
			comboTime.SelectedIndex = obj.precision;
			comboSepar.SelectedIndex = obj.sep;
			TimeSpan t = TimeSpan.FromSeconds(obj.time);
			timeMax.Value = new DateTime(2020,1,1,t.Hours, t.Minutes, t.Seconds);
			comboFreq.Text = obj.freq+"";
			comboBand.SelectedIndex = obj.bandwitdh;
			numericPTX.Value = (decimal) obj.PTX;
			numericGTX.Value = (decimal)obj.GTX;
			numericGRX.Value = (decimal)obj.GRX;
			numericMargin.Value = (decimal)obj.margin;
			comboModule.SelectedIndex = obj.Module;



			foreach (ConfigData d in obj.datas)
			{
				addDataConfig();
				textDataList.Last().Text = d.name;
				numDataList.Last().Value = d.size;
				textDataUnitList.Last().Text = d.unit;
				textDataOffsetList.Last().Text = d.offset;
				checkBoxList.Last().Checked = d.signed;
			}


		}

		const byte GPS = 0b0001;
		const byte TIME_SINCE_START = 0b0010;
		const byte UNIX_TIME = 0b0100;
		const byte DATA = 0b1000;

		public ConfigObj getObj()
		{
			ConfigObj obj = new ConfigObj();
			obj.Modulation = comboModul.SelectedIndex;
			obj.CR = comboCR.SelectedIndex;
			obj.SF = comboSF.SelectedIndex;
			obj.Module = comboModule.SelectedIndex;
			obj.GPS = comboGPS.SelectedIndex;
			obj.precision = comboTime.SelectedIndex;
			obj.sep = comboSepar.SelectedIndex;
			obj.time = timeMax.Value.Hour * 60 * 60 + timeMax.Value.Minute * 60 + timeMax.Value.Second;
			obj.freq = Double.Parse(comboFreq.Text);
			obj.bandwitdh = comboBand.SelectedIndex;
			obj.PTX = (int)numericPTX.Value;
			obj.GTX = (double)numericGTX.Value;
			obj.GRX = (double)numericGRX.Value;
			obj.margin = (double)numericMargin.Value;
			obj.framePattern = new byte[5];

			if (comboGPS.SelectedIndex == 0) 
			{
				obj.framePattern = new byte[1];
				obj.framePattern[0] = DATA;
			}else if (comboGPS.SelectedIndex == 1)
			{
				obj.framePattern = new byte[5];
				obj.framePattern[0] = DATA;
				obj.framePattern[1] = DATA;
				obj.framePattern[2] = DATA;
				obj.framePattern[3] = DATA;
				obj.framePattern[4] = DATA | GPS;
			}
			else if (comboGPS.SelectedIndex == 2)
			{
				obj.framePattern = new byte[3];
				obj.framePattern[0] = 8;
				obj.framePattern[1] = 8;
				obj.framePattern[2] = 9;
			}
			else if (comboGPS.SelectedIndex == 3)
			{
				obj.framePattern = new byte[1];
				obj.framePattern[0] = 9;
			}
			int i = 0;
			var list = new List<ConfigData>();
			foreach (NumericUpDown num in numDataList)
			{
				list.Add(new ConfigData(textDataList[i].Text, textDataUnitList[i].Text, (int)num.Value, textDataOffsetList[i].Text,checkBoxList[i].Checked)); // TODO
				i++;
			}
			obj.datas = list.ToArray();
			return obj;
		}

		public void saveData(string filename)
		{
			XMLParser parser = new XMLParser();
			parser.serializeConfig(getObj(), filename);
		}

		private void comboSF_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateData(sender, e);
		}

		private void comboCR_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateData(sender, e);
		}

		private void comboBand_TextChanged(object sender, EventArgs e)
		{
			UpdateData(sender, e);
		}

		private void comboFreq_TextChanged(object sender, EventArgs e)
		{
			UpdateData(sender, e);
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count-1);
			panelDataList.RemoveAt(panelDataList.Count-1);
			numDataList.RemoveAt(panelDataList.Count-1);
			textDataList.RemoveAt(panelDataList.Count-1);
			textDataUnitList.RemoveAt(panelDataList.Count-1);
			textDataOffsetList.RemoveAt(panelDataList.Count - 1);
		}
	}
}
