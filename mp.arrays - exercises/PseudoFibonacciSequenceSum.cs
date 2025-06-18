using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class PseudoFibonacciSequenceSum
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine(0);
                return;
            }

            int a = 1, b = 1, sum = n == 1 ? 1 : 2;

            for (int i = 2; i < n; i++)
            {
                int next = a + b;
                sum += next;
                a = b;
                b = next;
            }

            Console.WriteLine(sum);
        }
    }
}
