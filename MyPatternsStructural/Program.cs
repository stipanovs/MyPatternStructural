using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternsStructural
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Proxy
            ExchangeRateProxy rmProxy = new ExchangeRateProxy();

            string usdExchangeRate = rmProxy.USDExchangeRate;
            Console.WriteLine("USD Exchange Rate for " + DateTime.Now.ToShortDateString() + " is: " + usdExchangeRate);

            string eurExchangeRate = rmProxy.EURExchangeRate;
            Console.WriteLine("EUR Exchange Rate for " + DateTime.Now.ToShortDateString() + " is: " + eurExchangeRate);

            string uahExchangeRate = rmProxy.UAHExchangeRate;
            Console.WriteLine("UAH Exchange Rate for " + DateTime.Now.ToShortDateString() + " is: " + uahExchangeRate);

            string rubExchangeRate = rmProxy.RUBExchangeRate;
            Console.WriteLine("RUB Exchange Rate for " + DateTime.Now.ToShortDateString() + " is: " + rubExchangeRate);

            string ronExchangeRate = rmProxy.RONExchangeRate;
            Console.WriteLine("RUB Exchange Rate for " + DateTime.Now.ToShortDateString() + " is: " + ronExchangeRate);
            
            #endregion







            Console.ReadKey();
        }
    }
}
