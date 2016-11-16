using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility_trial_tasks_pit_depth
{
    public class Solution
    {
        public int Run(int[] A)
        {
            if (A.Length < 3)
                return -1;

            for (int i = 0; i < A.Length - 2; i++)
            {
                Console.Write(A[i] + " ");
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    Console.Write(A[j] + " ");
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        Console.Write(A[k] + " ");
                    }
                }
                Console.WriteLine();
            }

            return -1;
        }
    }
}
