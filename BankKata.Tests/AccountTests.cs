using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;

namespace BankKata.Tests
{

    [TestFixture]
    public class AccountTests
    {
        private IAccount _account;
        private Mock<ITransactionRepository> _repo;
        private Mock<IStatementPrinter> _statementPrinter;


        [SetUp]
        public void Init()
        {
            _repo = new Mock<ITransactionRepository>();
            _statementPrinter = new Mock<IStatementPrinter>();
            _account = new Account(_repo.Object,_statementPrinter.Object);
        }

        [Test]
        public void Account_Can_Make_A_Deposit()
        {
            _account.Deposit(1000);
            _repo.Verify(r => r.Deposit(1000));
        }

        [Test]
        public void Account_Can_Make_A_Withdraw()
        {
            _account.Withdraw(100);
            _repo.Verify(r => r.Withdraw(-100));
        }

        [Test]
        public void Account_Can_PrintAllStatement()
        {
            _account.PrintStatements();
            var transactions = _repo.Object.AllTransactions();
            _statementPrinter.Verify(r => r.Print(transactions));
        }
    }


}