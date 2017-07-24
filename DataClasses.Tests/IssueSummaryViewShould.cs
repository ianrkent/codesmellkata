namespace DataClasses.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class IssueSummaryViewShould
    {
        [Test]
        public void CustomerSummaryIncludesFullNameWithTitleAndCityPostCodeAndCountry()
        {
            var issue = new Issue(10, "Some critical issue", Priority.Critical);
            var summary = new IssueSummarizer(issue).IssueSummary;

            Assert.AreEqual("Description:'Some critical issue' Effort:'10' Priority:'Critical'", summary);
        }
    }
}