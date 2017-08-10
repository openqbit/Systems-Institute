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
    public class InstituteManagerTest
    {

        public InstituteManagerTest() {
        }

        [TestMethod]
        public void Create()
        {
            UnityResolver.Register();
            IInstituteManager InstituteManager = UnityResolver.Resolve<IInstituteManager>();

            List<Branch> list = new List<Branch>();
            Common.Models.Institute institute = new Common.Models.Institute { InstituteName = "IJSEPanadura", Branch =list  };
           

            bool ans = InstituteManager.Create(institute);
            InstituteManager.Save();

            Common.Models.Institute institute1 = InstituteManager.Find(I => I.InstituteName == "IJSEPanadura");

            string expected = "IJSEPanadura";
            string actual = institute1.InstituteName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Delete()
        {
            UnityResolver.Register();
            IInstituteManager InstituteManager = UnityResolver.Resolve<IInstituteManager>();
            Common.Models.Institute institute = InstituteManager.Find(I => I.InstituteName == "IJSEPanadura");

            bool ans = InstituteManager.Delete(institute);
            InstituteManager.Save();



            bool expected = true;
            bool actual = ans;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAll()
        {
            UnityResolver.Register();
            IInstituteManager InstituteManager = UnityResolver.Resolve<IInstituteManager>();

            List<Common.Models.Institute> list = InstituteManager.GetAll();

            foreach (Common.Models.Institute institute in list)
            {
                Console.WriteLine("Test : " + institute.InstituteName);
            }
        }


        [TestMethod]
        public void FindById()
        {
            UnityResolver.Register();
            IInstituteManager InstituteManager = UnityResolver.Resolve<IInstituteManager>();


            Common.Models.Institute institute1 = InstituteManager.FindById(93);

            int expected = 93;
            int actual = institute1.InstituteId;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Update()
        {
            UnityResolver.Register();
            IInstituteManager InstituteManager = UnityResolver.Resolve<IInstituteManager>();

            Common.Models.Institute institute = InstituteManager.FindById(5);

            institute.InstituteName = "IJSEPanadura" + DateTime.Now.ToString();

            bool isUpdate = InstituteManager.Update(institute);
            InstituteManager.Save();

            Common.Models.Institute institute1 = InstituteManager.FindById(5);

            string expected = institute.InstituteName;
            string actual = institute1.InstituteName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Find()
        {
            UnityResolver.Register();
            IInstituteManager InstituteManager = UnityResolver.Resolve<IInstituteManager>();


            Common.Models.Institute institute = InstituteManager.Find(I => I.InstituteId == 96);

            string expected = "IJSEPanadura";
            string actual = institute.InstituteName;

            Assert.AreEqual(expected, actual);
        }

    }
}
