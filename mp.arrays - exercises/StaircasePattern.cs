using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class StaircasePattern
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());  // Read the number of steps

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('#', i));  // Print i number of hashes on each row
            }
        }
    }
}
