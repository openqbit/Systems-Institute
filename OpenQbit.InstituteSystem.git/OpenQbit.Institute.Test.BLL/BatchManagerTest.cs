using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.Common.Ioc;
using Microsoft.Practices.Unity;
using OpenQbit.Institute.BLL.Service1.Contracts;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenQbit.Institute.Test.BLL
{
    [TestClass]
    public class BatchManagerTest
    {
        [TestMethod]
        public void AddBatch()
        {
            Batch batch = new Batch
            {
                BatchId = 001,
                BatchName = "37Batch",
                BranchId = 100

            };

            //use unity UnityResolver 

            IBatchManager BranchManager = UnityResolver.Resolve<IBatchManager>();

            bool ans = BranchManager.Create(batch);

            Batch batch1 = BranchManager.FindById(batch.BatchId);

            int expected = batch1.BatchId;
            int actual = 001;


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteById()
        {


        }
    }
}
