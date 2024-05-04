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
        private PerformanceCounter maxRAM;
        private PerformanceCounter threadCounter;
        private PerformanceCounter threadCounter_total;
        public Form1()
        {
            InitializeComponent();
            InitialiseCPUCounter();
            InitialiseRAMCounter();
        }
        // Inicjalizacja liczników
        private void InitialiseCPUCounter()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            // Dla bieżącego procesu:
            threadCounter = new PerformanceCounter("Process", "Thread Count", Process.GetCurrentProcess().ProcessName);
            // Dla całego systemu
            threadCounter_total = new PerformanceCounter("Process", "Thread Count", "_Total");
        }
        private void InitialiseRAMCounter()
        {
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            maxRAM = new PerformanceCounter("Hyper-v Dynamic Memory VM", "Physical Memory");
        }

        // Załadowanie strony głównej
        private void Form1_Load(object sender, EventArgs e)
        {
            maxiram.Text = maxRAM.ToString();
            // Wywołaj metodę aktualizacji liczników co sekundę
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 milisekund = 1 sekunda
            timer.Tick += new EventHandler((s, ev) => UpdateCounters());
            timer.Start();
        }
        // updater wartości cpu i RAM    
       private void UpdateCounters()
        {
            // Pobierz wartości z liczników
            float cpuUsage = cpuCounter.NextValue();
            float availableRAM = ramCounter.NextValue();
            float threadCount = threadCounter.NextValue();
            float threadCounttotal = threadCounter_total.NextValue();

            // Wyświetl wartości w kontrolkach
            lblCPU.Text = $"Użycie procesora: {cpuUsage}%";
            textBox2.Text = $"Dostępna pamięć RAM: {availableRAM} MB";
            thread_lbl.Text = $"Wartość licznika liczby wątków: {threadCount}";
            threadtotalbox.Text = $"Wartość dla całego systemu: {threadCounttotal}";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
