using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Compras;

namespace Capa_Controlador_Compras
{
    public class Cls_Compras_Controlador
    {
        private readonly Cls_Compras_Sentencias snc = new Cls_Compras_Sentencias();

        public class OperationResult
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public CompraDTO Compra { get; set; }
        }

        public class CompraDTO
        {
            public int Pk_Id_Factura { get; set; }
            public string Cmp_Numero_Factura { get; set; }
            public DateTime Cmp_Fecha_Factura { get; set; }
            public int Fk_Id_Proveedor { get; set; }
            public int Cmp_Id_Orden_Compra { get; set; }
            public float Cmp_Total_Compra { get; set; }
            public float Cmp_Adelanto { get; set; }
            public float Cmp_Saldo_Pendiente { get; set; }
            public string Cmp_Estado_Pago { get; set; }
        }

        public string[] ItemsProveedores()
        {
            return snc.fun_LlenarComboProveedores();
        }

        public DataTable ObtenerCompras()
        {
            return snc.Fun_ObtenerCompras();
        }

        public DataRow BuscarCompra(int iPk_Id_Factura)
        {
            return snc.BuscarCompraPorId(iPk_Id_Factura);
        }

        public float CalcularSaldo(float fTotal, float fAdelanto)
        {
            float saldo = fTotal - fAdelanto;
            return saldo < 0 ? 0 : saldo;
        }

        public string ObtenerEstado(float fTotal, float fAdelanto)
        {
            float saldo = fTotal - fAdelanto;

            if (saldo <= 0)
                return "pagado";

            if (fAdelanto > 0 && saldo > 0)
                return "parcial";

            return "pendiente";
        }

        public OperationResult GuardarCompra(
            string numeroFactura,
            DateTime fechaFactura,
            string proveedorSeleccionado,
            string ordenCompraText,
            string totalText,
            string adelantoText)
        {
            if (string.IsNullOrWhiteSpace(numeroFactura))
                return new OperationResult { Success = false, Message = "Debe ingresar el número de factura." };

            if (string.IsNullOrWhiteSpace(proveedorSeleccionado))
                return new OperationResult { Success = false, Message = "Debe seleccionar un proveedor." };

            if (!float.TryParse(totalText, out float total) || total <= 0)
                return new OperationResult { Success = false, Message = "El total de la compra debe ser un número mayor a 0." };

            if (!float.TryParse(adelantoText, out float adelanto))
                adelanto = 0;

            if (adelanto > total)
                return new OperationResult { Success = false, Message = "El adelanto no puede ser mayor al total." };

            string[] partesProveedor = proveedorSeleccionado.Split('-');
            if (partesProveedor.Length == 0 || !int.TryParse(partesProveedor[0].Trim(), out int idProveedor))
                return new OperationResult { Success = false, Message = "Proveedor inválido." };

            int idOrdenCompra = 0;
            if (!string.IsNullOrWhiteSpace(ordenCompraText))
            {
                if (!int.TryParse(ordenCompraText, out idOrdenCompra))
                    return new OperationResult { Success = false, Message = "El Id de orden de compra debe ser numérico." };
            }

            Cls_Compras compra = new Cls_Compras
            {
                Cmp_Numero_Factura = numeroFactura.Trim(),
                Cmp_Fecha_Factura = fechaFactura,
                Fk_Id_Proveedor = idProveedor,
                Cmp_Id_Orden_Compra = idOrdenCompra,
                Cmp_Total_Compra = total,
                Cmp_Adelanto = adelanto,
                Cmp_Saldo_Pendiente = CalcularSaldo(total, adelanto),
                Cmp_Estado_Pago = ObtenerEstado(total, adelanto)
            };

            int filas = snc.InsertarCompra(compra);
            bool ok = filas > 0;

            if (ok)
                return new OperationResult { Success = true, Message = "Compra guardada correctamente." };

            return new OperationResult { Success = false, Message = "Error al guardar la compra." };
        }
    }
}