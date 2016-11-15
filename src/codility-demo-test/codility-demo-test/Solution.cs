using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_demo_test
{
    public class Solution
    {
        public bool Run(int n)
        {
            if (n >= 0 && n < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
