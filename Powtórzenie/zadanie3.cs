using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Factorial(5)); // Output: 120
    }

    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
}
