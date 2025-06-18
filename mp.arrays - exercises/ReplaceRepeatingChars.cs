using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class ReplaceRepeatingChars
    {
        public static void Run()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;

            char prev = input[0];
            Console.Write(prev);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != prev)
                {
                    Console.Write(input[i]);
                    prev = input[i];
                }
            }
            Console.WriteLine();
        }
    }
}