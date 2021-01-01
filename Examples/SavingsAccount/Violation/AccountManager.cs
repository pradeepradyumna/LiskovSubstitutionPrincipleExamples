namespace SavingsAccount.Violation
{
    public class AccountManager
    {
        public int WithdrawMoney(IWithdraw withdraw)
        {
            return withdraw.Withdraw();
        }
    }

    class Client
    {

        public static void Main()
        {
            AccountManager acc = new AccountManager();

            int amount = 500;

            acc.WithdrawMoney(new SavingsAccount(amount));
            acc.WithdrawMoney(new CurrentAccount(amount));

            // This throws exception, as practically its not possible to withdra any money from such account
            acc.WithdrawMoney(new FixedDepositAccount(amount));

        }
    }
}
