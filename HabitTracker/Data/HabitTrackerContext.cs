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

        public DbSet<HabitTracker.Models.Habit> Habit { get; set; } = default!;
    }
}
