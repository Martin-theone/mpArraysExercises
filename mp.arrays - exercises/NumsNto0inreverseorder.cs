using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class NumsNto0inreverseorder
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

