using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Nic { get; set; }
        public int TelNo { get; set; }
        public int ParentInformationId { get; set; }
        public int PersonId { get; set; }
        public virtual ParentInformation ParentInformation { get; set; }
        public virtual Person Pereson { get;set ;}
        public ICollection<BatchEnrolment> BatchEnrolment { get; set; }


    }
}
