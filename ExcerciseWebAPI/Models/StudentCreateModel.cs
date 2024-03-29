﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExcerciseWebAPI.Models
{
    public class StudentCreateModel
    {
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstMidName { get; set; }
        public DateTime? EnrollmentDate { get; set; }
    }
    public class StudentEditModel
    {
        public int StudentID { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstMidName { get; set; }
    }
}
