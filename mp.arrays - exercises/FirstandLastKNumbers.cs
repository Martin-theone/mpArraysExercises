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
        class FirstandLastKNumbers
        {
            public static void PrintFirstAndLastKNumbers(int[] arr, int k)
            {
                // Print first k elements
                Console.WriteLine(string.Join(" ", arr.Take(k)));

                // Print last k elements
                Console.WriteLine(string.Join(" ", arr.Skip(arr.Length - k)));
            }

            public static void Run()
            {
                int k = int.Parse(Console.ReadLine());  // Input k
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);  // Input the array
                PrintFirstAndLastKNumbers(arr, k);  // Call the function to print first and last k elements
            }
        }
    }
}

