using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternsStructural.SalaryComponent.Bonus
{
    class YearlyBonus : ISalaryBonus
    {
        private readonly ISalarySuppliment _salarySupplement;
        private double __yearlyBonus = 7000;

        public YearlyBonus(ISalarySuppliment salarySuppliment)
        {
            _salarySupplement = salarySuppliment;

        }
        public void AddComponent()
        {
            Console.WriteLine("Add Yearly Bonus to salary: " + __yearlyBonus);
            _salarySupplement.AddComponent();
        }

        public double SalaryCalc()
        {

            return __yearlyBonus + _salarySupplement.SalaryCalc();
        }
    }
}
