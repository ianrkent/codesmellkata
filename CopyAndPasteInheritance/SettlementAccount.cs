namespace CopyAndPasteInheritance
{
    using System;
    using System.Collections;

    public class SettlementAccount
    {
        private readonly IList transactions = new ArrayList();

        private float owing;

        public float Balance { get; private set; }

        public Transaction LastTransaction
        {
            get
            {
                return (Transaction)transactions[transactions.Count - 1];
            }
        }

        public string LastTransactionDate { get; private set; }

        public void Credit(float amount)
        {
            executeTransaction(amount);
        }

        public void Debit(float amount)
        {
            executeTransaction(-amount);
        }

        public void Borrow(float amount)
        {
            owing += amount;
        }

        public void Settle()
        {
            this.Balance -= owing;
        }

        private void executeTransaction(float amount)
        {
            this.Balance += amount;
            recordTransaction(amount);
            updateLastTransactionDate();
        }

        private void recordTransaction(float amount)
        {
            transactions.Add(new Transaction(true, amount));
        }

        private void updateLastTransactionDate()
        {
            var now = DateTime.Now;
            this.LastTransactionDate = now.Date + "/" + now.Month + "/" + now.Year;
        }
    }
}