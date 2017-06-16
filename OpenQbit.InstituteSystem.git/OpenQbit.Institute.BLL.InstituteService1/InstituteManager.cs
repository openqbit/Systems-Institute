using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Institute.DAL.DataAccess.Contracts;
using OpenQbit.Institute.Common.Models;
using OpenQbit.Institute.Common.Utils.Log;

using Microsoft.Practices.Unity;
using OpenQbit.Institute.BLL.Service.Contracts;

namespace OpenQbit.Institute.BLL.InstituteService1
{
    public class InstituteManager : IInstituteManager
    {

        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public InstituteManager(IRepository repository, ILogger logger)
        {
            _db = repository;
        }
    }
}
