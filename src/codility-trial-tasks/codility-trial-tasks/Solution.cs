using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_trial_tasks
{
    public class Solution
    {
        public int Run(int[] A)
        {
            int n = A.Length;
            int[] L = new int[n + 1];
            L[0] = -1;
            for (int i = 0; i < n; i++)
            {
                L[i + 1] = A[i];
            }
            int count = 1;
            int pos = (n + 2) / 2;

            int candidate = L[pos];
            for (int i = 1; i <= n; i++)
            {
                if (L[i] == candidate)
                    count = count + 1;
            }
            if (count > pos)
                return candidate;
            return (-1);
        }
    }
}
