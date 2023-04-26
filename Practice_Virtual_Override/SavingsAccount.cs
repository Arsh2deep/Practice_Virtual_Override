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
            if (base.Deposit(amount))
            {
                Balance += Balance * Interest / 100;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()}: Interest {Interest}%";
        }
    }
}