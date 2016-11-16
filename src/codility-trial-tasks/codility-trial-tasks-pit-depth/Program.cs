using System;
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
            var A = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            
            if (A.Length < 3)
                Console.WriteLine(-1);

            int count = 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        count++;
                        //Console.Write(A[i] + " ");
                        //Console.Write(A[j] + " ");
                        //Console.Write(A[k] + " ");
                        //Console.WriteLine();
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
