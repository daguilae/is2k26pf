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
        // Registrar pago completo
        public bool RegistrarPago(
            int idCuentaPorCobrar,
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

                // Obtener ID de tipo de operación (suponiendo que es "Pago")
                int idTipoOperacion = cxcDetalleDAO.ObtenerIdTipoOperacion("Pago");

                if (idTipoOperacion == 0)
                {
                    // Si no existe, intentar con otro nombre
                    idTipoOperacion = cxcDetalleDAO.ObtenerIdTipoOperacion("Abono");

                    if (idTipoOperacion == 0)
                    {
                        MessageBox.Show("No se encontró el tipo de operación.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // Crear objeto Cls_CXC_Detalle
                Cls_CXC_Detalle detalle = new Cls_CXC_Detalle(
                    iPk_Id_Cuenta_Por_Cobrar_Detalle: 0,  // Auto-incremento
                    iFk_Id_Cuenta_Por_Cobrar: idCuentaPorCobrar,
                    iFk_Id_Tipo_Operacion: idTipoOperacion,
                    sCmp_No_Documento: numeroDocumento ?? "",
                    dCmp_Fecha_Pago: DateTime.Now,
                    sCmp_Tipo_Pago: tipoPago,
                    fCmp_Monto_Pagado: (float)montoPagado,
                    fCmp_Saldo_Pendiente: (float)saldoPendiente
                );

                // Guardar detalle de pago
                bool resultado = cxcDetalleDAO.GuardarDetallePago(detalle);

                if (!resultado)
                {
                    MessageBox.Show("Error al guardar el detalle de pago.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Actualizar saldo pendiente en CXC
                resultado = cxcDetalleDAO.ActualizarSaldoPendiente(idCuentaPorCobrar, saldoPendiente);

                if (!resultado)
                {
                    MessageBox.Show("Error al actualizar el saldo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Si saldo es 0 o menor, cambiar estado a "Inactivo" (pagado)
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

    
        public bool RegistrarPagoParcial(
            int idCuentaPorCobrar,
            string numeroDocumento,
            string tipoPago,
            decimal montoPagado,
            decimal montoTotal)
        {
            decimal saldoPendiente = montoTotal - montoPagado;
            return RegistrarPago(idCuentaPorCobrar, numeroDocumento, tipoPago, montoPagado, saldoPendiente);
        }

      
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
    }
}

