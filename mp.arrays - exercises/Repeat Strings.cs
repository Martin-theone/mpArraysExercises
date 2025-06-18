using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class Repeat_Strings
    {
        public static void Run()
        {
            string[] input = Console.ReadLine().Split();
            string result = string.Empty;

            foreach (var word in input)
            {
                result += new string(word.SelectMany(c => Enumerable.Repeat(c, word.Length)).ToArray());
            }

            Console.WriteLine(result);
        }
    }
}