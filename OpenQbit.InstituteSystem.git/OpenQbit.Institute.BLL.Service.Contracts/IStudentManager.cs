using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service.Contracts
{
    public interface IStudentManager
    {
        bool RecordStudentManager(Student student);
    }
}
