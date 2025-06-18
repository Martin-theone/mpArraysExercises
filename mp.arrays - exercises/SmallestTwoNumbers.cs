using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{

    using System;
    using System.Linq;

    namespace ArraysExample
    {
        class SmallestTwoNumbers
        {
            public static void PrintSmallestTwoNumbers(int[] arr)
            {
                var smallestTwo = arr.OrderBy(x => x).Take(2);  // Sort and take the first two smallest elements
                Console.WriteLine(string.Join(" ", smallestTwo));  // Print the smallest two numbers
            }

            public static void Run()
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);  // Input the array
                PrintSmallestTwoNumbers(arr);  // Print the smallest two numbers
            }
        }
    }
}

