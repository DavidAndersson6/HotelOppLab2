using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOppLab2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }



        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}");

            Console.WriteLine($"Ålder: {Age}");

        }

        public void Introduce()
        {
            Console.WriteLine($"Hej mitt namn är {Name} och är {Age} år gammal");
        }


    }

    public class Manager : Person
    {
        public string Department { get; set; }


        public void Holdmeeting()
        {
            Console.WriteLine($"{Name} från avdelning {Department} ska hålla ett personalmöte på hotellet");
        }

        public void PlanBudget()
        {
            Console.WriteLine($"{Name} håller koll på budgeten");}

    }

        public class Employee : Person
        {
            public string JobTitle { get; set; }
            public string Department { get; set; }

            public virtual void Work()
            {
                Console.WriteLine($"{JobTitle} {Name} från avdelning {Department} gör sitt jobb");
            }
        }

        public class Consultant : Person

        {

            public decimal HourlyRate { get; set; }
            public string ConsultingFirm { get; set; }

            public void GiveAdvice()
            {
                Console.WriteLine($"{Name} ger råd till hotellet om hur de kan förbättra sina rutiner.");
            }
        }

        public class Housekeeper : Employee
        {
            public override void Work()
            {
                base.Work();
            }
        }


    }
}
