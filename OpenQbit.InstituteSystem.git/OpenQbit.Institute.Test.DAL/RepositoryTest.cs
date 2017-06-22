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
                BatchId = 001,
                BatchName = "37Batch",
                BranchId = 100
            };

            bool ans = res.Create<Batch>(batch);

            Batch batch1 = res.FindById<Batch>(batch.BatchId);

            int expected = batch1.BatchId;
            int actual = 001;


            Assert.AreEqual(expected, actual);
        }
    }
}
