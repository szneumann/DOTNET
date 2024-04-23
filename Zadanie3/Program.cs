using System;
using System.IO;
using System.Text;
class Program
{
    static void Main()
    {
        string path = @"C:\ścieżka\do\pliku.txt";
        try
        {
            // Otwarcie strumienia do zapisu do pliku (jeśli nie istnieje, zostanie utworzony)
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                // Tworzenie ciągu znaków do zapisania
                string data = "To jest przykładowy tekst do zapisania w pliku.";
                // Konwersja ciągu znaków na tablicę bajtów w formacie UTF-8
                byte[] byteData = Encoding.UTF8.GetBytes(data);
                // Zapis danych do pliku
                fs.Write(byteData, 0, byteData.Length);
                Console.WriteLine("Dane zostały zapisane do pliku.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Wystąpił błąd wejścia/wyjścia: {ex.Message}");
        }
    }
}