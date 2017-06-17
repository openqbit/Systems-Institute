using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OpenQbit.Institute.Common.Ioc;
using OpenQbit.Institute.BLL.Service.Contracts;

namespace OpenQbit.Institute.Presentation.WebTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IBranchResourceAllocationManager BranchManager = UnityResolver.Resolve<IBranchResourceAllocationManager>();
           // IBranchResourceAllocationManager BranchManager = new BranchResourceAllocationManager();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}