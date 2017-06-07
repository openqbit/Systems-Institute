using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class Institute
    {
        public int InstituteId { get; set; }
        public string InstituteName { get; set; }

        public string WebSite { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Branch>Branch{ get; set; }
    }
}
