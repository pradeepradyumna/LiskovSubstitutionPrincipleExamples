using SavingsAccount.Violation;

namespace SavingsAccount
{
    public class AccountManager
    {
        public int WithdrawMoney(IWithdraw withdraw)
        {
            return withdraw.Withdraw();
        }

        public void HandleNonSavingsAccount(IWithdrawAfterMaturity withdraw)
        {
             withdraw.TransferToSavingsAccount();
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

            acc.HandleNonSavingsAccount(new FixedDepositAccount());

        }
    }
}
