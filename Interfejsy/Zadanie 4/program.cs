using System;

public interface IEmployee
{
    void Work();
    void TakeBreak();
}

public class Developer : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Programista pracuje nad kodem");
    }

    public void TakeBreak()
    {
        Console.WriteLine("Programista robi przerwę na kawę");
    }
}

public class Manager : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Menedżer zarządza zespołem");
    }

    public void TakeBreak()
    {
        Console.WriteLine("Menedżer robi przerwę na spotkanie");
    }
}

public class Intern : IEmployee
{
    public void Work()
    {
        Console.WriteLine("Stażysta uczy się nowych technologii");
    }

    public void TakeBreak()
    {
        Console.WriteLine("Stażysta robi przerwę na pytania do mentora");
    }
}

public class EmployeeManager
{
    public void WykonajObowiazki(IEmployee employee)
    {
        employee.Work();
        employee.TakeBreak();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IEmployee developer = new Developer();
        IEmployee manager = new Manager();
        IEmployee intern = new Intern();
        
        var empManager = new EmployeeManager();
        
        empManager.WykonajObowiazki(developer);
        empManager.WykonajObowiazki(manager);
        empManager.WykonajObowiazki(intern);
    }
}