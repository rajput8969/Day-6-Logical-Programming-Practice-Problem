using System;

namespace Day_6_Logical_Programming_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, n;
            Console.Write("Enter the Number:- ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
