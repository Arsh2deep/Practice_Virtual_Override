namespace Practice_Virtual_Override
{
    public abstract class BankAccount
    {
        public string Name { get; set; }
        public int AccountNumber { get; }
        public double Balance { get; protected set; }


        public BankAccount(string name, double balance)
        {
            Name = name;
            Balance = balance;
            AccountNumber = GenerateAccountNumber();
        }

        public abstract bool Deposit(double amount);

        public abstract bool Withdraw(double amount);
        

        public override string ToString()
        {
            return $"{GetType().Name} - {Name} - Account Number {AccountNumber} - Balance {Balance:C}";
        }

        private string GenerateAccountNumber()
        {
            Random rand = new Random();
            string accNum = "";

            for (int i = 0; i < 8; i++)
            {
                int num = rand.Next(10);
                accNum += num.ToString();
            }

            return accNum;
        }
    
    }//Class

}//Namespace