using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;

namespace BankKata.Tests
{

    [TestFixture]
    public class TransactionRepositoryTests
    {
        private ITransactionRepository _repo;
        private Mock<IClock> _clock;

        [SetUp]
        public void Init()
        {
            _clock = new Mock<IClock>();
            _repo = new TransactionRepository(_clock.Object);
        }

        [Test]
        public void Repository_Can_Deposit()
        {
            _repo.Deposit(1000);
            _clock.Verify(x => x.DayOfTransactionFormated());
            Assert.AreEqual(1000,_repo.AllTransactions().First().Amount);
        }
    }


}