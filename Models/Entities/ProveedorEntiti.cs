using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Models.Entities
{
    public class ProveedorEntiti
    {
        public Guid id_proveedor { get; set; }
        public string rfc { get; set; }
        public string razon_social { get; set; }
        public string nombre_contacto { get; set; }
        public string tel_principal { get; set; }
        public string tel_movil { get; set; }
        public string e_mail { get; set; }
        public string estatus { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}