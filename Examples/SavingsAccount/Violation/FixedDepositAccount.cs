using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavingsAccount.Violation
{
    class FixedDepositAccount : IWithdraw
    {
        public FixedDepositAccount(int amount)
        {

        }
        public int Withdraw()
        {
            throw new NotImplementedException("Cannot Withdraw");
        }
    }
}
