using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
   public interface IEmployeeManager
    {
        bool Create(Employee employee);
        Employee FindById(int employeeId);
        bool DeleteById(int employeeId);

        bool Delete(Employee employee);

        Employee Find(Expression<Func<Employee, bool>> predicate);

        List<Employee> FindList(Expression<Func<Employee, bool>> predicate);

        bool Update(Employee employee);

        List<Employee> GetAll();

        bool Save();
    }
}
