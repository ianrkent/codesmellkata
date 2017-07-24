namespace MessageChainsBonus.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class InvoiceTests
    {
        [Test]
        public void ShippingShouldBeAddedIfAddressIsNotInEurope()
        {
            var address = new Address(new Country(false));
            var customer = new Customer(address);

            var invoice = new Invoice(customer);
            invoice.AddItem(new InvoiceItem("Product X", 1, 100));

            Assert.AreEqual(100 + Invoice.SHIPPING_COST_OUTSIDE_EU, invoice.TotalPrice);
        }
    }
}