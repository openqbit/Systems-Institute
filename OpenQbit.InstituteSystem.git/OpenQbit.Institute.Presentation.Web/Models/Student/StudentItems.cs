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

        [Display(Name = "Batch Name")]
        public int StudentId { get; set; }

        [Display(Name = "Name")]
        public string StudentName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public int Email { get; set; }

        [Display(Name = "TelNo")]
        public int TelNo { get; set; }

        [Display(Name = "Parent Name")]
        public string ParentInformationId { get; set; }

        //[Display(Name = "TelNo")]
        //public double TelNo { get; set; }
    }
}