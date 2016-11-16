using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_trial_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // {-1}, 0
            Console.WriteLine((0 + 1) / 2);
            // { -1, 0 }, 1
            Console.WriteLine((1 + 1) / 2);
            // { -1, 0, 0 }, 1
            Console.WriteLine((2 + 1) / 2);
            // { -1, 0, 0, 0 }, 2
            Console.WriteLine((3 + 1) / 2);
            // { -1, 0, 0, 0, 0 }, 2
            Console.WriteLine((4 + 1) / 2);


            var a = new int[] { 0 };
            var result = new Solution().Run(a);
            Console.WriteLine(result);

            a = new int[] { 0, 0 };
            result = new Solution().Run(a);
            Console.WriteLine(result);

            a = new int[] { 0, 0, 0 };
            result = new Solution().Run(a);
            Console.WriteLine(result);

            a = new int[] { 1 };
            result = new Solution().Run(a);
            Console.WriteLine(result);

            a = new int[] { };
            result = new Solution().Run(a);
            Console.WriteLine(result);



        }
    }
}
