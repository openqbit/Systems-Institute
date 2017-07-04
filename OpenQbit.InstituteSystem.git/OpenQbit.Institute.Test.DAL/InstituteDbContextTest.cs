using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.DAL.DataAccess;

using Microsoft.VisualStudio.TestTools.UnitTesting;

//using Microsoft.VisualStudio.TestTools.UnitTesting


namespace OpenQbit.Institute.Test.DAL
{

    [TestClass]
    public class InstituteDbContextTest
    {
        public InstituteDbContextTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        [TestMethod]
        public void Create()
        {
            InstituteDbContext res = new InstituteDbContext();
            Batch batch = new Batch
            {
                BatchId = 12,
                BatchName = "37Batch",
                BranchId = 100
            };
            res.Set<Batch>().Add(batch);

            Batch batch1 = res.Set<Batch>().Find(batch.BatchId);


            int expected = batch1.BatchId;
            int actual = 12;
            Assert.AreEqual(expected, actual);
        }


        //[TestMethod]
        //public void Delete()
        //{
        //    InstituteDbContext res = new InstituteDbContext();
        //    Batch batch = new Batch
        //    {
        //        BatchId = 12,
        //        BatchName = "37Batch",
        //        BranchId = 100
        //    };
        //    res.Set<Batch>().Add(batch);
        //    Batch batch1 = res.Set<Batch>().Find(batch.BatchId);

        //    res.Set<Batch>().Remove(batch);

        //    Batch batch2 = res.Set<Batch>().Find(batch.BatchId);


        //    int expected = batch2.BatchId;
        //    string actual = null;
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void GetAll()
        {
            InstituteDbContext res = new InstituteDbContext();

            List<Batch> list = res.Set<Batch>().ToList();

            foreach (Batch batch in list)
            {
                Console.WriteLine("Ashan Tharuka : " + batch.BatchId);
            }
        }


        //[TestMethod]
        //public void FindById()
        //{

        //    IRepository res = new Repository();
        //    Batch batch = new Batch
        //    {
        //        BatchId = 12,
        //        BatchName = "37Batch",
        //        BranchId = 100,

        //    };
        //    bool ans = res.Create<Batch>(batch);
        //    res.Save();

        //    Batch batch1 = res.FindById<Batch>(batch.BatchId);

        //    int expected = 12;
        //    int actual = batch1.BatchId;

        //    Assert.AreEqual(expected, actual);
        //}


        //[TestMethod]
        //public void Update()
        //{

        //    IRepository res = new Repository();
        //    Batch batch = new Batch
        //    {
        //        BatchId = 19,
        //        BatchName = "37Batch",
        //        BranchId = 100,

        //    };
        //    bool ans = res.Create<Batch>(batch);
        //    res.Save();


        //    bool isUpdate = res.Update<Batch>(batch);
        //    res.Save();

        //    Batch batch1 = res.FindById<Batch>(batch.BatchId);

        //    int expected = 19;
        //    int actual = batch1.BatchId;

        //    Assert.AreEqual(expected, actual);
        //}


    }
}
