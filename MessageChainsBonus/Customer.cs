namespace MessageChainsBonus
{
    public class Customer
    {
        public Customer(Address address)
        {
            this.Address = address;
        }

        public Address Address { get; private set; }
    }
}