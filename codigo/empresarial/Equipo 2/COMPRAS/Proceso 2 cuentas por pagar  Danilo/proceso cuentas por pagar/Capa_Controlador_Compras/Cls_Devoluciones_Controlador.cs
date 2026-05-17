using Capa_Modelo_Compras;
using System;
using System.Data;

namespace Capa_Controlador_Compras
{
    public class Cls_Devoluciones_Controlador
    {
        private readonly Cls_Devoluciones_Sentencias sentencias = new Cls_Devoluciones_Sentencias();

        public DataTable MostrarComprasParaDevolucion()
        {
            return sentencias.Fun_MostrarComprasParaDevolucion();
        }

        public DataTable MostrarDevoluciones()
        {
            return sentencias.Fun_MostrarDevoluciones();
        }

        public DataTable ObtenerIdsCompra()
        {
            return sentencias.Fun_ObtenerIdsCompra();
        }

        public DataTable ObtenerFacturas()
        {
            return sentencias.Fun_ObtenerFacturas();
        }

        public DataTable ObtenerProveedores()
        {
            return sentencias.Fun_ObtenerProveedores();
        }

        public DataTable BuscarCompraPorId(int idCompra)
        {
            return sentencias.Fun_BuscarCompraPorId(idCompra);
        }

        public DataTable ObtenerDetalleCompra(int idCompra)
        {
            return sentencias.Fun_ObtenerDetalleCompra(idCompra);
        }

        public string RegistrarDevolucionParcial(
            int idCompra,
            int idProveedor,
            int? idCuentaPorPagar,
            int idDetalleCompra,
            int idInventario,
            decimal cantidadDevuelta,
            decimal precioUnitario,
            string motivo,
            string tipoDevolucion,
            DateTime fechaDevolucion,
            string observacion)
        {
            if (idCompra <= 0)
                return "Debe seleccionar una compra.";

            if (idProveedor <= 0)
                return "Debe seleccionar un proveedor.";

            if (idDetalleCompra <= 0)
                return "Debe seleccionar un producto del detalle.";

            if (idInventario <= 0)
                return "Producto inválido.";

            if (cantidadDevuelta <= 0)
                return "La cantidad devuelta debe ser mayor a 0.";

            if (precioUnitario <= 0)
                return "El precio unitario es inválido.";

            if (string.IsNullOrWhiteSpace(motivo))
                return "Debe seleccionar o ingresar un motivo.";

            if (string.IsNullOrWhiteSpace(tipoDevolucion))
                return "Debe seleccionar el tipo de devolución.";

            decimal valorMonetario = cantidadDevuelta * precioUnitario;

            int filas = sentencias.Fun_RegistrarDevolucionParcial(
                idCompra,
                idProveedor,
                idCuentaPorPagar,
                idDetalleCompra,
                idInventario,
                cantidadDevuelta,
                precioUnitario,
                valorMonetario,
                motivo,
                tipoDevolucion,
                fechaDevolucion,
                observacion
            );

            return filas > 0 ? "Devolución registrada correctamente." : "Error al registrar la devolución.";
        }
    }
}