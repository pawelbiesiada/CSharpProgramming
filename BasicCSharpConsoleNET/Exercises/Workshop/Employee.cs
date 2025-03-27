using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal abstract class Employee
    {
        public string Name { get; set; }

        public virtual void CalculateSalary()
        {
            Console.WriteLine($"Obliczam wypłatę dla {Name}");
        }
    }

    internal class Director : Employee
    {

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            Console.WriteLine("Zarabia 4000 PLN");
        }

        public void GetBonus()
        {
            Console.WriteLine("Wypłacam bonus");
        }

    }

    internal class Programmer : Employee
    {
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            Console.WriteLine("Zarabia 3000 PLN");
        }
    }

    internal class Secretary : Employee
    {
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            Console.WriteLine("Zarabia 2000 PLN");
        }
    }

    internal static class HR
    {
        public static List<Employee> CreateStaff()
        {
            return new List<Employee>
            {
                new Secretary { Name = "Anna" },
                new Secretary { Name = "Ewa" },
                new Programmer { Name = "Jan" },
                new Director { Name = "Marek" }
            };
        }

        public static void CalculateStaffSalary(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                employee.CalculateSalary();

                if (employee is Director director)
                {
                    director.GetBonus();
                }
            }
        }
    }
}
