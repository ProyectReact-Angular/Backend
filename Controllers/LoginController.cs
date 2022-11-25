using CrudPWA_PMB.Servicios;
using CrudPWA_PMB.Models.Entities;
using CrudPWA_PMB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Claims;
using CrudPWA_PMB.Security;

namespace CrudPWA_PMB.Controllers
{
    [AllowAnonymous]
    public class LoginController : ApiController
    {
        LoginServices services = new LoginServices();
        TokenProvider tokens = new TokenProvider();

        [HttpPost]
        public IHttpActionResult Login(UsuariosEntiti usuario)
        {
            string[] roles = services.GetPermisosByUsuario(usuario);
            var usu = services.GetUsuario(usuario);
            if (usu != null)
            {
                return Ok(tokens.CrearToken(usu));
            }
            else
            {
                return BadRequest("Credenciales Invalidas");
            }
        }
    }
}
