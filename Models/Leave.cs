using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LeaveSystem.Models
{
    public class Leave
    {   
        [Key]
        [Required]
        [DisplayName("Leave Id")]
        public int leaveId { get; set; }


        [Required]
        [DisplayName("Starting Date")]
        [DataType(DataType.Date)]
        public DateTime leaveFrom { get; set; }


        [Required]
        [DisplayName("Ending Date")]
        [DataType(DataType.Date)]
        public DateTime leaveTo { get; set; }

        [Required]
        [DisplayName("Number of Days")]
        public int leaveNdays { get; set; }


        [Required]
        [DisplayName("Apply Date")]
        [DataType(DataType.Date)]
        public DateTime leaveApplyDate { get; set; }


        [Required]
        [DisplayName("Leave Type")]
        [StringLength(15, MinimumLength = 5)]
        public string leaveType { get; set; }


        [Required]
        [DisplayName("Leave Reason")]
        [StringLength(15, MinimumLength = 5)]
        public string leaveReason { get; set; }


        [Required]
        [DisplayName("Leave Status")]
        [StringLength(15, MinimumLength = 6)]
        public string lStatus { get; set; }


        public Employee Employee { get; set; }

        [DisplayName("Employee Id")]
        public int empId { get; set; }


    }
}