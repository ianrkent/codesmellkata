namespace Comments.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TechnicalDebtShould
    {
        private TechnicalDebt technicalDebt;

        [SetUp]
        public void BeforeEach()
        {
            technicalDebt = new TechnicalDebt();
        }

        [Test]
        public void FixingIssueIssueDeductsEffortFromTotal()
        {
            technicalDebt.Register(50, "Declared Issue class in same file as TechnicalDebt class");

            technicalDebt.Fixed(50);

            Assert.AreEqual(0, technicalDebt.Total);
        }

        [Test]
        public void RegisteringIssueIncreasesTotal()
        {
            technicalDebt.Register(50, "Declared Issue class in same file as TechnicalDebt class");

            Assert.AreEqual(50, technicalDebt.Total);
        }

        [Test]
        public void RegisteringIssueUpdatesLastIssueDate()
        {
            technicalDebt.Register(50, "Declared Issue class in same file as TechnicalDebt class");

            var now = DateTime.Now;
            Assert.AreEqual(now.Date + "/" + now.Month + "/" + now.Year, technicalDebt.LastIssueDate);
        }

        [Test]
        public void RegisteringMoreThanMaxAllowedEffortThrowsException()
        {
            Assert.Throws<ArgumentException>(() => technicalDebt.Register(1001, "The PM forced me to register this"));
        }
    }
}