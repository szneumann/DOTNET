using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wybierz opcję:");
        Console.WriteLine("1. Zapisz dane do pliku binarnego");
        Console.WriteLine("2. Odczytaj dane z pliku binarnego");
        Console.Write("Twój wybór: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ZapiszDaneDoPliku();
                break;
            case "2":
                OdczytajDaneZPliku();
                break;
            default:
                Console.WriteLine("Niepoprawny wybór.");
                break;
        }
    }

    static void ZapiszDaneDoPliku()
    {
        Console.WriteLine("Podaj imię:");
        string name = Console.ReadLine();
        Console.WriteLine("Podaj wiek:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj adres:");
        string address = Console.ReadLine();

        // Tworzenie obiektu zawierającego dane
        DaneOsobowe dane = new DaneOsobowe(name, age, address);

        string filePath = @"dane.bin";

        try
        {
            // Zapisywanie danych do pliku binarnego za pomocą FileStream
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    // Zapisywanie danych
                    writer.Write(dane.Imie);
                    writer.Write(dane.Wiek);
                    writer.Write(dane.Adres);
                }
            }

            Console.WriteLine("Dane zostały zapisane do pliku binarnego.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd podczas zapisu danych: " + ex.Message);
        }
    }

    static void OdczytajDaneZPliku()
    {
        string filePath = @"dane.bin";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Plik z danymi nie istnieje.");
            return;
        }

        try
        {
            // Odczytywanie danych z pliku binarnego za pomocą FileStream
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    // Odczytywanie danych
                    string name = reader.ReadString();
                    int age = reader.ReadInt32();
                    string address = reader.ReadString();

                    // Wyświetlanie odczytanych danych
                    Console.WriteLine("Imię: " + name);
                    Console.WriteLine("Wiek: " + age);
                    Console.WriteLine("Adres: " + address);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd podczas odczytu danych: " + ex.Message);
        }
    }
}

class DaneOsobowe
{
    public string Imie { get; set; }
    public int Wiek { get; set; }
    public string Adres { get; set; }

    public DaneOsobowe(string imie, int wiek, string adres)
    {
        Imie = imie;
        Wiek = wiek;
        Adres = adres;
    }
}
