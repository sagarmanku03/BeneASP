using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AssignmentFour.Data;
using AssignmentFour.Models;

namespace AssignmentFour.Pages.Benefits
{
    public class DeleteModel : PageModel
    {
        private readonly AssignmentFour.Data.AssignmentFourContext _context;

        public DeleteModel(AssignmentFour.Data.AssignmentFourContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Benefit = await _context.Benefit.FindAsync(id);

            if (Benefit != null)
            {
                _context.Benefit.Remove(Benefit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
