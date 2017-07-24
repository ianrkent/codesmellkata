namespace InappropriateIntimacy.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class MotoristTests
    {
        private Motorist createMotoristWithPointsOnLicense(int points)
        {
            var license = new License();
            license.addPoints(points);
            var motorist = new Motorist(license, "", "", "");
            return motorist;
        }

        [Test]
        public void MotoristWithMoreThanThreePointsOnLicenseIsHighRisk()
        {
            Assert.AreEqual(RiskFactor.HIGH_RISK, createMotoristWithPointsOnLicense(4).RiskFactor);
        }

        [Test]
        public void MotoristWithNoPointsOnLicenseIsLowRisk()
        {
            Assert.AreEqual(RiskFactor.LOW_RISK, createMotoristWithPointsOnLicense(0).RiskFactor);
        }

        [Test]
        public void MotoristWithOneToThreePointsOnLicenseIsModerateRisk()
        {
            Assert.AreEqual(RiskFactor.MODERATE_RISK, createMotoristWithPointsOnLicense(1).RiskFactor);
        }
    }
}