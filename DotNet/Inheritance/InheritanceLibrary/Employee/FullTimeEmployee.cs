using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLibrary.Employee
{
    public class FullTimeEmployee : BaseEmployee
    {
        public int AnnualSalary { get; set; }
        
        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
