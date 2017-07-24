namespace LongParameterLists
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public Address Address { get; set; }

        public string Summary
        {
            get
            {
                return buildCustomerSummary(
                    FirstName,
                    LastName,
                    Title,
                    this.Address.City,
                    this.Address.Postcode,
                    this.Address.Country);
            }
        }

        private string buildCustomerSummary(
            string customerFirstName,
            string customerLastName,
            string customerTitle,
            string customerCity,
            string customerPostCode,
            string customerCountry)
        {
            return customerTitle + " " + customerFirstName + " " + customerLastName + ", " + customerCity + ", "
                   + customerPostCode + ", " + customerCountry;
        }
    }
}