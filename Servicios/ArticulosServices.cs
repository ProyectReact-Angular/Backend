using CrudPWA_PMB.Models;
using CrudPWA_PMB.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace CrudPWA_PMB.Servicios
{
    public class ArticulosServices
    {
        pos_adminEntities bdAdmin = new pos_adminEntities();

        Random gen = new Random();
       

        public List<articulo> ObtenerArticulos()
        {
            return bdAdmin.articulo.ToList<articulo>();
        }

        public List<ArticuloEntiti> BolcadoA()
        {
            var lis = ObtenerArticulos();
            List<ArticuloEntiti> newList = new List<ArticuloEntiti>();

            foreach (articulo a in lis)
            {
                newList.Add(new ArticuloEntiti
                {
                    cod_barras = a.cod_barras,
                    descripcion = a.descripcion,
                    cantidad_um = a.cantidad_um,
                    precio_compra = a.precio_compra,
                    precio_venta = a.precio_venta,
                    fecha_registro = a.fecha_registro,
                    utilidad = a.utilidad,
                    stock = a.stock,
                    iva = a.iva
                });
            }
            return newList;
        }

        public ArticuloEntiti ObtenerArtById(string cdBarras)
        {
            articulo art = bdAdmin.articulo.FirstOrDefault(a => a.cod_barras == cdBarras);
            if (art!= null)
            {
                ArticuloEntiti articuloEntiti = (new ArticuloEntiti
                {
                    cantidad_um = art.cantidad_um,
                    cod_barras = art.cod_barras,
                    descripcion = art.descripcion,
                    precio_compra = art.precio_compra,
                    precio_venta = art.precio_venta,
                    fecha_registro = art.fecha_registro,
                    iva = art.iva,
                    stock = art.stock,
                    utilidad = art.utilidad
                });
                return articuloEntiti;
            }
            else
            {
                return null;
            }

            
        }

        public bool Insertar(ArticuloEntiti art)
        {
            bool respuesta = false;
            try
            {
                articulo aNew = (new articulo
                {
                    cod_barras = gen.Next().ToString(),
                    id_clasificacion = 505,
                    descripcion = art.descripcion,
                    descripcion_corta = art.descripcion,
                    cantidad_um = art.cantidad_um,
                    id_unidad = Guid.Parse("8c383587-7684-4961-bee4-ad0b45a49d4c"),
                    id_proveedor = Guid.Parse("b7bf46b8-a741-4c78-8def-90ebf68c9d62"),
                    precio_compra = art.precio_compra,
                    utilidad = art.utilidad,
                    precio_venta = art.precio_venta,
                    tipo_articulo = "principal",
                    stock = art.stock,
                    stock_min = 0,
                    stock_max = 0,
                    iva = art.iva,
                    articulo_disponible = true,
                    kit = false,
                    fecha_registro = DateTime.Now,
                    visible = true,
                    last_update_inventory = DateTime.Now,
                    cve_producto = "50182002",
                });

                bdAdmin.articulo.Add(aNew);
                bdAdmin.SaveChanges();
                respuesta = true;
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return respuesta;
        }

        public bool Eliminar(string cdBarras)
        {
            bool respuesta = false;
            try
            {
                articulo art = bdAdmin.articulo.FirstOrDefault(p => p.cod_barras == cdBarras);
                bdAdmin.articulo.Remove(art);
                bdAdmin.SaveChanges();
                respuesta = true;
            }
            catch (Exception ex)
            {
                string mensajeErr = ex.Message;
            }
            return respuesta;
        }

        public bool Actualizar(ArticuloEntiti artNew)
        {
            bool respuesta = false;
            try
            {
                articulo aNuevo = (new articulo
                {
                    cod_barras = artNew.cod_barras,
                    id_clasificacion = 505,
                    descripcion = artNew.descripcion,
                    descripcion_corta = artNew.descripcion,
                    cantidad_um = artNew.cantidad_um,
                    id_unidad = Guid.Parse("8c383587-7684-4961-bee4-ad0b45a49d4c"),
                    id_proveedor = Guid.Parse("b7bf46b8-a741-4c78-8def-90ebf68c9d62"),
                    precio_compra = artNew.precio_compra,
                    utilidad = artNew.utilidad,
                    precio_venta = artNew.precio_venta,
                    tipo_articulo = "principal",
                    stock = artNew.stock,
                    stock_min = 0,
                    stock_max = 0,
                    iva = artNew.iva,
                    articulo_disponible = true,
                    kit = false,
                    fecha_registro = DateTime.Now,
                    visible = true,
                    last_update_inventory = DateTime.Now,
                    cve_producto = "50182002",
                });

                articulo artOld = bdAdmin.articulo.FirstOrDefault(a => a.cod_barras == aNuevo.cod_barras);

                artOld.cod_barras = aNuevo.cod_barras;
                artOld.id_clasificacion = aNuevo.id_clasificacion;
                artOld.descripcion = aNuevo.descripcion;
                artOld.descripcion_corta = aNuevo.descripcion_corta;
                artOld.cantidad_um = aNuevo.cantidad_um;
                artOld.id_unidad = aNuevo.id_unidad;
                artOld.id_proveedor = aNuevo.id_proveedor;
                artOld.precio_compra = aNuevo.precio_compra;
                artOld.utilidad = aNuevo.utilidad;
                artOld.precio_venta = aNuevo.precio_venta;
                artOld.tipo_articulo = aNuevo.tipo_articulo;
                artOld.stock = aNuevo.stock;
                artOld.stock_min = aNuevo.stock_min;
                artOld.stock_max = aNuevo.stock_max;
                artOld.iva = aNuevo.iva;
                artOld.articulo_disponible = aNuevo.articulo_disponible;
                artOld.kit = aNuevo.kit;
                artOld.visible = aNuevo.visible;
                artOld.last_update_inventory = DateTime.Now;
                artOld.cve_producto = aNuevo.cve_producto;


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