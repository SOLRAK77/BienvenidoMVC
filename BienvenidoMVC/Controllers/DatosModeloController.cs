using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BienvenidoMVC.Controllers
{
    public class DatosModeloController : Controller
    {
        // GET: DatosModelo
        public ActionResult DatosModelo()
        {
            //SE CREA UN OBJETO Y EL CONTROLADOR LO PASO A LA VISTA
            clsEstudiante objPersona = new clsEstudiante();
            objPersona.Nombre = "CARLOS";
            objPersona.Ap_Paterno = "CASTILLO";
            objPersona.Ap_Materno = "PEREZ";
            objPersona.Correo = "ccastillo.perez77@gmail.com";
            objPersona.Telefono = "55360566";
            objPersona.Fecha_Nac = new DateTime(2017, 2, 17);

            return View(objPersona);
        }
    }
}