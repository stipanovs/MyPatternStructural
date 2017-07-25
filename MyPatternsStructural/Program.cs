using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPatternsStructural.SalaryComponent;
using MyPatternsStructural.SalaryComponent.Bonus;

namespace MyPatternsStructural
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Proxy

            ICurrencyExchangeRate rmProxy = new ExchangeRateProxy();

            string usdExchangeRate = rmProxy.USDExchangeRate;
            Console.WriteLine("USD Exchange Rate for date: " + DateTime.Now.ToShortDateString() + " is: " + usdExchangeRate);

            string eurExchangeRate = rmProxy.EURExchangeRate;
            Console.WriteLine("EUR Exchange Rate for date: " + DateTime.Now.ToShortDateString() + " is: " + eurExchangeRate);

            string uahExchangeRate = rmProxy.UAHExchangeRate;
            Console.WriteLine("UAH Exchange Rate for date: " + DateTime.Now.ToShortDateString() + " is: " + uahExchangeRate);

            string rubExchangeRate = rmProxy.RUBExchangeRate;
            Console.WriteLine("RUB Exchange Rate for date: " + DateTime.Now.ToShortDateString() + " is: " + rubExchangeRate);

            string ronExchangeRate = rmProxy.RONExchangeRate;
            Console.WriteLine("RON Exchange Rate for date: " + DateTime.Now.ToShortDateString() + " is: " + ronExchangeRate);


            #endregion

            #region SalaryDecorator

            //Employee employee1 = new Employee("Sergiu", "Stipanov");
            //ISalarySuppliment salary = employee1._salary;
            //salary = new BirthDayBonus(salary);
            //salary = new SalesBonus(salary);
            //salary = new YearlyBonus(salary);

            //double salaryAmount = employee1.CalculateSalary(salary);
            //Console.WriteLine("Salary Amount: " + salaryAmount);


            #endregion

            Console.ReadKey();
        }
    }
}
