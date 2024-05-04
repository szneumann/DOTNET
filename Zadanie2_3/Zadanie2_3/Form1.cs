using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Zadanie2_3
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        public Form1()
        {
            InitializeComponent();
            InitialiseCPUCounter();
        }
        // Inicjalizacja liczników
        private void InitialiseCPUCounter()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            Console.WriteLine("Inicjalizacja cpuCounter");
            Console.WriteLine(cpuCounter.NextValue());
        }

                  

        private void Form1_Load(object sender, EventArgs e)
        {
            float tmp = cpuCounter.NextValue();
            lblCPU.Text = String.Format("{0} %", tmp);
            Console.WriteLine("Form1_Load");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
