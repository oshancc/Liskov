using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager();
            manager1.FirstName = "shane";
            manager1.LastName = "watson";
            manager1.CalculatePerHourRate(4);

            Employee emp = new Manager();
            emp.FirstName = "Steven";
            emp.LastName = "Smith";
            emp.AssignManager(manager1);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName}'s salary is ${emp.Salary}/hour");

            Console.ReadLine();
        }
    }
}
