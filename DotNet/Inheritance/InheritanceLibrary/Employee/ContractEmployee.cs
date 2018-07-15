using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLibrary.Employee
{
    public class ContractEmployee : BaseEmployee
    {        
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHours;
        }
    }
}
