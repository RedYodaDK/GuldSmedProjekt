using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("Best Price Rekrusiv: " + Rekrusiv.GetBestPriceForChain(int.Parse(input)));
            Console.WriteLine("Best Price Dynamisk: " + Dynamisk.GetBestPriceForChain(int.Parse(input)));
            Console.ReadKey();
        }
    }
}
