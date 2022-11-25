using CrudPWA_PMB.Models;
using CrudPWA_PMB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Servicios
{
    public class DireccionProveedorServices
    {
        pos_adminEntities bdAdmin = new pos_adminEntities();

        public List<direccion_proveedor> ObtenerDP()
        {
            return bdAdmin.direccion_proveedor.ToList<direccion_proveedor>();
        }

        public List<DireccionProveedorEntiti> BolcadoDP()
        {
            var lis = ObtenerDP();

            List<DireccionProveedorEntiti> newList = new List<DireccionProveedorEntiti>();

            foreach (direccion_proveedor dp in lis)
            {
                newList.Add(new DireccionProveedorEntiti
                {
                    id_proveedor = dp.id_proveedor,
                    calle = dp.calle,
                    no_int = dp.no_int,
                    no_ext = dp.no_ext,
                    colonia = dp.colonia,
                    localidad = dp.localidad,
                    pais = dp.pais,
                    cod_postal = dp.cod_postal
                });
            }
            return newList;
        }

        public DireccionProveedorEntiti ObtenerDProvById(Guid id)
        {
            direccion_proveedor direccion_ = bdAdmin.direccion_proveedor.FirstOrDefault(p => p.id_proveedor == id);

            DireccionProveedorEntiti respuesta = (new DireccionProveedorEntiti
            {
                id_proveedor = direccion_.id_proveedor,
                calle = direccion_.calle,
                no_ext = direccion_.no_ext,
                no_int = direccion_.no_int,
                colonia = direccion_.colonia,
                localidad = direccion_.localidad,
                pais = direccion_.pais,
                cod_postal = direccion_.cod_postal
            });
            return respuesta;
        }
    }
}