public class Klient
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string NumerTelefonu { get; set; }
    public string Adres { get; set; }

    public Klient(string imie, string nazwisko, string numerTelefonu, string adres)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        NumerTelefonu = numerTelefonu;
        Adres = adres;
    }

    public void WyswietlDaneKlienta()
    {
        Console.WriteLine($"Klient: {Imie} {Nazwisko}, Telefon: {NumerTelefonu}, Adres: {Adres}");
    }
}


using System.Collections.Generic;

public class Bank
{
    public string Nazwa { get; set; }
    public string Adres { get; set; }
    public List<Klient> Klienci =  new List<Klient>();

    public Bank(string nazwa, string adres)
    {
        Nazwa = nazwa;
        Adres = adres;
    }

    public void DodajKlienta(Klient klient)
    {
        Klienci.Add(klient);
        Console.WriteLine($"Dodano klienta: {klient.Imie} {klient.Nazwisko}");
    }

    public void UsunKlienta(Klient klient)
    {
        Klienci.Remove(klient);
        Console.WriteLine($"Usunięto klienta: {klient.Imie} {klient.Nazwisko}");
    }

    public void WyswietlDaneKlienta(Klient klient)
    {
        klient.WyswietlDaneKlienta();
    }

    public void WyswietlWszystkichKlientow()
    {
        Console.WriteLine($"Klienci banku {Nazwa}:");
        foreach (var klient in Klienci)
        {
            klient.WyswietlDaneKlienta();
        }
    }
}


using System.Collections.Generic;

public class Samochod
{
    public string Marka { get; set; }
    public List<string> Modele = new List<string>();
    public int RokProdukcji { get; set; }
    public decimal Cena { get; set; }

    public Samochod(string marka, int rokProdukcji, decimal cena)
    {
        Marka = marka;
        RokProdukcji = rokProdukcji;
        Cena = cena;
    }

    public void DodajModel(string model)
    {
        Modele.Add(model);
        Console.WriteLine($"Dodano model: {model}");
    }

    public void UsunModel(string model)
    {
        Modele.Remove(model);
        Console.WriteLine($"Usunięto model: {model}");
    }

    public void WyswietlInformacjeOSamochodzie()
    {
        Console.WriteLine($"Samochód: {Marka}, Rok: {RokProdukcji}, Cena: {Cena} PLN");
        Console.WriteLine("Modele:");
        foreach (var model in Modele)
        {
            Console.WriteLine($"- {model}");
        }
    }
}


public class Produkt
{
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
    public int Ilosc { get; set; }

    public Produkt(string nazwa, decimal cena, int ilosc)
    {
        Nazwa = nazwa;
        Cena = cena;
        Ilosc = ilosc;
    }

    public void DodajIlosc(int ilosc)
    {
        Ilosc += ilosc;
        Console.WriteLine($"Dodano {ilosc} sztuk produktu: {Nazwa}");
    }

    public void UsunIlosc(int ilosc)
    {
        if (Ilosc >= ilosc)
        {
            Ilosc -= ilosc;
            Console.WriteLine($"Usunięto {ilosc} sztuk produktu: {Nazwa}");
        }
        else
        {
            Console.WriteLine("Nie można usunąć więcej niż dostępna ilość.");
        }
    }

    public void WyswietlInformacjeOProdukcie()
    {
        Console.WriteLine($"Produkt: {Nazwa}, Cena: {Cena} PLN, Ilość: {Ilosc}");
        Console.WriteLine($"Wartość wszystkich produktów: {Cena * Ilosc} PLN");
    }
}


using System;
using System.Collections.Generic;

public class Student
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string NumerIndeksu { get; set; }
    public List<int> Oceny = new List<int>();
    public List<Tuple<DateTime, bool>> ListaObecnosci { get; set; }

    public Student(string imie, string nazwisko, string numerIndeksu)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        NumerIndeksu = numerIndeksu;
        ListaObecnosci = new List<Tuple<DateTime, bool>>();
    }

    public void DodajOcene(int ocena)
    {
        Oceny.Add(ocena);
        Console.WriteLine($"Dodano ocenę: {ocena}");
    }

    public void UsunOcene(int ocena)
    {
        Oceny.Remove(ocena);
        Console.WriteLine($"Usunięto ocenę: {ocena}");
    }

    public void DodajObecnosc(DateTime data, bool obecny)
    {
        ListaObecnosci.Add(new Tuple<DateTime, bool>(data, obecny));
        Console.WriteLine($"Dodano obecność: {data.ToShortDateString()} - {(obecny ? "Obecny" : "Nieobecny")}");
    }

    public void UsunObecnosc(DateTime data)
    {
        ListaObecnosci.RemoveAll(o => o.Item1 == data);
        Console.WriteLine($"Usunięto obecność z dnia: {data.ToShortDateString()}");
    }

    public double ObliczProcentObecnosci()
    {
        int obecnosci = ListaObecnosci.Count(o => o.Item2);
        return (double)obecnosci / ListaObecnosci.Count * 100;
    }

    public double ObliczSredniaOcen()
    {
        if (Oceny.Count == 0) return 0;
        double suma = 0;
        foreach (var ocena in Oceny)
        {
            suma += ocena;
        }
        return suma / Oceny.Count;
    }

    public void WyswietlInformacjeOStudencie()
    {
        Console.WriteLine($"Student: {Imie} {Nazwisko}, Indeks: {NumerIndeksu}");
        Console.WriteLine($"Średnia ocen: {ObliczSredniaOcen()}");
        Console.WriteLine($"Procent obecności: {ObliczProcentObecnosci()}%");
    }
}
