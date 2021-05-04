using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Assignment
    {
        [Column("AssignmentId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Assignment name is a required field.")]
        [MaxLength(15, ErrorMessage = "Must contain a combincation of numbers and letters.")]
        public string AssignmentName { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}