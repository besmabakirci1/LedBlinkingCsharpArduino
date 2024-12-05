using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GptLed
{
    public partial class Form1 : Form
    {
        SerialPort arduinoPort;
        public Form1()
        {
            InitializeComponent();
            arduinoPort = new SerialPort
            {
                PortName = "COM5",
                BaudRate = 9600
            };

            arduinoPort.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (arduinoPort != null && arduinoPort.IsOpen)
            {
                arduinoPort.Write("1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arduinoPort != null && arduinoPort.IsOpen)
            {
                arduinoPort.Write("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arduinoPort != null && arduinoPort.IsOpen)
            {
                arduinoPort.Write("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arduinoPort != null && arduinoPort.IsOpen)
            {
                arduinoPort.Write("4");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapatıldığında portu kapat
            if (arduinoPort != null && arduinoPort.IsOpen)
            {
                arduinoPort.Close();
            }
        }
    }
}
