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
    
    public partial class venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venta()
        {
            this.venta_articulo = new HashSet<venta_articulo>();
            this.venta_devolucion = new HashSet<venta_devolucion>();
        }
    
        public int id_pos { get; set; }
        public System.Guid id_venta { get; set; }
        public string vendedor { get; set; }
        public long folio { get; set; }
        public System.DateTime fecha_venta { get; set; }
        public decimal total_vendido { get; set; }
        public decimal pago_efectivo { get; set; }
        public decimal pago_cheque { get; set; }
        public decimal pago_vales { get; set; }
        public decimal pago_tc { get; set; }
        public string supervisor { get; set; }
        public bool upload { get; set; }
        public short num_registros { get; set; }
    
        public virtual factura_venta factura_venta { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_articulo> venta_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_devolucion> venta_devolucion { get; set; }
    }
}
