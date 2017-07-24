namespace MessageChainsBonus
{
    using System.Collections.Generic;

    public class Invoice
    {
        public const double SHIPPING_COST_OUTSIDE_EU = 10;

        private readonly Customer customer;

        private readonly IList<InvoiceItem> invoiceItems = new List<InvoiceItem>();

        public Invoice(Customer customer)
        {
            this.customer = customer;
        }

        public double TotalPrice
        {
            get
            {
                double invoiceTotal = 0;

                foreach (var invoiceItem in invoiceItems)
                {
                    invoiceTotal += invoiceItem.Subtotal;
                }

                var address = customer.Address;
                var country = address.Country;

                if (!country.IsInEurope)
                {
                    invoiceTotal += SHIPPING_COST_OUTSIDE_EU;
                }
                return invoiceTotal;
            }
        }

        public void AddItem(InvoiceItem invoiceItem)
        {
            invoiceItems.Add(invoiceItem);
        }
    }
}