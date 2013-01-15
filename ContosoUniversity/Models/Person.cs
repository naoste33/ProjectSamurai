using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public abstract class Person
    {

        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Column("FirstName")]
        [MaxLength(50)]
        public string FirstMidName { get; set; }
         
        public string FullName
        {

            get
            {
                return LastName + " " + FirstMidName;
            }

        }
    }
}
