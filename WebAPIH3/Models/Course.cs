using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIH3.Models
{
    public class Course
    {
        [Key]
        [Required]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Trainer { get; set; }
        public int Fees { get; set; }
        public string CourseDescription { get; set; }
    }
}