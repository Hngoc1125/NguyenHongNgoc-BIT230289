using System;

class Program
{
    static void Main(string[] args)
    {
        // Chọn bài toán
        Console.WriteLine("Chọn bài toán (2a, 2b, 2c, 2d):");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "2a":
                FindMaxMin();
                break;
            case "2b":
                SumEvenNumbers();
                break;
            case "2c":
                SumFromOneToN();
                break;
            case "2d":
                SumDigits();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }

    static void FindMaxMin()
    {
        // Nhập dãy số nguyên
        Console.Write("Nhập dãy số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
        string[] input = Console.ReadLine().Split();

        // Tìm số lớn nhất và nhỏ nhất
        sbyte min = sbyte.MaxValue;
        sbyte max = sbyte.MinValue;
        foreach (string s in input)
        {
            sbyte num = sbyte.Parse(s);
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        // In kết quả
        Console.WriteLine($"Số nhỏ nhất: {min}");
        Console.WriteLine($"Số lớn nhất: {max}");
    }

    static void SumEvenNumbers()
    {
        // Nhập dãy số nguyên
        Console.Write("Nhập dãy số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
        string[] input = Console.ReadLine().Split();

        // Tính tổng các số chẵn
        int sum = 0;
        foreach (string s in input)
        {
            sbyte num = sbyte.Parse(s);
            if (num % 2 == 0)
                sum += num;
        }

        // In kết quả
        Console.WriteLine($"Tổng các số chẵn: {sum}");
    }

    static void SumFromOneToN()
    {
        // Nhập số nguyên n
        Console.Write("Nhập số nguyên n (không dấu, 1 byte): ");
        byte n = byte.Parse(Console.ReadLine());

        // Tính tổng các số từ 1 đến n
        uint sum = (uint)(n * (n + 1)) / 2;

        // In kết quả
        Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
    }

    static void SumDigits()
    {
        // Nhập số nguyên không dấu kiểu byte
        Console.Write("Nhập số nguyên không dấu kiểu byte: ");
        byte num = byte.Parse(Console.ReadLine());

        // Tính tổng các chữ số
        byte sum = 0;
        while (num > 0)
        {
            sum += (byte)(num % 10);
            num /= 10;
        }

        // In kết quả
        Console.WriteLine($"Tổng các chữ số: {sum}");
    }
}