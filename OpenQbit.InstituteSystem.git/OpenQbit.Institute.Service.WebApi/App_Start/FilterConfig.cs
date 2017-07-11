using System.Web;
using System.Web.Mvc;

namespace OpenQbit.Institute.Service.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
