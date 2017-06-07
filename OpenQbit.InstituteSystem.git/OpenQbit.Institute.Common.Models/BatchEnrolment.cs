using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class BatchEnrolment
    {
        public int BatchEnrolmentId { get; set; }

        public int StudentLimit { get; set; }

        public int TimeDuration { get; set; }
        public int BatchId { get; set; }

        public int StudentId { get; set; }
        public virtual Batch Batch { get; set; }
    }
}
