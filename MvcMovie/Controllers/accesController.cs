using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMovie.Models;
using System.Web.Mvc;


namespace MvcMovie.Controllers
{
    public class accesController : Controller
    {
        // GET: acces
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Entrar(string usuario, string password) 
        {
            try
            {



                using (MvcEntities db= new MvcEntities())
                {
                    var list = from d in db.users
                               where d.email == usuario && d.password == password && d.idState==1
                               select d;


                    if (list.Count() > 0)
                    {
                        users oUsers = list.First();
                        Session["Users"] = oUsers;

                    }
                }
                return Content("1");
            }
            catch (Exception ex)

            {
                return Content("Ocurrio un error" + ex.Message);
            }
        }

 
    }
}