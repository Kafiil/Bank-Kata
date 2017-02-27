namespace BankKata
{
    public class Account : IAccount
    {
        private readonly ITransactionRepository _repo;
        private readonly IStatementPrinter _statementPrinter;


        public Account(ITransactionRepository repo, IStatementPrinter statementPrinter)
        {

            _statementPrinter = statementPrinter;
            _repo = repo;

        }

        public void Deposit(int amount)
        {
            _repo.Deposit(amount);
        }

        public void Withdraw(int amount)
        {
            _repo.Withdraw(-amount);
        }

        public void PrintStatements()
        {
            _statementPrinter.Print(_repo.AllTransactions());
        }
    }
}