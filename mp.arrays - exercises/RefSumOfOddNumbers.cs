using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class RefSumOfOddNumbers
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int odd = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(odd);
                sum += odd;
                odd += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
