using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface ISubjectManager
    {
        bool CreateSubject(Subject student);
        Student FindBySubjectId(int subjectId);
        bool DeleteBySubjectId(int subjectId);

        bool DeleteSubject(Subject subject);

        Subject FindSubject(Expression<Func<Subject, bool>> predicate);

        List<Subject> FindSubjectList(Expression<Func<Subject, bool>> predicate);

        bool UpdateSubject(Subject subject);

        List<Subject> GetAllSubject();

        /////////////////////////////////////////////

        bool CreateSubjectEnrolment(SubjectEnrolment subjectEnrolment);
        SubjectEnrolment FindBySubjectEnrolmentId(int subjectEnrolmentId);
        bool DeleteBySubjectEnrolmentId(int subjectEnrolmentId);

        bool DeleteSubjectEnrolment(SubjectEnrolment subjectEnrolment);

        SubjectEnrolment FindSubjectEnrolment(Expression<Func<SubjectEnrolment, bool>> predicate);

        List<SubjectEnrolment> FindSubjectEnrolmentList(Expression<Func<SubjectEnrolment, bool>> predicate);

        bool UpdateSubjectEnrolment(SubjectEnrolment subjectEnrolment);

        List<SubjectEnrolment> GetAllSubjectEnrolment();

        bool Save();
    }
}
