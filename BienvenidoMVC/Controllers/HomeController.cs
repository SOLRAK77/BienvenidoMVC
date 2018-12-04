using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BienvenidoMVC.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        // GET: Home
        //  Todo metodo publico de un controller == accion
        /// URL : http://localhost/HomeController/Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}