﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                return Content("1");
            }
            catch (Exception ex)

            {
                return Content("Ocurrio un error" + ex.Message);
            }
        }

 
    }
}