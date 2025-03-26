using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Podaj drugą liczbę:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Podaj operację (+, -, *, /):");
        char operation = Convert.ToChar(Console.ReadLine());
        
        double result = 0;
        bool validOperation = true;
        
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Nie można dzielić przez zero!");
                break;
            default:
                Console.WriteLine("Nieprawidłowa operacja!");
                validOperation = false;
                break;
        }
        
        if (validOperation && (operation != '/' || num2 != 0))
            Console.WriteLine($"Wynik: {result}");
    }
}