using System;

class Program
{
    static void Main(string[] args)
    {
        // Zadanie 1: Obliczanie wartości ciągu Fibonacciego
        Console.WriteLine("Podaj liczbę n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"n-ty wyraz ciągu Fibonacciego: {Fibonacci(n)}");

        // Zadanie 2: Sprawdzanie, czy słowo jest palindromem
        Console.WriteLine("Podaj słowo:");
        string word = Console.ReadLine();
        Console.WriteLine($"Czy słowo jest palindromem: {IsPalindrome(word)}");
    }

    // Funkcja rekurencyjna do obliczania wartości Fibonacciego
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Funkcja rekurencyjna do sprawdzania, czy słowo jest palindromem
    static bool IsPalindrome(string word)
    {
        if (word.Length <= 1)
            return true;
        if (word[0] != word[word.Length - 1])
            return false;
        return IsPalindrome(word.Substring(1, word.Length - 2));
    }
}
