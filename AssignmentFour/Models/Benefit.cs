using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentFour.Models
{
    public class Benefit // benefit entity
    {
        
            [Key]
            public int Id { get; set; } // id PK

            [ForeignKey("Plan")]
            public int PlanCode { get; set; }
            public Plan Plan { get; set; }

            [ForeignKey("Staff")]
            public int StaffCode { get; set; }
            public Staff Staff { get; set; }
        }
    }

