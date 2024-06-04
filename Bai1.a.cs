using System;

class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        bool isValid;

        do
        {
            isValid = true;
            try
            {
                Console.Write("Enter the first number (4 byte integer): ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number (4 byte integer): ");
                b = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid 4 byte integer.");
                isValid = false;
            }
        } while (!isValid);

        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        int integerQuotient = a / b;
        double floatQuotient = (double)a / b;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Integer Quotient: " + integerQuotient);
        Console.WriteLine("Float Quotient: " + floatQuotient);
    }
}
