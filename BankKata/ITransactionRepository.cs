using System.Collections.Generic;

namespace BankKata
{
    public interface ITransactionRepository
    {
        List<Transaction> AllTransactions();
        void Deposit(int i);
        void Withdraw(int i);
    }
}