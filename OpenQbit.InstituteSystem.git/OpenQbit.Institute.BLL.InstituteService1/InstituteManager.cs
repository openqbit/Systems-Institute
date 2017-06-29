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
   public  class InstituteManager:IInstituteManager
    {

        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public InstituteManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            _db = repository;
        }

        public bool Create(Branch instituteo)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Branch branch)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int branchId)
        {
            throw new NotImplementedException();
        }

        public Branch Find(Expression<Func<Branch, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Branch FindById(int branchId)
        {
            throw new NotImplementedException();
        }

        public List<Branch> FindList(Expression<Func<Branch, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Branch> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Branch branch)
        {
            throw new NotImplementedException();
        }
    }
}
