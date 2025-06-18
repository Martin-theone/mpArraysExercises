using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class ArrowPattern
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());  // Read the number of rows

            // First part of the arrow (increasing rows of stars)
            for (int i = 1; i <= n; i++)
            {
                // Print leading spaces for alignment
                Console.Write(new string(' ', n - i));

                // Print stars with space in between
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                // Move to the next line
                Console.WriteLine();
            }

            // Second part of the arrow (constant rows of stars)
            for (int i = 0; i < n; i++)
            {
                // Print stars
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
