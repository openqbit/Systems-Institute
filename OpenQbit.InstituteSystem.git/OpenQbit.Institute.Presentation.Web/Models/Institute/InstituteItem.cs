using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace OpenQbit.Institute.Presentation.Web.Models.Institute
{
    public class InstituteItem
    {
        public int ID { get; set; }

        [Display(Name = "Institute Name")]
        public string InstituteName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telepone No")]
        public int TelephoneNo { get; set; }

        [Display(Name = "Branch Name")]
        public string InstituteInformationID { get; set; }
    }
}