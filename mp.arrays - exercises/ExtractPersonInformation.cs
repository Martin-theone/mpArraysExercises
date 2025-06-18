using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class ExtractPersonInformation
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                int startName = line.IndexOf('@') + 1;
                int endName = line.IndexOf('|');
                string name = line.Substring(startName, endName - startName);

                int startAge = line.IndexOf('#') + 1;
                int endAge = line.IndexOf('*');
                string age = line.Substring(startAge, endAge - startAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}