using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4Sec4
{
    internal class Employe
    {

        public string Name;
        public double Salary;
        public double Taxes;
        public double Percent;

        public string General()
        {
            double fullSalary = Salary - Taxes;
            return Name + ", $" + double.Parse(fullSalary.ToString("F2"));
        }

        public double RaiseSalary()
        {
            double dream = Salary = Salary + (Salary * Percent / 100);
            return dream - Taxes;
        }

    }
}
