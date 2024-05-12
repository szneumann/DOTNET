using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Ścieżka do pliku tekstowego
        string filePath = @"C:\Users\dev\Desktop\tekst.txt";

        try
        {
            // Otwieranie pliku za pomocą FileStream
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // Tworzenie czytnika StreamReader
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    // Odczytywanie i wyświetlanie zawartości pliku
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("Plik nie istnieje.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"Wystąpił błąd wejścia-wyjścia: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {e.Message}");
        }
        Console.ReadKey();
    }
}




