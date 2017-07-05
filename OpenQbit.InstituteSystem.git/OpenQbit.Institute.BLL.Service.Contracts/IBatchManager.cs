using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
    public interface IBatchManager
    {

        bool Create(Batch batch);
        Batch FindById(int batchId);
        bool DeleteById(int batchId);

        bool Delete(Batch batch);

        Batch Find(Expression<Func<Batch, bool>> predicate);

        List<Batch> FindList(Expression<Func<Batch, bool>> predicate);

        bool Update(Batch batch);

        List<Batch> GetAll();

        bool Save();
    }
}
