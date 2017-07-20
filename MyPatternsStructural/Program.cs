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
            RemoteProxy rmProxy = new RemoteProxy();

            string cursulUSD = rmProxy.GetResponseFromServer(DateTime.Today, "840");
            string cursulUSD117 = rmProxy.GetResponseFromServer(new DateTime(2017, 07, 17), "840");
            Console.WriteLine(cursulUSD);
            Console.WriteLine(cursulUSD117);

            Console.ReadKey();
        }
    }
}
