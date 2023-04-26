namespace Practice_Virtual_Override
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int AccountNumber { get; }
        public double Balance { get; set; }

        private static int _lastAccountNumber = 100000;

        public BankAccount(string name, double balance)
        {
            Name = name;
            Balance = balance;
            AccountNumber = ++_lastAccountNumber;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public virtual bool Withdraw(double amount)
        {
            if (amount >= 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{GetType().Name} - {Name} - Account Number {AccountNumber} - Balance {Balance:C}";
        }

    }//Class

}//Namespace