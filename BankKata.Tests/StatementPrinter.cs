using System.Collections.Generic;

namespace BankKata.Tests
{
    public class StatementPrinter : IStatementPrinter
    {
        private IWriter _writer;

        public StatementPrinter(IWriter writer)
        {
            _writer = writer;
        }

        public void Print(List<ITransaction> transactions)
        {
            PrintHeader();
        }

        private void PrintHeader()
        {
            _writer.Write("DATE | AMOUNT | BALANCE");
        }
    }
}