using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.Common.Utils.Log;

using Microsoft.Practices.Unity;

using OpenQbit.Institute.BLL.Service1.Contracts;

namespace OpenQbit.Institute.BLL.InstituteService1
{
   public class EmployeeManager :IEmployeeManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public EmployeeManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            _db = repository;
        }

        public bool Create(Employee employee)
        {
            //Some Logics If Applicable
            return _db.Create<Employee>(employee);
        }

        public bool DeleteById(int employeeId)
        {
            Employee employee = _db.Find<Employee>(E => E.EmployeeID == employeeId);
            return _db.Delete<Employee>(employee);

        }
        public bool Delete(Employee employee)
        {
            //Some Logics If Applicable
            return _db.Delete<Employee>(employee);
        }


        public Employee FindById(int employeeId)
        {
            return _db.Find<Employee>(E => E.EmployeeID == employeeId);
        }

        public Employee Find(Expression<Func<Employee, bool>> predicate)
        {
            return _db.Find<Employee>(predicate);
        }

        public List<Employee> FindList(Expression<Func<Employee, bool>> predicate)
        {
            return _db.FindList<Employee>(predicate);
        }

        public bool Update(Employee employee)
        {
            return _db.Update<Employee>(employee);
        }

        public List<Employee> GetAll()
        {
            return _db.GetAll<Employee>();
        }

        public bool Save()
        {
            return _db.Save();
        }
    }
}
