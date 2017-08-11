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
    /// Summary description for StudentManagerTest
    /// </summary>
    [TestClass]
    public class StudentManagerTest
    {
        public StudentManagerTest()
        {
           
        }

    



        [TestMethod]
        public void Create()
        {
            UnityResolver.Register();
            IStudentManager StudentManager = UnityResolver.Resolve<IStudentManager>();

            Student student = new Student
            {
                Address = "Wadduwa",
                StudentName = "ashan",
                BatchEnrolment =  new ICollection<BatchEnrolment>(),
                Pereson=new Person { }

            };

            bool ans = StudentManager.Create(student);
            StudentManager.Save();

            Student Student1 = StudentManager.Find(S =>S.StudentName == "ashan");

            string expected = "Panadura";
            string actual = Student1.StudentName;
;

            Assert.AreEqual(expected, actual);
        }

    }
}
