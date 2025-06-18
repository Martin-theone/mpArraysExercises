using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    internal class Randomizer
    {
        static public void Run()
        {
            // Input string
            string input = "Just have fun with C#";

            // Split the input string into an array of words
            string[] words = input.Split(' ');

            // Create a random number generator
            Random rnd = new Random();

            // Shuffle the words using Fisher-Yates shuffle algorithm
            for (int i = words.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1); // Generate a random index between 0 and i
                                         // Swap the words at position i and j
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }

            // Print each word in the shuffled array on a new line
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
