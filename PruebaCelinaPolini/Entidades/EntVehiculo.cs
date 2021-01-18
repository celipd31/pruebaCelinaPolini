using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PruebaCelinaPolini.Entidades
{
    public class EntVehiculo
    {
        [Key]
        public int ID_vehiculo { set; get; }
        [Required]
        [Display(Name = "nombre dueño")]
        public string dueño { set; get; }
        [Required]
        [Display(Name = "placa")]
        public string placa { set; get; }
        [Required]
        [Display(Name = "marca")]
        public string marca { set; get; }
        public List<string> listServicios { set; get; }
    }
}