using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Rekrusiv
    {
        public static int GetPriceRight(int length)
        {
            int temp = 0;

            if (length == 0)
            {
                return 0;
            }

            if (length < 0)
            {
                return int.MinValue;
            }

            if (length < 13)
            {
                temp = 1;
            }

            if (length < 30)
            {
                if (temp < 140)
                {
                    temp = 140;
                }
            }

            if (length > 30)
            {
                if (temp < 300)
                {
                    temp = 300;
                }
            }

            int one = GetPriceRight(length - 1)+1;
            int arm = GetPriceRight(length - 13)+140;
            int hals = GetPriceRight(length - 30)+300;

            if (hals > arm && hals > one)
            {
                return hals;
            }
            else if (arm > one && arm > hals)
            {
                return arm;
            }
            else
            {
                return one;
            }

            

        }
        /*
        public static int GetBestPriceForChain(int length)
        {
            if (length <= 0)
            {
                return 0;
            } 
            else if (length > 30)
            {
                return 301 + GetBestPriceForChain(length - 31);
            }
            else if (length > 13)
            {
                return 101 + GetBestPriceForChain(length - 14);
            }
            else
            {
                return length;
            }
        }
        */
    }
}
