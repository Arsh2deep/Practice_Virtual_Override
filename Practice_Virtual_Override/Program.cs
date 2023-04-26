namespace Practice_Virtual_Override;
class Program
{
    static void Main(string[] args)
    {

        List<BankAccount> accounts = new List<BankAccount>();

        accounts.Add(new CheckingAccount("Will", 1000, 20));
        accounts.Add(new SavingsAccount("Arsh", 2000, 5));
        accounts.Add(new RetirementAccount("Mike", 3000, 8));

        foreach (var account in accounts)
        {
            Console.WriteLine($"Initial Balance: {account}");
            account.Deposit(500);
            Console.WriteLine($"Balance after depositing $500: {account}");
            account.Deposit(-50000);
            Console.WriteLine($"Balance after depositing -$50,000: {account}");
            account.Withdraw(200);
            Console.WriteLine($"Balance after withdrawing $200: {account}");
            account.Withdraw(-200000);
            Console.WriteLine($"Balance after withdrawing -$200,000: {account}");
            account.Withdraw(account.Balance + 1);
            Console.WriteLine($"Attempted to overdraw: {account}");
            Console.WriteLine();

        }//Loop

    }//Main

}//Class

