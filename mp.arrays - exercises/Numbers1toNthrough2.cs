using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Numbers1toNthrough2
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
