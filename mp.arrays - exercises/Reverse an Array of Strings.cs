using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises { 
using System;

namespace ArraysExample
{
    class ReverseStringArraya
    {
        public static void ReverseStringArray(string[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        public static void Run()
        {
            string[] arr = Console.ReadLine().Split(',');
            ReverseStringArray(arr);
        }
    }
}
}