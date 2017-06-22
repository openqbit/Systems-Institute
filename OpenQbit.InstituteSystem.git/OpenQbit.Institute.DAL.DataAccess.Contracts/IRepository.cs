﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using OpenQbit.Institute.Common;

namespace OpenQbit.Institute.DAL.DataAccess.Contracts
{
    public interface IRepository
    {
        List<T> GetAll<T>() where T : class;
        T Find<T>(Expression<Func<T, bool>> predicate) where T : class;
        List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class;
        bool Create<T>(T obj) where T : class;
        bool Update<T>(T obj) where T : class;
        bool Delete<T>(T obj) where T : class;
        bool Save();
       // Institute.Common.Models.Branch FindList<T>(int branchResourceAllocationId);//this is create for FIND LIST object passing
        bool Create<T>(object newBranchResourceAllocation, object branch);
    }
}
