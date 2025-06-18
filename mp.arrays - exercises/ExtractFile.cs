using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    public class ExtractFile
    {
        public static void Run()
        {
            string path = Console.ReadLine();
            string file = path.Substring(path.LastIndexOf('\\') + 1);
            string fileName = file.Substring(0, file.LastIndexOf('.'));
            string extension = file.Substring(file.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}