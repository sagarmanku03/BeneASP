using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssignmentFour.Data;
using AssignmentFour.Models;

namespace AssignmentFour.Pages.Benefits
{
    public class EditModel : PageModel
    {
        private readonly AssignmentFour.Data.AssignmentFourContext _context;

        public EditModel(AssignmentFour.Data.AssignmentFourContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Benefit Benefit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Benefit = await _context.Benefit
                .Include(b => b.Plan)
                .Include(b => b.Staff).FirstOrDefaultAsync(m => m.Id == id);

            if (Benefit == null)
            {
                return NotFound();
            }
           ViewData["PlanCode"] = new SelectList(_context.Plan, "PlanCode", "PlanCode");
           ViewData["StaffCode"] = new SelectList(_context.Staff, "StaffCode", "StaffCode");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Benefit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BenefitExists(Benefit.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BenefitExists(int id)
        {
            return _context.Benefit.Any(e => e.Id == id);
        }
    }
}
