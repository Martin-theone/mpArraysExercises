using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Rhombus
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            // Upper part of rhombus
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
            }

            // Lower part of rhombus
            for (int i = n - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
            }
        }
    }
}
