using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Course
    {
        [Column("CourseId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Course name is a required field.")]
        [MaxLength(15, ErrorMessage = "Must begin with department ID followed by course number.")]
        public string CourseName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}