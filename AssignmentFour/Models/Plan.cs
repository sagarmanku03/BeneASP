using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentFour.Models
{
    public class Plan // plan entity
    {
        [Key]
        public int PlanCode { get; set; } //  plan code PK

        public string PlanDescription { get; set; } // plan descriotjn
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } // end date for the project

        public List<Benefit> Benefits { get; set; } // for list of benfits: making ref for FK
        public Plan()
        {
            Benefits = new List<Benefit>();// object creation
        }
    }
}
