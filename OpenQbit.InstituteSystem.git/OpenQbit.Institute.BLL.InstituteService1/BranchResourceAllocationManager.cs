using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.InstituteService1
{
    class BranchResourceAllocationManager
    {
        private Repository _db = new Repository();


        public bool CreateBranchResourceAllocation(int BranchId, int ResourceId)
        {
            BranchResourceAllocation newBranchResourceAllocation = new BranchResourceAllocation();
            return _db.Create<BranchResourceAllocation>(newBranchResourceAllocation);
        }

        public bool RemoveBranchResourceAllocation(int BranchResourceAllocationID)
        {
            BranchResourceAllocation newBranchResourceAllocation = new BranchResourceAllocation();
            return _db.Delete<BranchResourceAllocation>(newBranchResourceAllocation);
        }
        public Branch FindBranchResourceAllocation(int BranchResourceAllocationId)
        {
            BranchResourceAllocation newBranchResourceAllocation = new BranchResourceAllocation();
            return _db.FindList<BranchResourceAllocation>(BranchResourceAllocationId);
        }
    }
}
