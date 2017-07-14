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
            this._db = repository;
        }

        public bool CreateEmployee(Employee employee)
        {
            //Some Logics If Applicable
            return _db.Create<Employee>(employee);
        }

        public bool DeleteByEmployeeId(int employeeId)
        {
            Employee employee = _db.Find<Employee>(E => E.EmployeeID == employeeId);
            return _db.Delete<Employee>(employee);

        }
        public bool DeleteEmployee(Employee employee)
        {
            //Some Logics If Applicable
            return _db.Delete<Employee>(employee);
        }


        public Employee FindByEmployeeId(int employeeId)
        {
            return _db.Find<Employee>(E => E.EmployeeID == employeeId);
        }

        public Employee FindEmployee(Expression<Func<Employee, bool>> predicate)
        {
            return _db.Find<Employee>(predicate);
        }

        public List<Employee> FindEmployeeList(Expression<Func<Employee, bool>> predicate)
        {
            return _db.FindList<Employee>(predicate);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return _db.Update<Employee>(employee);
        }

        public List<Employee> GetAllEmployee()
        {
            return _db.GetAll<Employee>();
        }


        /// <summary>
        /// Lecture
        /// </summary>
        public bool CreateLecture(Lecture lecture)
        {
            //Some Logics If Applicable
            return _db.Create<Lecture>(lecture);
        }

        public bool DeleteByLectureId(int lectureId)
        {
            Lecture lecture = _db.Find<Lecture>(L => L.LectureID == lectureId);
            return _db.Delete<Lecture>(lecture);

        }
        public bool DeleteLecture(Lecture lecture)
        {
            //Some Logics If Applicable
            return _db.Delete<Lecture>(lecture);
        }


        public Lecture FindByLectureId(int lectureId)
        {
            return _db.Find<Lecture>(L => L.LectureID== lectureId);
        }

        public Lecture FindLecture(Expression<Func<Lecture, bool>> predicate)
        {
            return _db.Find<Lecture>(predicate);
        }

        public List<Lecture> FindLectureList(Expression<Func<Lecture, bool>> predicate)
        {
            return _db.FindList<Lecture>(predicate);
        }

        public bool UpdateLecture(Lecture lecture)
        {
            return _db.Update<Lecture>(lecture);
        }

        public List<Lecture> GetAllLecture()
        {
            return _db.GetAll<Lecture>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        
    }
}
