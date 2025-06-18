using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class NumberReversal
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            char[] digits = n.ToString().ToCharArray();
            Array.Reverse(digits);
            Console.WriteLine(new string(digits));
        }
    }
}
