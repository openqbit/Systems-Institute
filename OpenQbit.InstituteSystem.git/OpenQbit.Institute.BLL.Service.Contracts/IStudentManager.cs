using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface IStudentManager
    {
        bool Create(Student student);
        Student FindById(int studentId);
        bool DeleteById(int studentId);

        bool Delete(Student student);

        Student Find(Expression<Func<Student, bool>> predicate);

        List<Student> FindList(Expression<Func<Student, bool>> predicate);

        bool Update(Student student);

        List<Student> GetAll();

        bool Save();
    }
}
