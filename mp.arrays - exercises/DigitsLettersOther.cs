using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class DigitsLettersOther
    {
        public static void Run()
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch)) digits += ch;
                else if (char.IsLetter(ch)) letters += ch;
                else others += ch;
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}