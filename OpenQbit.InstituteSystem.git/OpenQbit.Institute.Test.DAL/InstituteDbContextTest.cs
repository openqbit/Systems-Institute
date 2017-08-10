using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.DAL.DataAccess;
using System.Data.Entity;

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
                BatchName = "39Batch" + DateTime.Now.ToString(),
                Branch = new Branch
                {
                    BranchName = "TestBranch",

                    Institute = new Common.Models.Institute { InstituteName = "Test Institute" }
                }
            };

            res.Set<Batch>().Add(batch);
            res.SaveChanges();

            Batch batch1 = res.Set<Batch>().Where(B => B.BatchName == batch.BatchName).FirstOrDefault();

            string expected = batch.BatchName;
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Delete()
        {
            InstituteDbContext res = new InstituteDbContext();

            Batch batch = new Batch
            {
                BatchName = "39Batch" + DateTime.Now.ToString(),
                Branch = new Branch
                {
                    BranchName = "TestBranch",

                    Institute = new Common.Models.Institute { InstituteName = "Test Institute" }
                }
            };

            res.Set<Batch>().Add(batch);
            res.SaveChanges();

            Batch batch1 = res.Set<Batch>().Where(B => B.BatchName == batch.BatchName).FirstOrDefault();

            res.Set<Batch>().Remove(batch);
            res.SaveChanges();



            Batch batch2 = res.Set<Batch>().Where(B => B.BatchName == batch.BatchName).FirstOrDefault();



            // Assert.AreNotEqual(null, batch2);
            Assert.AreEqual(null, batch2);

        }

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


        [TestMethod]
        public void FindById()
        {

            InstituteDbContext res = new InstituteDbContext();


            Batch batch1 = res.Set<Batch>().Find(60);

            int expected = 60;
            int actual = batch1.BatchId;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Update()
        {

            InstituteDbContext res = new InstituteDbContext();

            Batch batch = new Batch
            {
                BatchName = "39Batch" + DateTime.Now.ToString(),
                Branch = new Branch
                {
                    BranchName = "TestBranch",

                    Institute = new Common.Models.Institute { InstituteName = "Test Institute" }
                }
            };



            res.Set<Batch>().Add(batch);
            res.SaveChanges();

            batch.BatchName = "40Batch" + DateTime.Now.ToString();

            var edbstate = res.Entry(batch);
            res.Set<Batch>().Attach(batch);
            edbstate.State = EntityState.Modified;
            res.SaveChanges();


            Batch batch1 = res.Set<Batch>().Where(B => B.BatchName == batch.BatchName).FirstOrDefault();

            string expected = batch.BatchName;
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);
        }

        public void Find()
        {
            InstituteDbContext res = new InstituteDbContext();

            Batch batch = new Batch
            {
                BatchName = "37Batch" + DateTime.Now.ToString(),
                Branch = new Branch
                {
                    BranchName = "TestBranch",

                    Institute = new Common.Models.Institute { InstituteName = "Test Institute" }
                }
            };



            res.Set<Batch>().Add(batch);
            res.SaveChanges();


            Batch batch1 = res.Set<Batch>().Where(B => B.BatchName == batch.BatchName).FirstOrDefault();

            string expected = batch.BatchName;
            string actual = batch1.BatchName;

            Assert.AreEqual(expected, actual);

        }

    }
}
