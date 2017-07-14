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
   public  class StaffManager : IStaffManager
    {
        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public StaffManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            this._db = repository;
        }

        public bool Create(Staff staff)
        {
            //Some Logics If Applicable
            return _db.Create<Staff>(staff);
        }

        public bool DeleteById(int staffId)
        {
            Staff staff = _db.Find<Staff>(S => S.StaffID == staffId);
            return _db.Delete<Staff>(staff);

        }
        public bool Delete(Staff staff)
        {
            //Some Logics If Applicable
            return _db.Delete<Staff>(staff);
        }


        public Staff FindById(int staffId)
        {
            return _db.Find<Staff>(S => S.StaffID == staffId);
        }

        public Staff Find(Expression<Func<Staff, bool>> predicate)
        {
            return _db.Find<Staff>(predicate);
        }

        public List<Staff> FindList(Expression<Func<Staff, bool>> predicate)
        {
            return _db.FindList<Staff>(predicate);
        }

        public bool Update(Staff staff)
        {
            return _db.Update<Staff>(staff);
        }

        public List<Staff> GetAll()
        {
            return _db.GetAll<Staff>();
        }

        public bool Save()
        {
            return _db.Save();
        }
    }
}
