using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AssignmentFour.Data;
using AssignmentFour.Models;

namespace AssignmentFour.Pages.Jobs
{
    public class DetailsModel : PageModel
    {
        private readonly AssignmentFour.Data.AssignmentFourContext _context;

        public DetailsModel(AssignmentFour.Data.AssignmentFourContext context)
        {
            _context = context;
        }

        public Job Job { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job = await _context.Job
                .Include(j => j.Staff).FirstOrDefaultAsync(m => m.JobCode == id);

            if (Job == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
