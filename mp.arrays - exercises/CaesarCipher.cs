using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class CaesarCipher
    {
        public static void Run()
        {
            string input = Console.ReadLine();
            string encrypted = string.Empty;

            foreach (char ch in input)
            {
                encrypted += (char)(ch + 3);
            }

            Console.WriteLine(encrypted);
        }
    }
}