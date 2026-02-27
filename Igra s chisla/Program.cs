using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra_s_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                int num1 = num.Next(0, 9);
                if (!numbers.Contains(num1))
                    numbers[i] = num1;
                else i--;
            }
            //Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine("Guess the numers and there order - there are NO repeating numbers!");
            int[] guess = new int[5];
            bool flag = false;
            Console.WriteLine(new string('-', 65));
            do
            {
                Console.Write("Make a guess (put spaces!): ");
                guess = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int contains = 0;
                int right = 0;
                for (int i = 0; i < guess.Length; i++)
                {
                    if (numbers.Contains(guess[i]))
                    {
                        contains++;
                        if (numbers[i] == guess[i])
                            right++;
                    }
                }
                Console.WriteLine($"There are {contains} right numbers and {right} on the right position");
                Console.WriteLine(new string('-', 65));
                if (right == 5)
                    flag = true;
            }
            while (flag == false);
            Console.WriteLine();
            Console.Write("You guess the numbers!! It's ");
            Console.WriteLine(string.Join(" ", guess));
        }
    }
}
