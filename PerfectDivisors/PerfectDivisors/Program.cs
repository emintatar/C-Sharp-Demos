using System;

namespace PerfectDivisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = 0;
                int number;

                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write(i + "\n");
                        count++;
                    }
                }

                Console.WriteLine("\n" + count);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}