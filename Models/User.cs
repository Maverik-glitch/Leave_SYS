using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeaveSystem.Models
{
    public class User
    {
        [Key]
        public int userid { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Display(Name ="Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [Display(Name = "Email Id")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is not in correct format")]
        public string email { get; set; }
    }
}