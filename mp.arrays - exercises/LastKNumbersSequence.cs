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
        class LastKNumbersSequence
        {
            public static void GenerateLastKNumbers(int n, int k)
            {
                List<int> sequence = new List<int> { 1 };

                for (int i = 1; i < n; i++)
                {
                    int sum = 0;
                    int start = Math.Max(0, sequence.Count - k);
                    for (int j = start; j < sequence.Count; j++)
                    {
                        sum += sequence[j];
                    }
                    sequence.Add(sum);
                }

                Console.WriteLine(string.Join(" ", sequence));  // Print the sequence
            }

            public static void Run()
            {
                int n = int.Parse(Console.ReadLine());  // Input n
                int k = int.Parse(Console.ReadLine());  // Input k
                GenerateLastKNumbers(n, k);  // Generate and print the sequence
            }
        }
    }
}

