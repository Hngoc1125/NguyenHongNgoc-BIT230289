using System;

// Bài tập 1
public class AgeOutOfRangeException : Exception
{
    public AgeOutOfRangeException(string message) : base(message) { }
}

// Bài tập 2
public class NegativeAmountException : Exception
{
    public NegativeAmountException(string message) : base(message) { }
}

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

public class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }

    public void NapTien(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Không thể nạp số tiền âm.");
        }
        balance += amount;
    }

    public void RutTien(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Không thể rút số tiền âm.");
        }
        if (balance - amount < 0)
        {
            throw new InsufficientFundsException("Không đủ số dư trong tài khoản.");
        }
        balance -= amount;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Kiểm tra tuổi hợp lệ của học sinh");
            Console.WriteLine("2. Nạp/rút tiền từ tài khoản ngân hàng");
            Console.WriteLine("0. Thoát");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int age = LayTuoiHocSinh();
                    KiemTraTuoiHopLe(age);
                    break;
                case 2:
                    BankAccount account = new BankAccount();
                    decimal amount;
                    Console.WriteLine("1. Nạp tiền");
                    Console.WriteLine("2. Rút tiền");
                    int bankChoice = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số tiền: ");
                    amount = decimal.Parse(Console.ReadLine());
                    switch (bankChoice)
                    {
                        case 1:
                            account.NapTien(amount);
                            Console.WriteLine($"Số dư hiện tại: {account.Balance}");
                            break;
                        case 2:
                            account.RutTien(amount);
                            Console.WriteLine($"Số dư hiện tại: {account.Balance}");
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                    break;
                case 0:
                    running = false;
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }

    static int LayTuoiHocSinh()
    {
        Console.Write("Nhập tuổi của học sinh: ");
        return int.Parse(Console.ReadLine());
    }

    static void KiemTraTuoiHopLe(int age)
    {
        try
        {
            switch (age)
            {
                case int i when (i >= 18 && i <= 25):
                    Console.WriteLine("Học sinh đủ điều kiện nhập học.");
                    break;
                default:
                    throw new AgeOutOfRangeException("Tuổi của học sinh không nằm trong khoảng hợp lệ.");
            }
        }
        catch (AgeOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}