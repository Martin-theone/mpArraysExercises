using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class ValidUsernames
    {
        public static void Run()
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16 &&
                    username.All(ch => char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}