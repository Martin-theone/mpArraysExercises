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
        class LongestSequenceofIdenticalElements
        {
            public static void LongestSequence(int[] arr)
            {
                int longestCount = 1;
                int currentCount = 1;
                int startIndex = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] == arr[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        if (currentCount > longestCount)
                        {
                            longestCount = currentCount;
                            startIndex = i - currentCount;
                        }
                        currentCount = 1;
                    }
                }

                // In case the longest sequence is at the end
                if (currentCount > longestCount)
                {
                    longestCount = currentCount;
                    startIndex = arr.Length - currentCount;
                }

                // Print the longest sequence
                for (int i = startIndex; i < startIndex + longestCount; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            public static void Run()
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);  // Input the array
                LongestSequence(arr);  // Print the longest sequence
            }
        }
    }
}

