namespace LongMethods
{
    public class Issue
    {
        public float EffortManHours { get; set; }

        public string Description { get; set; }

        public Priority Priority { get; set; }

        public Issue(float effortManHours, string description)
        {
            EffortManHours = effortManHours;
            Description = description;
        }

        public Issue(float effortManHours, string description, Priority priority) 
            : this(effortManHours, description)
        {
            this.Priority = priority;
        }
    }
}