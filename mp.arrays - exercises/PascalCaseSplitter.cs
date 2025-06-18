using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class PascalCaseSplitter
    {
        public static void Run()
        {
            string input = Console.ReadLine();
            string[] words = Regex.Split(input, @"(?=[A-Z])");
            Console.WriteLine(string.Join(", ", words));
        }
    }
}