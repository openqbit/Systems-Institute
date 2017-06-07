using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int TelNo { get; set; }
        public int InstituteId { get; set; }
        public virtual Institut Institute { get; set; }
    }
}
