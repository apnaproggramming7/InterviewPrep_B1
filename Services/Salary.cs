using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public abstract class SalaryAbstract
    {
        public abstract void GetSalary();
    }

    public class Salary : SalaryAbstract
    {
        public override void GetSalary()
        {
            Console.WriteLine("Salary from Salary Class");
        }
    }
}
