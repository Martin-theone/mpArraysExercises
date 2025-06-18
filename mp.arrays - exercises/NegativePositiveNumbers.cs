using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{

    using System;
    using System.Collections.Generic;

    namespace ArraysExample
    {
        class NegativePositiveNumbers
        {
            public static void ProcessNumbers(int[] arr)
            {
                List<int> result = new List<int>();

                // Prepend negative numbers
                foreach (int num in arr)
                {
                    if (num < 0)
                    {
                        result.Insert(0, num);
                    }
                    else
                    {
                        result.Add(num);
                    }
                }

                // Print the final result
                Console.WriteLine(string.Join(" ", result));
            }

            public static void Run()
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
                ProcessNumbers(arr);  // Process the array
            }
        }
    }
}

