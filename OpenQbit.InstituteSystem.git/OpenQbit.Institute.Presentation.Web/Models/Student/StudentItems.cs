using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenQbit.Institute.Presentation.Web.Models.Student
{
    public class StudentItems
    {
        public int ID { get; set; }

        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Display(Name = "Name")]
        public string StudentName { get; set; }

        [Display(Name = "Address")]
        public double Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telephone No")]
        public int TelephoneNo { get; set; }

        [Display(Name = "Parent Name")]
        public string ParentInformationId { get; set; }

        //[Display(Name = "TelNo")]
        //public double TelNo { get; set; }
    }
}