using System;

class Zwierze
{
    public string Nazwa { get; set; }

    public virtual void DajGlos()
    {
        Console.WriteLine("Zwierzę wydaje dźwięk");
    }
}

class Pies : Zwierze
{
    public override void DajGlos()
    {
        Console.WriteLine("Pies szczeka");
    }
}

class Kot : Zwierze
{
    public override void DajGlos()
    {
        Console.WriteLine("Kot miauczy");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zwierze pies = new Pies();
        Zwierze kot = new Kot();

        pies.DajGlos();  // Pies szczeka
        kot.DajGlos();   // Kot miauczy
    }
}
