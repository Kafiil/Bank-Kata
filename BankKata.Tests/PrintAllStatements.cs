using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;

namespace BankKata.Tests
{

    [TestFixture]
    public class PrintAllStatements
    {
        private IAccount _account;
        private Mock<ITransactionRepository> _repo;
        private Mock<IStatementPrinter> _statementPrinter;

        [SetUp]
        public void Init()
        {
            _statementPrinter = new Mock<IStatementPrinter>();
            _repo = new Mock<ITransactionRepository>();

            _account = new Account(_repo.Object, _statementPrinter.Object);
        }

        [Test]
        public void PrintAllStatements_MakeSomeTransactions_PrintedSummary()
        {
            _account.Deposit(1000);
            _account.Withdraw(100);
            _account.Deposit(500);

            List<Transaction> transactions = _repo.Object.AllTransactions();

            _account.PrintStatements();

            _statementPrinter.Verify(x => x.Print(transactions));
        }
    }


}