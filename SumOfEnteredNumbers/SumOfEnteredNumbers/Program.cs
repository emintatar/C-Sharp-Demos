using System;

namespace SumOfEnteredNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            int total = 0;

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    Console.Write("Number " + (i + 1) + ": ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                catch 
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Invalid Number");
                    i--;
                }
            }

            foreach (int number in numbers)
            {
                total += number;
            }

            Console.WriteLine("Total: " + total);
        }
    }
}