using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Numbers_Divisible_by_3_and_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write numbers: ");
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(n => int.Parse(n))
                                                  .Where(n => n % 21 == 0)
                                                  .ToList();
            if (numbers.Any())
            {
                if (numbers.Contains(0))
                {
                    Console.WriteLine("There are no numbers divisible by 7 and 3!");

                    return;
                }
                Console.WriteLine($"Numbers divisible by 7 and 3 are: {string.Join(" ", numbers)}");
            }
            else 
            {
                Console.WriteLine("There are no numbers divisible by 7 and 3!");
            }
        }
    }
}
