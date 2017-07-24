namespace MessageChainsBonus
{
    public class Country
    {
        public Country(bool inEurope)
        {
            this.IsInEurope = inEurope;
        }

        public bool IsInEurope { get; private set; }
    }
}