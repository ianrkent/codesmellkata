namespace DataClumps
{
    public class Customer
    {
        public Customer(string title, string firstName, string lastName, string house, string street, string city, string postCode, string country)
        {
            House = house;
            Street = street;
            City = city;
            PostCode = postCode;
            Country = country;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string House { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        
        public string AddressSummary
        {
            get
            {
                return House + ", " + Street + ", " + City + ", " + PostCode + ", " + Country;
            }
        }
    }
}