using System.Xml.Linq;

namespace HotelOppLab2
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: { Age}");
            }

            public void Introduce()
            {
                Console.WriteLine($"Hej, mitt namn är {Name} och jag är {Age} år gammal. ");
            }

            class Employee : Person
            {
                public string EmployeeID { get; set; }
                public DateTime StartDate { get; set; }
                public decimal Salary { get; set; }
                public string Department { get; set; }

                public Employee(string name, int age, string employeeID, DateTime startDate, decimal salary, string department) : base(name, age)
                {
                    EmployeeID = employeeID;
                    StartDate = startDate;
                    Salary = salary;
                    Department = department;
                }

                public void PrintManagerInfo()
                {
                    if (Department == "Administration")
                    {
                        Console.WriteLine($"{Name} är chef på hotellet och håller på med det adminstrativa.");
                    }
                }

                public void PrintReceptionInfo()
                {
                    if (Department == "Reception")
                    {
                        Console.WriteLine($"{Name} är receptionist på hotellets frontdesk avdelningen.");
                    }
                }

                class Consultant : Person
                {
                    public decimal HourlyRate { get; set; }
                    public string ConsultingFirm { get; set; }

                    public Consultant(string name, int age, decimal hourlyRate, string consultingFirm) : base(name, age)
                    {
                        HourlyRate = hourlyRate;
                        ConsultingFirm = consultingFirm;
                    }

                class Program
                {
                    static void Main(string[] args)
                    {
                        Employee employee = new Employee("Maria Chefsson", 35, "MC01", new DateTime(2020, 02, 02), 50000, "Administration");

                        employee.PrintInfo();
                        employee.Introduce();
                        employee.PrintManagerInfo();

                        Console.WriteLine();

                        Employee employee2 = new Employee("Harry Jonsson", 25, "HJ03", new DateTime(2022, 02, 02), 30000, "Reception");

                        employee2.PrintInfo();
                        employee2.Introduce();
                        employee2.PrintReceptionInfo();

                    }

                }



            }
        }
    }
}
