using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class SquareFrame
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            // Top row
            Console.WriteLine("+" + new string('-', n - 2) + "+");

            // Middle rows
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|" + new string('-', n - 2) + "|");
            }

            // Bottom row
            Console.WriteLine("+" + new string('-', n - 2) + "+");
        }
    }
}
