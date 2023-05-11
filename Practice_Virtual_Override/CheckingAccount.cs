namespace Practice_Virtual_Override
{
    internal class CheckingAccount : BankAccount
    {
        public double OverdraftFee {get; set;}

        
        public CheckingAccount(string name, double balance, double overdraftFee)
            : base(name, balance)
        {
            OverdraftFee = overdraftFee;
        }

        public override bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Withdraw(double amount)
        {
            if (amount >= 0)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    return true;
                }
                else
                {
                    Balance -= OverdraftFee;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString()+$": Overdraft Fee {OverdraftFee:C}";
        }

    }//Class

}//NameSpace