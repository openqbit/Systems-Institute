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

        
        public Batch FindById(int batchId)
        {
            return _db.Find<Batch>(B => B.BatchId == batchId);
        }

        public Batch Find(Expression<Func<Batch, bool>> predicate)
        {
            return _db.Find<Batch>(predicate);
        }

        public List<Batch> FindList(Expression<Func<Batch, bool>> predicate)
        {
            return _db.FindList<Batch>(predicate);
        }

        public bool Update(Batch batch)
        {
            return _db.Update<Batch>(batch);
        }

        public List<Batch> GetAll()
        {
            return _db.GetAll<Batch>();
        }

        public bool Save()
        {
            return _db.Save();
        }
    }
}
