using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenQbit.Institute.Presentation.Web.Models.Staff
{
    public class StaffItem
    {
        public int ID { get; set; }

        [Display(Name = "Staff ID")]
        public string StaffID { get; set; }
        [Display(Name = "Staff Name")]
        public string StaffName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Telephone")]
        public int Telephone { get; set; }
        [Display(Name = "Category")]
        public string Category { get; set; }
        [Display(Name = "Employee ID")]
        public string EmployeeID { get; set; }

    }
}
