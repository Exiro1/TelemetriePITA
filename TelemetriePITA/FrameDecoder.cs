using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;

namespace TelemetriePITA
{
	public class FrameDecoder
	{

		Config conf;
		SerialPort serialPort;
		public int rssi;

		//gps
		public float lon;
		public float lat;
		public int alt;

		double[] offsetA;
		double[] offsetB;
		Boolean[] signed;
		int[] sizes;

		public double[] values;

		public string[] currentParam;
		public bool status1 = false, status2 = false;

		public byte[] frameType; 

		public string toAppend;

		Stopwatch sw;
		Stopwatch statWatch;

		public FrameDecoder(Config config, SerialPort serial, Boolean[] signed, int[] sizes, double[] offsetA, double[] offsetB, byte[] type)
		{
			sw = Stopwatch.StartNew();
			statWatch = Stopwatch.StartNew();
			this.offsetA = offsetA;
			this.offsetB = offsetB;
			this.signed = signed;
			this.sizes = sizes;
			serialPort = serial;
			conf = config;
			currentParam = new string[4];
			frameType = type;
		}
		

		int[] mask = { 255, 127, 63, 31, 15, 7, 3, 1 };
		//convert string data into int array ; peut etre faire plus de test
		public double[] bytesToValues(int[] bytes, int[] sizes, double[] offsetA, double[] offsetB,Boolean[] signed)
		{
			int total = 0;
			foreach (int t in sizes)
			{
				total += t;
			}
			if (bytes.Length < Math.Ceiling((double)total / 8))
				return null;
			double[] datas = new double[sizes.Length];
			int cursor = 0;
			int v = 0;
			int b = 0;
			int i = 0;
			int localCursor = 0;
			foreach (int size in sizes)
			{
				v = 0;
				int s = size;
				while (s > 0)
				{
					localCursor = cursor - ((int)(cursor / 8)) * 8;
					b = ((int)bytes[(int)(cursor / 8)]);
					b &= mask[localCursor];
					if (s - 8 + localCursor >= 0)
					{
						v |= b << (s - 8 + localCursor);
					}
					else
					{
						v |= b >> -(s - 8 + localCursor);
					}
					cursor += Math.Min(s, 8 - localCursor);
					s -= Math.Min(s, 8 - localCursor);
				}

				//transform n bits signed value in 32 bits signed integer
				if (signed[i] && v >> 15 == 1)
				{
					if (size < 32)
					{
						int toAdd = -1;
						toAdd = toAdd - (int)Math.Pow((int)2, (int)size) + 1;
						v = toAdd | v;
					}
				}
				datas[i] = offsetA[i] * v + offsetB[i];
				//datas[i] = v;
				v = 0;
				i++;
			}

			return datas;
		}

		public int[] stringToData(string data)
		{
			int[] bytes = new int[255];
			int index = 0;
			foreach (string d in data.Split(':'))
			{
				int.TryParse(d, System.Globalization.NumberStyles.HexNumber, null, out bytes[index]);
				index++;
			}
			return bytes;
		}

		

		public void gpsData(double[] data)
		{

			lon = ((int)data[0]) + ((int)data[1]) * 0.01f + ((int)data[2]) * 0.0001f + ((int)data[3]) * 0.000001f;
			lat = ((int)data[4]) + ((int)data[5]) * 0.01f + ((int)data[6]) * 0.0001f + ((int)data[7]) * 0.000001f;
			alt = ((int)data[8]) << 8 | ((int)data[9]);
		}

