using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "dziennik.txt";
        string currentDate = DateTime.Now.ToString("dd.MM.yyyy");

        Console.WriteLine("Podaj treść notatki:");
        string note = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"-------------------------- {currentDate} -----------------------------");
            writer.WriteLine(note);
            writer.WriteLine();
        }

        Console.WriteLine("Wpis został zapisany w dzienniku!");
    }
}