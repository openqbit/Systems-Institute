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
            this._db = repository;
        }

        public bool Create(Common.Models.Institute institute)
        {
            return _db.Create<Common.Models.Institute>(institute);
        }

        public bool Delete(Common.Models.Institute institute)
        {
            return _db.Delete<Common.Models.Institute>(institute);
        }

        public bool DeleteById(int  instituteId)
        {
            Common.Models.Institute institute = _db.Find<Common.Models.Institute>(I => I.InstituteId == instituteId);
            return _db.Delete<Common.Models.Institute>(institute);
        }

        public Common.Models.Institute Find(Expression<Func<Common.Models.Institute, bool>> predicate)
        {
            return _db.Find<Common.Models.Institute>(predicate);
        }

        public Common.Models.Institute FindById(int instituteId)
        {
            return _db.Find<Common.Models.Institute>(I => I.InstituteId == instituteId);
        }

        public List<Common.Models.Institute> FindList(Expression<Func<Common.Models.Institute, bool>> predicate)
        {
            return _db.FindList<Common.Models.Institute>(predicate);
        }

        public List<Common.Models.Institute> GetAll()
        {
            return _db.GetAll<Common.Models.Institute>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        public bool Update(Common.Models.Institute institute)
        {
            return _db.Update<Common.Models.Institute>(institute);
        }
    }
}
