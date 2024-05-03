using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;

namespace DzielenieApp
{   
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDzielenie_Click(object sender, EventArgs e)
        {
            try
            {
                // Pobierz wartości z pól tekstowych
                double dzielna = Convert.ToDouble(textBoxDzielna.Text);
                double dzielnik = Convert.ToDouble(textBoxDzielnik.Text);

                // Sprawdź, czy dzielnik jest różny od zera
                if (dzielnik == 0)
                {
                    throw new DivideByZeroException("Nie można dzielić przez zero.");
                }

                // Wykonaj dzielenie
                double wynik = dzielna / dzielnik;

                // Wyświetl wynik
                textBoxWynik.Text = wynik.ToString();
            }
            catch (FormatException)
            {
                // Obsługa błędu dla nieprawidłowego formatu danych
                MessageBox.Show("Wprowadzono nieprawidłowe dane. Proszę wprowadzić liczby.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                // Obsługa błędu dla zbyt dużych lub zbyt małych liczb
                MessageBox.Show("Wprowadzono zbyt dużą lub zbyt małą liczbę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                // Obsługa błędu dzielenia przez zero
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Obsługa innych nieprzewidzianych błędów
                MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

