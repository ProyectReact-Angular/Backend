using CrudPWA_PMB.Models;
using CrudPWA_PMB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Servicios
{
    public class UnidadMedidaServices
    {
        pos_adminEntities bdAdmin = new pos_adminEntities();

        public List<unidad_medida> ObtenerUD()
        {
            return bdAdmin.unidad_medida.ToList<unidad_medida>();
        }

        public List<UnidadMedidaEntiti> BolcadoUD()
        {
            var lis = ObtenerUD();

            List<UnidadMedidaEntiti> newList = new List<UnidadMedidaEntiti>();

            foreach (unidad_medida unidadMedida in lis)
            {
                newList.Add(new UnidadMedidaEntiti
                {
                    id_unidad = unidadMedida.id_unidad,
                    descripcion = unidadMedida.descripcion,
                    fecha_registro = unidadMedida.fecha_registro,
                    cve_sat = unidadMedida.cve_sat
                });
            }
            return newList;
        }

        public UnidadMedidaEntiti ObtenerUnidadMById(Guid id)
        {
            unidad_medida unidadMedida = bdAdmin.unidad_medida.FirstOrDefault(a => a.id_unidad == id);

            UnidadMedidaEntiti medidaEntiti = (new UnidadMedidaEntiti
            {
                id_unidad = unidadMedida.id_unidad,
                descripcion = unidadMedida.descripcion,
                fecha_registro = unidadMedida.fecha_registro,
                cve_sat = unidadMedida.cve_sat
            });
            return medidaEntiti;
        }
    }
}