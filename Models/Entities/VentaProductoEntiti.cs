using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Models.Entities
{
    public class VentaProductoEntiti
    {
        public Guid id_venta { get; set; }
        public string cod_barras { get; set; }
        public decimal cantidad { get; set; }
        public int Total { get; set; }
    }
}