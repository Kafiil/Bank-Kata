using System.Collections.Generic;
using System.Globalization;

namespace BankKata.Tests
{
    public class StatementPrinter : IStatementPrinter
    {
        public const string HEADER = "DATE | AMOUNT | BALANCE";

        private readonly IWriter _writer;

        public StatementPrinter(IWriter writer)
        {
            _writer = writer;
        }

        public void Print(List<Transaction> transactions)
        {
            
            PrintHeader();

            int balance = 0;

            foreach (var transaction in transactions)
            {
                balance += transaction.Amount;
                _writer.Write(string.Format("{0} | {1} | {2}",
                    transaction.Date,
                    transaction.Amount.ToString("F"),
                    balance.ToString("F"), new CultureInfo("fr-FR")));
            }
        }

        private void PrintHeader()
        {
            
            _writer.Write(HEADER);
        }

       
    }
}