using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Ass
    {
        public static void Run()
        {
            Console.WriteLine("Enter numbers with (,) separator:");
            string[] input = Console.ReadLine().Split(',');
            int first = int.Parse(input[0]);
            int last = int.Parse(input[input.Length - 1]);
            Console.WriteLine(first + last);
        }
    }
}