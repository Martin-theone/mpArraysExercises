    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Pyramid
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            for (int row = 1; ; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (current > n) return;
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
            }
        }
    }
}
