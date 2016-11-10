using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1_iterations_1._2_while_loops
{
    public class WhileLoop
    {
        public static string Run(int n)
        {
            var result = string.Empty;
            var i = 0;
            while (i < n)
            {
                result += '*';
                i++;
            }

            return result;
        }
    }
}
