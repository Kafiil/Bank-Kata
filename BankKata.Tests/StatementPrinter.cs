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

            PrintLines(transactions);
        }

        private void PrintLines(List<Transaction> transactions)
        {
            int balance = 0;
            var lines = new List<string>();

            foreach (var transaction in transactions)
            {
                balance += transaction.Amount;
                lines.Add(GetTransactionLine(transaction, balance));
                
            }

            lines.Reverse();

            foreach (var line in lines)
            {
                _writer.Write(line);
            }
        }

        private string  GetTransactionLine(Transaction transaction, int balance)
        {
            return string.Format("{0} | {1} | {2}",
                transaction.Date,
                transaction.Amount.ToString("F"),
                balance.ToString("F"), new CultureInfo("fr-FR"));
            
        }

        private void PrintHeader()
        {
            
            _writer.Write(HEADER);
        }

       
    }
}