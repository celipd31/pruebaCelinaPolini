using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PruebaCelinaPolini.Entidades;

namespace PruebaCelinaPolini.AccesoDatos
{
    public class CrudVehiculo
    {
        public List<EntServicio> lstServicios()
        {
            List<EntServicio> listaS;
            using (LavaCarEntities lcContext = new LavaCarEntities())
            {
                listaS = (from s in lcContext.Servicios
                          select new EntServicio
                          {
                              idServicio = s.ID_Servicio,
                              nombreServicio = s.Descripción,
                              montoServicio = s.Monto
                          }).ToList();
            }

            return listaS;
        }

        public List<int> idServ(string nombreServ)
        {
            
            using (LavaCarEntities lcContext = new LavaCarEntities())
            {
                                                     
                return (
                    from serv in lcContext.Servicios
                    where serv.Descripción == nombreServ
                    select serv.ID_Servicio
                    ).ToList();
            }
        }
        
        public List<EntVehiculo> lstV(string descripcion)
        {
            
            using (LavaCarEntities lcContext = new LavaCarEntities())
            {

                var groupJoinQuery = (
                    from s in lcContext.Servicios
                    join vs in lcContext.Vehiculo_Servicio on s.ID_Servicio equals vs.ID_Servicio
                    join v in lcContext.Vehiculoes on vs.ID_Vehiculo equals v.ID_Vehiculo
                    where s.Descripción == descripcion
                    select new EntVehiculo
                    {
                        dueño = v.Dueño,
                        ID_vehiculo = v.ID_Vehiculo,
                        marca = v.Marca,
                        placa = v.Placa
                    }
                    ).ToList();
                return groupJoinQuery;
            }
            
        }



        public bool crearVehiculo(Vehiculo vehiculo)
        {
                using (LavaCarEntities lcContext = new LavaCarEntities())
                {
                lcContext.Vehiculoes.Add(vehiculo);
                    if (lcContext.SaveChanges() == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            
        }

        public bool crearServicio(Servicio servicio)
        {
            using (LavaCarEntities lcContext = new LavaCarEntities())
            {
                lcContext.Servicios.Add(servicio);
                if (lcContext.SaveChanges() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}