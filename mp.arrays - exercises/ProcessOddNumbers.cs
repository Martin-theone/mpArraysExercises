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
        class ProcessOddNumbers1
        {
            public static void ProcessOddNumbers(int[] arr)
            {
                var oddPositionElements = new List<int>();

                for (int i = 1; i < arr.Length; i += 2)
                {
                    oddPositionElements.Add(arr[i] * 2);  // Double the element at odd positions
                }

                oddPositionElements.Reverse();  // Reverse the list
                Console.WriteLine(string.Join(" ", oddPositionElements));  // Print the result
            }

            public static void Run()
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);  // Input the array
                ProcessOddNumbers(arr);  // Process the odd elements
            }
        }
    }
}

