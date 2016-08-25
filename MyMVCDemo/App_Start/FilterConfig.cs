using MyMVCDemo.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCDemo
{
    public class FilterConfig
    {
        public static void RegisterFilters(GlobalFilterCollection filters)
        {
            //HandleErrorAttribute默认导航到Views-Shared-Error.cshtml，并且ViewData为HandleErrorInfo类型
            filters.Add(new HandleErrorAttribute());
            //添加记录异常日志过滤器
            filters.Add(new LogExceptionAttribute());
        }
    }
}