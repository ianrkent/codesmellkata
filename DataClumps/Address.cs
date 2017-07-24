namespace DataClumps
{
    public class Address
    {
        public string House { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public string GetAddressSummary()
        {
            return House + ", " + Street + ", " + City + ", " + Postcode + ", "
                   + Country;
        }
    }
}