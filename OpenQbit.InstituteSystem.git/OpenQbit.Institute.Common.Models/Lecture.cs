using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Models
{
    public class Lecture
    {
        public int LectureID { get; set; }
        public string LectureName { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Specify { get; set; }
        public int SubjectID { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employe{get;set;}
        public virtual Subject Subject { get; set; }
    }
}
