//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudPWA_PMB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class venta_articulo
    {
        public int id_pos { get; set; }
        public System.Guid id_venta { get; set; }
        public long no_articulo { get; set; }
        public string cod_barras { get; set; }
        public Nullable<short> user_code_bascula { get; set; }
        public decimal cantidad { get; set; }
        public bool articulo_ofertado { get; set; }
        public decimal precio_regular { get; set; }
        public bool cambio_precio { get; set; }
        public decimal iva { get; set; }
        public decimal precio_vta { get; set; }
        public decimal porcent_desc { get; set; }
        public decimal cant_devuelta { get; set; }
        public string user_name { get; set; }
        public Nullable<System.Guid> id_promo { get; set; }
        public Nullable<short> no_promo_aplicado { get; set; }
    
        public virtual articulo articulo { get; set; }
        public virtual promocion promocion { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual venta venta { get; set; }
    }
}