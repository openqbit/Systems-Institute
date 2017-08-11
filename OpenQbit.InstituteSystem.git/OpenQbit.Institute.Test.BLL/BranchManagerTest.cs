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
            UnityResolver.Register();
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();

            Branch branch = new Branch
            {
                BranchName = "TestBranch",
                Address = "Panadura",
                TelNo = 12,
                Institute = new Common.Models.Institute { InstituteName = "Test Institute" }
            };

            bool ans = BranchManager.CreateBranch(branch);
            BranchManager.Save();

            Branch branch1 = BranchManager.FindBranch(B => B.Address == "Panadura");

            string expected = "Panadura";
            string actual = branch1.Address;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Delete()
        {
            UnityResolver.Register();
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();
            Branch branch = BranchManager.FindBranch(B => B.BranchId == 3);

            bool ans = BranchManager.DeleteBranch(branch);
            BranchManager.Save();



            bool expected = true;
            bool actual = ans;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAll()
        {
            UnityResolver.Register();
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();

            List<Branch> list = BranchManager.GetAllBranch();

            foreach (Branch branch in list)
            {
                Console.WriteLine("Ashan Tharuka : " + branch.Address);
            }
        }


        [TestMethod]
        public void FindById()
        {
            UnityResolver.Register();
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();


            Branch branch1 = BranchManager.FindByBranchId(88);

            int expected = 88;
            int actual = branch1.BranchId;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Update()
        {
            UnityResolver.Register();
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();

            Branch branch = BranchManager.FindByBranchId(84);

            branch.Address = "Panadura" + DateTime.Now.ToString();

            bool isUpdate = BranchManager.UpdateBranch(branch);
            BranchManager.Save();

            Branch branch1 = BranchManager.FindByBranchId(84);

            string expected = branch.Address;
            string actual = branch1.Address;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Find()
        {
            UnityResolver.Register();
            IBranchManager BranchManager = UnityResolver.Resolve<IBranchManager>();


            Branch branch1 = BranchManager.FindBranch(B => B.BranchId ==96);

            string expected = "Panadura";
            string actual = branch1.Address;

            Assert.AreEqual(expected, actual);
        }

    }
}
