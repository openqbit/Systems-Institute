using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

using Microsoft.Practices.Unity;


using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OpenQbit.Institute.Test.DAL
{
    /// <summary>
    /// Summary description for DbContextTest
    /// </summary>
    [TestClass]
    public class DbContextTest
    {
        public DbContextTest()
        {
            
        }

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

         
            //bool ans = BranchManager.Create(batch);

            //Batch batch1 = BranchManager.FindById(batch.BatchId);

            //int expected = batch1.BatchId;
            //int actual = 001;


            //Assert.AreEqual(expected, actual);



        }


    }
}
