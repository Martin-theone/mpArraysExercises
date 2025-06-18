using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Sumofvowels
    {
        public static void Run()
        {
            string text = Console.ReadLine();
            int sum = 0;
            foreach (char c in text.ToLower())
            {
                switch (c)
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
