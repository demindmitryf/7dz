using System;

class BankAccount
{
    public int number;
    public string type;
    public double balance;

    public void Transfer(BankAccount account, double sum)
    {
        if (sum > 0 && balance >= sum)
        {
            balance -= sum;
            account.balance += sum;

            Console.WriteLine("Перевод выполнен успешно.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств или неправильная сумма.");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount();
        account1.number = 123;
        account1.type = "Текущий";
        account1.balance = 5000;

        BankAccount account2 = new BankAccount();
        account2.number = 456;
        account2.type = "Сберегательный";
        account2.balance = 2000;

        Console.WriteLine("До перевода:");
        Console.WriteLine("Первый счет: " + account1.balance);
        Console.WriteLine("Второй счет: " + account2.balance);

        account1.Transfer(account2, 1500);

        Console.WriteLine("После перевода:");
        Console.WriteLine("Первый счет: " + account1.balance);
        Console.WriteLine("Второй счет: " + account2.balance);
    }
}