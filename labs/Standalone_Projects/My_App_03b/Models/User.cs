using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace My_App_03b.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "Username")]
        public int Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public int Password { get; set; }

        [Display(Name = "First Name")]
        public int FirstName { get; set; }

        [Display(Name = "Last Name")]
        public int LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [Display(Name = "Email ID")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid")]
        public int Email { get; set; }

        [Display(Name = "Mobile")]
        public int Mobile { get; set; }
    }
}