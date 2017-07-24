namespace CopyAndPasteInheritance
{
    using System;
    using System.Collections;

    public class LoyaltyAccount
    {
        private readonly IList transactions = new ArrayList();

        private int loyaltyPoints;

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
            loyaltyPoints++;
        }

        public void Debit(float amount)
        {
            executeTransaction(-amount);
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