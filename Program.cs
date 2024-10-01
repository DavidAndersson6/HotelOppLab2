    namespace HotelOppLab2
    {

        class Program
        {
            static void Main(string[] args)
            {
                Manager manager = new Manager
                {
                    Name = "Lisa Ledarsson",
                    Age = 40,
                    EmployeeId = "M001",
                    StartDate = new DateTime(2020, 1, 1),
                    Salary = 50000m,
                    Department = "Administration"
                };

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

            Housekeeper anna = new Housekeeper();
            anna.Name = "Anna Clean";
            anna.Age = 32;
           

            Console.WriteLine("Employee:");

                employee.PrintInfo();
                employee.Introduce();
                employee.Work();
                Console.WriteLine("\nManager:");
                manager.PrintInfo();
                manager.Introduce();
                manager.Holdmeeting();

            Console.WriteLine("\nConsultant:");
            consultant.PrintInfo();
            consultant.Introduce();
            consultant.GiveAdvice();
            Console.WriteLine($"Hourly Rate: {consultant.HourlyRate}");
            Console.WriteLine($"Consulting Firm: {consultant.ConsultingFirm}");

            anna.PrintInfo(); // Skriver ut namn och ålder
            anna.Work();
        }

    }

    }

