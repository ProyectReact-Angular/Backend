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
    public class UnidadMedidaController : ApiController
    {
        UnidadMedidaServices services = new UnidadMedidaServices();

        [HttpGet]
        public List<UnidadMedidaEntiti> GetAll(int page_size, int page_number)
        {

            var listaPag = services.BolcadoUD().Skip((page_number - 1) * page_size).Take(page_size);

            return listaPag.ToList<UnidadMedidaEntiti>();
        }

        [Route("api/UnidadMedida/{id}")]
        [HttpGet]
        public UnidadMedidaEntiti GetOneP(Guid id)
        {
            return services.ObtenerUnidadMById(id);
        }
    }
}
