using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HabitTracker.Data;
using HabitTracker.Models;


namespace HabitTracker.Pages.Habit
{    


public class IndexModel : PageModel
    {
        private readonly HabitTracker.Data.HabitTrackerContext _context;

        public IndexModel(HabitTracker.Data.HabitTrackerContext context)
        {
            _context = context;
        }

        public IList<HabitTracker.Models.Habit> Habit { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Habit = await _context.Habit.ToListAsync();
        }
    }
}
