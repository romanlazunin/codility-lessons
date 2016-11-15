using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_demo_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[] { 0, 0 };
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");

                if (i == A.Length - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}