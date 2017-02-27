using System.Collections.Generic;

namespace BankKata.Tests
{
    public interface ITransactionRepository
    {
        List<Transaction> AllTransactions();
        void Deposit(int i);
        void Withdraw(int i);
    }
}