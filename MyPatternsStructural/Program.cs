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
            rmProxy.GetResponseFromServer("dfsaf", DateTime.Today);
            Console.ReadKey();
        }
    }
}
