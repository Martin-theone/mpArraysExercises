using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class AsciiSumator
    {
        public static void Run()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int sum = 0;
            foreach (char c in input)
            {
                if (c > start && c < end)
                {
                    sum += c;
                }
            }

            Console.WriteLine(sum);
        }
    }
}