using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chọn một bài tập:");
        Console.WriteLine("1. Số Dương, Âm hoặc Bằng 0");
        Console.WriteLine("2. Ngày Trong Tuần");
        Console.WriteLine("3. Tính Giai Thừa");
        Console.WriteLine("4. Mẫu Dấu Sao");
        Console.WriteLine("5. Trò Chơi Đoán Số");
        Console.WriteLine("6. Tổng Các Số Dương");
        Console.Write("Nhập số bài tập (1-6): ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Bài tập 1: Số Dương, Âm hoặc Bằng 0
                Console.Write("Nhập một số: ");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 > 0)
                {
                    Console.WriteLine("Số này là số dương.");
                }
                else if (num1 < 0)
                {
                    Console.WriteLine("Số này là số âm.");
                }
                else
                {
                    Console.WriteLine("Số này bằng 0.");
                }
                break;

            case 2:
                // Bài tập 2: Ngày Trong Tuần
                Console.Write("Nhập một ngày trong tuần (1-7): ");
                int dayOfWeek = int.Parse(Console.ReadLine());

                switch (dayOfWeek)
                {
                    case 1:
                        Console.WriteLine("Thứ Hai");
                        break;
                    case 2:
                        Console.WriteLine("Thứ Ba");
                        break;
                    case 3:
                        Console.WriteLine("Thứ Tư");
                        break;
                    case 4:
                        Console.WriteLine("Thứ Năm");
                        break;
                    case 5:
                        Console.WriteLine("Thứ Sáu");
                        break;
                    case 6:
                        Console.WriteLine("Thứ Bảy");
                        break;
                    case 7:
                        Console.WriteLine("Chủ Nhật");
                        break;
                    default:
                        Console.WriteLine("Ngày không hợp lệ.");
                        break;
                }
                break;

            case 3:
                // Bài tập 3: Tính Giai Thừa
                Console.Write("Nhập một số nguyên dương: ");
                int num3 = int.Parse(Console.ReadLine());
                int factorial = 1;

                for (int i = 1; i <= num3; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"Giai thừa của {num3} là {factorial}.");
                break;

            case 4:
                // Bài tập 4: Mẫu Dấu Sao
                Console.Write("Nhập số hàng: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Nhập số cột: ");
                int cols = int.Parse(Console.ReadLine());

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                break;

            case 5:
                // Bài tập 5: Trò Chơi Đoán Số
                Random rand = new Random();
                int secretNumber = rand.Next(1, 101);
                int guess;
                int attempts = 0;

                do
                {
                    Console.Write("Đoán một số từ 1 đến 100: ");
                    guess = int.Parse(Console.ReadLine());
                    attempts++;

                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Cao hơn");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Thấp hơn");
                    }
                    else
                    {
                        Console.WriteLine($"Chính xác! Bạn đã đoán đúng sau {attempts} lần.");
                    }
                } while (guess != secretNumber);
                break;

            case 6:
                // Bài tập 6: Tổng Các Số Dương
                Console.WriteLine("Nhập một chuỗi số (nhập 0 để dừng):");
                double sum = 0;
                double num6;

                while (true)
                {
                    Console.Write("Nhập một số: ");
                    num6 = double.Parse(Console.ReadLine());

                    if (num6 == 0)
                    {
                        break;
                    }
                    else if (num6 > 0)
                    {
                        sum += num6;
                    }
                    else
                    {
                        continue;
                    }
                }

                Console.WriteLine($"Tổng các số dương là: {sum}");
                break;

            default:
                Console.WriteLine("Số bài tập không hợp lệ.");
                break;
        }
    }
}