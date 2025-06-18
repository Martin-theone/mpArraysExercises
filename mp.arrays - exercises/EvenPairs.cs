using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class EvenPairs
    {
        public static void Run()
        {
            int start1 = int.Parse(Console.ReadLine());
            int start2 = int.Parse(Console.ReadLine());
            int diff1 = int.Parse(Console.ReadLine());
            int diff2 = int.Parse(Console.ReadLine());

            for (int i = start1; i <= start1 + diff1; i++)
            {
                for (int j = start2; j <= start2 + diff2; j++)
                {
                    if (IsPrime(i) && IsPrime(j))
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
