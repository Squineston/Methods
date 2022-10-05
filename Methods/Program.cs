using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                static int[] arrayPopulate(int length)
                {
                    int[] randArray = new int[length];

                    Random randNum = new Random();

                    for (int i = 0; i < length; i++)
                    {
                        randArray[i] = randNum.Next(10, 50);
                    }

                    return randArray;
                }

                static int arraySum(int[] array)
                {
                    int sum = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }

                    return sum;
                }

                Console.Write("Please enter an integer value between 5 and 15: ");
                int length = Convert.ToInt32(Console.ReadLine());

                while (length < 5 || length > 15)
                {
                    Console.Write("Invalid input, please enter an integer value between 5 and 15: ");
                    length = Convert.ToInt32(Console.ReadLine());
                }

                int[] array = arrayPopulate(length);

                Console.Write("The elements of the array are: ");

                for (int i = 0; i < length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine();

                int sum = arraySum(array);

                Console.WriteLine("The sum is: " + sum);
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }
        }
    }
}
