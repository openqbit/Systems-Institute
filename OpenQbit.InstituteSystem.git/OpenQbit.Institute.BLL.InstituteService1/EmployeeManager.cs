using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.Common.Utils.Log;

using Microsoft.Practices.Unity;
using OpenQbit.Institute.BLL.Service.Contracts;

namespace OpenQbit.Institute.BLL.InstituteService1
{
   public class EmployeeManager : IEmployeeManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public EmployeeManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            _db = repository;
        }


        public bool Create<T>(T obj) where T : class
        {
            //Some Logics If Applicable
            return _db.Create(obj);
        }

        public bool Delete<T>(T obj) where T : class
        {
            //Some Logics If Applicable
            return _db.Delete(obj);
        }

        public T Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            //Some Logics If Applicable
            return _db.Find(predicate);
        }

        public List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            //Some Logics If Applicable
            return _db.FindList(predicate);
        }

        public List<T> GetAll<T>() where T : class
        {
            //Some Logics If Applicable
            return _db.GetAll<T>();
        }


        public bool Update<T>(T obj) where T : class
        {
            //Some Logics If Applicable
            return _db.Update(obj);
        }


        public bool Save()
        {
            return _db.Save();
        }


    }

}
