using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_modelo_orden_compra;

namespace Capa_controlador_orden_compra
{
    public class Cls_controlador
    {


        Cls_Sentencias sn = new Cls_Sentencias();

       
        public DataTable llenarTblDetalle()
        {
            // Podrías agregar lógica de validación aquí si fuera necesario
            return sn.obtenerDetalles();
        }





        public DataTable getProveedores()
        {
            return sn.obtenerProveedores();
        }


        public DataTable getProductos()
        {
            return sn.obtenerProductos();
        }



        public DataTable llenarComboBodega()
        {

            return sn.obtenerBodegas();
        }


        public DataTable obtenerUnidadMedida()
        {
            return sn.obtenerUnidadMedida();
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





        public string generarNumeroOrden()
        {
            return sn.generarNumeroOrden();
        }

        public int guardarOrdenCompra(int idProveedor, int idBodega, string numero,
                                       DateTime fecha, DateTime fechaEntrega,
                                       string tipoPago, int diasCredito,
                                       decimal subtotal, decimal total)
        {
            return sn.guardarOrdenCompra(idProveedor, idBodega, numero,
                                                 fecha, fechaEntrega, tipoPago,
                                                 diasCredito, subtotal, total);
        }

        public void guardarDetalleOrdenCompra(int idOrden,
                                       int idInventario,
                                       int idUnidad,
                                       float cantidad,
                                       decimal precio)
        {
            sn.guardarDetalleOrdenCompra(idOrden,
                                         idInventario,
                                         idUnidad,
                                         cantidad,
                                         precio);
        }


        public DataTable MostrarDetalleOrden()
        {
            return sn.ObtenerDetalleOrden();
        }


        public DataTable buscarOrdenPorNumero(string numeroOrden)
        {
            return sn.buscarOrdenPorNumero(numeroOrden);
        }

        // Numero de Orden para MRP

        public void mrp(
      int idProveedor,
      List<(int idInventario, int idUnidad, float cantidad)> detalles
  )
        {
            //Datos quemados 

            int idBodega = 1;

            DateTime fecha = DateTime.Now;

            DateTime fechaEntrega = DateTime.Now.AddDays(7);

            string tipoPago = "credito";

            int diasCredito = 30;

           // generar numor de MRP

            string numero = generarNumeroMRP();

            // calculo de total y subtotal 

            decimal subtotal = 0;

            foreach (var item in detalles)
            {
                decimal precio = sn.obtenerPrecioProducto(item.idInventario);

                subtotal += Convert.ToDecimal(item.cantidad) * precio;
            }

            decimal iva = subtotal * 0.12m;

            decimal total = subtotal + iva;

            // registro encabezado 

            int idOrden = sn.guardarOrdenCompra(
                idProveedor,
                idBodega,
                numero,
                fecha,
                fechaEntrega,
                tipoPago,
                diasCredito,
                subtotal,
                total
            );

            // registro detalles 

            foreach (var item in detalles)
            {
                decimal precio = sn.obtenerPrecioProducto(item.idInventario);

                sn.guardarDetalleOrdenCompra(
                    idOrden,
                    item.idInventario,
                    item.idUnidad,
                    item.cantidad,
                    precio
                );
            }
        }
        public string generarNumeroMRP()
        {
            string ultimoNumero = sn.obtenerUltimoNumeroMRP();

            if (string.IsNullOrEmpty(ultimoNumero))
            {
                return "MRP-001";
            }

            string[] partes = ultimoNumero.Split('-');

            int correlativo = 0;

            if (partes.Length == 2)
            {
                int.TryParse(partes[1], out correlativo);
            }

            correlativo++;

            return $"MRP-{correlativo:D3}";
        }



        public decimal obtenerPrecioProducto(int idProducto)
        {
            return sn.obtenerPrecioProducto(idProducto);
        }



        public DataTable buscarOrdenCompletaPorNumero(string numeroOrden)
        {
            return sn.buscarOrdenCompletaPorNumero(numeroOrden);
        }



        public void eliminarOrdenCompra(string numeroOrden)
        {
            sn.eliminarOrdenCompra(numeroOrden);
        }


        //  Editar Ornde de Compra


        public void editarOrdenCompra(string numeroOrden, int idProveedor, int idBodega,
                               DateTime fecha, DateTime fechaEntrega,
                               string tipoPago, int diasCredito,
                               decimal subtotal, decimal total,
                               List<(int idInventario, int idUnidad, float cantidad, decimal precio)> detalles)
        {
            sn.editarOrdenCompra(numeroOrden, idProveedor, idBodega,
                                 fecha, fechaEntrega, tipoPago, diasCredito,
                                 subtotal, total, detalles);
        }


        public void editarSoloEncabezado(string numeroOrden, int idProveedor, int idBodega,
                                  DateTime fecha, DateTime fechaEntrega,
                                  string tipoPago, int diasCredito,
                                  decimal subtotal, decimal total)
        {
            sn.editarSoloEncabezado(numeroOrden, idProveedor, idBodega,
                                     fecha, fechaEntrega, tipoPago,
                                     diasCredito, subtotal, total);
        }


    }
}
