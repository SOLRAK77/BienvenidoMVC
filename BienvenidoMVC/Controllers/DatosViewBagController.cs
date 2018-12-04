using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BienvenidoMVC.Controllers
{
    public class DatosViewBagController : Controller
    {
        // GET: DatosViewBag
        public ActionResult Index()
        {
            //PASO DE DATOS CON VIEWBAG
            ViewBag.NOMBRE = "CARLOS";
            ViewBag.AP_PATER = "CASTILLO";
            ViewBag.AP_MATER = "PEREZ";
            ViewBag.CORREO = "ccastillo.perez77@gmail.com";
            ViewBag.TELEFONO = "55360566";
            ViewBag.FECHA_NAC = new DateTime(2017, 2, 17);

            return View(ViewBag);
        }
    }
}