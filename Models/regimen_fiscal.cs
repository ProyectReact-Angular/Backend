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
    
    public partial class regimen_fiscal
    {
        public string id { get; set; }
        public string descripcion { get; set; }
        public string persona_fisica { get; set; }
        public string persona_moral { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
    }
}
