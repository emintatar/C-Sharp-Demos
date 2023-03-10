using System;

namespace NumberOfBacteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 1;

            for (int i = 1; i <= 24; i++)
            {
                total = total * 2;
            }

            Console.WriteLine("Total: " + total);
        }
    }
}