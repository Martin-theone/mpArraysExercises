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
        class ExtractaNonDecreasingSubsequencefromanArray
        {
            public static void ExtractNonDecreasingSubsequence(int[] arr)
            {
                int currentMax = arr[0];
                Console.Write(arr[0] + " ");
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] >= currentMax)
                    {
                        Console.Write(arr[i] + " ");
                        currentMax = arr[i];
                    }
                }
                Console.WriteLine();
            }

            public static void Run()
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
                ExtractNonDecreasingSubsequence(arr);
            }
        }
    }
}

