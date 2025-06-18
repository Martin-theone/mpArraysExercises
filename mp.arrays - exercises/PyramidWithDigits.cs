using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class PyramidWithDigits
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());  // Read the number of rows

            // Iterate through each row
            for (int i = 1; i <= n; i++)
            {
                // Print leading spaces for alignment
                Console.Write(new string(' ', n - i));

                // Print the increasing part of the pyramid
                for (int j = i; j < 2 * i; j++)
                {
                    Console.Write(j);
                }

                // Print the decreasing part of the pyramid
                for (int j = 2 * i - 2; j >= i; j--)
                {
                    Console.Write(j);
                }

                // Move to the next line after each row
                Console.WriteLine();
            }
        }
    }
}
