using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Chọn bài tập (1-3, 0 để thoát):");
            Console.WriteLine("1. Tìm số lớn nhất và số nhỏ nhất trong dãy số");
            Console.WriteLine("2. Tính các phép tính cơ bản");
            Console.WriteLine("3. Tính tổng, tích các số trong mảng");
            Console.Write("Lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FindMinMax();
                    break;
                case 2:
                    BasicCalculations();
                    break;
                case 3:
                    ArrayOperations();
                    break;
                case 0:
                    Console.WriteLine("Đã thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 0);
    }

    static void FindMinMax()
    {
        Console.WriteLine("Nhập dãy số nguyên có dấu kích thước 1 byte (các số cách nhau bởi dấu cách):");
        string[] input = Console.ReadLine().Split(' ');
        sbyte[] numbers = new sbyte[input.Length];

        sbyte max = sbyte.MinValue;
        sbyte min = sbyte.MaxValue;

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = sbyte.Parse(input[i]);
            if (numbers[i] > max)
                max = numbers[i];
            if (numbers[i] < min)
                min = numbers[i];
        }

        Console.WriteLine($"Số lớn nhất: {max}");
        Console.WriteLine($"Số nhỏ nhất: {min}");
    }

    static void BasicCalculations()
    {
        int a, b;
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
                a = 0;
                b = 0;
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

    static void ArrayOperations()
    {
        Console.Write("Nhập kích thước mảng: ");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int product = 1;
        foreach (int num in numbers)
        {
            sum += num;
            product *= num;
        }

        Console.WriteLine($"Tổng các phần tử trong mảng: {sum}");
        Console.WriteLine($"Tích các phần tử trong mảng: {product}");
    }
}