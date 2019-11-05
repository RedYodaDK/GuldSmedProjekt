using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Program
    {
        static Dictionary<int, int> values = new Dictionary<int, int>
        {
            {1,  1},
            {13, 140},
            {30, 800}
        };

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("Best Price Recursiv: " + Rekrusiv.GetPriceRight(int.Parse(input), values));
            //Console.WriteLine("Best Price Dynamic: " + Dynamisk.GetPriceRight(int.Parse(input), values));
            Console.ReadKey();
        }
    }
}
