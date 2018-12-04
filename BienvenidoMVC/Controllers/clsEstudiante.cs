using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BienvenidoMVC.Controllers
{
    public class clsEstudiante
    {
        public string Nombre { get; set; }
        public string Ap_Paterno { get; set; }
        public string Ap_Materno { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Nac { get; set; }


    }
}