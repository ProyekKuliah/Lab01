using System.Web;
using System.Web.Mvc;

namespace Lab01_151524010_FerdhikaYudira
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
