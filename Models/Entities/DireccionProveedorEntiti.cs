using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Models.Entities
{
    public class DireccionProveedorEntiti
    {
        public Guid id_proveedor { get; set; }
        public string calle { get; set; }
        public string no_int { get; set; }
        public string no_ext { get; set; }
        public string colonia { get; set; }
        public string localidad { get; set; }
        public string pais { get; set; }
        public string cod_postal { get; set; }
    }
}