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
        bool CreateEmployee(Employee employee);
        Employee FindByEmployeeId(int employeeId);
        bool DeleteByEmployeeId(int employeeId);

        bool DeleteEmployee(Employee employee);

        Employee FindEmployee(Expression<Func<Employee, bool>> predicate);

        List<Employee> FindEmployeeList(Expression<Func<Employee, bool>> predicate);

        bool UpdateEmployee(Employee employee);

        List<Employee> GetAllEmployee();

        //////////////////////////////////////////////////////////////

        bool CreateLecture(Lecture lecture);
        Lecture FindByLectureId(int lectureId);
        bool DeleteByLectureId(int lectureId);

        bool DeleteLecture(Lecture lecture);

        Lecture FindLecture(Expression<Func<Lecture, bool>> predicate);

        List<Lecture> FindLectureList(Expression<Func<Lecture, bool>> predicate);

        bool UpdateLecture(Lecture lecture);

        List<Lecture> GetAllLecture();

        bool Save();
    }
}
