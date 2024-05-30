using System;

namespace ArrayMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());

            int[] numbers = new int[arraySize];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxValue = FindMaxValue(numbers);

            Console.WriteLine($"The maximum value in the array is: {maxValue}");
        }

        static int FindMaxValue(int[] arr)
        {
            int max = arr[0]; 

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i]; 
                }
            }

            return max;
        }
    }
}