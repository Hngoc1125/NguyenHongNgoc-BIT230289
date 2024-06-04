using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chọn chức năng:");
        Console.WriteLine("1. Kiểm tra số Palindrome");
        Console.WriteLine("2. Tính tổng mảng số nguyên có dấu");
        Console.Write("Nhập lựa chọn (1 hoặc 2): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Kiểm tra số Palindrome
                Console.Write("Nhập số nguyên không dấu (8 byte): ");
                ulong inputNumber = ulong.Parse(Console.ReadLine());
                ulong originalNumber = inputNumber;
                ulong reversedNumber = 0;

                while (inputNumber > 0)
                {
                    reversedNumber = reversedNumber * 10 + (inputNumber % 10);
                    inputNumber /= 10;
                }

                if (originalNumber == reversedNumber)
                {
                    Console.WriteLine($"{originalNumber} là số Palindrome.");
                }
                else
                {
                    Console.WriteLine($"{originalNumber} không phải là số Palindrome.");
                }
                break;

            case 2:
                // Tính tổng mảng số nguyên có dấu
                Console.Write("Nhập mảng số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
                string[] inputArray = Console.ReadLine().Split();
                long sum = 0;
                foreach (string s in inputArray)
                {
                    long num = long.Parse(s);
                    sum += num;
                }
                Console.WriteLine($"Tổng các số trong mảng: {sum}");
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }
}