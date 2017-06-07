using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class ParentInformation
    {
        public int ParentInformationId { get; set; }
        public virtual Person Mother { get; set; }
        public virtual Person Father { get; set; }

        public int MotherId { get; set; }
        public int FatherId { get; set; }

        public int PrimaryContactNumber { get; set; }




    }
}
