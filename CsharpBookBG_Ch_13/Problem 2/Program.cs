using System; //correct (  )    85/92 tests passed @leetcode.com
using System.Text;

namespace Problem_2 //Balanced Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arithmetic expression: ");
            string input = Console.ReadLine();
            
            IsValid(input);
        }

        public static bool IsValid(string input)
        {
            int counterOne = 0;
            int counterTwo = 0;
            int counterThree = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.IndexOf(')') == 0 || input.IndexOf(']') == 0 || input.IndexOf('}') == 0)
                {
                    return false;
                }

                if (input[i] == '(')
                {
                    counterOne++;
                }
                else if (input[i] == ')')
                {
                    counterOne--;
                }

                if (input[i] == '[')
                {
                    counterTwo++;
                }
                else if (input[i] == ']')
                {
                    counterTwo--;
                }

                if (input[i] == '{')
                {
                    counterThree++;
                }
                else if (input[i] == '}')
                {
                    counterThree--;
                }
            }

            if (counterOne == 0 && counterTwo == 0 && counterThree == 0)
            {
                Console.WriteLine("The brackets are correct.");

                return true;
            }
            else
            {
                Console.WriteLine("The brackets are incorrect!");

                return false;
            }
        }
    }
}
