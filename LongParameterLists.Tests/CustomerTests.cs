namespace LongParameterLists.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void CustomerSummaryIncludesFullNameWithTitleAndCityPostCodeAndCountry()
        {
            var customer = new Customer();
            customer.FirstName = "Jason";
            customer.LastName = "Gorman";
            customer.Title = "Mr";
            var address = new Address();
            address.City = "London";
            address.Postcode = "SW23 9YY";
            address.Country = "United Kingdom";
            customer.Address = address;
            Assert.AreEqual("Mr Jason Gorman, London, SW23 9YY, United Kingdom", customer.Summary);
        }
    }
}