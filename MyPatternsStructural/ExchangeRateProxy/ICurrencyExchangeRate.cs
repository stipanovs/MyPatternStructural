using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternsStructural
{
    interface ICurrencyExchangeRate
    {
        string EURExchangeRate { get; }
        string USDExchangeRate { get; }
        string UAHExchangeRate { get; }
        string RUBExchangeRate { get; }
        string RONExchangeRate { get; }
    }
}
