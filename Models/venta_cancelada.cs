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
    
    public partial class venta_cancelada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venta_cancelada()
        {
            this.venta_cancelada_articulo = new HashSet<venta_cancelada_articulo>();
        }
    
        public int id_pos { get; set; }
        public System.Guid id_venta_cancel { get; set; }
        public string vendedor { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal total_vendido { get; set; }
        public decimal pago_efectivo { get; set; }
        public decimal pago_cheque { get; set; }
        public decimal pago_vales { get; set; }
        public decimal pago_tc { get; set; }
        public string status { get; set; }
        public string supervisor { get; set; }
        public bool upload { get; set; }
    
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_cancelada_articulo> venta_cancelada_articulo { get; set; }
    }
}
