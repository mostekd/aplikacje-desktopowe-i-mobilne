//1.Napisz program, który tworzy klasę Produkt z polami:
// Nazwa (string),
// Cena (double).
// Następnie utwórz obiekt tej klasy, przypisz mu wartości i wyświetl je w konsoli.

using System;

class Produkt
{
    public string Nazwa { get; set; }
    public double Cena { get; set; }
    
    public Produkt(string nazwa, double cena)
    {
        Nazwa = nazwa;
        Cena = cena;
    }
    
    public override string ToString()
    {
        return $"Nazwa: {Nazwa}, Cena: {Cena} zł";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produkt produkt = new Produkt("Chleb", 4.5);
        Console.WriteLine(produkt);
    }
}

// 2.Utwórz klasę Sklep, która zawiera:
// Nazwę sklepu (string),
// Listę obiektów typu Produkt (z zadania 1).
// W programie utwórz sklep, dodaj do niego co najmniej trzy produkty, a następnie wyświetl w konsoli informacje o nazwie sklepu i wszystkich produktach.

using System;
using System.Collections.Generic;

class Produkt
{
    public string Nazwa { get; set; }
    public double Cena { get; set; }
    
    public Produkt(string nazwa, double cena)
    {
        Nazwa = nazwa;
        Cena = cena;
    }
    
    public override string ToString()
    {
        return $"Nazwa: {Nazwa}, Cena: {Cena} zł";
    }
}

class Sklep
{
    public string NazwaSklepu { get; set; }
    public List<Produkt> Produkty { get; set; }
    
    public Sklep(string nazwaSklepu)
    {
        NazwaSklepu = nazwaSklepu;
        Produkty = new List<Produkt>();
    }
    
    public void DodajProdukt(Produkt produkt)
    {
        Produkty.Add(produkt);
    }
    
    public void WyswietlInformacje()
    {
        Console.WriteLine($"Sklep: {NazwaSklepu}");
        Console.WriteLine("Produkty:");
        foreach (var produkt in Produkty)
        {
            Console.WriteLine($"- {produkt}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Sklep sklep = new Sklep("SuperMarket");
        sklep.DodajProdukt(new Produkt("Chleb", 4.5));
        sklep.DodajProdukt(new Produkt("Masło", 6.2));
        sklep.DodajProdukt(new Produkt("Mleko", 3.8));
        
        sklep.WyswietlInformacje();
    }
}

// 3.Rozszerz klasę Produkt, tworząc klasę Elektronika, która dodatkowo ma pole:
// GwarancjaWMiesiacach (int).
// Utwórz listę zawierającą obiekty klasy Produkt oraz Elektronika, a następnie wyświetl w konsoli wszystkie informacje. Wykorzystaj polimorfizm, aby obsłużyć różne typy obiektów.

using System;
using System.Collections.Generic;

class Produkt
{
    public string Nazwa { get; set; }
    public double Cena { get; set; }
    
    public Produkt(string nazwa, double cena)
    {
        Nazwa = nazwa;
        Cena = cena;
    }
    
    public virtual void WyswietlInformacje()
    {
        Console.WriteLine($"Nazwa: {Nazwa}, Cena: {Cena} zł");
    }
}

class Elektronika : Produkt
{
    public int GwarancjaWMiesiacach { get; set; }
    
    public Elektronika(string nazwa, double cena, int gwarancjaWMiesiacach) : base(nazwa, cena)
    {
        GwarancjaWMiesiacach = gwarancjaWMiesiacach;
    }
    
    public override void WyswietlInformacje()
    {
        Console.WriteLine($"Nazwa: {Nazwa}, Cena: {Cena} zł, Gwarancja: {GwarancjaWMiesiacach} miesięcy");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Produkt> produkty = new List<Produkt>
        {
            new Produkt("Chleb", 4.5),
            new Elektronika("Smartfon", 1500, 24),
            new Elektronika("Telewizor", 3000, 36),
            new Produkt("Masło", 6.2)
        };
        
        foreach (var produkt in produkty)
        {
            produkt.WyswietlInformacje();
        }
    }
}
