using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMVCDemo.Filters
{
    /// <summary>
    /// 发生异常记录错误日志
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class LogExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                string controller = filterContext.RouteData.Values["controller"] as string;
                string action = filterContext.RouteData.Values["action"] as string;
                string msgTemplate = "在执行 controller[{0}] 的 action[{1}] 时产生异常";
                //TODO 写日志操作
            }
            if (filterContext.Result is JsonResult)
            {
                filterContext.ExceptionHandled = true;
            }
            else
            {
                base.OnException(filterContext);
            }
        }
    }
}