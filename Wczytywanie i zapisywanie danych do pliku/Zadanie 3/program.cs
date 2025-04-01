using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "licznik.txt";
        int count = 0;

        if (File.Exists(filePath))
        {
            count = int.Parse(File.ReadAllText(filePath));
        }

        count++;
        File.WriteAllText(filePath, count.ToString());

        Console.WriteLine($"Program został uruchomiony {count} razy.");
    }
}