using System;


class Garaz
{
    //pola
    private string adres;
    private int pojemnosc;
    private int liczbaSamochodow = 0;
    private Samochod[] samochody;

    // pola dostępu
    public string Adres
    {
        get { return adres; }
        set { adres = value; }
    }

    public int Pojemnosc
    {
        get { return pojemnosc; }
        set 
        { 
            pojemnosc = value;
            samochody = new Samochod[pojemnosc];
        }
    }

    // Konstruktor domyślny
    public Garaz()
    {
        Adres = "nieznany";
        Pojemnosc = 0;
        samochody = null;
    }

    // Konstruktor przyjmujący parametry
    public Garaz(string adres_, int pojemnosc_)
    {
        Adres = adres_;
        Pojemnosc = pojemnosc_;
    }
    // Metoda która wprowadza samochód do garażu, zwraca komunikat, gdy garaż jest pełny
    public void WprowadzSamochod(Samochod samochod)
    {
        if (liczbaSamochodow >= pojemnosc)
        { 
            Console.WriteLine("Garaż jest pełny");
            Console.WriteLine();
        }
        else
        {
            samochody[liczbaSamochodow] = samochod;
            liczbaSamochodow++;
        }
    }

    // Metoda która wyprowadza samochód z garażu, zwraca komunikat, gdy garaż jest pusty
    public Samochod WyprowadzSamochod()
    {
        if (liczbaSamochodow == 0)
        { 
            Console.WriteLine("Garaz jest pusty");
            Console.WriteLine();
        }
        else if (liczbaSamochodow >= pojemnosc)
        {
            samochody[liczbaSamochodow - 1] = null;


            liczbaSamochodow--;

        }
        return new Samochod();
    }

    // Metoda, która wypisuje informacje o garażu oraz samochodach, które są w nim przechowywane
    public void WypiszInfo()
    {
        Console.WriteLine($"Adres garażu: {Adres}");
        Console.WriteLine($"Pojemnosc: {Pojemnosc}");
        Console.WriteLine($"Samochody w garażu: {liczbaSamochodow}");

        foreach (Samochod samochod in samochody)
        {
            if (samochod != null)
            {
                samochod.WypiszInfo();
                Console.WriteLine();
            }
        }
    }
}

   
