using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class SumofEvenNumbers
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int evenCount = 0;
            int number = 2;

            while (evenCount < n)
            {
                sum += number;
                evenCount++;
                number += 2;
            }
            Console.WriteLine(sum);
        }
    }
}
