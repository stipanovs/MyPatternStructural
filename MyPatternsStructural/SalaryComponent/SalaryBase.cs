using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternsStructural.SalaryComponent
{
    class SalaryBase : ISalarySuppliment
    {
        private double _baseSalary = 2000;

        public SalaryBase(double salary)
        {
            _baseSalary = salary;
        }
        public void AddComponent()
        {
            Console.WriteLine("Add base salary: " + _baseSalary);
        }
        public double SalaryCalc()
        {
            return _baseSalary;
        }
    }
}
