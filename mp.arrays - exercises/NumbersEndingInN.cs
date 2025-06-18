using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class NumbersEndingInN
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == n)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
