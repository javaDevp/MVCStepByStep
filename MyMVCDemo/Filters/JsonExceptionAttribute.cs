using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCDemo.Filters
{
    /// <summary>
    /// 返回JSON格式的错误信息提示
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple =false, Inherited =true)]
    public class JsonExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                filterContext.Result = new JsonResult()
                {
                    Data = new { Success = false, Message = filterContext.Exception.Message },
                    //ContentType = "application/json"
                    //为了方便效果展示，允许Get请求，实际应用中，通过ajax等请求，可以不用
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
        }
    }
}