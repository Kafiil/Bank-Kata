using System.Collections.Generic;

namespace BankKata.Tests
{
    public interface ITransactionRepository
    {
        List<ITransaction> AllTransactions();
    }
}