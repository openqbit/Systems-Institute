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
  public  class StudentManager:IStudentManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public StudentManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            this._db = repository;
        }

        public bool Create(Student student)
        {
            //Some Logics If Applicable
            return _db.Create<Student>(student);
        }

        public bool DeleteById(int studentId)
        {
            Student subject = _db.Find<Student>(S => S.StudentId == studentId);
            return _db.Delete<Student>(subject);

        }
        public bool Delete(Student student)
        {
            //Some Logics If Applicable
            return _db.Delete<Student>(student);
        }


        public Student FindById(int studentId)
        {
            return _db.Find<Student>(S =>S.StudentId == studentId);
        }

        public Student Find(Expression<Func<Student, bool>> predicate)
        {
            return _db.Find<Student>(predicate);
        }

        public List<Student> FindList(Expression<Func<Student, bool>> predicate)
        {
            return _db.FindList<Student>(predicate);
        }

        public bool Update(Student student)
        {
            return _db.Update<Student>(student);
        }

        public List<Student> GetAll()
        {
            return _db.GetAll<Student>();
        }

        public bool Save()
        {
            return _db.Save();
        }
    }
}
