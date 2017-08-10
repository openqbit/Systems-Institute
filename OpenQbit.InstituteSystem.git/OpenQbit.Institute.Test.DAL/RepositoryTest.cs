using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.DAL.DataAccess;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenQbit.Institute.Test.DAL
{
    /// <summary>
    /// Summary description for RepositoryTest
    /// </summary>
    [TestClass]
    public class RepositoryTest
    {
        public RepositoryTest()
        {


        }

        [TestMethod]
        public void Create()
        {
            IRepository res = new Repository();
            Batch batch = new Batch
            {
                BatchName = "37Batch" + DateTime.Now.ToString(),
                Branch = new Branch
                {
                    BranchName = "TestBranch",

                    Institute = new Common.Models.Institute { InstituteName = "Test Institute" }
                }
            };
            bool ans = res.Create<Batch>(batch);
            res.Save();

            Batch batch1 = res.Find<Batch>(B => B.BatchName == batch.BatchName);

            string expected = batch.BatchName;
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Delete()
        {

            IRepository res = new Repository();

      //      List<Batch> batchList = res.GetAll<Batch>();

            Batch batch = res.Find<Batch>(B => B.BatchId == 71);

            bool ans = res.Delete<Batch>(batch);
            res.Save();

           

            bool expected = true;
            bool actual = ans;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAll()
        {
            IRepository res = new Repository();

            List<Batch> list = res.GetAll<Batch>();

            foreach (Batch batch in list)
            {
                Console.WriteLine("Ashan Tharuka : " + batch.BatchId);
            }
        }


        [TestMethod]
        public void FindById()
        {

            IRepository res = new Repository();
            

            Batch batch1 = res.FindById<Batch>(93);

            int expected = 93;
            int actual = batch1.BatchId;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Update()
        {

            IRepository res = new Repository();

            Batch batch = res.FindById<Batch>(91);

            batch.BatchName = "38Batch" + DateTime.Now.ToString();

            bool isUpdate = res.Update<Batch>(batch);
            res.Save();

            Batch batch1 = res.FindById<Batch>(93);

            string expected = "38Batch";
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Find()
        {

            IRepository res = new Repository();
           

            Batch batch1 = res.Find<Batch>(B => B.BatchId == 92);

            string expected = "38Batch";
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);
        }

    }
}
