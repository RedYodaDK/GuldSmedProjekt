using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Rekrusiv
    {
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
    }
}
