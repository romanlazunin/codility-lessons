using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_trial_tasks_pit_depth
{
    class Program
    {
        static void Main(string[] args)
        {
            //var A = new int[] { };
            //var A = new int[] { 0 };
            //var A = new int[] { 0, 0 };
            //var A = new int[] { 0, 0, 0 };
            //var A = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            var A = new int[] { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 };
            
            if (A.Length < 3)
                Console.WriteLine(-1);

            int count = 0;
            int depth = 0;
                        
            for (int i = 0; i < A.Length - 2; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        bool truePit = true;

                        for (int m = i; m < j; m++)
                        {
                            if (!(A[m] > A[m + 1]))
                            {
                                truePit = false;
                            }
                        }

                        for (int m = j; m < k; m++)
                        {
                            if (!(A[m] < A[m + 1]))
                            {
                                truePit = false;
                            }
                        }

                        if (!truePit)
                        {
                            continue;
                        }

                        var currentDepth = Math.Min(A[i] - A[j], A[k] - A[j]);
                        depth = Math.Max(depth, currentDepth);
                        count++;
                        //Console.Write(A[i] + " ");
                        //Console.Write(A[j] + " ");
                        //Console.Write(A[k] + " ");
                        //Console.WriteLine();
                    }
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(depth);
        }
    }
}
