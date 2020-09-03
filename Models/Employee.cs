using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LeaveSystem.Models
{
    public class Employee
    {

        [DisplayName("Email Id")]
        [Key]
        [Required]
        public int empId { get; set; }

        [DisplayName("Manager Id")]
        [Required]
        public int mgrId { get; set; }

        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(30, MinimumLength = 10)]
        public String fullName { get; set; }


        [DisplayName("Department")]
        [Required(ErrorMessage = "Please enter Department")]
        [StringLength(15, MinimumLength = 8)]
        public String deptName { get; set; }

        [DisplayName("Mail Id")]
        [Required]
        [EmailAddress]
        public String mailId { get; set; }

        [DisplayName("Mobile Number")]
        public double contactNo { get; set; }


        [DisplayName("Available Leaves")]
        [Required]
        public int availLeaves { get; set; }

        [DisplayName("DateOfJoining")]
        [Required(ErrorMessage = "Please Enter Date of Joining")]
        [DataType(DataType.Date)]
        public DateTime doj { get; set; }
    }
}