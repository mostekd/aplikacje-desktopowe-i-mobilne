using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj ocenę (1-6):");
        int grade = Convert.ToInt32(Console.ReadLine());
        
        string gradeDescription;
        
        switch (grade)
        {
            case 1:
                gradeDescription = "Niedostateczny";
                break;
            case 2:
                gradeDescription = "Dopuszczający";
                break;
            case 3:
                gradeDescription = "Dostateczny";
                break;
            case 4:
                gradeDescription = "Dobry";
                break;
            case 5:
                gradeDescription = "Bardzo dobry";
                break;
            case 6:
                gradeDescription = "Celujący";
                break;
            default:
                gradeDescription = "Niepoprawna ocena";
                break;
        }
        
        Console.WriteLine(gradeDescription);
    }
}