using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface IInstituteManager
    {

        bool Create(Common.Models.Institute institute);
        Common.Models.Institute FindById(int instituteId);
        bool DeleteById(int instituteId);

        bool Delete(Common.Models.Institute institute);

        Common.Models.Institute Find(Expression<Func<Common.Models.Institute, bool>> predicate);

        List<Common.Models.Institute> FindList(Expression<Func<Common.Models.Institute, bool>> predicate);

        bool Update(Common.Models.Institute institute);

        List<Common.Models.Institute> GetAll();

        bool Save();
    }
}
