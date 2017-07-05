using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface IBranchManager
    {


        bool Create(Branch branch);
        Branch FindById(int branchId);
        bool DeleteById(int branchId);

        bool Delete(Branch branch);

        Branch Find(Expression<Func<Branch, bool>> predicate);

        List<Branch> FindList(Expression<Func<Branch, bool>> predicate);

        bool Update(Branch branch);

        List<Branch> GetAll();

        bool Save();
    }
}
