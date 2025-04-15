using System;

// Interfejs IPayment
public interface IPayment
{
    void ProcessPayment();
    void Refund();
}

// Klasa CreditCardPayment
public class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Przetwarzanie płatności kartą kredytową");
    }

    public void Refund()
    {
        Console.WriteLine("Zwrot środków na kartę kredytową");
    }
}

// Klasa PayPalPayment
public class PayPalPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Przetwarzanie płatności PayPal");
    }

    public void Refund()
    {
        Console.WriteLine("Zwrot środków przez PayPal");
    }
}

// Klasa BankTransferPayment (rozszerzenie)
public class BankTransferPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Przetwarzanie płatności przelewem bankowym");
    }

    public void Refund()
    {
        Console.WriteLine("Zwrot środków przelewem bankowym");
    }
}

// Klasa z metodą ObsluzPlatnosc
public class PaymentProcessor
{
    public void ObsluzPlatnosc(IPayment payment)
    {
        payment.ProcessPayment();
        payment.Refund();
    }
}

// Przykładowe użycie
class Program
{
    static void Main(string[] args)
    {
        IPayment creditCard = new CreditCardPayment();
        IPayment payPal = new PayPalPayment();
        IPayment bankTransfer = new BankTransferPayment();
        
        var processor = new PaymentProcessor();
        
        processor.ObsluzPlatnosc(creditCard);
        processor.ObsluzPlatnosc(payPal);
        processor.ObsluzPlatnosc(bankTransfer);
    }
}