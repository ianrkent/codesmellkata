namespace DuplicateCode
{
    public class Issue
    {
        public float EffortManHours { get; set; }
        public string Description { get; set; }

        public Issue(float effortManHours, string description)
        {
            EffortManHours = effortManHours;
            Description = description;
        }
    }
}