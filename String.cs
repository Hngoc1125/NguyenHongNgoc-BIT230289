using System;
using System.Linq;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot chuoi:");
            string userInput = Console.ReadLine();

            string reversedString = ReverseString(userInput);
            Console.WriteLine("Chuoi dao nguoc: " + reversedString);

            Console.WriteLine("Nhap mot chuoi tim kiem:");
            string searchString = Console.ReadLine();

            int occurrences = CountOccurrences(userInput, searchString);
            Console.WriteLine("So lan xuat hien: " + occurrences);

            Console.WriteLine("Nhap mot chuoi cu:");
            string oldSubstring = Console.ReadLine();
            Console.WriteLine("Nhap mot chuoi moi:");
            string newSubstring = Console.ReadLine();

            string modifiedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine("Chuoi da sua doi: " + modifiedString);

            string stringWithoutWhitespace = RemoveWhitespace(userInput);
            Console.WriteLine("Chuoi khong co khoang trang: " + stringWithoutWhitespace);
        }

        static string ReverseString(string inputString)
        {
            return string.Concat(inputString.Reverse());
        }

        static int CountOccurrences(string inputString, string searchString)
        {
            return inputString.Split(new[] { searchString }, StringSplitOptions.None).Length - 1;
        }

        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }

        static string RemoveWhitespace(string inputString)
        {
            return inputString.Replace(" ", "");
        }
    }
}