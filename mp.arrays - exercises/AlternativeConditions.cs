using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class AlternativeConditions
    {
        public static void Run()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(); // Just for clean spacing

            int current = 1;
            int groupSize = 1;

            while (current <= n)
            {
                for (int i = 0; i < groupSize && current <= n; i++)
                {
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
                groupSize++;
            }
        }
    }
}