using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface IBatchManager
    {

        bool CreateBatch(Batch batch);
        Batch FindByBatchId(int batchId);
        bool DeleteByBatchId(int batchId);

        bool DeleteBatch(Batch batch);

        Batch FindBatch(Expression<Func<Batch, bool>> predicate);

        List<Batch> FindBatchList(Expression<Func<Batch, bool>> predicate);

        bool UpdateBatch(Batch batch);

        List<Batch> GetAllBatch();


        ///////////////////////////////////////////////////

        bool CreateBatchEnrolment(BatchEnrolment batchEnrolment);
        BatchEnrolment FindByBatchEnrolmentId(int batchEnrolmentId);
        bool DeleteByBatchEnrolmentId(int batchId);

        bool DeleteBatchEnrolment(BatchEnrolment batchEnrolment);

        BatchEnrolment FindBatchEnrolment(Expression<Func<BatchEnrolment, bool>> predicate);

        List<BatchEnrolment> FindBatchList(Expression<Func<BatchEnrolment, bool>> predicate);

        bool UpdateBatchEnrolment(BatchEnrolment batchEnrolment);

        List<BatchEnrolment> GetAllBatchEnrolment();

        bool Save();
    }
}
