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
        class PrinteveryNthElementfromanArray
        {
            public static void PrintNthElement(string[] arr, int n)
            {
                for (int i = n - 1; i < arr.Length; i += n)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }

            public static void Run()
            {
                string[] arr = Console.ReadLine().Split(',');
                int n = int.Parse(Console.ReadLine());
                PrintNthElement(arr, n);
            }
        }
    }
}
