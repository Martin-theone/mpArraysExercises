using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class Reverse_Strings
    {
        public static void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;

                char[] reversed = input.ToCharArray();
                Array.Reverse(reversed);

                Console.WriteLine($"{input} = {new string(reversed)}");
            }
        }
    }
}