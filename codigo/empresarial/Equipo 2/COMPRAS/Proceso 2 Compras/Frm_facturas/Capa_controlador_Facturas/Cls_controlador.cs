using System;
using System.Data;
using Capa_modelo_factura;
using System.Linq;
//using Capa_Controlador_CXP;
using Capa_Controlador_Mov_Inv;
using System.Collections.Generic;

namespace Capa_controlador_Facturas
{
    public class Cls_controlador
    {

        Capa_modelo_factura.Cls_Sentencias sn = new Capa_modelo_factura.Cls_Sentencias();


        /*----------Cuentas por pagar-----------*/


     //   Cls_Compras_Controlador cxp = new Cls_Compras_Controlador();

        public DataTable llenarTblDetalle()
        {
            // Podrías agregar lógica de validación aquí si fuera necesario
            return sn.obtenerDetalles();
        }


        public DataTable getProveedores()
        {
            return sn.obtenerProveedores();
        }

        public DataTable getOrdenesCompra()
        {
            return sn.obtenerOrdenesCompra();
        }


        public DataTable obtenerUnidadMedida()
        {
            return sn.obtenerUnidadMedida();
        }


        public DataTable getProductos()
        {
            return sn.obtenerProductos();
        }



        public DataTable buscarCompra(string numero)
        {
            
            return sn.buscarCompraPorNumero(numero);
        }


        public DataTable obtenerDetalle(int id)
        {
            return sn.obtenerDetallePorCompra(id);
        }


        public void GuardarCompra(
               int idProveedor, int idOrdenCompra, int idbodega,
               string serie, string numero, DateTime fecha, string tipoPago,
               decimal subtotal, decimal total, int diasCredito,
               DateTime? fechaVencimiento, DataTable detalles)
        {
            
            int idCompra = sn.guardarCompra(
                idProveedor, idOrdenCompra, idbodega, serie, numero,
                fecha, tipoPago, subtotal, total, diasCredito, fechaVencimiento
            );

           
            var detalleInventario = detalles.AsEnumerable()
                .Select(row => (
                    idInventario: Convert.ToInt32(row["idInventario"]),
                    idBodega: idbodega,
                    cantidad: Convert.ToSingle(row["cantidad"]),
                    idUnidad: Convert.ToInt32(row["idUnidad"]) 
                ))
                .ToList();

            
            Cls_Mov_Inv_Controlador inventario = new Cls_Mov_Inv_Controlador();
            bool actualizacionStock = inventario.fun_GuardarMovimiento(
                2,      
                fecha,
                "Compra",
                detalleInventario
            );

            
            foreach (DataRow row in detalles.Rows)
            {
                int idInventario = Convert.ToInt32(row["idInventario"]);
                float cantidad = Convert.ToSingle(row["cantidad"]);

                
                int idUnidad = Convert.ToInt32(row["idUnidad"]);

                decimal precio = Convert.ToDecimal(row["precio"]);

                
                sn.guardarDetalleCompra(idCompra, idInventario, cantidad, idUnidad, precio);
            }
        }

        public int obtenerIdInventario(string nombreProducto)
        {
            return sn.obtenerIdInventario(nombreProducto);
        }


        public decimal calcularTotalCompra(DataTable dtDetalle)
        {
            decimal total = 0;
            foreach (DataRow fila in dtDetalle.Rows)
            {
                
                total += Convert.ToDecimal(fila["Subtotal"]);
            }
            return total;
        }

        /*---------------Boton-Actualizar-------*/



        public void actualizarCompra(int idCompra, int idProveedor, int idOrdenCompra, string serie,
                                string numero, DateTime fecha, string tipoPago,
                                decimal subtotal, decimal total,
                                int diasCredito, DateTime? fechaVencimiento)
        {
            // Reutilizamos la lógica de validación que definimos antes
            string pagoValidado = tipoPago.Trim().ToLower();
            sn.actualizarCompra(idCompra, idProveedor, idOrdenCompra, serie, numero, fecha,
                                pagoValidado, subtotal, total, diasCredito, fechaVencimiento);
        }



        public void eliminarDetalleCompra(int idCompra)
        {
            sn.eliminarDetalleCompra(idCompra);
        }

        public DataTable llenarComboBodega()
        {
         
            return sn.obtenerBodegas();
        }




        public DataTable buscarCompraCompletaPorNumero(string numeroFactura)
        {
            return sn.buscarCompraCompletaPorNumero(numeroFactura);
        }

        public void eliminarCompra(string numeroFactura)
        {
            sn.eliminarCompra(numeroFactura);
        }

        public void editarSoloEncabezadoCompra(string numeroFactura, int idProveedor,
                                                int idBodega, int idOrdenCompra,
                                                string serieFactura, DateTime fecha,
                                                DateTime fechaVencimiento, string tipoCompra,
                                                int diasCredito, decimal subtotal, decimal total)
        {
            sn.editarSoloEncabezadoCompra(numeroFactura, idProveedor, idBodega,
                                           idOrdenCompra, serieFactura, fecha,
                                           fechaVencimiento, tipoCompra,
                                           diasCredito, subtotal, total);
        }

        public void editarCompra(string numeroFactura, int idProveedor,
                                  int idBodega, int idOrdenCompra,
                                  string serieFactura, DateTime fecha,
                                  DateTime fechaVencimiento, string tipoCompra,
                                  int diasCredito, decimal subtotal, decimal total,
                                  List<(int idInventario, int idUnidad, float cantidad, decimal precio)> detalles)
        {
            sn.editarCompra(numeroFactura, idProveedor, idBodega, idOrdenCompra,
                            serieFactura, fecha, fechaVencimiento, tipoCompra,
                            diasCredito, subtotal, total, detalles);
        }



    }
}
