using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var laptops = new Dictionary<int, Laptop>
            {
                [1] = new Laptop
                {
                    Manufacturer = "HP",
                    Model = "XPS 15",
                    Price = "2000"
                },
                [2] = new Laptop
                {
                    Manufacturer = "Razor",
                    Model = "Blade 15",
                    Price = "2500"
                },
                [3] = new Laptop
                {
                    Manufacturer = "Apple",
                    Model = "Macbook Pro",
                    Price = "3000"
                }
            };

            foreach (var laptop in laptops)
            {
                Console.WriteLine($"{laptop.Key}. {laptop.Value}");
            }

            do
            {
                Console.Write("\nInsert the No to get the price... ");
                var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    if (int.TryParse(input, out int id))
                    {
                        if (laptops.ContainsKey(id))
                        {
                            var laptop = laptops[id];
                            Console.WriteLine($"You chose {laptop} which is {laptop.Price}$");
                        }
                        else
                        {
                            Console.WriteLine($"Key {input} is invalid.");
                        }
                    }
                }
            } while (true);
        }
    }
}
