namespace Practice_Virtual_Override
{
    internal class CheckingAccount : BankAccount
    {
        public double OverdraftFee { get; set; }

        public CheckingAccount(string name, double balance, double overdraftFee)
            : base(name, balance)
        {
            OverdraftFee = overdraftFee;
        }
        public override bool Withdraw(double amount)
        {
            if (amount >= 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            else if (amount < 0)
            {
                return false;
            }
            else
            {
                Balance -= OverdraftFee;
                return true;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}: Overdraft Fee {OverdraftFee:C}";
        }

    }//Class

}//NameSpace