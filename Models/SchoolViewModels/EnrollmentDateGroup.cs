using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime? EnrollmentDate { get; set; }

        [Display(Name = "Students")]
        public int StudentCount { get; set; }
    }
}
