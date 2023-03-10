namespace SortAscendingOrder
{
    // Write a program that sorts the 5 numbers entered from the keyboard from in ascending order.

    internal class Program
    {
        static int[] getNumbers()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                try 
                {
                    Console.Write("Number " + (i + 1) + ": ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number!");
                    i--;
                }
            }

            return numbers;
        }

        static void Main(string[] args)
        {
           int[] arr = getNumbers();

            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
        }
    }
}