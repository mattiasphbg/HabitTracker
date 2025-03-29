using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<Goal> Records { get; set; }

        public DbSet<User> Users { get; set; }




    }
}
