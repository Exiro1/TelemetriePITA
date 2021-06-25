using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelemetriePITA
{
	public partial class Telemetry : Form
	{
		public Telemetry()
		{
			InitializeComponent();
			init("lastConf.xml");
		}

		public FrameDecoder fdecoder;
		Config conf;
		StringBuilder csv;
		bool stop = false;
		int dataNbr;
		
		public void init(string confFile)
		{
			stop = true;
			if(readThread!=null)
				if(readThread.IsAlive)
					readThread.Join();
			plots = new List<ScottPlot.PlottableSignalXY>();
			fplots = new List<ScottPlot.FormsPlot>();


			csv = new StringBuilder();

			foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
			{
				comboBox1.Items.Add(s);
			}

			
			conf = new Config(confFile);
			sizes = new int[conf.getDataNbr()];
			signed = new Boolean[conf.getDataNbr()];
			offsetA = new double[conf.getDataNbr()];
			offsetB = new double[conf.getDataNbr()];
			dataNbr = conf.getDataNbr();
			initPlot(dataNbr+2); //+2 pour gps + alt
			fdecoder = new FrameDecoder(conf, serialPort, signed, sizes, offsetA, offsetB, conf.getPattern());
			
		}

		

		GMap.NET.WindowsForms.GMapControl mapcontrol;
		double sampleRateHz = 3;

		double[] timeData = new double[1];

		public void initPlot(int plotNbr)
		{

			tableLayoutPanel1.Controls.Clear();
			tableLayoutPanel1.ColumnCount = (int) Math.Ceiling(Math.Sqrt((4/3)*plotNbr));
			tableLayoutPanel1.RowCount = (int) Math.Ceiling((double)plotNbr/(double)tableLayoutPanel1.ColumnCount);

			this.tableLayoutPanel1.ColumnStyles.Clear();
			this.tableLayoutPanel1.RowStyles.Clear();
			for (int i = 0; i < this.tableLayoutPanel1.ColumnCount; i++)
			{
				ColumnStyle c = new ColumnStyle();
				c.SizeType = SizeType.Percent;
				c.Width = Convert.ToSingle(Math.Ceiling((decimal)100 / (decimal)this.tableLayoutPanel1.ColumnCount));
				this.tableLayoutPanel1.ColumnStyles.Add(c);
			}
			for (int i = 0; i < this.tableLayoutPanel1.RowCount; i++)
			{
				RowStyle c = new RowStyle();
				c.SizeType = SizeType.Percent;
				c.Height = Convert.ToSingle(Math.Ceiling((decimal)100 / (decimal)this.tableLayoutPanel1.RowCount));
				this.tableLayoutPanel1.RowStyles.Add(c);
			}

			mapcontrol = new GMap.NET.WindowsForms.GMapControl();
			mapcontrol.Dock = DockStyle.Fill;
			tableLayoutPanel1.Controls.Add(mapcontrol, 0, 0);
			mapcontrol.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
			GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
			mapcontrol.MinZoom = 2;
			mapcontrol.MaxZoom = 18;
			mapcontrol.Zoom = 13;
			mapcontrol.CanDragMap = false;

			double[] altData = new double[1];
			altitudeFPlot = new ScottPlot.FormsPlot();
			altitudeFPlot.Dock = DockStyle.Fill;
			altitudePlot = altitudeFPlot.plt.PlotSignalXY(timeData, altData);
			altitudeFPlot.plt.Title("Altitude");
			altitudeFPlot.plt.XLabel("Temps");
			altitudeFPlot.plt.YLabel("m");
			tableLayoutPanel1.Controls.Add(altitudeFPlot, 1, 0);
			altitudeFPlot.Render();

			int col=2, row=0;

			for (int i = 0; i < plotNbr-2; i++)
			{
				double[] signalData = new double[1];
				
				ScottPlot.FormsPlot fplt = new ScottPlot.FormsPlot();
				fplt.Dock = DockStyle.Fill;

				//plots.Add(fplt.plt.PlotSignal(signalData, sampleRateHz));
				plots.Add(fplt.plt.PlotSignalXY(timeData, signalData));
				ConfigData cdata = conf.getConfigData(i);
				offsetA.Append(0.0);
				offsetB.Append(0.0);
				if (cdata.offset.IndexOf('*') > 0)
				{
					Double.TryParse(cdata.offset.Substring(0, cdata.offset.IndexOf('*')), out offsetA[i]);
				}
				if (cdata.offset.IndexOf('+') > 0)
				{
					Double.TryParse(cdata.offset.Substring(cdata.offset.IndexOf('+'), cdata.offset.Length- cdata.offset.IndexOf('+')),out offsetB[i]);
				}

				fplt.plt.Title(cdata.name);
				fplt.plt.XLabel("Temps");
				fplt.plt.YLabel(cdata.unit);
				fplt.plt.AxisAutoY(0.5);
				fplt.plt.AxisPan(1 / sampleRateHz);
				
				tableLayoutPanel1.Controls.Add(fplt, col, row);
				fplots.Add(fplt);
				sizes[i] = cdata.size;
				signed[i] = cdata.signed;
				fplt.Render();

				col++;
				if (col >= tableLayoutPanel1.ColumnCount)
				{
					col = 0;
					row++;
				}
			}


			
			tableLayoutPanel1.Update();

		}

		ScottPlot.PlottableSignalXY altitudePlot;
		ScottPlot.FormsPlot altitudeFPlot;

		double[] offsetA;
		double[] offsetB;

		List<ScottPlot.FormsPlot> fplots;
		List<ScottPlot.PlottableSignalXY> plots;
		bool seeRaw = false;




		public void initSerial()
		{
			
			if (serialPort.IsOpen)
				return;
			dataBuffer = new StringBuilder();
			serialPort.PortName = comboBox1.SelectedItem.ToString();
			serialPort.BaudRate = 115200;
			
			if (!serialPort.IsOpen){
				try
				{
					serialPort.Open();
					receivStatus.Text = "Connecté";
					receivStatus.BackColor = Color.Lime;
					
				}
				catch (Exception e)
				{
					int i = 0;
					i++;
				}
				readThread = new Thread(Read);
				readThread.Start();
				//serialPort.DataReceived += new SerialDataReceivedEventHandler(datareceived); ;
			}
		}

		public void Read()
		{
			while (!stop)
			{
				try
				{
					tempBuffer1 = serialPort.ReadLine();
					try
					{
						this.BeginInvoke(new updateInfoCallBack(updateInfo), tempBuffer1);
					}
					catch (Exception ex)
					{
					}
				}
				catch (TimeoutException) { }
			}
			serialPort.Close();
		}

		public Thread readThread;

		StringBuilder dataBuffer;

		public void datareceived(object sender, SerialDataReceivedEventArgs e)
		{
			SerialPort sp = (SerialPort)sender;
			string indata = sp.ReadExisting();

			if (stop)
				return;
			dataBuffer.Append(indata);
			if (dataBuffer.ToString().Contains("\n\r"))
			{
				tempBuffer1 = dataBuffer.ToString();
				dataBuffer.Clear();
				try
				{
					this.BeginInvoke(new updateInfoCallBack(updateInfo), tempBuffer1);
				}
				catch (Exception ex)
				{
				}
				
			}

		}

		string tempBuffer1;
		delegate void updateInfoCallBack(string data);

		int[] sizes;
		Boolean[] signed;

		//called when full dataframe is received
		public void updateInfo(string tempBuffer)
		{
			fdecoder.decode(tempBuffer);
			statusDataRate.Text = "frame / sec : " + fdecoder.FramePerSec;
			toolFreq.Text = fdecoder.currentParam[0];
			toolBand.Text = fdecoder.currentParam[1];
			toolRate.Text = fdecoder.currentParam[2];
			toolModul.Text = fdecoder.currentParam[3];

			if (!fdecoder.status2)
			{
				transcStatus.Text = "déconnecté";
				transcStatus.BackColor = Color.Red;
			}
			else
			{
				transcStatus.Text = "Connecté";
				transcStatus.BackColor = Color.Lime;
			}
			receptionDbValue.Text = fdecoder.rssi + " db";
			progBarSignalQuality.Value = 100 - Math.Max(Math.Min(100 * fdecoder.rssi / (-130), 100), 0);
				
			textBox1.AppendText(fdecoder.toAppend);

			timeData = timeData.Append(fdecoder.timeSinceStart).ToArray();
			updateGpsData((uint)fdecoder.timeSinceStart);
			updateData(fdecoder.values, (uint)fdecoder.timeSinceStart);
			lastTime = (uint)fdecoder.timeSinceStart;
			tempBuffer = string.Empty;
		}


		
		public void updateGpsData(uint time)
		{
			mapcontrol.Position = new GMap.NET.PointLatLng(fdecoder.lat, fdecoder.lon);


			altitudePlot.ys = altitudePlot.ys.Append(fdecoder.alt).ToArray();
			altitudePlot.xs = altitudePlot.xs.Append(time).ToArray();
			altitudePlot.maxRenderIndex = altitudePlot.ys.Length - 1;
			//fplots[i].plt.AxisAuto();
			//altitudeFPlot.plt.AxisAutoY(0.5);
			//altitudeFPlot.plt.AxisPan(1 / sampleRateHz);
			altitudeFPlot.plt.AxisPan(time-lastTime, -altitudePlot.ys.ElementAt(altitudePlot.ys.Length - 2) + altitudePlot.ys.Last());
			altitudeFPlot.Render();
		}
		uint lastTime = 0;
		public void updateData(double[] values,uint time)
		{
			//int time = values[0];
			if (values == null)
				return;
			int i = 0;

			

			csv.Append(string.Format("{0},", time));
			csv.Append(string.Format("{0},", fdecoder.fullTime.ToString().Replace(',', '.')));
			csv.Append(string.Format("{0},", fdecoder.lat.ToString().Replace(',', '.')));
			csv.Append(string.Format("{0},", fdecoder.lon.ToString().Replace(',', '.')));
			csv.Append(string.Format("{0},", fdecoder.alt.ToString().Replace(',', '.')));
			foreach (double value in values)
			{
				plots[i].ys = plots[i].ys.Append(value).ToArray();
				plots[i].xs = plots[i].xs.Append(time).ToArray();
				plots[i].maxRenderIndex = plots[i].ys.Length-1;
				//fplots[i].plt.AxisAuto();
				//fplots[i].plt.AxisAutoY(0.5);
				//fplots[i].plt.AxisPan(1 / sampleRateHz);
				fplots[i].plt.AxisPan(time - lastTime, -plots[i].ys.ElementAt(plots[i].ys.Length-2) +plots[i].ys.Last());
				fplots[i].Render();
				i++;
				csv.Append(string.Format("{0},", value.ToString().Replace(',','.')));
			}
			csv.Remove(csv.Length - 1, 1);
			csv.AppendLine();
			if(csv.Length > 1000000)
			{
				saveData("data.csv","");
				csv.Clear();
			}

		}

		public void saveData(string pathData,string pathGPS)
		{
			//string path = @"c:\temp\MyTest.txt";
			if (!File.Exists(pathData))
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("Temps (ms),");
				sb.Append("UnixTime (s),");
				sb.Append("lat,");
				sb.Append("lon,");
				sb.Append("altitude (m),");
				for (int i = 0; i < dataNbr; i++)
				{
					ConfigData cdata = conf.getConfigData(i);
					sb.Append(cdata.name.Replace(',', '.') + " (" + cdata.unit.Replace(',', '.') + "),");
				}
				sb.Remove(sb.Length - 1, 1);
				sb.AppendLine();

				File.AppendAllText(pathData, sb.ToString());
			}
			File.AppendAllText(pathData, csv.ToString());
		}


		private void Telemetry_Load(object sender, EventArgs e)
		{

		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}
		

		private void configToolStripMenuItem_Click(object sender, EventArgs e)
		{
			conf.Show();
		}


		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripStatusLabel5_Click(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void entréeBrutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			seeRaw = !seeRaw;
			splitContainer1.Panel2Collapsed = !seeRaw;
			splitContainer1.SplitterDistance = splitContainer1.Width * 3 / 4;
			
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			OpenFileDialog fileDialog = (OpenFileDialog) sender;
			//
			saveData(fileDialog.FileName,"");

		}

		private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fdSaveData.ShowDialog();
		}

		private void toolStripStatusLabel12_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			initSerial();
			stop = false;
		}

		private void comboBox1_Click(object sender, EventArgs e)
		{
			comboBox1.Items.Clear();
			foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
			{
				comboBox1.Items.Add(s);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			stop = true;
			
		}

		private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fdOpenConfig.ShowDialog();
		}

		private void fdConfigSave_FileOk(object sender, CancelEventArgs e)
		{
			OpenFileDialog fileDialog = (OpenFileDialog)sender;
			conf.saveData(fileDialog.FileName);
		}

		private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fdConfigSave.ShowDialog();
		}

		private void fdOpenConfig_FileOk(object sender, CancelEventArgs e)
		{
			OpenFileDialog fileDialog = (OpenFileDialog)sender;
			init(fileDialog.FileName);
		}
	}
}
