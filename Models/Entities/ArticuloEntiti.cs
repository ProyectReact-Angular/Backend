using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Models.Entities
{
    public class ArticuloEntiti
    {
        public string cod_barras { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad_um { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public decimal utilidad { get; set; }
        public decimal stock { get; set; }
        public decimal iva { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}