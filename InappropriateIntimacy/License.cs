namespace InappropriateIntimacy
{
    public class License
    {
        private Motorist motorist;

        public Motorist Motorist
        {
            set
            {
                motorist = value;
            }
        }

        public int Points { get; private set; }

        public string Summary
        {
            get
            {
                return motorist.Title + " " + motorist.FirstName + " " + motorist.Surname + ", " + Points + " points";
            }
        }

        public void addPoints(int points)
        {
            this.Points += points;
        }
    }
}