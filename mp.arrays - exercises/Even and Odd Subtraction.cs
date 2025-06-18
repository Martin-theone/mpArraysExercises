using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{

    using System;

    namespace ArraysExample
    {
        class EvenandOddSubtraction
        {
            public static void EvenOddSubtraction(string[] arr)
            {
                int evenSum = 0, oddSum = 0;
                foreach (var s in arr)
                {
                    int num = int.Parse(s);
                    if (num % 2 == 0)
                        evenSum += num;
                    else
                        oddSum += num;
                }
                Console.WriteLine(evenSum - oddSum);
            }

            public static void Run()
            {
                string[] arr = Console.ReadLine().Split(',');
                EvenOddSubtraction(arr);
            }
        }
    }
}

