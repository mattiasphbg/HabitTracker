using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HabitTracker.Data;
using HabitTracker.Models;

namespace HabitTracker.Pages.Habit
{
    public class CreateModel : PageModel
    {
        private readonly HabitTracker.Data.HabitTrackerContext _context;

        public CreateModel(HabitTracker.Data.HabitTrackerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HabitTracker.Models.Habit Habit { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Habit.Add(Habit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
