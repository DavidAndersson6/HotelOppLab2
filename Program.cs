namespace HotelOppLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
    }
}
public class Person
{
    public string Name;
    public int Age;
    public string EmployeeId;
    public decimal HourSalary;
    public DateTime StartDate;

    public virtual void PrintInfo()
    {
        Console.WriteLine("Namn: {0}, Ålder {1}", Name, Age);
    }

    public virtual void Introduce()
    {
        Console.WriteLine("Tjena, mitt namn är {0} och jag är {1} år gammal!", Name, Age);
    }

    public virtual void Date()
    {
        Console.WriteLine("datumet är {0}", StartDate);
    }
}

public class Manager : Person
{
    public string Department;

    public void HoldMeeting()
    {
        Console.WriteLine("{0} håller ett möte på hotelet!", Name);
    }

    public void PlanBudget()
    {
        Console.WriteLine("");
    }
}

public class Employee : Person
{
    private string JobTitle;
    private string Department;

    public virtual void Work()
    {
        Console.WriteLine("{0} arbetar som {1} på {2}", Name, JobTitle, Department);
    }
}

public class Consultant : Person
{
    public string ConsultingFirm;
    public string Expertise;

    public void GiveAdvice()
    {
        Console.WriteLine("Jag är från {0} och är här för att ge förbättringsförslag", ConsultingFirm);
        Console.WriteLine("Jag är expert inom {0}", Expertise);
    }

    public void Salary()
    {
        Console.WriteLine("Timlön: {0}", HourSalary);
    }
}

public class HouseKeeper : Employee
{
    public override void Work()
    {
        base.Work();
    }
}