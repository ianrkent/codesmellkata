namespace InappropriateIntimacy
{
    public class Motorist
    {
        public License license;

        public Motorist(License license, string surname, string firstName, string title)
        {
            license.Motorist = this;
            this.license = license;
            this.Surname = surname;
            this.FirstName = firstName;
            this.Title = title;
        }

        public string Surname { get; private set; }

        public string FirstName { get; private set; }

        public string Title { get; private set; }

        public RiskFactor RiskFactor
        {
            get
            {
                if (license.Points > 3)
                {
                    return RiskFactor.HIGH_RISK;
                }
                if (license.Points > 0)
                {
                    return RiskFactor.MODERATE_RISK;
                }
                return RiskFactor.LOW_RISK;
            }
        }
    }
}