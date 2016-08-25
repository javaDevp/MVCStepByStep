using MyMVCDemo.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //[JsonException]
        public ActionResult Index()
        {
            #region 测试异常处理
            //throw new Exception("aaaaa");
            #endregion
            return View();
        }
    }
}