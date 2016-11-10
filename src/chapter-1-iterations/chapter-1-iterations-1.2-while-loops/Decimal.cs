using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1_iterations_1._2_while_loops
{
    public class Decimal
    {
        public static int CountDigits(int n)
        {
            var count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }

            return count;
        }
    }
}
