using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class Batch
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

    }
}
