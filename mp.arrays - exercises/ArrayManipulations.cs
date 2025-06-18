using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{

    using System;
    using System.Collections.Generic;

    namespace ArraysExample
    {
        class ArrayManipulations
        {
            public static void ManipulateArray(ref List<int> arr, string command)
            {
                var commandParts = command.Split();
                string action = commandParts[0];

                if (action == "Add")
                {
                    arr.Add(int.Parse(commandParts[1]));  // Add the number to the end
                }
                else if (action == "Remove")
                {
                    arr.Remove(int.Parse(commandParts[1]));  // Remove the specific number
                }
                else if (action == "RemoveAt")
                {
                    arr.RemoveAt(int.Parse(commandParts[1]));  // Remove the number at specific index
                }
                else if (action == "Insert")
                {
                    arr.Insert(int.Parse(commandParts[2]), int.Parse(commandParts[1]));  // Insert at specific index
                }
            }

            public static void Run()
            {
                List<int> arr = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));  // Input the array
                string command;
                while ((command = Console.ReadLine()) != "end")
                {
                    ManipulateArray(ref arr, command);  // Execute commands
                }

                Console.WriteLine(string.Join(" ", arr));  // Print the manipulated array
            }
        }
    }
}
