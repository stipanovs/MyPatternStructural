﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternsStructural.SalaryComponent.Bonus
{
    class BirthDayBonus : ISalaryBonus
    {
        private readonly ISalarySuppliment _salarySupplement;
        private double _birthDayBonus = 2500;

        public BirthDayBonus(ISalarySuppliment salarySuppliment)
        {
            _salarySupplement = salarySuppliment;

        }
        public void AddComponent()
        {
            Console.WriteLine("Add Birthday Bonus to salary: " + _birthDayBonus);
            _salarySupplement.AddComponent();
        }

        public double SalaryCalc()
        {

            return _birthDayBonus + _salarySupplement.SalaryCalc();
        }
    }
}
