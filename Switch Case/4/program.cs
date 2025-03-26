using System;
using System.Collections.Generic;

class Uzytkownik
{
    public string Login { get; set; }
    public string Haslo { get; set; }
    public string Rola { get; set; }
    
    public Uzytkownik(string login, string haslo, string rola)
    {
        Login = login;
        Haslo = haslo;
        Rola = rola;
    }
    
    public void WyswietlUprawnienia()
    {
        switch (Rola.ToLower())
        {
            case "admin":
                Console.WriteLine("Uprawnienia: Pełny dostęp do systemu");
                break;
            case "moderator":
                Console.WriteLine("Uprawnienia: Moderowanie treści, zarządzanie użytkownikami");
                break;
            case "użytkownik":
                Console.WriteLine("Uprawnienia: Podstawowy dostęp do systemu");
                break;
            default:
                Console.WriteLine("Nieznana rola - brak uprawnień");
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        List<Uzytkownik> uzytkownicy = new List<Uzytkownik>
        {
            new Uzytkownik("admin1", "admin123", "admin"),
            new Uzytkownik("mod1", "mod123", "moderator"),
            new Uzytkownik("user1", "user123", "użytkownik")
        };
        
        Console.WriteLine("Logowanie");
        Console.WriteLine("Podaj login:");
        string login = Console.ReadLine();
        
        Console.WriteLine("Podaj hasło:");
        string haslo = Console.ReadLine();
        
        bool zalogowany = false;
        
        foreach (var uzytkownik in uzytkownicy)
        {
            if (uzytkownik.Login == login && uzytkownik.Haslo == haslo)
            {
                Console.WriteLine($"Zalogowano jako {uzytkownik.Rola}");
                uzytkownik.WyswietlUprawnienia();
                zalogowany = true;
                break;
            }
        }
        
        if (!zalogowany)
            Console.WriteLine("Nieudana próba logowania. Nieprawidłowy login lub hasło.");
    }
}