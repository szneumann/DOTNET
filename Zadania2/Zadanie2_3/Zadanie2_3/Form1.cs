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
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Zadanie2_3
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private PerformanceCounter threadCounter;
        private PerformanceCounter thread_totalCounter;
        public Form1()
        {
            InitializeComponent();
            InitialiseCPUCounter();
            InitialiseRAMCounter();
        }
        // Inicjalizacja liczników
        private void InitialiseCPUCounter()
        {
            //Monitorowanie użycia procesora
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            // Monitorowanie liczby wątków dla bieżącego procesu:
            threadCounter = new PerformanceCounter("Process", "Thread Count", Process.GetCurrentProcess().ProcessName);
            // Monitorowanie liczby wątków dla całego systemu
            thread_totalCounter = new PerformanceCounter("Process", "Thread Count", "_Total");
        }
        private void InitialiseRAMCounter()
        {
            // Monitorowanie użycia pamięci RAM.
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        // Załadowanie strony głównej
        public void Form1_Load(object sender, EventArgs e)
        {
            // Wywołaj metodę aktualizacji liczników co sekundę
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 milisekund = 1 sekunda
            timer.Tick += new EventHandler((s, ev) => UpdateCounters());
            timer.Start();
        }

        // updater wartości CPU i RAM    
       private void UpdateCounters()
        {
            // Pobierz wartości z liczników
            float cpuUsage = cpuCounter.NextValue();
            float availableRAM = ramCounter.NextValue();
            float threadCount = threadCounter.NextValue();
            float threadtotalCount = thread_totalCounter.NextValue();
            
            // Sprawdzenie czy wartość cpuUsage nie przekracza wcześniej ustalonej wartości
            // Na mojej platformie naprawdę samo odpalenie kodu i wejście w menu start Windowsa
            // podwyższa tę wartość do 40%
            if (cpuUsage > 35) 
            {
                // Jeśli wcześniej ustalona wartość zostaje przekroczona, dokonywany jest wpis w rejestrze.
                DialogResult dr = MessageBox.Show($"Przekroczony limit {cpuUsage} > 35", "cpu over 35", MessageBoxButtons.OK , MessageBoxIcon.Information);
                            
                registerCPUusage(cpuUsage);
                
            }
            

            // Wyświetl wartości w kontrolkach
            lblCPU.Text = $"Użycie procesora: {cpuUsage}%";
            textBox2.Text = $"Dostępna pamięć RAM: {availableRAM} MB";
            thread_lbl.Text = $"Wartość licznika liczby wątków: {threadCount}";
            threadtotalbox.Text = $"Wartość dla całego systemu: {threadtotalCount}";
        }

        private void registerCPUusage(float value)
        {
            // Symulacja niestandardowego zdarzenia
            string CPUusageMessage = $"Przekroczony limit {value} > 35%";
            // Zapisujemy niestandardowe zdarzenie do dziennika zdarzeń
            EventLog.WriteEntry("Application", CPUusageMessage, EventLogEntryType.Information, 1234);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
