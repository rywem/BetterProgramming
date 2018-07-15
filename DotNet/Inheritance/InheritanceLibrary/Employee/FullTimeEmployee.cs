using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLibrary.Employee
{
    public class FullTimeEmployee : BaseEmployee
    {
        //public int ID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int AnnualSalary { get; set; }
        //public string GetFullName()
        //{
        //    return this.FirstName + " " + LastName;
        //}

        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
