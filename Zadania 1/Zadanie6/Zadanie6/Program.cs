using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        try
        {
            // Ścieżka do pliku źródłowego
            string sourceFilePath = @"C:\Users\dev\Desktop\tekst.txt";

            // Ścieżka do pliku docelowego
            string destinationFilePath = @"C:\Users\dev\Desktop\nowytekst.txt";

            // Kopiowanie pliku
            File.Copy(sourceFilePath, destinationFilePath, true);

            Console.WriteLine("Plik został skopiowany pomyślnie.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd podczas kopiowania pliku: " + ex.Message);
        }
        Console.ReadKey();
    }
}
