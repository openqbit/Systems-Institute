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
    /// <summary>
    /// Summary description for BranchManagerTest
    /// </summary>
    [TestClass]
    public class BranchManagerTest
    {
        public BranchManagerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }



        [TestMethod]
        public void Create()
        {
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();

            Branch branch = new Branch
            {
                BranchName = "TestBranch",
                Address = "Panadura",
                TelNo = 12,
                Institute = new Common.Models.Institute { InstituteName = "Test Institute" }
            };

            bool ans = BranchManager.Create(branch);
            BranchManager.Save();

            Branch branch1 = BranchManager.Find(B => B.Address == "Panadura");

            string expected = "Panadura";
            string actual = branch1.Address;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Delete()
        {

            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();
            Branch branch = BranchManager.Find(B => B.BranchId == 115);

            bool ans = BranchManager.Delete(branch);
            BranchManager.Save();



            bool expected = true;
            bool actual = ans;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAll()
        {
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();

            List<Branch> list = BranchManager.GetAll();

            foreach (Branch branch in list)
            {
                Console.WriteLine("Ashan Tharuka : " + branch.Address);
            }
        }


        [TestMethod]
        public void FindById()
        {

            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();


            Branch branch1 = BranchManager.FindById(93);

            int expected = 93;
            int actual = branch1.BranchId;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Update()
        {
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();

            Branch branch = BranchManager.FindById(91);

            branch.Address = "Panadura" + DateTime.Now.ToString();

            bool isUpdate = BranchManager.Update(branch);
            BranchManager.Save();

            Branch branch1 = BranchManager.FindById(93);

            string expected = "Panadura";
            string actual = branch1.Address;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Find()
        {

            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();


            Branch branch1 = BranchManager.Find(B => B.BranchId == 92);

            string expected = "Panadura";
            string actual = branch1.Address;

            Assert.AreEqual(expected, actual);
        }

    }
}
