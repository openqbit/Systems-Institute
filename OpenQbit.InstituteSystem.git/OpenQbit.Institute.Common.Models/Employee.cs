using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeType { get; set; }

        public int PersonID { get; set; }
        public virtual Person Person { get; set; }


    }
}
