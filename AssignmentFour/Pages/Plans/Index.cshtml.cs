﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AssignmentFour.Data;
using AssignmentFour.Models;

namespace AssignmentFour.Pages.Plans
{
    public class IndexModel : PageModel
    {
        private readonly AssignmentFour.Data.AssignmentFourContext _context;

        public IndexModel(AssignmentFour.Data.AssignmentFourContext context)
        {
            _context = context;
        }

        public IList<Plan> Plan { get;set; }

        public async Task OnGetAsync()
        {
            Plan = await _context.Plan.ToListAsync();
        }
    }
}