		public void decode(string dataBuffer)
		{
			if (dataBuffer.Contains("waiting"))
			{
				serialPort.Write("ready\n");
			}
				if (dataBuffer.Contains("CONF"))
			{
				string[] newConf = dataBuffer.Split(';');
				currentParam[0] = newConf[1] + "Hz";
				currentParam[1] = conf.comboBand.Items[int.Parse(newConf[5])].ToString() + " kHz";
				currentParam[2] = conf.comboSF.Items[int.Parse(newConf[2]) - 7].ToString();
				currentParam[3] = conf.comboModul.Items[int.Parse(newConf[6])].ToString();
			}
			if (dataBuffer.Contains("set time"))
			{
				long time = DateTimeOffset.Now.ToUnixTimeSeconds();
				serialPort.Write(time.ToString() + "\n");
			}
			if (dataBuffer.Contains("set mode"))
			{
				serialPort.Write(conf.getMod().ToString() + "\n");
			}
			if (dataBuffer.Contains("set freq"))
			{
				int freq = (int)conf.getFreq();
				serialPort.Write((freq*1000000).ToString() + "\n");
			}
			if (dataBuffer.Contains("set band"))
			{
				serialPort.Write(conf.getBand().ToString() + "\n");
			}
			if (dataBuffer.Contains("set rate"))
			{
				serialPort.Write(conf.getRate().ToString() + "\n");
			}
			if (dataBuffer.Contains("set cr"))
			{
				serialPort.Write(conf.getCR().ToString() + "\n");
			}
			if (dataBuffer.Contains("set ptx"))
			{
				serialPort.Write(conf.getPTX().ToString() + "\n");
			}
			if (dataBuffer.Contains("set pattern"))
			{
				StringBuilder ftb = new StringBuilder();
				foreach (byte b in frameType)
				{
					char c = (char) (b + 48);
					ftb.Append(b);
				}
				ftb.Append("@\n");
				serialPort.Write(ftb.ToString());
			}

			if (dataBuffer.Contains("ERROR") || dataBuffer.Contains("TIMEOUT"))
			{
				status2 = false;

			}
			int len = 0;
			if (dataBuffer.Contains("SUCCESS"))
			{
				status2 = true;

				if (dataBuffer.Split(';').Length > 1)
				{
					int.TryParse(dataBuffer.Split(';')[1], out rssi);
				}
				if (dataBuffer.Split(';').Length > 2)
				{

					string data = dataBuffer.Substring(dataBuffer.IndexOf(';', dataBuffer.IndexOf(';') + 1) + 1).Replace("\n", "").Replace("\r", "");
					data = data.Remove(data.LastIndexOf(':'));
					int[] byteData = stringToData(data);
					processFrame(byteData);
					totalDataReceived++;
					tempDataReceived++;
					if (tempDataReceived >= 10)
					{
						long timeInterval = statWatch.ElapsedMilliseconds;
						timeBetweenTwoFrame = timeInterval / 10.0;
						FramePerSec = (10.0/(timeInterval/1000.0));
						statWatch = Stopwatch.StartNew();
						tempDataReceived = 0;
					}
				}
			}


			toAppend = "\n"+dataBuffer.Replace("\n", "").Replace("\r", "") + Environment.NewLine;

		}


		/*FRAME TYPE
		 * 0000 0	0: RIEN
		 * 0001 1	1: GPS
		 * 0010 2	2: TEMPS DEPUIS LANCEMENT (ms)
		 * 0011 3	3: TEMPS DEPUIS LANCEMENT (ms) + GPS
		 * 0100 4	4: UNIX TIME
		 * 0101 5	5: UNIX TIME + GPS
		 * 0110 6	6: UNIX TIME + TEMPS DEPUIS LANCEMENT (ms)
		 * 0111 7	7: UNIX TIME + TEMPS DEPUIS LANCEMENT (ms) + GPS
		 * 1000 8	8: DATA
		 * 1001 9	9: DATA + GPS
		 * 1010 10	A: DATA + TEMPS DEPUIS LANCEMENT (ms)
		 * 1011 11	B: DATA + TEMPS DEPUIS LANCEMENT (ms) + GPS
		 * 1100 12	C: DATA + UNIX TIME
		 * 1101 13	D: DATA + UNIX TIME + GPS
		 * 1110 14	E: DATA + UNIX TIME + TEMPS DEPUIS LANCEMENT (ms)
		 * 1111 15  F: DATA + UNIX TIME + TEMPS DEPUIS LANCEMENT (ms) + GPS
		 */
		const byte GPS = 0b0001;
		const byte TIME_SINCE_START = 0b0010;
		const byte UNIX_TIME = 0b0100;
		const byte DATA = 0b1000;

		public byte getType(int[] byteData)
		{
			return (byte)(byteData[0]>>4);
		}
		

