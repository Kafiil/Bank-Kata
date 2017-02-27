using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;

namespace BankKata.Tests
{

    [TestFixture]
    public class StatementPrinterTests
    {
        private IStatementPrinter _statementPrinter;
        private Mock<IWriter> _writer;

        [SetUp]
        public void Init()
        {
            _writer = new Mock<IWriter>();
            _statementPrinter = new StatementPrinter(_writer.Object);
        }

        [Test]
        public void PrintAllStatements()
        {
            List<ITransaction> transactions = GetSomeTransactions();
            _statementPrinter.Print(transactions);
            _writer.Verify(w => w.Write("DATE | AMOUNT | BALANCE"));
        }

        private List<ITransaction> GetSomeTransactions()
        {
            return null;
        }
    }

  
}