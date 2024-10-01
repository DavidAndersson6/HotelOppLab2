using System;

namespace HotellOOP2
{
    // Main-metoden ska vara inne i en klass
    public class Program
    {
        // Main-metoden kan inte vara privat, den ska vara public eller åtminstone internal
        public static void Main(string[] args)
        {
            // Skapa en Consultant
            Consultant consultant = new Consultant
            {
                Name = "Eva Expert",
                Age = 35,
                EmployeeId = "C001",
                StartDate = new DateTime(2023, 1, 1),
                Salary = 0, // Konsulter har ofta inte fast lön
                HourlyRate = 1000,
                ConsultingFirm = "Hotell Experterna AB"
            };

            // Skapa en Manager
            Manager manager = new Manager
            {
                Name = "Lisa Ledarsson",
                Age = 40,
                EmployeeId = "M001",
                StartDate = new DateTime(2020, 1, 1),
                Salary = 50000m,
                Department = "Administration"
            };

            // Skapa en Employee
            Employee employee = new Employee
            {
                Name = "Erik Eriksson",
                Age = 30,
                EmployeeId = "E001",
                StartDate = new DateTime(2022, 3, 15),
                Salary = 30000m,
                JobTitle = "Receptionist",
                Department = "Front Desk"
            };

            // Skapa en Housekeeper
            Housekeeper housekeeper = new Housekeeper
            {
                Name = "Anna Clean",
                Age = 32,
                EmployeeId = "H001",
                StartDate = new DateTime(2021, 5, 10),
                Salary = 25000m,
                JobTitle = "Housekeeper",
                Department = "Housekeeping"
            };

            // Anropa metoder för att testa
            Console.WriteLine("Manager:");
            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();

            Console.WriteLine("\nEmployee:");
            employee.PrintInfo();
            employee.Introduce();
            employee.Work();

            Console.WriteLine("\nConsultant:");
            consultant.PrintInfo();
            consultant.Introduce();
            consultant.GiveAdvice();
            Console.WriteLine($"Hourly Rate: {consultant.HourlyRate}");
            Console.WriteLine($"Consulting Firm: {consultant.ConsultingFirm}");

            Console.WriteLine("\nHousekeeper:");
            housekeeper.PrintInfo();
            housekeeper.Introduce();
            housekeeper.Work();
        }
    }

    // Bas-klass för all hotellpersonal
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public int GetYearsOfService()
        {
            return DateTime.Now.Year - StartDate.Year;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}");
            Console.WriteLine($"Ålder: {Age}");
            Console.WriteLine($"Anställnings-ID: {EmployeeId}");
            Console.WriteLine($"Startdatum: {StartDate.ToShortDateString()}");
            Console.WriteLine($"Lön: {Salary:C}");
            Console.WriteLine($"Antal år i tjänst: {GetYearsOfService()}");
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name} och jag arbetar här på hotellet.");
        }
    }

    // Employee-klass som ärver från Person
    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public string Department { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Jobbtitel: {JobTitle}");
            Console.WriteLine($"Avdelning: {Department}");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name} och jag jobbar som {JobTitle} på {Department}-avdelningen.");
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} arbetar som {JobTitle} på {Department}-avdelningen.");
        }
    }

    // Housekeeper-klass som ärver från Employee
    public class Housekeeper : Employee
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} städar hotellrummen.");
        }
    }

    // Manager-klass som ärver från Person
    public class Manager : Person
    {
        public string Department { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Avdelning: {Department}");
        }

        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} håller ett möte för {Department}-avdelningen.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name} och jag är chef för {Department}-avdelningen.");
        }
    }

    // Consultant-klass som ärver från Person
    public class Consultant : Person
    {
        public decimal HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Konsultföretag: {ConsultingFirm}");
        }

        public void GiveAdvice()
        {
            Console.WriteLine($"{Name} från {ConsultingFirm} ger råd till hotellet.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name} och jag arbetar som konsult från {ConsultingFirm}.");
        }
    }
}
