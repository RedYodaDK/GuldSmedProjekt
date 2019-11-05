using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Rekrusiv
    {
        public static int GetPriceRight(int length, Dictionary<int, int> vals)
        {
            if (length == 0)
            {
                return 0;
            }

            if (length < 0)
            {
                return int.MinValue;
            }

            if (length == 13)
            {
                return 140;
            }

            if (length == 30)
            {
                return 300;
            }

            int arm = GetPriceRight(length - 14,vals)+vals[13]+vals[1];
            int hals = GetPriceRight(length - 31, vals) + vals[30] + vals[1];

            if (hals >= arm && hals >= length)
            {
                return hals;
            }
            else if (arm >= length && arm >= hals)
            {
                return arm;
            }
            else
            {
                return length;
            }
        }
    }
}
