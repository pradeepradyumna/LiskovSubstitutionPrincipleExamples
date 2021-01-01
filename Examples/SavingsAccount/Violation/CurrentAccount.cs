namespace SavingsAccount.Violation
{
    class CurrentAccount : IWithdraw
    {
        public CurrentAccount(int amount)
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
