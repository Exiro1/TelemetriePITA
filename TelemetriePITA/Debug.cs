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
    public partial class Debug : Form
    {
        public Debug()
        {
            InitializeComponent();
        }

        COM com1;
        COM com2;


        private void Form1_Load(object sender, EventArgs e)
        {
            initPort1Name("COM1");
            initPort2Name("COM1");
        }
        string PORT1;
        string PORT2;
        private void initPort1Name(string defaultPortName)
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
        }
        private void initPort2Name(string defaultPortName)
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox2.Items.Add(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PORT1 = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com1 = new COM(PORT1, this,1);
        }

        public void addText(string text, int i)
        {
            if (i == 1)
            {
                this.BeginInvoke(new SetTextDeleg(dataReceived1), new object[] { text });
            }
            else
            {
                this.BeginInvoke(new SetTextDeleg(dataReceived2), new object[] { text });
            }
        }

        public delegate void SetTextDeleg(string text);
        
        public void dataReceived1(string data)
        {
            listBox1.Items.Add(data);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        public void dataReceived2(string data)
        {
            listBox2.Items.Add(data);
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            com1._continue = false;
            com1.readThread.Join();
            com1._serialPort.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            com1 = new COM(PORT2, this,2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PORT2 = comboBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            com2._continue = false;
            com2.readThread.Join();
            com2._serialPort.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            long time = DateTimeOffset.Now.ToUnixTimeSeconds();
            com1.Write(time.ToString());
        }
    }
}
