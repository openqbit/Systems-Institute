using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenQbit.Institute.Presentation.Web.Models.Branch
{
    public class BranchItem
    {
        public int ID { get; set; }

        [Display(Name = "Branch Name")]
        public int BranchId { get; set; }

        [Display(Name = "Address")]
        public double Address { get; set; }

        [Display(Name = "Branch Email")]
        public string Email { get; set; }

        [Display(Name = "Telephone No")]
        public int TelephoneNo { get; set; }
       
    }
}