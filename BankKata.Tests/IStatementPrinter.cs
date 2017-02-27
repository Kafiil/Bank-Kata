using System.Collections.Generic;
using NUnit.Framework;

namespace BankKata.Tests
{
    public interface IStatementPrinter
    {
       
        void Print(List<Transaction> transactions);
    }
}