using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.InstituteService1
{
    class BatchManager
    {
        private Repository _db = new Repository();


        public bool CreateBatch(string BatchName, int BranchId)
        {
            Batch newBatch = new Batch();
            return _db.Create<Batch>(newBatch);
        }

        public bool RemoveBatch(int BatchID)
        {
            Batch newBatch = new Batch();
            return _db.Delete<Batch>(newBatch);
        }
        public bool RemoveBatch(string BatchName)
        {
            Batch newBatch = new Batch();
            return _db.Delete<Batch>(newBatch);
        }
        public Batch FindBatch(int BatchID)
        {
            Batch newBatch = new Batch();
            return _db.FindList<Batch>(BatchID);
        }
    }
}
