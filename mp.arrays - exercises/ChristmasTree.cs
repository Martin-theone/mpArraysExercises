using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class ChristmasTree
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine()); // Read the height of the tree

            // Loop through each row for the tree part (above the trunk)
            for (int i = 1; i <= n; i++)
            {
                // Print leading spaces to center the tree
                string spaces = new string(' ', n - i);

                // Print the left side of the tree (stars)
                string leftStars = new string('*', i);

                // Print the right side of the tree (stars)
                string rightStars = new string('*', i);

                // Print the row, with stars separated by "|"
                Console.WriteLine(spaces + leftStars + " | " + rightStars);
            }
        }
    }
}
