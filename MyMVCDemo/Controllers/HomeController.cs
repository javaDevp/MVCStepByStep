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
        [JsonException]
        public ActionResult Index()
        {
            throw new Exception("aaaaa");
            //return View(new JsonResult()
            //{
            //    Data = new { Success = false, Message = "aaa" }
            //});
        }
    }
}