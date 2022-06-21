using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSS.Controllers
{
    public class HomeController : Controller
    {
        //Objeto referencia a entidades de base de datos
        private ConcesionarioEntities db = new ConcesionarioEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TablaAlquiler()
        {
            var tabla = db.tabla_alquiler().ToList();
            return View(tabla);

        }

        public ActionResult Filtrar(DateTime fechaInicio, DateTime fechaFin)
        {
            var tabla = db.tabla_alquiler().ToList();

            if (fechaFin != null)
            {
                List<tabla_alquiler_Result> tFiltrada = new List<tabla_alquiler_Result>();
                foreach (var elemento in tabla)
                {
                    if (elemento.fecha_alquiler >= fechaInicio && elemento.fecha_alquiler < fechaFin)
                    {
                        tFiltrada.Add(elemento);
                    }
                }

                return View(tFiltrada);
            }
            else
            {
                return View(tabla);
            }

            
        }

    }
}