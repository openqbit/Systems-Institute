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
            this._db = repository;
        }

        public bool CreateBatch(Batch batch)
        {
            //Some Logics If Applicable
            return _db.Create<Batch>(batch);
        }

        public bool DeleteByBatchId(int batchId)
        {
            // return  _db.FindList<Batch>(B => B.BatchId == batchId).FirsrtO;
            Batch batch = _db.Find<Batch>(B => B.BatchId == batchId);
            return _db.Delete<Batch>(batch);

        }
        public bool DeleteBatch(Batch batch)
        {
            //Some Logics If Applicable
            return _db.Delete<Batch>(batch);
        }

        
        public Batch FindByBatchId(int batchId)
        {
            return _db.Find<Batch>(B => B.BatchId == batchId);
        }

        public Batch FindBatch(Expression<Func<Batch, bool>> predicate)
        {
            return _db.Find<Batch>(predicate);
        }

        public List<Batch> FindBatchList(Expression<Func<Batch, bool>> predicate)
        {
            return _db.FindList<Batch>(predicate);
        }

        public bool UpdateBatch(Batch batch)
        {
            return _db.Update<Batch>(batch);
        }

        public List<Batch> GetAllBatch()
        {
            return _db.GetAll<Batch>();
        }

        ///////////////////////////////////////////////////////////////
        ////////////////// BatchEnrolment //////////////////////////////
        ////////////////////////////////////////////////////////////////

        public bool CreateBatchEnrolment(BatchEnrolment batchEnrolment)
        {
            //Some Logics If Applicable
            return _db.Create<BatchEnrolment>(batchEnrolment);
        }

        public bool DeleteByBatchEnrolmentId(int batchEnrolmentId)
        {
            // return  _db.FindList<Batch>(B => B.BatchId == batchId).FirsrtO;
            BatchEnrolment batch = _db.Find<BatchEnrolment>(B => B.BatchEnrolmentId == batchEnrolmentId);
            return _db.Delete<BatchEnrolment>(batch);

        }
        public bool DeleteBatchEnrolment(BatchEnrolment batchEnrolment)
        {
            //Some Logics If Applicable
            return _db.Delete<BatchEnrolment>(batchEnrolment);
        }


        public BatchEnrolment FindByBatchEnrolmentId(int batchEnrolmentId)
        {
            return _db.Find<BatchEnrolment>(B => B.BatchEnrolmentId == batchEnrolmentId);
        }

        public BatchEnrolment FindBatchEnrolment(Expression<Func<BatchEnrolment, bool>> predicate)
        {
            return _db.Find<BatchEnrolment>(predicate);
        }

        public List<BatchEnrolment> FindBatchEnrolmentList(Expression<Func<BatchEnrolment, bool>> predicate)
        {
            return _db.FindList<BatchEnrolment>(predicate);
        }

        public bool UpdateBatchEnrolment(BatchEnrolment batchEnrolment)
        {
            return _db.Update<BatchEnrolment>(batchEnrolment);
        }

        public List<BatchEnrolment> GetAllBatchEnrolment()
        {
            return _db.GetAll<BatchEnrolment>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        public List<BatchEnrolment> FindBatchList(Expression<Func<BatchEnrolment, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        
    }
}
