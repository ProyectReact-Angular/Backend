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
    public class VentaController : ApiController
    {
        VentaServices services = new VentaServices();

        [HttpPost]
        public bool Insertar([FromBody] List<VentasEntiti> items)
        {
            return services.InsertarVenta(items);
        }

        [HttpGet]
        public List<VentaProductoEntiti> TopDiez()
        {
            var topDiez = services.TopArticulos().Take(10).ToList<VentaProductoEntiti>();
            return topDiez;
        }
    }
}
