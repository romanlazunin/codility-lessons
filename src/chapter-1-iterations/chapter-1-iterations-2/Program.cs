using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1_iterations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chapter-1 - iterations - example 2");
            Console.WriteLine();

            var n = 4;

            Console.WriteLine(Triangle.Print(n));

            Console.WriteLine();

            Console.WriteLine("Upside down symmetrical triangle");
            Console.WriteLine();

            Console.WriteLine(UpsideDownSymmetricalTriangle.Print(n));
        }
    }
}
