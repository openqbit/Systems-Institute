using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class SubjectEnrolment
    {
        public int SubjectEnrolmentId { get; set; }

        public int SubjectId { get; set; }

        public int StudentId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}
