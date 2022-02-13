using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_work1
{
    class Logic
    {
        public static void Count(int x, int y)
        {
            if (x < y)
            {
                Count(x, y - 1);
                Console.WriteLine(y + " ");
            }

            if (x > y)
            {
                Count(x, y + 1);
                Console.WriteLine(y + " ");
            }
        }


    }
}
