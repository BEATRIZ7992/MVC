using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //GET: /HelloWolrd/Enter/
        public ActionResult Enter(string user, string pass)
        {
            try
            {
                return Content("1");

            }
            catch(Exception ex)
            {
                return Content("error que pasa:("+ex.Message);
            }
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }


    }
}