using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chọn chức năng:");
        Console.WriteLine("1. Tính trung bình cộng mảng số thực");
        Console.WriteLine("2. Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực");
        Console.Write("Nhập lựa chọn (1 hoặc 2): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Tính trung bình cộng mảng số thực
                Console.Write("Nhập mảng số thực (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
                string[] inputArray = Console.ReadLine().Split();
                double[] doubleArray = new double[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    doubleArray[i] = double.Parse(inputArray[i]);
                }

                double sum = 0;
                foreach (double d in doubleArray)
                {
                    sum += d;
                }
                double average = sum / doubleArray.Length;
                Console.WriteLine($"Trung bình cộng của mảng: {average}");
                break;

            case 2:
                // Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực
                Console.Write("Nhập mảng số thực (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
                string[] inputArray2 = Console.ReadLine().Split();
                double[] doubleArray2 = new double[inputArray2.Length];
                for (int i = 0; i < inputArray2.Length; i++)
                {
                    doubleArray2[i] = double.Parse(inputArray2[i]);
                }

                double max = doubleArray2[0];
                double min = doubleArray2[0];
                foreach (double d in doubleArray2)
                {
                    if (d > max)
                    {
                        max = d;
                    }
                    if (d < min)
                    {
                        min = d;
                    }
                }

                Console.WriteLine($"Giá trị lớn nhất: {max}");
                Console.WriteLine($"Giá trị nhỏ nhất: {min}");
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }
}