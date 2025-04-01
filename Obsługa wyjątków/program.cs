using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Podaj liczby oddzielone spacjami:");
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');
            double[] numbers = new double[numbersStr.Length];

            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbers[i] = double.Parse(numbersStr[i]);
            }

            while (numbers.Length > 1)
            {
                double[] newNumbers = new double[numbers.Length - 1];
                
                try
                {
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        try
                        {
                            newNumbers[i] = numbers[i] / numbers[i + 1];
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Nie można dzielić przez zero!");
                        }
                    }
                    Console.WriteLine(string.Join(", ", newNumbers));
                    numbers = newNumbers;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
                    break;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Nieprawidłowy format liczby!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Program zakończył działanie.");
        }
    }
}