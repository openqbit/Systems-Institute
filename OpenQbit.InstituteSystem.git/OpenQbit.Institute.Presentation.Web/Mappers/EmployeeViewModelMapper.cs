using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OpenQbit.Institute.Presentation.Web.Models;

namespace OpenQbit.Institute.Presentation.Web.Mappers
{
    public class EmployeeViewModelMapper
    {
        public Web.Models.Employee.EmployeeItem Map(Common.Models.Employee employee)
        {

            return new Models.Employee.EmployeeItem { EmployeeName = employee.Person.PersonName, Address = employee.Person.Address };

        }

    }
}