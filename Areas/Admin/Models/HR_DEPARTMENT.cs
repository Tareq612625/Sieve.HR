﻿using Sieve.HR.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_DEPARTMENT
    {
        public HR_DEPARTMENT()
        {
            HR_SECTIONS_NAV = new HashSet<HR_SECTIONS>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Company Id")]
        [Required(ErrorMessage = "{0} is required")]
        public int COMP_ID { get; set; }


        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? DEPT_NAME { get; set; }

        [Display(Name = "Department Address")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(250, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? DEPT_ADDR { get; set; }

        [Display(Name = "Department Head")]
        [Required(ErrorMessage = "{0} is required")]
        public int HEAD_EMP_ID { get; set; }

        [Display(Name = "Total Employees")]
        [Required(ErrorMessage = "{0} is required")]
        public int MAX_EMP_NO { get; set; } = 5;

        [Display(Name = "Total Salary")]
        [Required(ErrorMessage = "{0} is required")]
        public int MAX_SALARY { get; set; } = 500000;



        //Foreign Key
        [ForeignKey("COMP_ID")]
        public virtual HR_COMPANY HR_COMPANY { get; set; } = null!;

        //For Navigation
        public virtual ICollection<HR_SECTIONS> HR_SECTIONS_NAV { get; set; } = null!;
    }
}
