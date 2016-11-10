using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1_iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chapter-1 - iterations - example 1");

            var n = 100;

            var factorial = Iteratoins.Factorial(n);

            Console.WriteLine($"Factorial from {n} is {factorial}. {n}! = {factorial}");
        }
    }
}
