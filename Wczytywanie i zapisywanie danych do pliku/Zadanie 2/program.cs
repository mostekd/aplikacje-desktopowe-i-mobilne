using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "liczby.txt";

        if (File.Exists(filePath))
        {
            string[] numbersStr = File.ReadAllLines(filePath);
            double[] numbers = numbersStr.Select(double.Parse).ToArray();
            double average = numbers.Average();

            Console.WriteLine($"Średnia zapisanych liczb: {average}");
        }
        else
        {
            Console.WriteLine("Podaj liczby oddzielone spacjami:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            File.WriteAllLines(filePath, numbers);
            Console.WriteLine("Liczby zostały zapisane. Uruchom program ponownie aby obliczyć średnią.");
        }
    }
}