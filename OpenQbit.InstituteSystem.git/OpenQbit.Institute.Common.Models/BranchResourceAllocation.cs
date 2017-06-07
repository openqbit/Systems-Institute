using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class BranchResourceAllocation
    {

        public int BranchResourceAllocationId { get; set; }
        public virtual int BranchId { get; set; }

        public virtual int ResourceId { get; set; }

    }

}
