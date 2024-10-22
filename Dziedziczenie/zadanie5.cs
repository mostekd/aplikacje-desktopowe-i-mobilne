using System;
using System.Collections.Generic;

class Pojazd
{
    public virtual void PoruszajSie()
    {
        Console.WriteLine("Pojazd się porusza");
    }
}

class Samochod : Pojazd
{
    public override void PoruszajSie()
    {
        Console.WriteLine("Samochód jedzie");
    }
}

class Motocykl : Pojazd
{
    public override void PoruszajSie()
    {
        Console.WriteLine("Motocykl jedzie");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Pojazd> pojazdy = new List<Pojazd>
        {
            new Samochod(),
            new Motocykl()
        };

        foreach (var pojazd in pojazdy)
        {
            pojazd.PoruszajSie();
        }
    }
}
