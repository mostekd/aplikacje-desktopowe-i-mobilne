using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 432;
        int sum = SumOfDigits(number);
        Console.WriteLine($"Sum of digits of {number} is {sum}");
    }

    static int SumOfDigits(int number)
    {
        if (number == 0)
            return 0;
        return (number % 10) + SumOfDigits(number / 10);
    }
}