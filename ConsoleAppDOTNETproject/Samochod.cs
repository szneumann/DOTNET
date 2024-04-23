using System;



// Klasa „Samochod” ma posiadać właściwości dostępowe do wszystkich pól, które nie są statyczne (kazdy samochod ma inną marke itp)
class Samochod
{
    // Pola
    private string marka;
    private string model ;
    private int iloscDrzwi;
    private double pojemnoscSilnika;
    private double srednieSpalanie;

    // Pole prywatne statyczne do przechowywania liczby utworzonych obiektów klasy Samochod 
    private static int iloscSamochodow = 0;


    public string Marka
    {
        get { return marka; }
        set { marka = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public int IloscDrzwi
    {
        get { return iloscDrzwi; }
        set { iloscDrzwi = value; }
    }
    public double PojemnoscSilnika
    {
        get { return pojemnoscSilnika; }
        set { pojemnoscSilnika = value; }
    }
    public double SrednieSpalanie
    {
        get { return srednieSpalanie; }
        set { srednieSpalanie = value; }
    }

    // Konstruktor domyślny
    public Samochod()
    {
        Marka = "nieznana";
        Model = "nieznany";
        IloscDrzwi = 0;
        PojemnoscSilnika = 0.0;        
        SrednieSpalanie = 0.0 ;
        iloscSamochodow++;
    }

    // Konstruktor przyjmujący parametry
    public Samochod(string marka_, string model_, int iloscDrzwi_, double pojemnoscSilnika_, double srednieSpalanie_)
    {
        Marka = marka_;
        Model = model_;
        IloscDrzwi = iloscDrzwi_;
        PojemnoscSilnika = pojemnoscSilnika_;
        SrednieSpalanie = srednieSpalanie_;
        iloscSamochodow++;
    }

    // Metoda obliczająca średnie spalanie na danej trasie
    private double ObliczSpalanie(double dlugoscTrasy)
    {
        return (srednieSpalanie * dlugoscTrasy) / 100;
    }

    // Metoda obliczająca cenę paliwa potrzebnego do przejechania danej trasy
    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
    {
        return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
    }

    // Metoda wypisująca informacje o samochodzie na ekran konsoli
    public void WypiszInfo()
    {
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Ilość drzwi: {IloscDrzwi}");
        Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika} l");
        Console.WriteLine($"Średnie spalanie: {SrednieSpalanie} l/100km");
        Console.WriteLine();

    }

    // Metoda statyczna wypisująca informacje o liczbie utworzonych obiektów klasy Samochod
    public static void WypiszIloscSamochodow()
    {
        Console.WriteLine($"Liczba utworzonych samochodów: {iloscSamochodow}");
    }
}



