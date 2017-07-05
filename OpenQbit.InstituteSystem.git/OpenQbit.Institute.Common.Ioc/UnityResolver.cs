using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.DAL.DataAccess;
using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.Common.Utils.Log;
using OpenQbit.Institute.BLL.Service1.Contracts;
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
            Container.RegisterType<IBatchManager, BatchManager>();
            Container.RegisterType<IBatchEnrolmentManager, BatchEnrolmentManager>();
            Container.RegisterType<IBranchManager, BranchManager>();
            Container.RegisterType<IEmployeeManager, EmployeeManager>();
            Container.RegisterType<IInstituteManager, InstituteManager>();
            Container.RegisterType<IRepository, Repository>();
            Container.RegisterType<ILogger, Logger>();
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
