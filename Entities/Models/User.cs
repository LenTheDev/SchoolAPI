using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class User
    {
        [Column("UserId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "User name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        [MinLength(5, ErrorMessage = "Minimum length for the Name is 60 characters.")]

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[ForeignKey(nameof(Organization))]
        public Guid OrganizationId { get; set; }

        //public Organization Organization { get; set; }
    }
}