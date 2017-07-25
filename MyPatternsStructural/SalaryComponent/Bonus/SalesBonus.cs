using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternsStructural.SalaryComponent.Bonus
{
    class SalesBonus : ISalaryBonus
    {
        private readonly ISalarySuppliment _salarySupplement;
        private double _salesBonus = 2450;

        public SalesBonus(ISalarySuppliment salarySuppliment)
        {
            _salarySupplement = salarySuppliment;
        }
        public void AddComponent()
        {
            Console.WriteLine("Add Salary bonus from sales: " + _salesBonus);
            _salarySupplement.AddComponent();
        }

        public double SalaryCalc()
        {
            return _salesBonus + _salarySupplement.SalaryCalc();
        }
    }
}
