using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises { 
using System;

namespace ArraysExample
{
    class ReverseanArrayofNumbers
    {
        public static void ReverseArray(int n, int[] arr)
        {
            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[i] = arr[n - 1 - i];
            }
            Console.WriteLine(string.Join(" ", reversed));
        }

        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());  // Read number of elements to reverse
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse); // Read the array input and parse to integers
            ReverseArray(n, arr);  // Call the function to reverse and print the array
        }
    }
}
}