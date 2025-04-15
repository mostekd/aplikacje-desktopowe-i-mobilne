using System;

// Interfejs IZamowienie
public interface IZamowienie
{
    void ZlozZamowienie();
    void AnulujZamowienie();
    void PokazStatus();
}

// Klasa ZamowienieOnline
public class ZamowienieOnline : IZamowienie
{
    public void ZlozZamowienie()
    {
        Console.WriteLine("Zamówienie online zostało złożone przez stronę internetową.");
    }

    public void AnulujZamowienie()
    {
        Console.WriteLine("Zamówienie online zostało anulowane.");
    }

    public void PokazStatus()
    {
        Console.WriteLine("Status zamówienia online: W trakcie realizacji");
    }
}

// Klasa ZamowienieTelefoniczne
public class ZamowienieTelefoniczne : IZamowienie
{
    public void ZlozZamowienie()
    {
        Console.WriteLine("Zamówienie telefoniczne zostało złożone przez konsultanta.");
    }

    public void AnulujZamowienie()
    {
        Console.WriteLine("Zamówienie telefoniczne zostało anulowane.");
    }

    public void PokazStatus()
    {
        Console.WriteLine("Status zamówienia telefonicznego: Oczekuje na potwierdzenie");
    }
}

// Klasa z metodą ObsluzZamowienie
public class ObslugaZamowien
{
    public void ObsluzZamowienie(IZamowienie zamowienie)
    {
        zamowienie.ZlozZamowienie();
    }
}

// Przykładowe użycie
class Program
{
    static void Main(string[] args)
    {
        IZamowienie zamowienieOnline = new ZamowienieOnline();
        IZamowienie zamowienieTelefoniczne = new ZamowienieTelefoniczne();
        
        zamowienieOnline.ZlozZamowienie();
        zamowienieOnline.PokazStatus();
        
        zamowienieTelefoniczne.ZlozZamowienie();
        zamowienieTelefoniczne.PokazStatus();
        
        var obsluga = new ObslugaZamowien();
        obsluga.ObsluzZamowienie(zamowienieOnline);
        obsluga.ObsluzZamowienie(zamowienieTelefoniczne);
    }
}