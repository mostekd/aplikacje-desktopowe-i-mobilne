using System;

class Figura
{
    public virtual double ObliczPole()
    {
        return 0;
    }
}

class Kwadrat : Figura
{
    public double Bok { get; set; }

    public override double ObliczPole()
    {
        return Bok * Bok;
    }
}

class Kolo : Figura
{
    public double Promien { get; set; }

    public override double ObliczPole()
    {
        return Math.PI * Promien * Promien;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kwadrat kwadrat = new Kwadrat { Bok = 5 };
        Kolo kolo = new Kolo { Promien = 3 };

        Console.WriteLine("Pole kwadratu: " + kwadrat.ObliczPole());
        Console.WriteLine("Pole koła: " + kolo.ObliczPole());
    }
}
