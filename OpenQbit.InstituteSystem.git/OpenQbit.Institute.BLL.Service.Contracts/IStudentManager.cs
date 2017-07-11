using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service.Contracts
{
    interface IStudentManager
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
