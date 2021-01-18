using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaCelinaPolini.Entidades;
using PruebaCelinaPolini.LogicaNegocio;


namespace PruebaCelinaPolini.Views.Controllers
{
    public class LavaCarController : Controller
    {
        LavaCarLogica logicaLv = new LavaCarLogica();
        EntVehiculo vehiculoE = new EntVehiculo();
      

        // GET: LavaCar
        public ActionResult InicioLavaCar()
        {
            return View();
        }
        
        public ActionResult guardarVehiculo(FormCollection formCollection)
        {
            if (formCollection.HasKeys())
            {
                vehiculoE.dueño = formCollection["txtNombre"];
                vehiculoE.marca = formCollection["txtMarca"];
                vehiculoE.placa = formCollection["txtPlaca"];

                logicaLv.guardarVehiculo(vehiculoE);
            }

            return View();

        }


        
        public ActionResult listaVehiculos(FormCollection formCollection)
        {
            if (formCollection.HasKeys())
            {
               
                var nombre = "Lavado Interno";
                logicaLv.lstVehiculos(nombre);
            }
            return View();
        }

    }
}