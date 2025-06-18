using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class CoinsAndNotes
    {
        public static void Run()
        {
            int ones = int.Parse(Console.ReadLine());
            int twos = int.Parse(Console.ReadLine());
            int fives = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= ones; i++)
            {
                for (int j = 0; j <= twos; j++)
                {
                    for (int k = 0; k <= fives; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
