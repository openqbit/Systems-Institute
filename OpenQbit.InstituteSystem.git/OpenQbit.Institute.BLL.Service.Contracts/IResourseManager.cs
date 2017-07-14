using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface IResourseManager
    {
        bool Create(Resource resource);
        Resource FindById(int resourceId);
        bool DeleteById(int resourceId);

        bool Delete(Resource resource);

        Resource Find(Expression<Func<Resource, bool>> predicate);

        List<Resource> FindList(Expression<Func<Resource, bool>> predicate);

        bool Update(Resource resource);

        List<Resource> GetAll();

        bool Save();
    }
}
