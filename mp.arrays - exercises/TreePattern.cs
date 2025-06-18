using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class TreePattern
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', 2 * i - 1).PadLeft(n + i - 1));
            }
            Console.WriteLine(new string('*', 1).PadLeft(n));
        }
    }
}
