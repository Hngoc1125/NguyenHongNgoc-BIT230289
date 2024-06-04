using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chọn chức năng:");
        Console.WriteLine("1. Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực");
        Console.WriteLine("2. Tính tổng mảng số thực");
        Console.Write("Nhập lựa chọn (1 hoặc 2): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực
                Console.Write("Nhập mảng số thực (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
                string[] inputArray = Console.ReadLine().Split();
                float[] floatArray = new float[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    floatArray[i] = float.Parse(inputArray[i]);
                }

                float max = floatArray[0];
                float min = floatArray[0];
                foreach (float f in floatArray)
                {
                    if (f > max)
                    {
                        max = f;
                    }
                    if (f < min)
                    {
                        min = f;
                    }
                }

                Console.WriteLine($"Giá trị lớn nhất: {max}");
                Console.WriteLine($"Giá trị nhỏ nhất: {min}");
                break;

            case 2:
                // Tính tổng mảng số thực
                Console.Write("Nhập mảng số thực (tối đa 10 số, mỗi số cách nhau bởi dấu cách): ");
                string[] inputArray2 = Console.ReadLine().Split();
                float sum = 0;
                foreach (string s in inputArray2)
                {
                    float num = float.Parse(s);
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