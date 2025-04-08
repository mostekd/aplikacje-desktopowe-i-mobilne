using System;

namespace ModyfikatoryDostepu
{
    // Zadanie 1: Klasa Samochod z różnymi modyfikatorami
    public class Samochod
    {
        private string model;
        
        public string Marka { get; set; } 
        
        protected double ObliczSpalanie(double przebieg, double zuzytePaliwo)
        {
            return zuzytePaliwo / przebieg * 100; 
        }
        
        public void WypiszInfo()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {model}");
        }
        
        public Samochod(string marka, string model)
        {
            this.Marka = marka;
            this.model = model;
        }
    }

    // Zadanie 2: Dziedziczenie i protected
    public class Pojazd
    {
        protected void StartSilnik()
        {
            Console.WriteLine("Silnik został uruchomiony.");
        }
    }

    public class Motocykl : Pojazd
    {
        public void Uruchom()
        {
            StartSilnik();
            Console.WriteLine("Motocykl gotowy do jazdy!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Zadanie 1 ===");
            Samochod samochod = new Samochod("Toyota", "Corolla");
            samochod.Marka = "Toyota";
            // samochod.model = "Corolla"; // błąd - model jest prywatny
            // samochod.ObliczSpalanie(100, 5); // błąd - metoda jest protected
            samochod.WypiszInfo(); 

            Console.WriteLine("\n=== Zadanie 2 ===");
            Motocykl motocykl = new Motocykl();
            motocykl.Uruchom(); 
            // motocykl.StartSilnik(); // błąd - metoda jest protected

            Console.ReadKey();
        }
    }
}