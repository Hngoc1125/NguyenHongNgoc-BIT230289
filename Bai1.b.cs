using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers;
        int size;
        int sum = 0;

        Console.Write("Enter the size of the array: ");
        size = int.Parse(Console.ReadLine());

        numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }

        Console.WriteLine("The sum of the array elements is: " + sum);
        Console.ReadLine();
    }
}