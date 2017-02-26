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
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void PrintAllStatements_MakeSomeTransactions_PrintedSummary()
        {
            _account.Deposit(1000);
            _account.Withdraw(100);
            _account.Deposit(500);

            var transactions = _repo.AllTransactions();

            _account.PrintStatements();

            _statementPrinter.Verify(x => x.Print(transactions));
        }
    }


}