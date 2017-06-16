using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.DAL.DataAccess;
using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.Common.Utils.Log;
using OpenQbit.Institute.BLL.Service.Contracts;
using OpenQbit.Institute.BLL.InstituteService1;

using Microsoft.Practices.Unity;

namespace OpenQbit.Institute.Common.Ioc
{
    public static class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        private static void Register()
        {
            Container.RegisterType<IBranchResourceAllocationManager, BranchResourceAllocationManager>();
            Container.RegisterType<IEmployeeManager, EmployeeManager>();
            Container.RegisterType<IRepository, Repository>();
            Container.RegisterType<ILogger, LoggerB>();
        }

        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = Container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }

        public static IUnityContainer GetContainer()
        {
            return Container;
        }
    }
}
