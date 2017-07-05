﻿using System;
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
        public string BranchName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telepone No")]
        public int TelephoneNo { get; set; }

        [Display(Name = "Parent Name")]
        public string ParentInformationID { get; set; }
    }
}