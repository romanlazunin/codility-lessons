using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_demo_test
{
    public class Solution
    {
        public int Run(int[] A)
        {
            double leftSum = 0;
            double rightSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                rightSum += A[i];
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                {
                    leftSum = 0;
                }
                else
                {
                    leftSum += A[i - 1];
                }

                if (i == A.Length - 1)
                {
                    rightSum = 0;
                }
                else
                {
                    rightSum -= A[i];
                }

                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
