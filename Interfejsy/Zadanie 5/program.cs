using System;

public interface IUserRegistration
{
    void Register();
    void SendConfirmationEmail();
}

public class BasicUserRegistration : IUserRegistration
{
    public void Register()
    {
        Console.WriteLine("Rejestracja podstawowego użytkownika");
    }

    public void SendConfirmationEmail()
    {
        Console.WriteLine("Wysłano podstawowy email potwierdzający");
    }
}

public class PremiumUserRegistration : IUserRegistration
{
    public void Register()
    {
        Console.WriteLine("Rejestracja użytkownika premium");
        AdditionalPremiumFeatures();
    }

    public void SendConfirmationEmail()
    {
        Console.WriteLine("Wysłano premium email potwierdzający z bonusami");
    }

    private void AdditionalPremiumFeatures()
    {
        Console.WriteLine("Aktywowano dodatkowe funkcje dla użytkownika premium");
    }
}

public class GuestUserRegistration : IUserRegistration
{
    public void Register()
    {
        Console.WriteLine("Rejestracja użytkownika gościa");
    }

    public void SendConfirmationEmail()
    {
        // Brak wysyłania emaila dla gościa
        Console.WriteLine("Użytkownik gość - brak wysyłania emaila potwierdzającego");
    }
}

public class RegistrationService
{
    public void RejestrujUzytkownika(IUserRegistration user)
    {
        user.Register();
        user.SendConfirmationEmail();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IUserRegistration basicUser = new BasicUserRegistration();
        IUserRegistration premiumUser = new PremiumUserRegistration();
        IUserRegistration guestUser = new GuestUserRegistration();
        
        var registrationService = new RegistrationService();
        
        registrationService.RejestrujUzytkownika(basicUser);
        Console.WriteLine();
        registrationService.RejestrujUzytkownika(premiumUser);
        Console.WriteLine();
        registrationService.RejestrujUzytkownika(guestUser);
    }
}