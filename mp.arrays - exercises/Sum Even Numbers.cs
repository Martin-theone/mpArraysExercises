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
        class SumEvenNumbersa
        {
            public static void SumEvenNumbers(string[] arr)
            {
                int sum = 0;
                foreach (var s in arr)
                {
                    int num = int.Parse(s);
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                }
                Console.WriteLine(sum);
            }

            public static void Run()
            {
                string[] arr = Console.ReadLine().Split(',');
                SumEvenNumbers(arr);
            }
        }
    }
}

