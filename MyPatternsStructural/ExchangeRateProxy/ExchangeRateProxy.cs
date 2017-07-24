using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace MyPatternsStructural
{
    class ExchangeRateProxy : ICurrencyExchangeRate
    {
        private ExchangeRate _exgangeRate;

        public ExchangeRateProxy()
        {
            _exgangeRate = new ExchangeRate();
        }
        public string EURExchangeRate{ get { return _exgangeRate.EURExchangeRate; }}

        public string USDExchangeRate { get { return _exgangeRate.USDExchangeRate; }}

        public string UAHExchangeRate { get { return _exgangeRate.UAHExchangeRate; }}

        public string RUBExchangeRate { get { return _exgangeRate.RUBExchangeRate; }}

        public string RONExchangeRate { get { return _exgangeRate.RONExchangeRate; }}

        public double ExchangeEurSum(double sum)
        {
            return double.Parse(EURExchangeRate) * sum;
        }

        public double ExchangeUSDSum(double sum)
        {
            return double.Parse(USDExchangeRate) * sum;
        }


    }
}
