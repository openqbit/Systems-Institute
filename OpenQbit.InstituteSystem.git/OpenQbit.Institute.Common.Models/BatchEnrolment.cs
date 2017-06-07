using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace OpenQbit.Institute.Common.Models
{
    public class BatchEnrolment
    {
        [Key]
        public int BatchEnrolmentId { get; set; }

        public int TimeDuration { get; set; }

        [ForeignKey("Batch")]
        public int BatchId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

    //    [ForeignKey("BatchId")]
        public virtual Batch Batch { get; set; }

     //   [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}
