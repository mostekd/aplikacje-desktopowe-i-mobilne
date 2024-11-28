// Napisz program w języku C#, który tworzy klasę Osoba z polami:
// Imie (string),
// Wiek (int).
// Następnie utwórz obiekt tej klasy, przypisz mu wartości i wyświetl te wartości w konsoli.

using System;

class Osoba
{
    public string Imie { get; set; }
    public int Wiek { get; set; }

    public Osoba(string imie, int wiek)
    {
        Imie = imie;
        Wiek = wiek;
    }

    public void WyswietlDane()
    {
        Console.WriteLine($"Imię: {Imie}");
        Console.WriteLine($"Wiek: {Wiek}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Osoba osoba = new Osoba("Jan", 25);

        osoba.WyswietlDane();

        Console.ReadLine();
    }
}

// Utwórz klasę Grupa, która zawiera:
// Nazwę grupy (string),
// Listę obiektów typu Osoba (z zadania 1).
// W programie utwórz grupę, dodaj do niej co najmniej trzy osoby, a następnie wyświetl w konsoli informacje o nazwie grupy i wszystkich osobach w niej zawartych.


using System;
using System.Collections.Generic;

class Osoba
{
    public string Imie { get; set; }
    public int Wiek { get; set; }

    public Osoba(string imie, int wiek)
    {
        Imie = imie;
        Wiek = wiek;
    }

    public void WyswietlDane()
    {
        Console.WriteLine($"Imię: {Imie}, Wiek: {Wiek}");
    }
}

class Grupa
{
    public string NazwaGrupy { get; set; }
    public List<Osoba> Osoby { get; set; }

    public Grupa(string nazwaGrupy)
    {
        NazwaGrupy = nazwaGrupy;
        Osoby = new List<Osoba>();
    }

    public void DodajOsobe(Osoba osoba)
    {
        Osoby.Add(osoba);
    }

    public void WyswietlDaneGrupy()
    {
        Console.WriteLine($"Nazwa grupy: {NazwaGrupy}");
        Console.WriteLine("Osoby w grupie:");
        foreach (var osoba in Osoby)
        {
            osoba.WyswietlDane();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Grupa grupa = new Grupa("Grupa Przyjaciół");

        grupa.DodajOsobe(new Osoba("Anna", 20));
        grupa.DodajOsobe(new Osoba("Kamil", 22));
        grupa.DodajOsobe(new Osoba("Marta", 24));

        grupa.WyswietlDaneGrupy();

        Console.ReadLine();
    }
}

// Rozszerz klasę Osoba, tworząc klasę Student, która dodatkowo ma pole:
// frekwencja (int).
// Utwórz listę zawierającą obiekty klasy Osoba oraz Student, a następnie wyświetl w konsoli wszystkie informacje. Wykorzystaj polimorfizm, aby obsłużyć różne typy obiektów.

using System;
using System.Collections.Generic;

class Osoba
{
    public string Imie { get; set; }
    public int Wiek { get; set; }

    public Osoba(string imie, int wiek)
    {
        Imie = imie;
        Wiek = wiek;
    }

    public virtual void WyswietlDane()
    {
        Console.WriteLine($"Imię: {Imie}, Wiek: {Wiek}");
    }
}

class Student : Osoba
{
    public int Frekwencja { get; set; }

    public Student(string imie, int wiek, int frekwencja) 
        : base(imie, wiek)
    {
        Frekwencja = frekwencja;
    }

    public override void WyswietlDane()
    {
        Console.WriteLine($"Imię: {Imie}, Wiek: {Wiek}, Frekwencja: {Frekwencja}%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Osoba> osoby = new List<Osoba>
        {
            new Osoba("Anna", 30),
            new Student("Kamil", 22, 85),
            new Osoba("Marta", 25),
            new Student("Jan", 20, 90)
        };

        Console.WriteLine("Lista osób:");
        foreach (var osoba in osoby)
        {
            osoba.WyswietlDane();
        }

        Console.ReadLine();
    }
}
