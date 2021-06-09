using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace TelemetriePITA
{
	class XMLParser
	{

		public XMLParser()
		{

		}

		public void serializeConfig(ConfigObj obj,string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(ConfigObj));
			TextWriter writer = new StreamWriter(filename);
			serializer.Serialize(writer, obj);
			writer.Close();
		}

		public ConfigObj deserializeConfig(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(ConfigObj));
			serializer.UnknownNode += new
		XmlNodeEventHandler(serializer_UnknownNode);
			serializer.UnknownAttribute += new
			XmlAttributeEventHandler(serializer_UnknownAttribute);
			FileStream fs = new FileStream(filename, FileMode.Open);
			ConfigObj obj;
			obj = (ConfigObj)serializer.Deserialize(fs);
			fs.Close();
			return obj;
		}


		protected void serializer_UnknownNode
   (object sender, XmlNodeEventArgs e)
		{
			Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
		}

		protected void serializer_UnknownAttribute
		(object sender, XmlAttributeEventArgs e)
		{
			System.Xml.XmlAttribute attr = e.Attr;
			Console.WriteLine("Unknown attribute " +
			attr.Name + "='" + attr.Value + "'");
		}



	}
}
