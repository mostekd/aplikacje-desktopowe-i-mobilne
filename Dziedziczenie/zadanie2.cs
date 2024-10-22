using System;

class Pracownik
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public decimal Wynagrodzenie { get; set; }
}

class Manager : Pracownik
{
    public decimal Premia { get; set; }

    public decimal ObliczCalkowiteWynagrodzenie()
    {
        return Wynagrodzenie + Premia;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager
        {
            Imie = "Jan",
            Nazwisko = "Kowalski",
            Wynagrodzenie = 5000,
            Premia = 2000
        };

        Console.WriteLine("Całkowite wynagrodzenie: " + manager.ObliczCalkowiteWynagrodzenie());
    }
}
