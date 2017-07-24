namespace DuplicateCode.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class TechnicalDebtShould
    {
        [Test]
        public void AddAmountFromBalanceRecordTransactionAndUpdateLastDebitDate()
        {
            var account = new TechnicalDebt();
            account.Register(50, "Some technical debt");
            Assert.AreEqual(50, account.Balance);
            var lastTransaction = account.LastTransaction;
            Assert.AreEqual(50, lastTransaction.EffortManHours);

            var now = DateTime.Now;

            Assert.AreEqual(now.Date + "/" + now.Month + "/" + now.Year, account.LastTransactionDate);
        }

        [Test]
        public void DeductAmountFromBalanceRecordTransactionAndUpdateLastdebitDate()
        {
            var account = new TechnicalDebt();
            account.Register(100, "Some technical debt");
            account.Fix(50, "Fix technical debt");
            Assert.AreEqual(50, account.Balance);
            var lastTransaction = account.LastTransaction;
            Assert.AreEqual(-50, lastTransaction.EffortManHours);

            var now = DateTime.Now;

            Assert.AreEqual(now.Date + "/" + now.Month + "/" + now.Year, account.LastTransactionDate);
        }
    }
}