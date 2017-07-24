namespace CopyAndPasteInheritance.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class LoyaltyAccountTests
    {
        [Test]
        public void DebitingAccountShouldDeductAmountFromBalanceRecordTransactionAndUpdateLastdebitDate()
        {
            var account = new LoyaltyAccount();
            account.Credit(100);
            account.Debit(50);
            Assert.AreEqual(50, account.Balance);
            var lastTransaction = account.LastTransaction;
            Assert.AreEqual(-50, lastTransaction.Amount);

            var now = DateTime.Now;

            Assert.AreEqual(now.Date + "/" + now.Month + "/" + now.Year, account.LastTransactionDate);
        }
    }
}