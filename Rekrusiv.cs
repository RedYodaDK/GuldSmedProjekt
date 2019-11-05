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
            if (length < 0)
            {
                return int.MinValue;
            }
            
            if (length == 0)
            {
                return 0;
            }

            foreach (int l in vals.Keys)
            {
                if (length == l)
                {
                    return vals[l];
                }
            }

            int arm = GetPriceRight(length - 14,vals)+vals[13]+vals[1];
            int hals = GetPriceRight(length - 31, vals) + vals[30] + vals[1];
            int one = vals[1] * length;

            if (hals >= arm && hals >= one)
            {
                return hals;
            }
            else if (arm >= one && arm >= hals)
            {
                return arm;
            }
            else
            {
                return one;
            }
        }
    }
}
