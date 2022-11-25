using CrudPWA_PMB.Models;
using CrudPWA_PMB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Servicios
{
    public class ProveedorServices
    {
        pos_adminEntities bdAdmin = new pos_adminEntities();

        public List<proveedor> ObtenerP()
        {
            return bdAdmin.proveedor.ToList<proveedor>();
        }

        public List<ProveedorEntiti> BolcadoP()
        {
            var lis = ObtenerP();
            List<ProveedorEntiti> newList = new List<ProveedorEntiti>();

            foreach (proveedor p in lis)
            {
                newList.Add(new ProveedorEntiti
                {
                    id_proveedor = p.id_proveedor,
                    rfc = p.rfc,
                    razon_social = p.razon_social,
                    nombre_contacto = p.nombre_contacto,
                    tel_principal = p.tel_principal,
                    tel_movil = p.tel_movil,
                    e_mail = p.e_mail,
                    estatus = p.estatus,
                    fecha_registro = p.fecha_registro
                });
            }
            return newList;
        }

        public ProveedorEntiti ObtenerPorvById(Guid id)
        {
            proveedor prov = bdAdmin.proveedor.FirstOrDefault(a => a.id_proveedor == id);
            ProveedorEntiti proveedorEntiti = (new ProveedorEntiti
            {
                id_proveedor = prov.id_proveedor,
                rfc = prov.rfc,
                razon_social = prov.razon_social,
                nombre_contacto = prov.nombre_contacto,
                tel_movil = prov.tel_movil,
                tel_principal = prov.tel_principal,
                e_mail = prov.e_mail,
                estatus = prov.estatus,
                fecha_registro = prov.fecha_registro
            });
            return proveedorEntiti;
        }

        public bool Insertar(ProveedorEntiti prt)
        {
            bool respuesta = false;
            try
            {
                proveedor pNuevo = (new proveedor
                {
                    id_proveedor = prt.id_proveedor,
                    rfc = prt.rfc,
                    razon_social= prt.razon_social,
                    nombre_contacto=prt.nombre_contacto,
                    tel_principal=prt.tel_principal,
                    tel_movil=prt.tel_movil,
                    e_mail=prt.e_mail,
                    estatus=prt.estatus,
                    fecha_registro=prt.fecha_registro
                });

                bdAdmin.proveedor.Add(pNuevo);
                bdAdmin.SaveChanges();
                respuesta = true;
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return respuesta;
        }

        public bool Eliminar(Guid id)
        {
            bool respuesta = false;
            try
            {
                proveedor prt = bdAdmin.proveedor.FirstOrDefault(p => p.id_proveedor == id);
                bdAdmin.proveedor.Remove(prt);
                bdAdmin.SaveChanges();
                respuesta = true;
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return respuesta;
        }

        public bool Actualizar(ProveedorEntiti provNew)
        {
            bool respuesta = false;
            try
            {
                proveedor pNuevo = (new proveedor
                {
                    id_proveedor = provNew.id_proveedor,
                    rfc = provNew.rfc,
                    razon_social = provNew.razon_social,
                    nombre_contacto = provNew.nombre_contacto,
                    tel_principal = provNew.tel_principal,
                    tel_movil = provNew.tel_movil,
                    e_mail = provNew.e_mail,
                    estatus = provNew.estatus,
                    fecha_registro = provNew.fecha_registro
                });

                proveedor provOld = bdAdmin.proveedor.FirstOrDefault(p => p.id_proveedor == pNuevo.id_proveedor);
                provOld.id_proveedor = pNuevo.id_proveedor;
                provOld.rfc = pNuevo.rfc;
                provOld.razon_social = pNuevo.razon_social;
                provOld.nombre_contacto = pNuevo.nombre_contacto;
                provOld.tel_principal = pNuevo.tel_principal;
                provOld.tel_movil = pNuevo.tel_movil;
                provOld.e_mail = pNuevo.e_mail;
                provOld.estatus = pNuevo.estatus;
                provOld.fecha_registro = pNuevo.fecha_registro;

                bdAdmin.SaveChanges();
                respuesta = true;

            }
            catch (Exception ex)
            {
                string msgErr = ex.Message;
            }
            return respuesta;
        }
    }
}