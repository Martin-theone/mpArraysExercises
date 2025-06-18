using System;

namespace mp.arrays___exercises
{
    public class Substring
    {
        public static void Run()
        {
            string toRemove = Console.ReadLine();
            string input = Console.ReadLine();

            while (input.Contains(toRemove))
            {
                input = input.Replace(toRemove, "");
            }

            Console.WriteLine(input);
        }
    }
}
