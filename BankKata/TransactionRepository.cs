using System.Collections.Generic;

namespace BankKata
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IClock _clock;
        private List<Transaction> transactions = new List<Transaction>();

        public TransactionRepository(IClock clock)
        {
            _clock = clock;
            
        }

        public List<Transaction> AllTransactions()
        {
            return transactions;
        }

        public void Deposit(int amount)
        {
            var today = _clock.DayOfTransactionFormated();
            var transaction = new Transaction(today,amount);

            transactions.Add(transaction);

        }

        public void Withdraw(int amount)
        {
            var today = _clock.DayOfTransactionFormated();
            var transaction = new Transaction(today, -amount);

            transactions.Add(transaction);
        }
    }
}