using System;
using System.Collections.Generic;
using Exerc_HP.Entities;
using System.Globalization;

namespace Exerc_HP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício sobre Polimorfismo

            List<Employee> list = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valuehours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hours, valuehours, additionalcharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuehours));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
