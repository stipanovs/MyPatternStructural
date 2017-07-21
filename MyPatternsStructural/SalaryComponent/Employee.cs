using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternsStructural.SalaryComponent
{
    class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }

        private double _salaryBase = 15000;

        public readonly ISalarySuppliment _salary; 


        public Employee(string fisrtName, string lastName)
        {
            FirstName = fisrtName;
            LastName = lastName;
            _salary = new SalaryBase(_salaryBase);

        }
        public double CalculateSalary(ISalarySuppliment salarySuppliment)
        {
            
            salarySuppliment.AddComponent();
            return salarySuppliment.SalaryCalc();
        }
    }
}
