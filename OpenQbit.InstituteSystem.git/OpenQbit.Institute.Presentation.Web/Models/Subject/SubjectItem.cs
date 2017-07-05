using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenQbit.Institute.Presentation.Web.Models
{
    public class SubjectItem
    {
        public int ID { get; set; }

        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        [Display(Name = "Subject ID")]
        public int SubjectID { get; set; }
        
    }
}