using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Zadanie3_1
{
    public partial class Form1 : Form
    {
        private SymmetricAlgorithm algorithm;
        private Stopwatch encryptionStopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();

            // Dodaj algorytmy szyfrowania do ComboBox
            algorithmComboBox.Items.AddRange(new string[] { "AES", "DES", "3DES" });

        }

        private void GenerateKeysButton_Click(object sender, EventArgs e)
        {
            if (algorithmComboBox.SelectedItem is null)
            {
                MessageBox.Show("Wybierz algorytm szyfrowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Wybierz algorytm szyfrowania na podstawie ComboBox
                switch (algorithmComboBox.SelectedItem.ToString())
                { 
                    case "AES":
                        algorithm = Aes.Create();
                        break;
                    case "DES":
                        algorithm = DES.Create();
                        break;
                    case "3DES":
                        algorithm = TripleDES.Create();
                        break;
                }
            }

            // Generuj klucze i IV
            algorithm.GenerateKey();
            algorithm.GenerateIV();

            // Wyświetl klucze i IV
            keyTextBox.Text = Convert.ToBase64String(algorithm.Key);
            ivTextBox.Text = Convert.ToBase64String(algorithm.IV);
        }

        private void ivLabel_Click(object sender, EventArgs e)
        {

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // Sprawdz czy zostal wybrany algorytm i wygenerowane klucze
            if (algorithm == null)
            {
                MessageBox.Show("Wybierz algorytm szyfrowania i wygeneruj klucze.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz tekst do zaszyfrowania
            byte[] plaintextBytes = Encoding.ASCII.GetBytes(plainASCIItextBox.Text);
            plainHEXtextBox.Text = ConvertAsciiToHex(plainASCIItextBox.Text);

            // Stwórz stoper
            Stopwatch encryptionStopwatch = new Stopwatch();
            // Aby czas się nie nawarstwiał z poprzedniego procesu szyfrowania, zresetuj stoper
            encryptionStopwatch.Reset();

            // Rozpocznij pomiar czasu szyfrowania
            encryptionStopwatch.Start();

            // Szyfruj tekst
            using (ICryptoTransform encryptor = algorithm.CreateEncryptor())
            {
                byte[] encryptedBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                cipherASCIItextBox.Text = Convert.ToBase64String(encryptedBytes);
                cipherHEXtextBox.Text = BitConverter.ToString(encryptedBytes).Replace("-", "");
            }

            // Zatrzymaj pomiar czasu szyfrowania i wyświetl czas na interfejsie
            encryptionStopwatch.Stop();
            timeEncryptionTextBox.Text = $"Czas szyfrowania: {encryptionStopwatch.ElapsedMilliseconds} ms";


        }


        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (algorithm == null)
            {
                MessageBox.Show("Wybierz algorytm szyfrowania i wygeneruj klucze.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz zaszyfrowany tekst
            byte[] encryptedBytes = Convert.FromBase64String(cipherASCIItextBox.Text);

            Stopwatch decryptionStopwatch = new Stopwatch();

            // Aby czas się nie nawarstwiał z poprzedniego procesu szyfrowania, zresetuj stoper
            decryptionStopwatch.Reset();

            // Rozpocznij pomiar czasu deszyfrowania
            decryptionStopwatch.Start();

            // Deszyfruj tekst
            using (ICryptoTransform decryptor = algorithm.CreateDecryptor())
            {
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                plainASCIItextBox.Text = Encoding.ASCII.GetString(decryptedBytes);
                plainHEXtextBox.Text = BitConverter.ToString(decryptedBytes).Replace("-", "");
            }

            // Zatrzymaj pomiar czasu deszyfrowania i wyświetl czas na interfejsie
            decryptionStopwatch.Stop();
            timeDecryptionTextBox.Text = $"Czas deszyfrowania: {decryptionStopwatch.ElapsedMilliseconds} ms";

        }

        public string ConvertAsciiToHex(string asciiText)
        {
            StringBuilder hexBuilder = new StringBuilder();

            foreach (char c in asciiText)
            {
                // Konwertuj każdy znak ASCII na jego wartość szesnastkową
                string hexValue = ((int)c).ToString("X2");
                hexBuilder.Append(hexValue);
            }

            return hexBuilder.ToString();
        }
    }
}
