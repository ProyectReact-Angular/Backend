using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using CrudPWA_PMB.Models.Entities;
using CrudPWA_PMB.Models;

namespace CrudPWA_PMB.Security
{
    public class TokenProvider
    {
        static string P12Secret = @"C:\Users\dani_\source\repos\CrudPWA_PMB\Security\certificate.p12";
        //static string P12Secret = @"C:\Users\dani_\OneDrive\Desktop\certificate.p12";
        //Metodo con arreglo de roles
        /*public string CrearToken(UsuariosEntiti usuario, string [] roles)
        {
            var credentials = new JwtHeader(new SigningCredentials(GetCertificate(), SecurityAlgorithms.RsaSha256));
            
            var claimsRoles = roles.Select(rol => new Claim(ClaimTypes.Role, rol));

            var claims = Enumerable.Concat(claimsRoles, new Claim[] {
              new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
              new Claim(JwtRegisteredClaimNames.Sub, usuario.user_name),
              new Claim(JwtRegisteredClaimNames.NameId, usuario.user_name)
            });

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            JwtPayload payLoad = new JwtPayload(
                issuer: "UTTT",
                audience: "UTTT",
                claims: claimsPrincipal.Claims,
                issuedAt: DateTime.Now,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddHours(3)
                );

            var jwtToken = new JwtSecurityToken(credentials,payLoad);

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }*/
        public string CrearToken(Asociados usuario)
        {
            var credentials = new JwtHeader(new SigningCredentials(GetCertificate(), SecurityAlgorithms.RsaSha256));
            string[] roles = { usuario.tipo_usuario }; 
            var claimsRoles = roles.Select(rol => new Claim(ClaimTypes.Role, rol));

            var claims = Enumerable.Concat(claimsRoles, new Claim[] {
              new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
              new Claim(JwtRegisteredClaimNames.Sub, usuario.user_name),
              new Claim(JwtRegisteredClaimNames.NameId, usuario.user_name)
            });

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            JwtPayload payLoad = new JwtPayload(
                issuer: "UTTT",
                audience: "UTTT",
                claims: claimsPrincipal.Claims,
                issuedAt: DateTime.Now,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddHours(3)
                );

            var jwtToken = new JwtSecurityToken(credentials, payLoad);

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

        private RsaSecurityKey GetCertificate() 
        {
            try
            {
                var cert = new X509Certificate2(P12Secret, "12345");
                //var pKey = cert.PrivateKey;
                var provider = (RSACryptoServiceProvider)cert.PrivateKey;
                return new RsaSecurityKey(provider);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        } 
    }
}