namespace SwitchStatements.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class InsuranceQuotationTests
    {
        private RiskFactor calculateMotoristRisk(string dateOfBirth, int pointsOnLicense)
        {
            return buildInsuranceQuoteForMotorist(dateOfBirth, pointsOnLicense).CalculateMotoristRisk();
        }

        private InsuranceQuote buildInsuranceQuoteForMotorist(string dateOfBirth, int pointsOnLicense)
        {
            return new InsuranceQuote(new Motorist(parseDate(dateOfBirth), pointsOnLicense));
        }

        private DateTime parseDate(string dateOfBirth)
        {
            return DateTime.Parse(dateOfBirth);
        }

        [Test]
        public void AnyMotoristUnderTwentyFiveIsHighRisk()
        {
            Assert.AreEqual(RiskFactor.HIGH_RISK, calculateMotoristRisk("1995-01-01", 0));
        }

        [Test]
        public void HighRiskMotoristsPayPremiumOfSixPercentOfInsuranceValue()
        {
            var quote = buildInsuranceQuoteForMotorist("1990-01-01", 5);
            Assert.AreEqual(600, quote.CalculateInsurancePremium(10000));
        }

        [Test]
        public void LowRiskMotoristsPayPremiumOfTwoPercentOfInsuranceValue()
        {
            var quote = buildInsuranceQuoteForMotorist("1960-01-01", 0);
            Assert.AreEqual(200, quote.CalculateInsurancePremium(10000));
        }

        [Test]
        public void ModerateRiskMotoristsPayPremiumOfFourPercentOfInsuranceValue()
        {
            var quote = buildInsuranceQuoteForMotorist("1960-01-01", 1);
            Assert.AreEqual(400, quote.CalculateInsurancePremium(10000));
        }

        [Test]
        public void MotoristWithMoreThanThreePointsOnLicenseOverTwentyFivePresentsHighRisk()
        {
            Assert.AreEqual(RiskFactor.HIGH_RISK, calculateMotoristRisk("1970-01-01", 4));
        }

        [Test]
        public void MotoristWithNoPointsOnLicenseAndOverTwentyFivePresentsLowRisk()
        {
            Assert.AreEqual(RiskFactor.LOW_RISK, calculateMotoristRisk("1970-01-01", 0));
        }

        [Test]
        public void MotoristWithOneToThreePointsOnLicenseAndOverTwentyFivePresentsModerateRisk()
        {
            Assert.AreEqual(RiskFactor.MODERATE_RISK, calculateMotoristRisk("1970-01-01", 3));
        }
    }
}