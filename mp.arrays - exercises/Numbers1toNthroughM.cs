using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Numbers1toNthroughM
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += m)
            {
                Console.WriteLine(i);
            }
        }
    }
}
