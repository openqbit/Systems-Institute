using System.Web;
using System.Web.Mvc;

namespace OpenQbit.Institute.Presentation.WebTest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
