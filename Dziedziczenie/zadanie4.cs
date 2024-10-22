using System;

class UrzadzenieElektroniczne
{
    public void Wlacz()
    {
        Console.WriteLine("Urządzenie włączone");
    }
}

class Telefon : UrzadzenieElektroniczne
{
    public void Zadzwon()
    {
        Console.WriteLine("Telefon dzwoni");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Telefon telefon = new Telefon();
        telefon.Wlacz();
        telefon.Zadzwon();
    }
}
