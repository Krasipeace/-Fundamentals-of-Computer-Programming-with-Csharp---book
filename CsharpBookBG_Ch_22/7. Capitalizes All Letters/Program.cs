using System;
using System.Globalization;

namespace _7._Capitalizes_First_Letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            text.CapitalizeFirstLetter();
        }
    }
    public static class Extensions
    {
        public static string CapitalizeFirstLetter(this string customStr)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            Console.WriteLine($"{textInfo.ToTitleCase(customStr)}");

            return customStr;
        }
    }
}
