using System;
using System.Data;
using Capa_Modelo_CXP;

namespace Capa_Controlador_CXP
{
    public class Cls_Compras_Controlador
    {
        private readonly Cls_Compras_Sentencias snc = new Cls_Compras_Sentencias();

        public DataTable ObtenerTodasCuentas()
        {
            return snc.Fun_ObtenerTodasCuentas();
        }

        public DataTable ObtenerCuentasPendientes()
        {
            return snc.Fun_ObtenerCuentasPendientes();
        }

        public DataTable ObtenerProveedores()
        {
            return snc.Fun_ObtenerProveedores();
        }

        public DataTable ObtenerIdsComprasPendientes()
        {
            return snc.Fun_ObtenerIdsComprasPendientes();
        }

        public DataTable ObtenerNumerosFacturasPendientes()
        {
            return snc.Fun_ObtenerNumerosFacturasPendientes();
        }

        public DataTable BuscarCuentasFiltradas(string idCompra, string numeroFactura, string proveedor, DateTime? fecha)
        {
            return snc.Fun_BuscarCuentasFiltradas(idCompra, numeroFactura, proveedor, fecha);
        }

        public DataTable ObtenerDetalleCompra(int idCompra)
        {
            return snc.Fun_ObtenerDetalleCompra(idCompra);
        }

        public decimal CalcularSaldo(decimal saldoActual, decimal pago)
        {
            decimal saldo = saldoActual - pago;
            return saldo < 0 ? 0 : saldo;
        }

        public string ObtenerEstado(decimal saldoNuevo)
        {
            return saldoNuevo <= 0 ? "pagado" : "parcial";
        }

        public string RegistrarPagoDetalle(
            string idCompraText,
            string idDetalleCompraText,
            string saldoActualText,
            string montoPagoText,
            string noDocumento)
        {
            if (!int.TryParse(idCompraText, out int idCompra))
                return "Debe seleccionar una compra.";

            if (!int.TryParse(idDetalleCompraText, out int idDetalleCompra))
                return "Debe seleccionar un detalle de compra.";

            if (!decimal.TryParse(saldoActualText, out decimal saldoActual))
                return "Saldo pendiente inválido.";

            if (!decimal.TryParse(montoPagoText, out decimal montoPago) || montoPago <= 0)
                return "Debe ingresar un monto de pago mayor a 0.";

            if (montoPago > saldoActual)
                return "El pago no puede ser mayor al saldo pendiente.";

            if (string.IsNullOrWhiteSpace(noDocumento))
                noDocumento = "PAGO-DET-CXP-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            int filas = snc.RegistrarPagoDetalle(idCompra, idDetalleCompra, montoPago, noDocumento);

            if (filas > 0)
                return "Pago de detalle registrado correctamente.";

            return "Error al registrar el pago del detalle.";
        }

        public DataTable ObtenerBodegas()
        {
            return snc.Fun_ObtenerBodegas();
        }

        public DataTable ObtenerProductos()
        {
            return snc.Fun_ObtenerProductos();
        }

        public DataTable ObtenerUnidades()
        {
            return snc.Fun_ObtenerUnidades();
        }

        public string RegistrarCompraManual(
            int idProveedor,
            int idBodega,
            string serieFactura,
            string numeroFactura,
            DateTime fecha,
            string tipoCompra,
            int diasCredito,
            DateTime? fechaVencimiento,
            decimal subtotal,
            decimal total,
            DataTable detalles)
        {
            if (idProveedor <= 0)
                return "Debe seleccionar un proveedor.";

            if (idBodega <= 0)
                return "Debe seleccionar una bodega.";

            if (string.IsNullOrWhiteSpace(numeroFactura))
                return "Debe ingresar número de factura.";

            if (string.IsNullOrWhiteSpace(tipoCompra))
                return "Debe seleccionar tipo de compra.";

            if (detalles == null || detalles.Rows.Count == 0)
                return "Debe agregar al menos un detalle.";

            int filas = snc.RegistrarCompraManual(
                idProveedor,
                idBodega,
                serieFactura,
                numeroFactura,
                fecha,
                tipoCompra,
                diasCredito,
                fechaVencimiento,
                subtotal,
                total,
                detalles
            );

            return filas > 0 ? "Cuenta por pagar creada correctamente." : "Error al crear la cuenta por pagar.";
        }

        public DataTable ObtenerIdsComprasTodas()
        {
            return snc.Fun_ObtenerIdsComprasTodas();
        }

        public DataTable ObtenerNumerosFacturasTodas()
        {
            return snc.Fun_ObtenerNumerosFacturasTodas();
        }

        public DataTable BuscarDetallesCuentasFiltradas(string idCompra, string numeroFactura, string proveedor, DateTime? fecha)
        {
            return snc.Fun_BuscarDetallesCuentasFiltradas(idCompra, numeroFactura, proveedor, fecha);
        }

        public DataTable ObtenerDetallesCuentasPorPagar()
        {
            return snc.Fun_ObtenerDetallesCuentasPorPagar();
        }

        public string DeshacerUltimoPagoDetalle(string idCompraText)
        {
            if (!int.TryParse(idCompraText, out int idCompra))
                return "Debe seleccionar una compra.";

            int filas = snc.DeshacerUltimoPagoDetalle(idCompra);

            if (filas > 0)
                return "Último pago deshecho correctamente.";

            return "No hay pagos para deshacer.";
        }
    }
}