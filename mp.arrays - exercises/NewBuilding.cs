using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class NewBuilding
    {
        public static void Run()
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int f = floors; f >= 1; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f == floors)
                        Console.Write($"L{f}{r} ");
                    else if (f % 2 == 0)
                        Console.Write($"O{f}{r} ");
                    else
                        Console.Write($"A{f}{r} ");
                }
                Console.WriteLine();
            }
        }
    }
}
