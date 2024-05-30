using System;

namespace NumericConversion
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.Write("Enter a real number: ");
            double realNumber = double.Parse(Console.ReadLine());

            int intNumber = (int)realNumber;
            long longNumber = (long)realNumber;

            Console.WriteLine($"The number you entered is {realNumber}, as an int is {intNumber} and as a long is {longNumber}");
        }
    }
}
