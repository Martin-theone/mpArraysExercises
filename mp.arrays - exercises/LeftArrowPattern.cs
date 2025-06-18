using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class LeftArrowPattern
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());  // Read the number of rows

            // Print the top part (the left half of the arrow pointing left)
            for (int i = 1; i <= n; i++)
            {
                // Print spaces followed by stars
                Console.WriteLine(new string(' ', n - i) + new string('*', i));
            }

            // Print the bottom part (reverse of the top part)
            for (int i = n - 1; i >= 1; i--)
            {
                // Print spaces followed by stars (in reverse order)
                Console.WriteLine(new string(' ', n - i) + new string('*', i));
            }
        }
    }
}
