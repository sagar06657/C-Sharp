using System;

interface IBank
{
    int Deposite(int amount);
    int Withdraw(int amount);
}

class Account : IBank
{
    private int balance;

    public Account(int initial = 0) => balance = initial;

    public int Deposite(int amount)
    {
        if (amount <= 0) { Console.WriteLine("Enter amount > 0."); return balance; }
        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
        return balance;
    }

    public int Withdraw(int amount)
    {
        if (amount <= 0) { Console.WriteLine("Enter amount > 0."); return balance; }
        if (amount > balance) { Console.WriteLine("Insufficient funds."); return balance; }
        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
        return balance;
    }

    public int GetBalance() => balance;
}

class Program
{
    static void Main()
    {
        var acc = new Account();
        while (true)
        {
            Console.WriteLine("\n1) Deposit  2) Withdraw  3) Balance  4) Exit");
            Console.Write("Choose: ");
            if (!int.TryParse(Console.ReadLine(), out int opt)) { Console.WriteLine("Invalid option."); continue; }
            if (opt == 4) break;
            switch (opt)
            {
                case 1:
                    Console.Write("Amount to deposit: ");
                    if (int.TryParse(Console.ReadLine(), out int d)) Console.WriteLine($"Balance: {acc.Deposite(d)}");
                    else Console.WriteLine("Invalid amount.");
                    break;
                case 2:
                    Console.Write("Amount to withdraw: ");
                    if (int.TryParse(Console.ReadLine(), out int w)) Console.WriteLine($"Balance: {acc.Withdraw(w)}");
                    else Console.WriteLine("Invalid amount.");
                    break;
                case 3:
                    Console.WriteLine($"Balance: {acc.GetBalance()}");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        Console.WriteLine("Goodbye.");
    }
}