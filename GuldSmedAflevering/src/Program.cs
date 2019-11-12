using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Program
    {
        static string PrittyFormatResult(int number, long ms)
        {
            return String.Format("Bedste Pris Dynamisk: {0}\nUdregnet på {1} Ms\n", number, ms);
        }

        static void TimeAndRunGetPriceRight(int input)
        {
            var watchDynamisk = System.Diagnostics.Stopwatch.StartNew();
            int dynamiskInt = Dynamisk.GetPriceRight(input, values);
            watchDynamisk.Stop();
            Console.WriteLine(PrittyFormatResult(dynamiskInt, watchDynamisk.ElapsedMilliseconds));
            var watchRekusiv = System.Diagnostics.Stopwatch.StartNew();
            int rekusivInt = Rekrusiv.GetPriceRight(input, values);
            watchRekusiv.Stop();
            Console.WriteLine(PrittyFormatResult(rekusivInt, watchRekusiv.ElapsedMilliseconds));
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
            while (input != "end")
            {
                if (int.TryParse(input, out int i))
                {
                    TimeAndRunGetPriceRight(i);
                }
                input = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
