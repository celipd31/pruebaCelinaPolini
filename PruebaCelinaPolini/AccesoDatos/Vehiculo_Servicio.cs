//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaCelinaPolini.AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo_Servicio
    {
        public int ID_Vehiculo_Servicio { get; set; }
        public int ID_Servicio { get; set; }
        public int ID_Vehiculo { get; set; }
    
        public virtual Servicio Servicio { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
