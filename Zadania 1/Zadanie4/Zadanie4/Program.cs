using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\dev\Desktop\tekst.txt"; // Wstaw ścieżkę do odpowiedniego pliku tekstowego

        try
        {
            // Otwieranie pliku za pomocą StreamReader
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Odczytywanie linii po linii i wyświetlanie odwróconych linii
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string reversedLine = ReverseString(line);
                    Console.WriteLine(reversedLine);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }

    // Metoda do odwracania ciągu znaków
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
