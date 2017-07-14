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
    public class SubjectManager:ISubjectManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public SubjectManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            this._db = repository;
        }

        public bool CreateSubject(Subject subject)
        {
            //Some Logics If Applicable
            return _db.Create<Subject>(subject);
        }

        public bool DeleteBySubjectId(int subjectId)
        {
            Subject subject = _db.Find<Subject>(S => S.SubjectId == subjectId);
            return _db.Delete<Subject>(subject);

        }
        public bool DeleteSubject(Subject subject)
        {
            //Some Logics If Applicable
            return _db.Delete<Subject>(subject);
        }


        public Subject FindBySubjectId(int subjectId)
        {
            return _db.Find<Subject>(S => S.SubjectId == subjectId);
        }

        public Subject FindSubject(Expression<Func<Subject, bool>> predicate)
        {
            return _db.Find<Subject>(predicate);
        }

        public List<Subject> FindSubjectList(Expression<Func<Subject, bool>> predicate)
        {
            return _db.FindList<Subject>(predicate);
        }

        public bool UpdateSubject(Subject subject)
        {
            return _db.Update<Subject>(subject);
        }

        public List<Subject> GetAllSubject()
        {
            return _db.GetAll<Subject>();
        }

        //////////////////////////////////////////////////////////////////////
        ////////////////   SubjectEnrolment     //////////////////////////////
        //////////////////////////////////////////////////////////////////////

        public bool CreateSubjectEnrolment(SubjectEnrolment subjectEnrolment)
        {
            //Some Logics If Applicable
            return _db.Create<SubjectEnrolment>(subjectEnrolment);
        }

        public bool DeleteBySubjectEnrolmentId(int subjectEnrolmentId)
        {
            SubjectEnrolment subjectEnrolment = _db.Find<SubjectEnrolment>(S => S.SubjectEnrolmentId == subjectEnrolmentId);
            return _db.Delete<SubjectEnrolment>(subjectEnrolment);

        }
        public bool DeleteSubjectEnrolment(SubjectEnrolment subjectEnrolment)
        {
            //Some Logics If Applicable
            return _db.Delete<SubjectEnrolment>(subjectEnrolment);
        }


        public SubjectEnrolment FindBySubjectEnrolmentId(int subjectEnrolmentId)
        {
            return _db.Find<SubjectEnrolment>(S => S.SubjectEnrolmentId == subjectEnrolmentId);
        }

        public SubjectEnrolment FindSubjectEnrolment(Expression<Func<SubjectEnrolment, bool>> predicate)
        {
            return _db.Find<SubjectEnrolment>(predicate);
        }

        public List<SubjectEnrolment> FindSubjectEnrolmentList(Expression<Func<SubjectEnrolment, bool>> predicate)
        {
            return _db.FindList<SubjectEnrolment>(predicate);
        }

        public bool UpdateSubjectEnrolment(SubjectEnrolment subjectEnrolment)
        {
            return _db.Update<SubjectEnrolment>(subjectEnrolment);
        }

        public List<SubjectEnrolment> GetAllSubjectEnrolment()
        {
            return _db.GetAll<SubjectEnrolment>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        Student ISubjectManager.FindBySubjectId(int subjectId)
        {
            throw new NotImplementedException();
        }

       
    }
}
