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

namespace OpenQbit.Institute.BLL.InstituteService1.Tests
{
    [TestClass()]
    public class EmployeeManagerTest
    {

        public EmployeeManagerTest() { }
        


        [TestMethod]
        public void Create()
        {
            UnityResolver.Register();
            IEmployeeManager EmployeeManager = UnityResolver.Resolve<IEmployeeManager>();

        
            Employee employee = new Employee { EmployeeType="Manager",Person= new Person { Address = "panadura" } };


            bool ans = EmployeeManager.CreateEmployee(employee);
            EmployeeManager.Save();

            Employee  employee1= EmployeeManager.FindEmployee(E => E.EmployeeType == "Manager");

           
        }


    }
}
