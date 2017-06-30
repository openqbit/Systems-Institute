using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenQbit.Institute.Presentation.Web.Models.Parent
{
    public class ParentItem
    {
        public int ID { get; set; }

        [Display(Name = "Parent Name")]
        public int ParentId { get; set; }

        [Display(Name = "Name")]
        public string ParentName { get; set; }

        [Display(Name = "Address")]
        public double Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telephone No")]
        public int TelephoneNo { get; set; }

    }
}