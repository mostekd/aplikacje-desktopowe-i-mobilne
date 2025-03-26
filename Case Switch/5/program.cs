using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Witaj w grze RPG!");
        Console.WriteLine("Wybierz klasę postaci:");
        Console.WriteLine("1. Wojownik");
        Console.WriteLine("2. Mag");
        Console.WriteLine("3. Łotrzyk");
        Console.Write("Twój wybór: ");
        
        int klasa = Convert.ToInt32(Console.ReadLine());
        string klasaPostaci = "";
        string specjalnaUmiejetnosc = "";
        
        switch (klasa)
        {
            case 1:
                klasaPostaci = "Wojownik";
                specjalnaUmiejetnosc = "Mocny atak mieczem";
                break;
            case 2:
                klasaPostaci = "Mag";
                specjalnaUmiejetnosc = "Rzucanie czarów";
                break;
            case 3:
                klasaPostaci = "Łotrzyk";
                specjalnaUmiejetnosc = "Cichy atak z zaskoczenia";
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór. Wybierz ponownie.");
                return;
        }
        
        Console.WriteLine($"Wybrałeś {klasaPostaci}! Twoja specjalna umiejętność: {specjalnaUmiejetnosc}");
        
        // Walka z przeciwnikiem
        Random rand = new Random();
        string[] przeciwnicy = { "goblin", "wilk", "smok" };
        string przeciwnik = przeciwnicy[rand.Next(przeciwnicy.Length)];
        
        Console.WriteLine($"\nSpotykasz {przeciwnik}a! Co robisz?");
        
        if (klasa == 1) // Wojownik
        {
            Console.WriteLine("1. Atak mieczem");
            Console.WriteLine("2. Blok tarczą");
            Console.WriteLine("3. Rzut toporem");
        }
        else if (klasa == 2) // Mag
        {
            Console.WriteLine("1. Rzucasz kulę ognia");
            Console.WriteLine("2. Przywołujesz lodowego golema");
            Console.WriteLine("3. Uciekasz teleportem");
        }
        else // Łotrzyk
        {
            Console.WriteLine("1. Cichy atak z tyłu");
            Console.WriteLine("2. Rzut nożem");
            Console.WriteLine("3. Ukrywasz się w cieniu");
        }
        
        Console.Write("Twój wybór: ");
        int akcja = Convert.ToInt32(Console.ReadLine());
        
        string wynikWalki = "";
        bool wygrana = false;
        
        switch (klasa)
        {
            case 1: // Wojownik
                switch (akcja)
                {
                    case 1:
                        wynikWalki = $"Zadajesz potężny cios mieczem {przeciwnik}owi!";
                        wygrana = rand.Next(2) == 1;
                        break;
                    case 2:
                        wynikWalki = $"Blokujesz atak {przeciwnik}a tarczą!";
                        wygrana = true;
                        break;
                    case 3:
                        wynikWalki = $"Rzucasz toporem w {przeciwnik}a!";
                        wygrana = rand.Next(2) == 1;
                        break;
                    default:
                        wynikWalki = "Nieprawidłowa akcja!";
                        break;
                }
                break;
                
            case 2: // Mag
                switch (akcja)
                {
                    case 1:
                        wynikWalki = $"Rzucasz kulę ognia w {przeciwnik}a!";
                        wygrana = przeciwnik != "smok"; // Smok jest odporny na ogień
                        break;
                    case 2:
                        wynikWalki = $"Przywołujesz lodowego golema do walki z {przeciwnik}em!";
                        wygrana = true;
                        break;
                    case 3:
                        wynikWalki = "Uciekasz teleportem!";
                        wygrana = false;
                        break;
                    default:
                        wynikWalki = "Nieprawidłowa akcja!";
                        break;
                }
                break;
                
            case 3: // Łotrzyk
                switch (akcja)
                {
                    case 1:
                        wynikWalki = $"Atakujesz {przeciwnik}a z zaskoczenia!";
                        wygrana = przeciwnik != "wilk"; // Wilk ma dobry węch
                        break;
                    case 2:
                        wynikWalki = $"Rzucasz nożem w {przeciwnik}a!";
                        wygrana = rand.Next(2) == 1;
                        break;
                    case 3:
                        wynikWalki = $"Ukrywasz się w cieniu przed {przeciwnik}em!";
                        wygrana = przeciwnik != "goblin"; // Gobliny widzą w ciemności
                        break;
                    default:
                        wynikWalki = "Nieprawidłowa akcja!";
                        break;
                }
                break;
        }
        
        Console.WriteLine(wynikWalki);
        Console.WriteLine(wygrana ? "Pokonałeś przeciwnika!" : "Niestety, przeciwnik cię pokonał.");
    }
}