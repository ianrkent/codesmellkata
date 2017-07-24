namespace CopyAndPasteInheritance
{
    public class Transaction
    {
        public Transaction(bool isDebit, float amount)
        {
            this.IsDebit = isDebit;
            this.Amount = amount;
        }

        public bool IsDebit { get; private set; }

        public float Amount { get; private set; }
    }
}