		int tempDataReceived = 0;
		double framePerSec = 0;
		double timeBetweenTwoFrame = 0;

		int totalDataReceived = 0;
		int totalIncompleteData = 0;

		int[] lsize;
		double[] loffsetA;
		double[] loffsetB;
		bool[] lsigned;

		public void getTrueSize(byte type)
		{
			lsize = new int[0];
			loffsetA = new double[0];
			loffsetB = new double[0];
			lsigned = new bool[0];
			
			//frame type
			lsize = lsize.Append(4).ToArray();
			loffsetA = loffsetA.Append(1).ToArray();
			loffsetB = loffsetB.Append(0).ToArray();
			lsigned = lsigned.Append(false).ToArray();

			//gps
			if ((type & GPS)==1)
			{
				int[] gpsSize = { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };
				double[] gpsoffa = { 1,1,1,1,1,1,1,1,1,1 };
				double[] gpsoffb = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
				bool[] gpssigned = { true, false, false, false, true, false, false, false, false, false };

				lsize = lsize.Concat(gpsSize).ToArray();
				loffsetA = loffsetA.Concat(gpsoffa).ToArray();
				loffsetB = loffsetB.Concat(gpsoffb).ToArray();
				lsigned = lsigned.Concat(gpssigned).ToArray();
			}
			//time since start (high res)
			if ((type & TIME_SINCE_START)>>1 == 1)
			{
				int sizeT = 16;//(int)Math.Ceiling((Math.Log10(60 * conf.getFactor()) / Math.Log10(2)));
				lsize = lsize.Append(sizeT).ToArray();
				loffsetA = loffsetA.Append(1).ToArray();
				loffsetB = loffsetB.Append(0).ToArray();
				lsigned = lsigned.Append(false).ToArray();
			}
			//full time
			if ((type & UNIX_TIME)>>2 == 1)
			{
				lsize = lsize.Append(22).ToArray();
				loffsetA = loffsetA.Append(1).ToArray();
				loffsetB = loffsetB.Append(0).ToArray();
				lsigned = lsigned.Append(false).ToArray();
			}
			//data
			if ((type & DATA)>>3 == 1)
			{
				lsize = lsize.Concat(sizes).ToArray();
				loffsetA = loffsetA.Concat(offsetA).ToArray();
				loffsetB = loffsetB.Concat(offsetB).ToArray();
				lsigned = lsigned.Concat(signed).ToArray();
			}
		}
		public uint fullTime=0;
		public long timeSinceStart=0;
		long lastValue = 0;


		long timePC = 0;

		public double FramePerSec { get => framePerSec; set => framePerSec = value; }


		

		public void processFrame(int[] byteData)
		{
			byte ftype = getType(byteData);
			getTrueSize(ftype);
			double[] lvalues = bytesToValues(byteData, lsize,loffsetA,loffsetB,lsigned);
			int index = 1;
			//gps
			if ((ftype & GPS) == 1)
			{
				gpsData(lvalues.Skip(index).ToArray());
				index += 10;
			}
			//time since start (high res)
			if ((ftype & TIME_SINCE_START)>>1 == 1)
			{
				
				if (lastValue > (long)lvalues[index]) //-> timer restarted
				{
					timeSinceStart += (long)lvalues[index];
				}
				else
				{
					timeSinceStart += (long)lvalues[index]-lastValue;
				}
				lastValue = (long)lvalues[index];

				timePC = sw.ElapsedMilliseconds-timeSinceStart;
				index++;
			}
			else
			{
				timeSinceStart = sw.ElapsedMilliseconds - timePC;
			}
			//full time
			if ((ftype & UNIX_TIME)>>2 == 1)
			{
				DateTime foo = DateTime.Now;
				long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();
				fullTime = (uint)lvalues[index] + ((uint)(unixTime / 10000000.0)) * 10000000;
				index++;
			}
			//data
			if ((ftype & DATA)>>3 == 1)
			{
				values = lvalues.Skip(index).ToArray();
				if(values.Length != Math.Ceiling((decimal)(sizes.Sum()/8)))
				{
					totalIncompleteData++;
				}
			}
		}
	}
}
