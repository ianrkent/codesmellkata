namespace Comments
{
    using System;
    using System.Collections.Generic;

    public class TechnicalDebt
    {
        private readonly IList<Issue> issues = new List<Issue>();

        public float Total { get; private set; }

        public Issue LastIssue
        {
            get
            {
                return issues[(issues.Count - 1)];
            }
        }

        public string LastIssueDate { get; private set; }

        public void Fixed(float amount)
        {
            Total -= amount;
        }

        public void Register(float effortManHours, string description)
        {
            // check effort does not exceed max allowed
            if (effortManHours > 1000)
            {
                throw new ArgumentException("Cannot register tech debt where effort is bigger than 1000 man hours to fix");
            }

            // deduct amount from total
            Total += effortManHours;

            // record issue
            issues.Add(new Issue(effortManHours, description));

            // update last issue date
            var now = DateTime.Now;
            LastIssueDate = now.Date + "/" + now.Month + "/" + now.Year;
        }
    }
}