using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class MatchPhoneNumber
    {
        public static void Run()
        {
            string input = Console.ReadLine();
            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}