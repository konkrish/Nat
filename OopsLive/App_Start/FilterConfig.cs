using OopsLive.Models;
using System.Web;
using System.Web.Mvc;

namespace OopsLive
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionHandlerFilter());
        }
    }
}
