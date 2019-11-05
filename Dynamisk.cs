using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Dynamisk
    {
        public static int GetPriceRight(int length)
        {
            int before = 0;
            int temp = 0;

            for (int i = 1; i < length; i++)
            {
                if (i < 30)
                {
                    if (i < 1)
                    {
                        temp = 1;
                    }
                    else
                    {
                        temp = 140;
                    }
                }
                else
                {
                    temp = 300;
                }

                before += temp;
            }






        }






    }
}
