using System;
using System.Collections.Generic;

namespace LongMethods
{
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
            if (effortManHours > 1000 || effortManHours <= 0)
            {
                throw new ArgumentException("Cannot register tech debt where effort is bigger than 1000 man hours to fix");
            }

            var priority = Priority.Low;

            if (effortManHours > 100)
            {
                priority = Priority.Medium;
            }

            if (effortManHours > 250)
            {
                priority = Priority.High;
            }

            if (effortManHours > 500)
            {
                priority = Priority.Critical;
            }

            Total += effortManHours;

            issues.Add(new Issue(effortManHours, description, priority));

            var now = DateTime.Now;
            LastIssueDate = now.Date + "/" + now.Month + "/" + now.Year;
        }
    }
}