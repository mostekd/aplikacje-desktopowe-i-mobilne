using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj imiona oddzielone spacjami:");
        string input = Console.ReadLine();
        string[] names = input.Split(' ');

        File.WriteAllLines("imiona.txt", names);

        string[] readNames = File.ReadAllLines("imiona.txt");

        Console.WriteLine("\nZapisane imiona:");
        foreach (string name in readNames)
        {
            Console.WriteLine(name);
        }
    }
}