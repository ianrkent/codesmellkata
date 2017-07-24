namespace CopyAndPasteInheritance.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class SettlementAccountTests
    {
        [Test]
        public void DebitingAccountShouldDeductAmountFromBalanceRecordTransactionAndUpdateLastdebitDate()
        {
            var account = new SettlementAccount();
            account.Credit(100);
            account.Debit(50);
            Assert.AreEqual(50, account.Balance);
            var lastTransaction = account.LastTransaction;
            Assert.AreEqual(-50, lastTransaction.Amount);

            var now = DateTime.Now;

            Assert.AreEqual(now.Date + "/" + now.Month + "/" + now.Year, account.LastTransactionDate);
        }

        [Test]
        public void SettlingAccountShouldDeductOwingFromBalance()
        {
            var account = new SettlementAccount();
            account.Credit(100);
            account.Borrow(50);
            account.Settle();
            Assert.AreEqual(50, account.Balance, 0);
        }
    }
}