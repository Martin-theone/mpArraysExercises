using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class LetterFiller
    {
        public static void Run()
        {
            string letter = Console.ReadLine();
            string[] replacements = Console.ReadLine()
                .Replace("[", "")
                .Replace("]", "")
                .Replace("'", "")
                .Split(", ");

            int replaceIndex = 0;
            while (letter.Contains("____"))
            {
                int startIndex = letter.IndexOf("____");
                int endIndex = startIndex + 4;
                string replacement = replacements[replaceIndex++];

                if (replacement.Length == 4)
                {
                    letter = letter.Substring(0, startIndex) + replacement + letter.Substring(endIndex);
                }
                else
                {
                    int underscores = 0;
                    while (startIndex - underscores >= 0 && letter[startIndex - underscores] == '_')
                    {
                        underscores++;
                    }

                    letter = letter.Remove(startIndex - underscores + 1, underscores + 3)
                        .Insert(startIndex - underscores + 1, replacement);
                }
            }

            Console.WriteLine(letter);
        }
    }
}