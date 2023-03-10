using System;

namespace SolidLiquidGas
{
    // Write a program that finds whether water is a liquid, a solid, or a gas according to its temperature.

    internal class Program
    {
        static void findState()
        {
            Console.Write("Enter the temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Solid");
            }
            else if (temp > 100)
            {
                Console.WriteLine("Gas");
            }
            else
            {
                Console.WriteLine("Liquid");
            }
        }

        static void Main(string[] args)
        {
            findState();
        }
    }
}