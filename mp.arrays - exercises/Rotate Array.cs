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
        class RotateArray1
        {
            public static void RotateArray(string[] arr, int rotations)
            {
                for (int i = 0; i < rotations; i++)
                {
                    string lastElement = arr[arr.Length - 1];
                    for (int j = arr.Length - 1; j > 0; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[0] = lastElement;
                }
                Console.WriteLine(string.Join(" ", arr));
            }

            public static void Run()
            {
                string[] arr = Console.ReadLine().Split(',');
                int rotations = int.Parse(Console.ReadLine());
                RotateArray(arr, rotations);
            }
        }
    }
}

