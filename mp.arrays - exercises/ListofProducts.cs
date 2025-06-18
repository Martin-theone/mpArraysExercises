using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{

    using System;
    using System.Linq;

    namespace ArraysExample
    {
        class ListofProducts
        {
            public static void ListProducts(string[] products)
            {
                var sortedProducts = products.OrderBy(x => x).ToArray();  // Sort the products alphabetically
                for (int i = 0; i < sortedProducts.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{sortedProducts[i]}");  // Print each product with its number
                }
            }

            public static void Run()
            {
                string[] products = Console.ReadLine().Split(',');  // Input the products array
                ListProducts(products);  // Print the sorted product list
            }
        }
    }
}

