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

        public bool Create(Branch branch)
        {
            return _db.Create<Branch>(branch);
        }

        public bool Delete(Branch branch)
        {
            return _db.Delete<Branch>(branch);
        }

        public bool DeleteById(int branchId)
        {
            Branch branch1= _db.Find<Branch>(B => B.BranchId == branchId);
            return _db.Delete<Branch>(branch1);
        }

        public Branch Find(Expression<Func<Branch, bool>> predicate)
        {
            return _db.Find<Branch>(predicate);
        }

        public Branch FindById(int branchId)
        {
            return _db.Find<Branch>(B => B.BranchId == branchId);
        }

        public List<Branch> FindList(Expression<Func<Branch, bool>> predicate)
        {
            return _db.FindList<Branch>(predicate);
        }

        public List<Branch> GetAll()
        {
            return _db.GetAll<Branch>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        public bool Update(Branch branch)
        {
            return _db.Update<Branch>(branch);
        }
    }
}
