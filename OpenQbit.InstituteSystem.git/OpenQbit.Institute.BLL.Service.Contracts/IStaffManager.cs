using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface IStaffManager
    {
        bool Create(Staff staff);
        Staff FindById(int staffId);
        bool DeleteById(int staffId);

        bool Delete(Staff staff);

        Staff Find(Expression<Func<Staff, bool>> predicate);

        List<Staff> FindList(Expression<Func<Staff, bool>> predicate);

        bool Update(Staff staff);

        List<Staff> GetAll();

        bool Save();
    }
}
