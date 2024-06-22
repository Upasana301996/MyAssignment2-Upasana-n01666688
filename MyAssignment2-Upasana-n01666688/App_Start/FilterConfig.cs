using System.Web;
using System.Web.Mvc;

namespace MyAssignment2_Upasana_n01666688
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
