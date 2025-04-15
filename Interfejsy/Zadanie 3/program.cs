using System;

public interface IPayment
{
    void ProcessPayment();
    void Refund();
}

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

public class PaymentProcessor
{
    public void ObsluzPlatnosc(IPayment payment)
    {
        payment.ProcessPayment();
        payment.Refund();
    }
}

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