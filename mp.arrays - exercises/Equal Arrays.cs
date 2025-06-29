﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    using System;

    namespace ArraysExample
    {
        class EqualArrays
        {
            public static void CompareArrays(string[] arr1, string[] arr2)
            {
                if (arr1.Length != arr2.Length)
                {
                    Console.WriteLine("Arrays are not identical.");
                    return;
                }

                int sum = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }
                    sum += int.Parse(arr1[i]);
                }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

            public static void Run()
            {
                string[] arr1 = Console.ReadLine().Split(',');
                string[] arr2 = Console.ReadLine().Split(',');
                CompareArrays(arr1, arr2);
            }
        }
    }
}

