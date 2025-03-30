using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HabitTracker.Models;

namespace HabitTracker.Data
{
    public class HabitTrackerContext : DbContext
    {
        public HabitTrackerContext (DbContextOptions<HabitTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Habit> Habits { get; set; } = default!;
        public DbSet<HabitLog> HabitLog { get; set; } = default!;
        public DbSet<Goal> Goals { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
    }
}
