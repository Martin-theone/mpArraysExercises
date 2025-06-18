using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{

    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    namespace ArraysExample
    {
        class AddandRemoveElementsfromArray
        {
            public static void ModifyArray(List<int> list, string command)
            {
                string[] commandParts = command.Split();
                string operation = commandParts[0];
                if (operation == "add")
                {
                    list.Add(int.Parse(commandParts[1]));
                }
                else if (operation == "remove")
                {
                    list.RemoveAt(list.Count - 1);
                }
            }

            public static void Run()
            {
                List<int> list = new List<int>();
                list.Add(1); // Initial number

                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "end")
                    {
                        break;
                    }
                    ModifyArray(list, command);
                }

                if (list.Count == 0)
                    Console.WriteLine("Empty");
                else
                    Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}

