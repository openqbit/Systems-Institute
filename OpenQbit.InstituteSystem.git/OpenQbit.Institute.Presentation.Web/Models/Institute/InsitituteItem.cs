using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenQbit.Institute.Presentation.Web.Models.Institute
{
    public class InsitituteItem
    {

        public int ID { get; set; }

        [Display(Name = "Institute Name")]
        public int InstituteId { get; set; }

        [Display(Name = "Address")]
        public double Address { get; set; }

        [Display(Name = "Institute Email")]
        public string Email { get; set; }

        [Display(Name = "Telephone No")]
        public int TelephoneNo { get; set; }
    }
}