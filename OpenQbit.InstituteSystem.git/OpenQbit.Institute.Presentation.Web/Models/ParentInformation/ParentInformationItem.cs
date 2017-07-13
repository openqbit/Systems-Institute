using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenQbit.Institute.Presentation.Web.Models.ParentInformation
{
    public class ParentInformationItem
    {
        public int ID { get; set; }

        [Display (Name = "ParentInformation ID")]
        public int ParentInformationId { get; set; }

        [Display (Name ="Mother ID")]
        public int MotherId { get; set; }

        [Display (Name ="Father ID")]
        public int FatherId { get; set; }

        [Display (Name ="Primary Contact Number")]
        public int PrimaryContactNumber { get; set; }
    }
}
