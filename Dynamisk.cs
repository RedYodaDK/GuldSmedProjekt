using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Dynamisk
    {

        public static int GetBestPriceForChain(int length)
        {
            int total = 0;
            while (length >0)
            {
                if (length >= 30)
                {
                    total += 301;
                    length -= 31;
                }
                else if (length >= 13)
                {
                    total += 101;
                    length -= 14;
                }
                else
                {
                    total += length;
                    length = 0;
                }
            }
            return total;
        }



    }
}
