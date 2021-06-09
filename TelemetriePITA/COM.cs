using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace TelemetriePITA
{
    class COM
    {

        public SerialPort _serialPort;
        public bool _continue = true;
        public String buffer;
        public Thread readThread;
        Debug f;
        int i;

        public COM(string portName, Debug f,int i)
        {

            this.i = i;
            this.f = f;
            string name;
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            readThread = new Thread(Read);

            _serialPort = new SerialPort();

            _serialPort.PortName = portName;
            _serialPort.BaudRate = 115200;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();
            readThread.Start();
        }


        public void Read()
        {
            while (_continue)
            {
                try
                {
                    buffer = _serialPort.ReadLine();

                    
                    f.addText(buffer, i);
                    if(buffer.Contains("set time"))
                    {
                        long time = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Write(time.ToString());
                    }
                    if (buffer.Contains("set mode"))
                    {
                        Write("1");
                    }
                    if (buffer.Contains("set freq"))
                    {
                        Write("868000000");
                    }
                    if (buffer.Contains("set band"))
                    {
                        Write("1");
                    }
                    if (buffer.Contains("set rate"))
                    {
                        Write("9");
                    }
                    if (buffer.Contains("set cr"))
                    {
                        Write("1");
                    }
                    if (buffer.Contains("set ptx"))
                    {
                        Write("13");
                    }
                    if (buffer.Contains("set pattern"))
                    {
                        Write("99;");
                    }
                }
                catch (TimeoutException) { }
            }

            
        }
        int[] sizeData = { 8, 12, 12 , 16};
        public string bytesToValue(string bytes)
		{
            string values = "";
            foreach(char c in bytes)
			{
                int value = (int) c;
                values += " | " + value;
			}
            return values;
		}
        int[] mask = { 255, 127, 63, 31, 15, 7, 3, 1 };

        public int[] bytesToValues(string bytes,int[] sizes)
        {
            int[] datas = new int[32];
            int cursor = 0;
            int v = 0;
            int b = 0;
            int i = 0;
            int localCursor = 0;
            foreach (int size in sizes)
            {
                int s = size;
                while (s > 0) 
                {
                    localCursor = cursor - ((int)(cursor / 8)) * 8;
                    b = ((int)bytes[(int)(cursor / 8)]);
                    b &= mask[localCursor];
                    if (s - 8 + localCursor >= 0)
                    {
                        v |= b << (s - 8+localCursor);
					}
					else
					{
                        v |= b >> -(s - 8+localCursor);
                    }
                    cursor += Math.Min(s, 8-localCursor);
                    s -= Math.Min(s, 8-localCursor);
                }
                datas[i] = v;
                v = 0;
                i++;
			}

            return datas;
        }


        public void Write(String s)
        {

            //byte[] data = { '1', '6', '1', '7', '7', '2', '9', '5', '1', '6' };

            _serialPort.Write(s+"\n");

        }

        


    }
}
