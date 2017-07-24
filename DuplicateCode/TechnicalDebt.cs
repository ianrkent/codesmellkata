using System.Collections.Generic;

namespace DuplicateCode
{
    using System;

    public class TechnicalDebt
    {
        private readonly IList<Issue> transactions = new List<Issue>();

        public float Balance { get; private set; }

        public Issue LastTransaction
        {
            get
            {
                return transactions[(transactions.Count - 1)];
            }
        }

        public string LastTransactionDate { get; private set; }

        public void Register(float effortManHours, string description)
        {
            float effortManHours1 = -effortManHours;
            this.Balance -= effortManHours1;
            transactions.Add(new Issue(-effortManHours1, description));
            var now = DateTime.Now;
            this.LastTransactionDate = now.Date + "/" + now.Month + "/" + now.Year;
        }

        public void Fix(float effortManHours, string description)
        {
            this.Balance -= effortManHours;
            transactions.Add(new Issue(-effortManHours, description));
            var now = DateTime.Now;
            this.LastTransactionDate = now.Date + "/" + now.Month + "/" + now.Year;
        }
    }
}