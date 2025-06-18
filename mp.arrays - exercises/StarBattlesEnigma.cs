using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class StarBattlesEnigma
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encrypted = Console.ReadLine();
                int key = encrypted.Count(c => "starSTAR".Contains(c));

                StringBuilder decrypted = new StringBuilder();
                foreach (char c in encrypted)
                {
                    decrypted.Append((char)(c - key));
                }

                string decryptedMessage = decrypted.ToString();
                Console.WriteLine("Decrypted: " + decryptedMessage); // Debug line

                string pattern = @"@(?<planet>[A-Za-z]+)[^@!:>-]*:(?<population>\d+)[^@!:>-]*!(?<attack>[AD])![^@!:>-]*->(?<soldiers>\d+)";
                Match match = Regex.Match(decryptedMessage, pattern);

                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    string attackType = match.Groups["attack"].Value;

                    if (attackType == "A") attacked.Add(planet);
                    else if (attackType == "D") destroyed.Add(planet);
                }
                else
                {
                    Console.WriteLine("No match found in decrypted message.");
                }
            }

            attacked.Sort();
            destroyed.Sort();

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (string name in attacked)
                Console.WriteLine($"-> {name}");

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (string name in destroyed)
                Console.WriteLine($"-> {name}");
        }
    }
}