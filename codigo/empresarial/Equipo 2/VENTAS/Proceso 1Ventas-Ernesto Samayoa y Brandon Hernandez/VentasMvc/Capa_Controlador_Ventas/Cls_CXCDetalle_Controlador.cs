using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Modelo_Ventas;

namespace Capa_Controlador_Ventas
{
    public class Cls_CXCDetalle_Controlador
    {
        private Cls_CXCDetalle_dao cxcDetalleDAO = new Cls_CXCDetalle_dao();

        // ✅ Registrar pago completo CON CLIENTE
        public bool RegistrarPago(
            int idCuentaPorCobrar,
            int idCliente,
            string numeroDocumento,
            string tipoPago,
            decimal montoPagado,
            decimal saldoPendiente)
        {
            try
            {
                // Validar parámetros
                if (idCuentaPorCobrar <= 0)
                {
                    MessageBox.Show("ID de CXC inválido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (idCliente <= 0)
                {
                    MessageBox.Show("ID de Cliente inválido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (montoPagado <= 0)
                {
                    MessageBox.Show("El monto debe ser mayor a cero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(tipoPago))
                {
                    MessageBox.Show("El tipo de pago es requerido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // ✅ REFERENCIA AL DAO 1 - Obtener tipo de operación
                int idTipoOperacion = cxcDetalleDAO.ObtenerIdTipoOperacion(tipoPago);

                if (idTipoOperacion == 0)
                {
                    MessageBox.Show($"No se encontró tipo de operación: '{tipoPago}'", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Crear objeto Cls_CXC_Detalle
                Cls_CXC_Detalle detalle = new Cls_CXC_Detalle(
                    iPk_Id_Cuenta_Por_Cobrar_Detalle: 0,
                    iFk_Id_Cuenta_Por_Cobrar: idCuentaPorCobrar,
                    iFk_Id_Tipo_Operacion: idTipoOperacion,
                    sCmp_No_Documento: numeroDocumento ?? "",
                    dCmp_Fecha_Pago: DateTime.Now,
                    sCmp_Tipo_Pago: tipoPago,
                    fCmp_Monto_Pagado: (float)montoPagado,
                    fCmp_Saldo_Pendiente: (float)saldoPendiente
                );

                //  REFERENCIA AL DAO 2 - Guardar detalle de pago
                bool resultado = cxcDetalleDAO.GuardarDetallePago(detalle);

                if (!resultado)
                {
                    MessageBox.Show("Error al guardar el detalle de pago.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // REFERENCIA AL DAO 3 - Actualizar saldo del cliente
                resultado = cxcDetalleDAO.ActualizarSaldoCliente(idCliente, montoPagado);

                if (!resultado)
                {
                    MessageBox.Show("Error al actualizar el saldo del cliente.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

          

                //  REFERENCIA AL DAO 5 - Si saldo es 0 o menor, cambiar estado a "Inactivo"
                if (saldoPendiente <= 0)
                {
                    cxcDetalleDAO.ActualizarEstadoCXC(idCuentaPorCobrar, "Inactivo");
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en RegistrarPago: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Registrar pago parcial CON CLIENTE
        public bool RegistrarPagoParcial(
            int idCuentaPorCobrar,
            int idCliente,
            string numeroDocumento,
            string tipoPago,
            decimal montoPagado,
            decimal montoTotal)
        {
            decimal saldoPendiente = montoTotal - montoPagado;
            return RegistrarPago(idCuentaPorCobrar, idCliente, numeroDocumento, tipoPago, montoPagado, saldoPendiente);
        }

        // ✅ Cambiar estado CXC
        public bool CambiarEstadoCXC(int idCuentaPorCobrar, string nuevoEstado)
        {
            try
            {
                if (idCuentaPorCobrar <= 0)
                {
                    MessageBox.Show("ID de CXC inválido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool resultado = cxcDetalleDAO.ActualizarEstadoCXC(idCuentaPorCobrar, nuevoEstado);

                if (!resultado)
                {
                    MessageBox.Show("Error al cambiar el estado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Obtener ID cliente por CXC
        public int ObtenerIdClientePorCXC(int idCuentaPorCobrar)
        {
            try
            {
                if (idCuentaPorCobrar <= 0)
                {
                    MessageBox.Show("ID de CXC inválido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }

                int idCliente = cxcDetalleDAO.ObtenerIdClientePorCXC(idCuentaPorCobrar);

                if (idCliente == 0)
                {
                    MessageBox.Show("No se encontró cliente para esta CXC.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return idCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        // Generar ID de Recibo con nomenclatura personalizada
        public string GenerarIdRecibo()
        {
            try
            {
                // Formato: RCP-YYYYMMDD-XXXXXX
                // Ejemplo: RCP-20260508-A7F2K9

                string fecha = DateTime.Now.ToString("yyyyMMdd");
                string codigoAleatorio = GenerarCodigoAleatorio(6);

                string idRecibo = $"RCP-{fecha}-{codigoAleatorio}";

                Console.WriteLine($"✓ ID Recibo generado: {idRecibo}");
                return idRecibo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al generar ID Recibo: {ex.Message}");
                throw;
            }
        }

        //  Generar código aleatorio 
        private string GenerarCodigoAleatorio(int longitud)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int indice = random.Next(caracteres.Length);
                resultado.Append(caracteres[indice]);
            }

            return resultado.ToString();
        }
    }
}