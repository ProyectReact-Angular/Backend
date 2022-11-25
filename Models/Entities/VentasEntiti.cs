using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Models.Entities
{
    public class VentasEntiti
    {
        public Guid? id_venta { get; set; }
        public string cod_barras { get; set; }
        public short? num_registros { get; set; }
        public int cantidad { get; set; }
    }
}