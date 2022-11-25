using CrudPWA_PMB.Models.Entities;
using CrudPWA_PMB.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudPWA_PMB.Controllers
{
    public class DireccionProveedorController : ApiController
    {
        DireccionProveedorServices services = new DireccionProveedorServices();
        
        [HttpGet]
        public List<DireccionProveedorEntiti> GetAll()
        {
            return services.BolcadoDP();
        }

        [Route("api/DireccionProveedor/{id}")]
        [HttpGet]
        public DireccionProveedorEntiti GetOneP(Guid id)
        {
            return services.ObtenerDProvById(id);
        }
    }
}
