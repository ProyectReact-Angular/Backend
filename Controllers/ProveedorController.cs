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
    public class ProveedorController : ApiController
    {
        ProveedorServices services = new ProveedorServices();
        [HttpGet]
        public List<ProveedorEntiti> GetAll()
        {
            return services.BolcadoP();
        }

        [Route("api/Proveedor/{id}")]
        [HttpGet]
        public ProveedorEntiti GetOneP(Guid id)
        {
            return services.ObtenerPorvById(id);
        }

        [HttpPost]
        public bool InsertP(ProveedorEntiti proveedor)
        {
            return services.Insertar(proveedor);
        }

        [HttpPatch]
        public bool Actualizar(ProveedorEntiti newP)
        {
            return services.Actualizar(newP);
        }

        [HttpDelete]
        public bool DeleteP(Guid id)
        {
            return services.Eliminar(id);
        }
    }
}
