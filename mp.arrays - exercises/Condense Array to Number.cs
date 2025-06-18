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
        class CondenseArraytoNumber
        {
            public static void CondenseArray(int[] arr)
            {
                while (arr.Length > 1)
                {
                    int[] condensed = new int[arr.Length - 1];
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        condensed[i] = arr[i] + arr[i + 1];
                    }
                    arr = condensed;
                }
                Console.WriteLine(arr[0]);
            }

            public static void Run()
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
                CondenseArray(arr);
            }
        }
    }
}

