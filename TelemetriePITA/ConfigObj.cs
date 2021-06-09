using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelemetriePITA
{
	public class ConfigObj
	{

		public int Modulation,SF,CR,Module,GPS,time,precision,maxTime, sep, bandwitdh, PTX;
		public double freq, GTX, GRX, margin;
		public byte[] framePattern;
		public ConfigData[] datas;

	}

	public class ConfigData
	{
		public ConfigData()
		{
		}
		public ConfigData(string name,string unit, int size,string offset,Boolean signed)
		{
			this.name = name;
			this.size = size;
			this.unit = unit;
			this.offset = offset;
			this.signed = signed;
			
		}
		public string name,unit,offset;
		public int size;
		public Boolean signed;
		public Type type;
	}

}
