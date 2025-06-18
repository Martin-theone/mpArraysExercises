using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Encoding
    {
        public static void Run()
        {
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                int digit = num % 10;
                if (digit == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    char symbol = (char)(digit + 33);
                    Console.WriteLine(new string(symbol, digit));
                }
                num /= 10;
            }
        }
    }
}
