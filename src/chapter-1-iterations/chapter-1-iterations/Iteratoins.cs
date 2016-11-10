using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1_iterations
{
    public class Iteratoins
    {
        public static double Factorial(int n)
        {
            double factorial = 1;

            for (int i = 1; i < n + 1; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
