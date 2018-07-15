using System;
using InheritanceLibrary.Employee;
namespace InheritanceConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Joe",
                LastName = "Smith",
                AnnualSalary = 60000
            };

            Console.WriteLine($"Get full name: {fte.GetFullName()},  Annual Salary: {fte.GetMonthlySalary()}");
            Console.WriteLine("------------------------------------------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Sarah",
                LastName = "Jones",
                HourlyPay = 50,
                TotalHours = 40 * 4
            };

            Console.WriteLine($"Get full name: {cte.GetFullName()},  Annual Salary: {cte.GetMonthlySalary()}");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
