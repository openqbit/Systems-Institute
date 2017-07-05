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

        [Display(Name = "Staff Name")]
        public string StaffName { get; set; }

    }
}