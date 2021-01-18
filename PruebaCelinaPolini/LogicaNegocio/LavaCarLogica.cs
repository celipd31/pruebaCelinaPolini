using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaCelinaPolini.Entidades;
using PruebaCelinaPolini.AccesoDatos;

namespace PruebaCelinaPolini.LogicaNegocio
{
    public class LavaCarLogica
    {
        CrudVehiculo dataVehiculo = new CrudVehiculo();
        int cont = 0, contS = 0;
        [HttpPost]
        public bool guardarVehiculo(EntVehiculo vehiculoE)
        {
            Vehiculo vehiculoD = new Vehiculo();
            try
            {
                    cont++;
                    vehiculoD.ID_Vehiculo = cont;
                    vehiculoD.Dueño = vehiculoE.dueño;
                    vehiculoD.Marca = vehiculoE.marca;
                    vehiculoD.Placa = vehiculoE.placa;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

            return dataVehiculo.crearVehiculo(vehiculoD);
        }

        
        public bool guardarServicio(EntServicio servicioE)
        {
            Servicio servicioD = new Servicio();
            try
            {
                contS++;
                servicioD.ID_Servicio = contS;
                servicioD.Descripción = servicioE.nombreServicio;
                servicioD.Monto = servicioE.montoServicio;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dataVehiculo.crearServicio(servicioD);
        }

        public List<EntVehiculo> lstVehiculos(string descripcion)
        {
            return dataVehiculo.lstV(descripcion);
        }
    }
}