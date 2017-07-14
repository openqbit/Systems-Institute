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
    public class ResourseManager:IResourseManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public ResourseManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            this._db = repository;
        }

        public bool Create(Resource resource)
        {
            //Some Logics If Applicable
            return _db.Create<Resource>(resource);
        }

        public bool DeleteById(int resourceId)
        {
            Resource resource = _db.Find<Resource>(R => R.ResourceID == resourceId);
            return _db.Delete<Resource>(resource);

        }
        public bool Delete(Resource resource)
        {
            //Some Logics If Applicable
            return _db.Delete<Resource>(resource);
        }


        public Resource FindById(int resourceId)
        {
            return _db.Find<Resource>(R => R.ResourceID == resourceId);
        }

        public Resource Find(Expression<Func<Resource, bool>> predicate)
        {
            return _db.Find<Resource>(predicate);
        }

        public List<Resource> FindList(Expression<Func<Resource, bool>> predicate)
        {
            return _db.FindList<Resource>(predicate);
        }

        public bool Update(Resource resource)
        {
            return _db.Update<Resource>(resource);
        }

        public List<Resource> GetAll()
        {
            return _db.GetAll<Resource>();
        }

        public bool Save()
        {
            return _db.Save();
        }
    }
}
