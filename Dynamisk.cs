using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuldSmed
{
    class Dynamisk
    {
        public static int GetPriceRight(int length, Dictionary<int, int> vals)
        {
            if (length <= 0)
            {
                return 0;
            }

            int[] memory = new int[length + 1];

            for (int i = 1; i <= length; i++)
            {
                memory[i] = memory[i-1] + vals[1];

                if (i == 13)
                {
                    memory[i] = memory[i - 13] + vals[13];
                }


                if (i > 13)
                {
                    if (memory[i] < memory[i - 14] + vals[13] + vals[1])
                    {
                        memory[i] = memory[i - 14] + vals[13] + vals[1];
                    }
                }

                if (i == 30)
                {
                    memory[i] = memory[i - 30] + vals[30];
                }


                if (i > 30)
                {
                    if (memory[i] < memory[i - 31] + vals[30] + vals[1])
                    {
                        memory[i] = memory[i - 31] + vals[30] + vals[1];
                    }
                    
                }

            }

            return memory[length];

        }

    }
}
