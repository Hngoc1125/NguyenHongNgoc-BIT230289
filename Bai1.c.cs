using System;

class Program
{
    static void Main(string[] args)
    {
        uint number;
        uint reversedNumber = 0;

        Console.Write("Enter a 4 byte unsigned integer: ");
        number = uint.Parse(Console.ReadLine());

        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + (number % 10);
            number /= 10;
        }

        Console.WriteLine("The reversed number is: " + reversedNumber);
        Console.ReadLine();
    }
}