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


        bool CreateBranch(Branch branch);
        Branch FindByBranchId(int branchId);
        bool DeleteByBranchId(int branchId);

        bool DeleteBranch(Branch branch);

        Branch FindBranch(Expression<Func<Branch, bool>> predicate);

        List<Branch> FindBranchList(Expression<Func<Branch, bool>> predicate);

        bool UpdateBranch(Branch branch);

        List<Branch> GetAllBranch();
        //////////////////////////////////////////////

        bool CreateBranchResourceAllocation(BranchResourceAllocation branchResourceAllocation);
        BranchResourceAllocation FindByBranchResourceAllocationId(int branchResourceAllocationId);
        bool DeleteByBranchResourceAllocationId(int branchResourceAllocationId);

        bool DeleteBranchResourceAllocation(BranchResourceAllocation branchResourceAllocation);

        BranchResourceAllocation FindBranchResourceAllocation(Expression<Func<BranchResourceAllocation, bool>> predicate);

        List<BranchResourceAllocation> FindBranchResourceAllocationList(Expression<Func<BranchResourceAllocation, bool>> predicate);

        bool UpdateBranchResourceAllocation(BranchResourceAllocation branchResourceAllocation);

        List<BranchResourceAllocation> GetAllBranchResourceAllocation();

        bool Save();
    }
}
