namespace HabitTracker.Models
{
    public class Habit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } // New property added
        public Habit()
        {
            CreatedDate = DateTime.UtcNow; // Initialize CreatedDate to current UTC time
        }
    }
}
