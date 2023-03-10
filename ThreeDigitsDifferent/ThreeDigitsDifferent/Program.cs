using System;

namespace ThreeDigitsDifferent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int ones, tens, hundreds;

            for (int i = 100; i <= 999; i++)
            {
                hundreds = i / 100;
                tens = (i / 10) % 10;
                ones = i % 10;

                if ((ones != tens) && (ones != hundreds) && (tens != hundreds))
                {
                    count++;
                }
            }

            Console.WriteLine("Result: " + count);

        }
    }
}