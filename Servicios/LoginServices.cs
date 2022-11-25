using CrudPWA_PMB.Models;
using CrudPWA_PMB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Servicios
{
    public class LoginServices
    {
        pos_adminEntities bdAdmin = new pos_adminEntities();

        public List<usuario_permiso> GetAllPermisos()
        {
            return bdAdmin.usuario_permiso.ToList<usuario_permiso>();
        }

        public Asociados GetUsuario(UsuariosEntiti usuario)
        {
            return bdAdmin.Asociados.FirstOrDefault(u => u.user_name == usuario.user_name && u.password == usuario.password);
        } 

        public string[] GetPermisosByUsuario(UsuariosEntiti usuario) 
        {
            List<usuario_permiso> usuario_Permisos = new List<usuario_permiso>();
            var allPermisos = GetAllPermisos();
            for (int i = 0; i < allPermisos.Count; i++)
            {
                if (allPermisos[i].user_name == usuario.user_name)
                {
                    usuario_Permisos.Add(allPermisos[i]);
                }
            }


            string[] permisos = new string[usuario_Permisos.Count];
            for (int i = 0; i < usuario_Permisos.Count; i++)
            {
                permisos[i] = usuario_Permisos[i].id_permiso;
            }
            return permisos;
        }
    }
}