using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPatternsStructural.SalaryComponent.Bonus;

namespace MyPatternsStructural.SalaryComponent
{
    class SalaryBuilder
    {
        public ISalarySuppliment SalarySet()
        {
            ISalarySuppliment salary = new SalaryBase(5600.00);
            salary = new SalesBonus(salary);
            salary = new BirthDayBonus(salary);
            salary = new YearlyBonus(salary);
            return salary;

        }
    }
}
