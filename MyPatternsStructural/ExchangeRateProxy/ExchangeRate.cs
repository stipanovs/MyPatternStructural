using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternsStructural
{
    class ExchangeRate : ICurrencyExchangeRate
    {
        // Return from local DB
        public string EURExchangeRate { get { return "20.00"; } }

        public string USDExchangeRate { get { return "18.00"; } }

        public string UAHExchangeRate { get { return "0.70"; } }

        public string RUBExchangeRate { get { return "0.33"; } }

        public string RONExchangeRate { get { return "4.55"; } }

    }
}
