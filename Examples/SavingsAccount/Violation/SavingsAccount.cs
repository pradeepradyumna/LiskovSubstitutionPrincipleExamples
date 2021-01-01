namespace SavingsAccount.Violation
{
    class SavingsAccount : IWithdraw
    {
        public SavingsAccount(int amount)
        {
            Amount = amount;
        }

        public int Balance { get; private set; }
        public int Amount { get; private set; }

        public int Withdraw()
        {
            return Balance - Amount;
        }
    }
}
