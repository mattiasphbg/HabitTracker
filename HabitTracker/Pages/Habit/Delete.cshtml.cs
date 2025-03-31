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
    public class DeleteModel : PageModel
    {
        private readonly HabitTracker.Data.HabitTrackerContext _context;

        public DeleteModel(HabitTracker.Data.HabitTrackerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HabitTracker.Models.Habit Habit { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habit = await _context.Habits.FirstOrDefaultAsync(m => m.Id == id);

            if (habit is not null)
            {
                Habit = habit;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habit = await _context.Habits.FindAsync(id);
            if (habit != null)
            {
                Habit = habit;
                _context.Habits.Remove(Habit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
