using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using OpenQbit.Institute.DAL.DataAccess;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.InstituteService1
{
    class BatchEnrolmentManager
    {
        private Repository _db = new Repository();


        public bool CreateBatchEnrolment(int TimeDuration, int BatchId, int StudentI)
        {
            BatchEnrolment newBatchEnrolment = new BatchEnrolment();
            return _db.Create<BatchEnrolment>(newBatchEnrolment);
        }

        public bool RemoveBatchEnrolment(int BatchEnrolmentId)
        {
            BatchEnrolment newBatchEnrolment = new BatchEnrolment();
            return _db.Delete<BatchEnrolment>(newBatchEnrolment);
        }
        
        public BatchEnrolment FindBatchEnrolment(int BatchEnrolmentId)
        {
            BatchEnrolment newBatchEnrolment = new BatchEnrolment();
            return _db.FindList<BatchEnrolment>(BatchEnrolmentId);
        }
    }
}
