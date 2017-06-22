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
    public class BatchManager : IBatchManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public BatchManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            _db = repository;
        }

        public bool Create(Batch batch)
        {
            //Some Logics If Applicable
            return _db.Create<Batch>(batch);
        }

        public bool DeleteById(int batchId)
        {
            // return  _db.FindList<Batch>(B => B.BatchId == batchId).FirsrtO;
            Batch batch = _db.Find<Batch>(B => B.BatchId == batchId);
            return _db.Delete<Batch>(batch);

        }
        public bool Delete(Batch batch)
        {
            //Some Logics If Applicable
            return _db.Delete<Batch>(batch);
        }

        public T Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            //Some Logics If Applicable
            return _db.Find(predicate);
        }

        public Batch FindById(int batchId)
        {
            //Some Logics If Applicable
            return _db.FindById<Batch>(batchId);
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
