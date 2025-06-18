using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Sunglasses
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine()); // Read the size of the sunglasses

            // Print the top row of the sunglasses
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

            // Print the middle part of the sunglasses
            for (int i = 0; i < n - 2; i++)
            {
                // The first and second half of the middle part
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*");
            }

            // Print the middle row with vertical bars ('|')
            if (n > 2)
            {
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string('|', n) + "*" + new string('/', 2 * n - 2) + "*");
            }

            // Print the bottom row of the sunglasses
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}
