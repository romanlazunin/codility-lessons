using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1_iterations_2
{
    public class Triangle
    {
        public static string Print(int n)
        {
            var triangle = "";

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    triangle += '*';

                    if (j < i - 1)
                    {
                        triangle += ' ';
                    }
                }

                if (i < n)
                {
                    triangle += Environment.NewLine;
                }
            }

            return triangle;
        }
    }
}
