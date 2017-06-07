using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public String PersonName { get; set; }
        public String Address { get; set; }
        public string Email { get; set; }

        public int Tel { get; set; }

        public int ResourceID{ get; set; }

        public virtual Resource Resource{ get; set; }

    }
}
