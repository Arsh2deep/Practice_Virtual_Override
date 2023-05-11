namespace Practice_Virtual_Override
{
    internal class SavingsAccount : BankAccount
    {
        public double Interest { get; set; }

        public SavingsAccount(string name, double balance, double interest)
            : base(name, balance)
        {
            Interest = interest;
        }

        public override bool Deposit(double amount)
        {
            if (amount <= 0)
                return false;

            Balance += amount;
            Balance += (Balance * Interest);
            return true;
        }
        public override bool Withdraw(double amount)
        {
            if (amount <= 0)
                return false;

            if (Balance >= amount)
            {
                Balance -= amount;
                Balance += (Balance * Interest);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}: Interest {Interest:P}";
        }
    }
}