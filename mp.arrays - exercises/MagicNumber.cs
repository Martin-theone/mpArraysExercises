using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class MagicNumber
    {
        public static void Run()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int count = 0;
            bool found = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Combination {count} - ({i} + {j} = {magic})");
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
        }
    }
}
