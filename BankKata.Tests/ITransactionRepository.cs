using System.Collections.Generic;

namespace BankKata.Tests
{
    public interface ITransactionRepository
    {
        List<ITransaction> AllTransactions();
        void Deposit(int i);
        void Withdraw(int i);
    }
}