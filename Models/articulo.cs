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
    
    public partial class articulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public articulo()
        {
            this.articulo1 = new HashSet<articulo>();
            this.inventario_captura = new HashSet<inventario_captura>();
            this.compra_articulo = new HashSet<compra_articulo>();
            this.entrada_articulo = new HashSet<entrada_articulo>();
            this.estadistica = new HashSet<estadistica>();
            this.kit_articulos = new HashSet<kit_articulos>();
            this.oferta_articulo = new HashSet<oferta_articulo>();
            this.pedido_articulo = new HashSet<pedido_articulo>();
            this.pedido_articulo1 = new HashSet<pedido_articulo>();
            this.promocion_articulo = new HashSet<promocion_articulo>();
            this.salida_articulo = new HashSet<salida_articulo>();
            this.venta_articulo = new HashSet<venta_articulo>();
            this.venta_cancelada_articulo = new HashSet<venta_cancelada_articulo>();
            this.kit_articulos1 = new HashSet<kit_articulos>();
            this.orden_articulo = new HashSet<orden_articulo>();
            this.orden_articulo1 = new HashSet<orden_articulo>();
        }
    
        public string cod_barras { get; set; }
        public string cod_asociado { get; set; }
        public long id_clasificacion { get; set; }
        public string cod_interno { get; set; }
        public string descripcion { get; set; }
        public string descripcion_corta { get; set; }
        public decimal cantidad_um { get; set; }
        public System.Guid id_unidad { get; set; }
        public System.Guid id_proveedor { get; set; }
        public decimal precio_compra { get; set; }
        public decimal utilidad { get; set; }
        public decimal precio_venta { get; set; }
        public string tipo_articulo { get; set; }
        public decimal stock { get; set; }
        public decimal stock_min { get; set; }
        public decimal stock_max { get; set; }
        public decimal iva { get; set; }
        public Nullable<System.DateTime> kit_fecha_ini { get; set; }
        public Nullable<System.DateTime> kit_fecha_fin { get; set; }
        public bool articulo_disponible { get; set; }
        public bool kit { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public bool visible { get; set; }
        public short puntos { get; set; }
        public System.DateTime last_update_inventory { get; set; }
        public string cve_producto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<articulo> articulo1 { get; set; }
        public virtual articulo articulo2 { get; set; }
        public virtual articulos articulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inventario_captura> inventario_captura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_articulo> compra_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrada_articulo> entrada_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estadistica> estadistica { get; set; }
        public virtual inventario_fisico_articulo inventario_fisico_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kit_articulos> kit_articulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<oferta_articulo> oferta_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedido_articulo> pedido_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedido_articulo> pedido_articulo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<promocion_articulo> promocion_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salida_articulo> salida_articulo { get; set; }
        public virtual precio_temporal precio_temporal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_articulo> venta_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_cancelada_articulo> venta_cancelada_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kit_articulos> kit_articulos1 { get; set; }
        public virtual clasificacion clasificacion { get; set; }
        public virtual inventario_articulo inventario_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orden_articulo> orden_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orden_articulo> orden_articulo1 { get; set; }
        public virtual proveedor proveedor { get; set; }
        public virtual unidad_medida unidad_medida { get; set; }
    }
}