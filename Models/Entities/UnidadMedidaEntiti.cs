using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Models.Entities
{
    public class UnidadMedidaEntiti
    {
        public Guid id_unidad { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_registro { get; set; }
        public string cve_sat { get; set; }
    }
}