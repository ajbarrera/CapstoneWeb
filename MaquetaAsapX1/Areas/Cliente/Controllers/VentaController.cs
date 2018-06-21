using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaquetaAsapX1.Areas.Cliente.Controllers
{
    public class VentaController : Controller
    {
        // GET: Cliente/Venta
        public ActionResult Detalle_Vuelo()
        {
            return View();
        }

        public ActionResult Info_Pasajero()
        {
            return View();
        }

        public ActionResult Pago_Pasaje()
        {
            return View();
        }
    }
}