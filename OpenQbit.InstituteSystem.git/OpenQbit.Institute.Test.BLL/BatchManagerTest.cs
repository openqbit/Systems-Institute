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
        public void Create()
        {
            UnityResolver.Register();
            IBatchManager BatchManager = UnityResolver.Resolve<IBatchManager>();
            Batch batch = new Batch
            {
                BatchName = "37Batch" + DateTime.Now.ToString(),
                Branch = new Branch
                {
                    BranchName = "TestBranch",

                    Institute = new Common.Models.Institute { InstituteName = "Test Institute" }
                }
            };
            bool ans = BatchManager.CreateBatch(batch);
            BatchManager.Save();

            Batch batch1 = BatchManager.FindBatch(B => B.BatchName == "37Batch");

            string expected = "37Batch";
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Delete()
        {
            UnityResolver.Register();
            IBatchManager BatchManager = UnityResolver.Resolve<IBatchManager>();
            Batch batch = BatchManager.FindBatch(B => B.BatchId == 115);

            bool ans = BatchManager.DeleteBatch(batch);
            BatchManager.Save();



            bool expected = true;
            bool actual = ans;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAll()
        {
            UnityResolver.Register();
            IBatchManager BatchManager = UnityResolver.Resolve<IBatchManager>();

            List<Batch> list = BatchManager.GetAllBatch();

            foreach (Batch batch in list)
            {
                Console.WriteLine("Ashan Tharuka : " + batch.BatchId);
            }
        }


        [TestMethod]
        public void FindById()
        {
            UnityResolver.Register();

            IBatchManager BatchManager = UnityResolver.Resolve<IBatchManager>();


            Batch batch1 = BatchManager.FindByBatchId(93);

            int expected = 93;
            int actual = batch1.BatchId;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Update()
        {
            UnityResolver.Register();
            IBatchManager BatchManager = UnityResolver.Resolve<IBatchManager>();

            Batch batch = BatchManager.FindByBatchId(91);

            batch.BatchName = "38Batch" + DateTime.Now.ToString();

            bool isUpdate = BatchManager.UpdateBatch(batch);
            BatchManager.Save();

            Batch batch1 = BatchManager.FindByBatchId(93);

            string expected = "38Batch";
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Find()
        {
            UnityResolver.Register();
            IBatchManager BatchManager = UnityResolver.Resolve<IBatchManager>();


            Batch batch1 = BatchManager.FindBatch(B => B.BatchId == 92);

            string expected = "38Batch";
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);
        }

    }
}
