using System.Collections.Generic;
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
            List<Transaction> transactions = GetSomeTransactions();
            _statementPrinter.Print(transactions);
            _writer.Verify(w => w.Write("DATE | AMOUNT | BALANCE"));
            _writer.Verify(w => w.Write($"10/04/2014 | {500:F} | {1400:F}"));
            _writer.Verify(w => w.Write($"02/04/2014 | {-100:F} | {900:F}"));
            _writer.Verify(w => w.Write($"01/04/2014 | {1000:F} | {1000:F}"));
            
        }

        private List<Transaction> GetSomeTransactions()
        {
            var transactions =   new List<Transaction>
            {
                new Transaction("01/04/2014", 1000),
                new Transaction("02/04/2014", -100),
                new Transaction("10/04/2014", 500)
            };
            return transactions;
        }
    }

  
}