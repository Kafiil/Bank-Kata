namespace BankKata
{
    public class Transaction : ITransaction
    {
        public string Date { get; private set; }
        public int Amount { get; private set; }

        public Transaction(string date, int amount)
        {
            Date = date;
            Amount = amount;
            
        }
    }
}