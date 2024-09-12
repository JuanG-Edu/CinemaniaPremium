using System.Web;
using System.Web.Mvc;

namespace Eva_E1_DesSisWebBD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
