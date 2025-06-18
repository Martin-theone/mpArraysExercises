using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class HousePattern
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());  // Read the height of the house

            // Print the top half of the house (roof)
            for (int i = 1; i <= n; i += 2)
            {
                // Print leading spaces
                Console.Write(new string(' ', (n - i) / 2));

                // Print stars
                Console.WriteLine(new string('*', i));
            }

            // Print the bottom half of the house (walls)
            for (int i = 0; i < 2; i++)  // Two lines for walls
            {
                // Print leading spaces for the walls
                Console.Write(new string(' ', (n - 3) / 2));

                // Print the body of the walls
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }
        }
    }
}
