using CrudPWA_PMB.Models;
using CrudPWA_PMB.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPWA_PMB.Servicios
{
    public class VentaServices
    {
        pos_adminEntities bdAdmin = new pos_adminEntities();
        Random rand = new Random();
        public bool InsertarVenta(List<VentasEntiti> ventaNueva)
        {
            articulo art = new articulo();
            bool respuesta = false;
            double totalArticulo = 0;
            int registrosTotales = 0;

            try
            {
                var codigos = devolverCodBarras(ventaNueva);

                for (int i = 0; i < ventaNueva.Count; i++)
                {
                    art = ObtenerArt(codigos[i],ventaNueva[i].cantidad);

                    totalArticulo = totalArticulo + (double.Parse(art.precio_venta.ToString()) * ventaNueva[i].cantidad);

                    registrosTotales = registrosTotales + (ventaNueva[i].cantidad);
                }

                Guid idventa = Guid.NewGuid();

                venta insertarVenta = (new venta
                {
                    id_pos = 1,
                    id_venta = idventa,
                    vendedor = "Andres",
                    folio = 1,
                    fecha_venta = DateTime.Now,
                    total_vendido = decimal.Parse(totalArticulo.ToString()),
                    pago_efectivo = decimal.Parse(totalArticulo.ToString()),
                    pago_cheque = 0,
                    pago_vales = 0,
                    pago_tc = 0,
                    upload = true,
                    num_registros = short.Parse(registrosTotales.ToString())
                });
                bdAdmin.venta.Add(insertarVenta);
                bdAdmin.SaveChanges();

                for (int v = 0; v < codigos.Length; v++)
                {
                    art = ObtenerArt(codigos[v],0);
                    venta_articulo insertarVentaArticulo = (new venta_articulo { 
                        id_pos = 1,
                        id_venta = idventa, 
                        no_articulo = rand.Next(),
                        cod_barras = codigos[v],
                        cantidad = ventaNueva[v].cantidad,
                        articulo_ofertado = false,
                        precio_regular = decimal.Parse(art.precio_venta.ToString()),
                        cambio_precio = false,
                        iva = 0,
                        precio_vta = (art.precio_venta * ventaNueva[v].cantidad),
                        porcent_desc = 0,
                        cant_devuelta = 0,
                    });
                    bdAdmin.venta_articulo.Add(insertarVentaArticulo);
                    bdAdmin.SaveChanges();
                }

                
                respuesta = true;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return respuesta;
        }

        public articulo ObtenerArt(string cdBarras, int cantidad)
        {
            articulo art = bdAdmin.articulo.FirstOrDefault(p => p.cod_barras == cdBarras);
            art.cod_barras = art.cod_barras;
            art.id_clasificacion = art.id_clasificacion;
            art.descripcion = art.descripcion;
            art.descripcion_corta = art.descripcion_corta;
            art.cantidad_um = art.cantidad_um;
            art.id_unidad = art.id_unidad;
            art.id_proveedor = art.id_proveedor;
            art.precio_compra = art.precio_compra;
            art.utilidad = art.utilidad;
            art.precio_venta = art.precio_venta;
            art.tipo_articulo = art.tipo_articulo;
            art.stock = art.stock - cantidad;
            art.stock_min = art.stock_min;
            art.stock_max = art.stock_max;
            art.iva = art.iva;
            art.articulo_disponible = art.articulo_disponible;
            art.kit = art.kit;
            art.visible = art.visible;
            art.last_update_inventory = DateTime.Now;
            art.cve_producto = art.cve_producto;
            bdAdmin.SaveChanges();

            return art;
        }
        public string[] devolverCodBarras (List<VentasEntiti> ventasEntitis)
        {
            string[] barras = new string[ventasEntitis.Count];
            for (int j = 0; j < ventasEntitis.Count; j++)
            {
                barras[j] = ventasEntitis[j].cod_barras;
            }
            return barras;
        }

        public List<venta_articulo> ObtenerVentaArticulos()
        {
            return bdAdmin.venta_articulo.ToList<venta_articulo>();
        }

        public List<VentaProductoEntiti> TopArticulos()
        {

            var lis = ObtenerVentaArticulos();
            List<VentaProductoEntiti> ventaProductoEntitis = new List<VentaProductoEntiti>();


            var listaA = (from a in lis
                          group a by new
                          { a.cod_barras } into g
                          select new
                          {
                              cod_barras = g.Key.cod_barras,
                              Total = g.Count()
                          }).ToList();

            foreach (var v in listaA)
            {
                decimal cantidadTotal = 0;

                for (int i = 0; i < lis.Count; i++)
                {
                    if (lis[i].cod_barras == v.cod_barras)
                    {
                        cantidadTotal = cantidadTotal + lis[i].cantidad;
                    }
                }

                ventaProductoEntitis.Add(new VentaProductoEntiti
                {
                    cod_barras = v.cod_barras,
                    cantidad = cantidadTotal,
                    Total = v.Total
                });
            }

            List<VentaProductoEntiti> topDiez = ventaProductoEntitis.OrderByDescending(x => x.cantidad).ToList();

            return topDiez;
        }
    }
}