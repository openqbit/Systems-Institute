using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;
using System.Linq.Expressions;
namespace OpenQbit.Institute.BLL.Service1.Contracts
{
   public  interface IBatchEnrolmentManager
    {

        bool Create(BatchEnrolment batchEnrolment);
        BatchEnrolment FindById(int batchEnrolmentId);
        bool DeleteById(int batchEnrolmentId);

        bool Delete(BatchEnrolment batchEnrolment);

        BatchEnrolment Find(Expression<Func<BatchEnrolment, bool>> predicate);

        List<BatchEnrolment> FindList(Expression<Func<BatchEnrolment, bool>> predicate);

        bool Update(BatchEnrolment batchEnrolment);

        List<BatchEnrolment> GetAll();

        bool Save();

    }
}
