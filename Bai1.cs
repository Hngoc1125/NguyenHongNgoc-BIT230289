using System;

namespace DataTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.Write("Enter an integer: ");
            int intNumber = int.Parse(Console.ReadLine());

            double doubleNumber = (double)intNumber;

            Console.WriteLine($"The number you entered is {intNumber} and as a double is {doubleNumber}");
        }
    }
}
