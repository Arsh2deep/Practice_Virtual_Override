namespace Practice_Virtual_Override
{
    internal class RetirementAccount : SavingsAccount
    {
        public RetirementAccount(string name, double balance, double interest)
         : base(name, balance, interest)
        {

        }
        public new bool Withdraw(double amount)
        {
            Console.WriteLine("Cannot Withdraw From a Retirement Account");
            return false;
        }
    }
}