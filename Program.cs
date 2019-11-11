using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Program
    {
        static void TimeAndRunGetPriceRight(int input)
        {
            var watchDynamisk = System.Diagnostics.Stopwatch.StartNew();
            int dynamiskInt = Dynamisk.GetPriceRight(input, values);
            watchDynamisk.Stop();
            Console.WriteLine("Bedste Pris Dynamisk: " + dynamiskInt + "og tog " + watchDynamisk.ElapsedMilliseconds + " Ms");
            var watchRekusiv = System.Diagnostics.Stopwatch.StartNew();
            int rekusivInt = Rekrusiv.GetPriceRight(input, values);
            watchRekusiv.Stop();
            Console.WriteLine("Bedste Pris Recursiv: " + rekusivInt + "og tog " + watchRekusiv.ElapsedMilliseconds + " Ms");
        }

        static Dictionary<int, int> values = new Dictionary<int, int>
        {
            {1,  1},
            {13, 140},
            {30, 300}
        };

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            TimeAndRunGetPriceRight(int.Parse(input));
            /*Console.WriteLine("Bedste Pris Recursiv: " + Rekrusiv.GetPriceRight(int.Parse(input), values));
            Console.WriteLine("Bedste Pris Dynamisk: " + Dynamisk.GetPriceRight(int.Parse(input), values));*/
            Console.ReadKey();
        }
    }
}
