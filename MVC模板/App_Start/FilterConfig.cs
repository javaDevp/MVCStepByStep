using System.Web;
using System.Web.Mvc;

namespace MVC模板
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //注意：HandleErrorAttribute只处理500错误
            filters.Add(new HandleErrorAttribute());
        }
    }
}
