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
    
    public partial class direccion_proveedor
    {
        public System.Guid id_proveedor { get; set; }
        public string calle { get; set; }
        public string no_int { get; set; }
        public string no_ext { get; set; }
        public string colonia { get; set; }
        public string localidad { get; set; }
        public Nullable<short> id_entidad { get; set; }
        public Nullable<short> id_municipio { get; set; }
        public string pais { get; set; }
        public string cod_postal { get; set; }
    
        public virtual municipio municipio { get; set; }
        public virtual proveedor proveedor { get; set; }
    }
}
