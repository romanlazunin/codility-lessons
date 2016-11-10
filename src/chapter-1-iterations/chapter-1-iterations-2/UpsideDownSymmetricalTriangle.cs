using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1_iterations_2
{
    public class UpsideDownSymmetricalTriangle
    {
        public static string Print(int n)
        {
            var triangle = string.Empty;

            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    triangle += "  ";
                }

                for (int j = 0; j < 2 * i - 1; j++)
                {
                    triangle += '*';

                    if (j < 2 * i - 2)
                    {
                        triangle += ' ';
                    }
                }

                if (i > 1)
                {
                    triangle += Environment.NewLine;
                }
            }

            return triangle;
        }
    }
}
