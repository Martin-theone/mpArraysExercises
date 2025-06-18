using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class SpecialNumbers
    {
        public static void Run()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Running...\n");

            for (int num = 1111; num <= 9999; num++)
            {
                int temp = num;
                bool isSpecial = true;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    if (digit == 0 || n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    temp /= 10;
                }

                if (isSpecial)
                {
                    Console.WriteLine(num);
                }

                // Stop at nnnn (like 2222 for n=2)
                if (n >= 1 && n <= 9) // Only valid for single digit n
                {
                    int stopAt = int.Parse(new string(n.ToString()[0], 4));
                    if (num == stopAt)
                    {
                        break;
                    }
                }
            }
        }
    }
}
     
