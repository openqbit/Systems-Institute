using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.Common.Utils.Log;

using Microsoft.Practices.Unity;

using OpenQbit.Institute.BLL.Service1.Contracts;

namespace OpenQbit.Institute.BLL.InstituteService1
{
    public class BranchManager :IBranchManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public BranchManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            _db = repository;
        }

        public bool CreateBranch(Branch branch)
        {
            return _db.Create<Branch>(branch);
        }

        public bool DeleteBranch(Branch branch)
        {
            return _db.Delete<Branch>(branch);
        }

        public bool DeleteByBranchId(int branchId)
        {
            Branch branch1= _db.Find<Branch>(B => B.BranchId == branchId);
            return _db.Delete<Branch>(branch1);
        }

        public Branch FindBranch(Expression<Func<Branch, bool>> predicate)
        {
            return _db.Find<Branch>(predicate);
        }

        public Branch FindByBranchId(int branchId)
        {
            return _db.Find<Branch>(B => B.BranchId == branchId);
        }

        public List<Branch> FindBranchList(Expression<Func<Branch, bool>> predicate)
        {
            return _db.FindList<Branch>(predicate);
        }

        public List<Branch> GetAllBranch()
        {
            return _db.GetAll<Branch>();
        }


        public bool UpdateBranch(Branch branch)
        {
            return _db.Update<Branch>(branch);
        }


        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////     BranchResourceAllocation     /////////////////////////
        /////////////////////////////////////////////////////////////////////////////////


        public bool CreateBranchResourceAllocation(BranchResourceAllocation branch)
        {
            return _db.Create<BranchResourceAllocation>(branch);
        }

        public bool DeleteBranchResourceAllocation(BranchResourceAllocation banchResourceAllocation)
        {
            return _db.Delete<BranchResourceAllocation>(banchResourceAllocation);
        }

        public bool DeleteByBranchResourceAllocationId(int branchResourceAllocationId)
        {
            BranchResourceAllocation branch1 = _db.Find<BranchResourceAllocation>(B => B.BranchResourceAllocationId == branchResourceAllocationId);
            return _db.Delete<BranchResourceAllocation>(branch1);
        }

        public BranchResourceAllocation FindBranchResourceAllocation(Expression<Func<BranchResourceAllocation, bool>> predicate)
        {
            return _db.Find<BranchResourceAllocation>(predicate);
        }

        public BranchResourceAllocation FindByBranchResourceAllocationId(int branchId)
        {
            return _db.Find<BranchResourceAllocation>(B => B.BranchResourceAllocationId == branchId);
        }

        public List<BranchResourceAllocation> FindBranchResourceAllocationList(Expression<Func<BranchResourceAllocation, bool>> predicate)
        {
            return _db.FindList<BranchResourceAllocation>(predicate);
        }

        public List<BranchResourceAllocation> GetAllBranchResourceAllocation()
        {
            return _db.GetAll<BranchResourceAllocation>();
        }


        public bool UpdateBranchResourceAllocation(BranchResourceAllocation branchResourceAllocation)
        {
            return _db.Update<BranchResourceAllocation>(branchResourceAllocation);
        }
        public bool Save()
        {
            return _db.Save();
        }

       
    }
}
