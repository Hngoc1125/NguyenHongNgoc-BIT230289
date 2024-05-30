using System;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to reverse: ");
            string inputString = Console.ReadLine();

            string reversedString = ReverseString(inputString);

            Console.WriteLine($"Original string: {inputString}");
            Console.WriteLine($"Reversed string: {reversedString}");
        }

        public static string ReverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}