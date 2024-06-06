using System;

namespace NumericTypeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chọn bài tập (a-m):");
            char choice = Console.ReadLine().ToLower()[0];

            switch (choice)
            {
                case 'a':
                    //Tính tổng của hai số nguyên không dấu
                    Console.WriteLine("Nhập hai số cần kiểm tra:");
                    uint num1 = uint.Parse(Console.ReadLine());
                    uint num2 = uint.Parse(Console.ReadLine());
                    uint sum = num1 + num2;
                    Console.WriteLine($"Tổng của {num1} và {num2} là: {sum}");
                    break;

                case 'b':
                    //Tính diện tích và chu vi của hình chữ nhật
                    Console.WriteLine("Nhập chiều dài và chiều rộng của hình chữ nhật:");
                    ushort length = ushort.Parse(Console.ReadLine());
                    ushort width = ushort.Parse(Console.ReadLine());
                    uint area = (uint)length * (uint)width;
                    uint perimeter = (uint)(2 * (length + width));
                    Console.WriteLine($"Diện tích: {area}");
                    Console.WriteLine($"Chu vi: {perimeter}");
                    break;

                case 'c':
                    //Kiểm tra số nguyên không dấu 4byte là chẵn hay lẻ
                    Console.WriteLine("Nhập số nguyên :");
                    uint num3 = uint.Parse(Console.ReadLine());
                    if (num3 % 2 == 0)
                    {
                        Console.WriteLine($"{num3} là số chẵn");
                    }
                    else
                    {
                        Console.WriteLine($"{num3} là số lẻ");
                    }
                    break;

                case 'd':
                    //Tính tổng của hai số nguyên có dấu 1byte
                    Console.WriteLine("Nhập hai số cần kiểm t :");
                    sbyte num4 = sbyte.Parse(Console.ReadLine());
                    sbyte num5 = sbyte.Parse(Console.ReadLine());
                    sbyte sum2 = (sbyte)(num4 + num5);
                    Console.WriteLine($"Tổng của {num4} và {num5} là: {sum2}");
                    break;

                case 'e':
                    //Tính tổng các số từ 1 đến n
                    Console.WriteLine("Nhập số n cần tính t:");
                    uint n = uint.Parse(Console.ReadLine());
                    uint sum3 = (uint)(n * (n + 1) / 2);
                    Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum3}");
                    break;

                case 'g':
                    //Tính diện tích và chu vi của hình chữ nhật
                    Console.WriteLine("Nhập chiều dài và chiều rộng của hình chữ nhật :");
                    double length2 = double.Parse(Console.ReadLine());
                    double width2 = double.Parse(Console.ReadLine());
                    double area2 = length2 * width2;
                    double perimeter2 = 2 * (length2 + width2);
                    Console.WriteLine($"Diện tích: {area2}");
                    Console.WriteLine($"Chu vi: {perimeter2}");
                    break;

                case 'h':
                    //Tìm số lớn nhất trong ba số nguyên
                    Console.WriteLine("Nhập ba số nguyên:");
                    int num6 = int.Parse(Console.ReadLine());
                    int num7 = int.Parse(Console.ReadLine());
                    int num8 = int.Parse(Console.ReadLine());
                    int max = Math.Max(Math.Max(num6, num7), num8);
                    Console.WriteLine($"Số lớn nhất là: {max}");
                    break;

                case 'k':
                    // Tính giai thừa của một số nguyên không âm
                    Console.WriteLine("Nhập số nguyên n:");
                    uint n2 = uint.Parse(Console.ReadLine());
                    uint factorial = 1;
                    for (uint i = 1; i <= n2; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Giai thừa của {n2} là: {factorial}");
                    break;

                case 'l':
                    // Kiểm tra số nguyên tố
                    Console.WriteLine("Nhập số nguyên n:");
                    uint n3 = uint.Parse(Console.ReadLine());
                    bool isPrime = true;
                    if (n3 < 2)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        for (uint i = 2; i <= Math.Sqrt(n3); i++)
                        {
                            if (n3 % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"{n3} là số nguyên tố");
                    }
                    else
                    {
                        Console.WriteLine($"{n3} không phải là số nguyên tố");
                    }
                    break;

                case 'm':
                    // Kiểm tra số hoàn hảo
                    Console.WriteLine("Nhập số nguyên n:");
                    int n4 = int.Parse(Console.ReadLine());
                    int sum4 = 0;
                    for (int i = 1; i < n4; i++)
                    {
                        if (n4 % i == 0)
                        {
                            sum4 += i;
                        }
                    }
                    if (sum4 == n4)
                    {
                        Console.WriteLine($"{n4} là số hoàn hảo");
                    }
                    else
                    {
                        Console.WriteLine($"{n4} không phải là số hoàn hảo");
                    }
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
            Console.ReadLine();
        }
    }
}