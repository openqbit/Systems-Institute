using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.Common.Utils.Log;

using Microsoft.Practices.Unity;

using OpenQbit.Institute.BLL.Service.Contracts;

namespace OpenQbit.Institute.BLL.InstituteService1
{
    public class BranchResourceAllocationManager : IBranchResourceAllocationManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public BranchResourceAllocationManager(IRepository repository, ILogger logger)
        {
            _db = repository;
        }

        public bool CreateBranchResourceAllocation(int BranchId, int ResourceId)
        {
            BranchResourceAllocation newBranchResourceAllocation = new BranchResourceAllocation();
            return _db.Create<BranchResourceAllocation>(newBranchResourceAllocation);
        }

        public bool CreateBranchResourceAllocation(int BranchId, List<int> resorceList)
        {

            List<BranchResourceAllocation> bracnhList = new List<BranchResourceAllocation>();

            foreach (var resoude in resorceList)
            {
                BranchResourceAllocation newBranchResourceAllocation = new BranchResourceAllocation { BranchId = BranchId, ResourceId = resoude };
                _db.Create<BranchResourceAllocation>(newBranchResourceAllocation);
                //bracnhList.Add(newBranchResourceAllocation);
            }


            //return _db.Create<BranchResourceAllocation>(List<newBranchResourceAllocation branch>);
            return _db.Save();
            //return _db.Create<BranchResourceAllocation>()
        }

        public bool RemoveBranchResourceAllocation(int BranchResourceAllocationID)
        {
            BranchResourceAllocation newBranchResourceAllocation = new BranchResourceAllocation();
            return _db.Delete<BranchResourceAllocation>(newBranchResourceAllocation);
        }

        public BranchResourceAllocation FindBranchResourceAllocation(int BranchResourceAllocationId)
        {
            BranchResourceAllocation newBranchResourceAllocation = new BranchResourceAllocation();
            return _db.FindList<BranchResourceAllocation>(B => B.BranchResourceAllocationId == BranchResourceAllocationId).FirstOrDefault();
        }
        public List<BranchResourceAllocation> FindBranchResourceAllocationList(int BranchId)
        {
            BranchResourceAllocation newBranchResourceAllocation = new BranchResourceAllocation();
            return _db.FindList<BranchResourceAllocation>(B => B.BranchId == BranchId);
        }

        public bool RecordBranchResourceAllocationManager(BranchResourceAllocation branchResourceAllocation)
        {
            _logger.LogError("");
            return _db.Create<BranchResourceAllocation>(branchResourceAllocation);
        }
    }
}
