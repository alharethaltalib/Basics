using System;
using System.Linq;

namespace Basics
{
    class Program
    {
        public static int Sum(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;

            }
            return result;
        }
        public static int Sum_A(int n)
        {
            return Enumerable.Range(1, n).Sum();

        }
        public static int Sum_B(int n)
        {
            int result = 0, i = 0;
            while (i <= n)
            {
                result += i;
                i++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number : ");
            string line = Console.ReadLine();
            int N = int.Parse(line);
            for (int i = 0; i < 100; i++)
			{
                Console.WriteLine(i+1+"\n");
            }
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i + "\n");
            }
            Console.WriteLine("Sum from 1 to " + N + " with for loop :"+Sum(N));
            Console.WriteLine("Sum from 1 to " + N + " with LINQ :" + Sum_A(N));
            Console.WriteLine("Sum from 1 to " + N + " with while loop :" + Sum_B(N));

        }
    }
}
