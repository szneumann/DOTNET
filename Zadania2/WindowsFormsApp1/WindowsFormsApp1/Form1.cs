using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Sprawdzenie poprawności wprowadzonych danych
                if (!double.TryParse(textBox_dzielna.Text, out double dzielna) ||
                    !double.TryParse(textBox_dzielnik.Text, out double dzielnik))
                {
                    MessageBox.Show("Wprowadź poprawne liczby.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Sprawdzenie, czy nie występuje próba dzielenia przez zero
                if (dzielnik == 0)
                {
                    MessageBox.Show("Nie można dzielić przez zero.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Wykonanie dzielenia
                double result = dzielna / dzielnik;

                // Wyświetlenie wyniku
                textBox_wynik.Text = result.ToString();
            }
            catch (Exception ex)
            {
                // Zapisanie błędu do dziennika zdarzeń systemu Windows
                EventLog eventLog = new EventLog("Application");
                eventLog.Source = "Application";
                eventLog.WriteEntry($"Wystąpił błąd: {ex.Message}", EventLogEntryType.Error);

                // Wyświetlenie komunikatu dla użytkownika
                MessageBox.Show("Wystąpił błąd. Szczegóły zostały zapisane do dziennika zdarzeń systemu Windows.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
