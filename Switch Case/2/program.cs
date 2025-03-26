using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj numer dnia tygodnia (1-7):");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        
        string dayName;
        
        switch (dayNumber)
        {
            case 1:
                dayName = "Poniedziałek";
                break;
            case 2:
                dayName = "Wtorek";
                break;
            case 3:
                dayName = "Środa";
                break;
            case 4:
                dayName = "Czwartek";
                break;
            case 5:
                dayName = "Piątek";
                break;
            case 6:
                dayName = "Sobota";
                break;
            case 7:
                dayName = "Niedziela";
                break;
            default:
                dayName = "Nieprawidłowa liczba";
                break;
        }
        
        Console.WriteLine(dayName);
    }
}