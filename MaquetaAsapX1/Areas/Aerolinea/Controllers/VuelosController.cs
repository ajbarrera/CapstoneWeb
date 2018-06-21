using BusLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaquetaAsapX1.Areas.Aerolinea.Controllers
{
    public class VuelosController : Controller
    {
        // GET: Aerolinea/Vuelos
        public ActionResult VuelosTripulacion()
        {
            //FALTA LLAMAAAAAAR
            ViewBag.ListadoTripulacion = BLEmpleado.Listado();
            return View();
        }
    }
}