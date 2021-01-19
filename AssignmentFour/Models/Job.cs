using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentFour.Models
{
    public class Job // job entity
    {
        [Key]
        public int JobCode { get; set; } // job code PK
        public string Description { get; set; } // desc of the job
        public bool isAvailable { get; set; } // job available or not

        // creating Foreign key relation
        [ForeignKey("Staff")]
        public int StaffCode { get; set; }
        public Staff Staff { get; set; }
    }
}
