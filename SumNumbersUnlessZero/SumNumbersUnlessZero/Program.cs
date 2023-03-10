using System;

namespace SumNumbersUnlessZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int number;

            while(true)
            {
                try
                {
                    Console.Write("Number: ");
                    number = int.Parse(Console.ReadLine());


                    if (number == 0)
                    {
                        break;
                    }

                    total += number;

                }

                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Number");
     
                }
            }

            Console.WriteLine("Total: " + total);
        }
    }
}