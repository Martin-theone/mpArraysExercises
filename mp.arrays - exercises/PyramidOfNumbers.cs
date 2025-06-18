using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class PyramidOfNumbers
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());  // Read the number of rows

            int currentNum = 1;

            // Print the pyramid rows
            for (int i = 1; i <= n; i++)
            {
                // Print spaces for alignment
                Console.Write(new string(' ', n - i));

                // Print the numbers in the current row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;
                }
                Console.WriteLine();
            }
        }
    }
}
