namespace InappropriateIntimacy.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class LicenseTests
    {
        [Test]
        public void LicenseSummaryShouldIncludeLicenseHolderFullNameAndPoints()
        {
            var license = new License();
            license.addPoints(3);
            var motorist = new Motorist(license, "Gorman", "Jason", "Mr");
            Assert.AreEqual("Mr Jason Gorman, 3 points", license.Summary);
        }
    }
}