namespace HabitTracker.Models
{
    public class Goal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Goal() { }
    }
}
