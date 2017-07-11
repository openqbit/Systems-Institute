using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface IBranchResourceAllocationManager
    {

        bool Create(BranchResourceAllocation branchResourceAllocation);
        BranchResourceAllocation FindById(int branchResourceAllocationId);
        bool DeleteById(int branchResourceAllocationId);

        bool Delete(BranchResourceAllocation branchResourceAllocation);

        BranchResourceAllocation Find(Expression<Func<BranchResourceAllocation, bool>> predicate);

        List<BranchResourceAllocation> FindList(Expression<Func<BranchResourceAllocation, bool>> predicate);

        bool Update(BranchResourceAllocation branchResourceAllocation);

        List<BranchResourceAllocation> GetAll();

        bool Save();

    }
}
