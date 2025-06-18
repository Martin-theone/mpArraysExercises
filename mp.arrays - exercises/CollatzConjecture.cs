using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class CollatzConjecture
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            while (n != 1)
            {
                Console.Write(n + " ");
                n = n % 2 == 0 ? n / 2 : 3 * n + 1;
            }
            Console.WriteLine("1");
        }
    }

}
