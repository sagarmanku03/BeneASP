using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AssignmentFour.Data;
using AssignmentFour.Models;

namespace AssignmentFour.Pages.Benefits
{
    public class CreateModel : PageModel
    {
        private readonly AssignmentFour.Data.AssignmentFourContext _context;

        public CreateModel(AssignmentFour.Data.AssignmentFourContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PlanCode"] = new SelectList(_context.Plan, "PlanCode", "PlanCode");
        ViewData["StaffCode"] = new SelectList(_context.Staff, "StaffCode", "StaffCode");
            return Page();
        }

        [BindProperty]
        public Benefit Benefit { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Benefit.Add(Benefit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
