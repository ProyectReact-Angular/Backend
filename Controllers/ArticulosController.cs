using CrudPWA_PMB.Models;
using CrudPWA_PMB.Servicios;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using CrudPWA_PMB.Models.Entities;

namespace CrudPWA_PMB.Controllers
{
    [Authorize(Roles = "admin")]
    [RoutePrefix("api/Articulos")]
    public class ArticulosController : ApiController
    {
        ArticulosServices services = new ArticulosServices();
        [HttpGet]
        /*public List<ArticuloEntiti> ObtenerTodosPaginado(int page_size, int page_number)
        {
            var lista= services.BolcadoA().Skip((page_number - 1) * page_size).Take(page_size);
            return lista.ToList<ArticuloEntiti>();
            // return services.BolcadoA();
        }*/
        public List<ArticuloEntiti> ObtenerTodos()
        {
            return services.BolcadoA();
        }


        [Route("api/Articulos/{cdBarras}")]
        [HttpGet]
        public ArticuloEntiti ObtenerById(string cdBarras)
        {
            return services.ObtenerArtById(cdBarras);
        }


        [HttpPost]
        public bool RegistroA(ArticuloEntiti newArt)
        {
            return services.Insertar(newArt);
        }

        [HttpPatch]
        public bool ActualizarA(ArticuloEntiti newArt)
        {
            return services.Actualizar(newArt);
        }

        [Route("api/Articulos/{cdBarras}")]
        [HttpDelete]
        public bool EliminarA(string cdBarras)
        {
            return services.Eliminar(cdBarras);
        }
    }
}
