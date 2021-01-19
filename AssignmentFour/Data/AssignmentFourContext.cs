using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssignmentFour.Models;

namespace AssignmentFour.Data
{
    public class AssignmentFourContext : DbContext
    {
        public AssignmentFourContext (DbContextOptions<AssignmentFourContext> options)
            : base(options)
        {
        }

        public DbSet<AssignmentFour.Models.Plan> Plan { get; set; }

        public DbSet<AssignmentFour.Models.Staff> Staff { get; set; }

        public DbSet<AssignmentFour.Models.Job> Job { get; set; }

        public DbSet<AssignmentFour.Models.Benefit> Benefit { get; set; }
    }
}
