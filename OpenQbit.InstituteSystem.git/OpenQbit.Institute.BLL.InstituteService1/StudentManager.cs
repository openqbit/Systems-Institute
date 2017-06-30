using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.Common.Utils.Log;

using Microsoft.Practices.Unity;

using OpenQbit.Institute.BLL.Service.Contracts;

namespace OpenQbit.Institute.BLL.InstituteService1
{
    public class StudentManager : IStudentManager
    {
        private IRepository _db;
        private ILogger _logger;

        [InjectionConstructor]
        public StudentManager(IRepository repository, ILogger logger)
        {
            _db = repository;
        }


        // public bool CreateStudent(Student newStudent)
        public bool CreateStudent(string ParentInformation, string Person, string BatchEnrolment)
        {
            Student newStudent = new Student();
            return _db.Create<Student>(newStudent);
        }

        public bool CreateStudent(int ParentInformation, int Person, List<int> BatchEnrolment)
        {
            List<Student> studentList = new List<Student>();

            foreach (var resource in BatchEnrolment)
            {
                //Student newStudent = new Student { ParentInformation = ParentInformation, Pereson = Person, BatchEnrolment = resource }
                //_db.Create<Student>(newStudent);
            }
            return _db.Save();
        }

        public bool RemoveStudent(int StudentId)
        {
            Student newStudent = new Student();
            return _db.Delete<Student>(newStudent);
        }

        public Student FindStudent(int StudentId)
        {
            Student newStudent = new Student();
            return _db.FindList<Student>(B => B.StudentId == StudentId).FirstOrDefault();
        }

        public List<Student> FindStudentList(int StudentId)
        {
            Student newStudent = new Student();
            return _db.FindList<Student>(B => B.StudentId == StudentId);
        }

        public bool RecordStudentManager(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
