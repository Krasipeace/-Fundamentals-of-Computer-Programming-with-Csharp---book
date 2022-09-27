using System;
using System.Linq;
using System.Text;

namespace _1._Custom_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Text: ");
            string input = Console.ReadLine();

            Console.Write("Enter: index and length of desired Substring: ");
            int[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            string result = input.CustomSubstring(commands[0], commands[1]);

            Console.WriteLine(result);
        }

    }
    public static class Extensions
    {
        public static string CustomSubstring(this string customStr, int index, int length)
        {
            StringBuilder sb = new StringBuilder(customStr);

            return sb.ToString(index, length);
        }
    }
}
