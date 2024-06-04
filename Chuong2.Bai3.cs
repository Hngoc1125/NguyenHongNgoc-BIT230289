using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chọn chức năng:");
        Console.WriteLine("1. Tính tổng số nguyên không dấu");
        Console.WriteLine("2. Tính tổng số nguyên có dấu");
        Console.Write("Nhập lựa chọn (1 hoặc 2): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Tính tổng các số nguyên không dấu
                Console.Write("Nhập mảng số nguyên không dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
                string[] inputUnsigned = Console.ReadLine().Split();
                ushort sumUnsigned = 0;
                foreach (string s in inputUnsigned)
                {
                    ushort num = ushort.Parse(s);
                    sumUnsigned += num;
                }
                Console.WriteLine($"Tổng các số trong mảng: {sumUnsigned}");
                break;

            case 2:
                // Tính tổng các số nguyên có dấu
                Console.Write("Nhập mảng số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
                string[] inputSigned = Console.ReadLine().Split();
                short sumSigned = 0;
                foreach (string s in inputSigned)
                {
                    short num = short.Parse(s);
                    sumSigned += num;
                }
                Console.WriteLine($"Tổng các số trong mảng: {sumSigned}");
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }
}