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
    public class DetailsModel : PageModel
    {
        private readonly AssignmentFour.Data.AssignmentFourContext _context;

        public DetailsModel(AssignmentFour.Data.AssignmentFourContext context)
        {
            _context = context;
        }

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
    }
}
