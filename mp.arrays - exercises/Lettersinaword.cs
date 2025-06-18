using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Lettersinaword
    {
        public static void Run()
        {
            string word = Console.ReadLine();
            foreach (char c in word)
            {
                Console.WriteLine(c);
            }
        }
    }
}
