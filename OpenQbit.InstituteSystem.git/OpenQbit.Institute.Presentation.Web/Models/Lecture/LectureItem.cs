using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OpenQbit.Institute.Presentation.Web.Models.Lecture
{
    public class LectureItem
    {
        public int ID { get; set; }

        [Display(Name = "Lecture Name")]
        public string LectureName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telepone No")]
        public int TelephoneNo { get; set; }

    }
}