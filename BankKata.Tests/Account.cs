using Moq;

namespace BankKata.Tests
{
    public  class Account : IAccount
    {
        private Mock<ITransactionRepository> _repo;
        private Mock<IStatementPrinter> _statementPrinter;

        public Account(Mock<ITransactionRepository> repo, Mock<IStatementPrinter> statementPrinter)
        {
            this._repo = repo;
            this._statementPrinter = statementPrinter;
        }

        public void Deposit(int p0)
        {
            throw new System.NotImplementedException();
        }

        public void Withdraw(int i)
        {
            throw new System.NotImplementedException();
        }

        public void PrintStatements()
        {
            throw new System.NotImplementedException();
        }
    }
}