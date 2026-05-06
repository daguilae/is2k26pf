using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace Capa_Modelo_Ventas
{
    public class Cls_CXCDetalle_dao
    {
        public bool GuardarDetallePago(Cls_CXC_Detalle detalle)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                string query = @"
                    INSERT INTO tbl_cuentas_por_cobrar_detalle 
                    (
                        Fk_Id_Cuenta_Por_Cobrar,
                        Fk_Id_Tipo_Operacion,
                        Cmp_No_Documento,
                        Cmp_Fecha_Pago,
                        Cmp_Tipo_Pago,
                        Cmp_Monto_Pagado,
                        Cmp_Saldo_Pendiente
                    )
                    VALUES (?, ?, ?, ?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@idCxc", OdbcType.Int).Value = detalle.Fk_Id_Cuenta_Por_Cobrar;
                    cmd.Parameters.Add("@idTipo", OdbcType.Int).Value = detalle.Fk_Id_Tipo_Operacion;
                    cmd.Parameters.Add("@documento", OdbcType.VarChar).Value = detalle.Cmp_No_Documento ?? "";
                    cmd.Parameters.Add("@fechaPago", OdbcType.Date).Value = detalle.Cmp_Fecha_Pago;
                    cmd.Parameters.Add("@tipoPago", OdbcType.VarChar).Value = detalle.Cmp_Tipo_Pago;
                    cmd.Parameters.Add("@montoPagado", OdbcType.Decimal).Value = detalle.Cmp_Monto_Pagado;
                    cmd.Parameters.Add("@saldoPendiente", OdbcType.Decimal).Value = detalle.Cmp_Saldo_Pendiente;

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en GuardarDetallePago: " + ex.Message);
                throw;
            }
            finally
            {
                if (conn != null)
                    conexionBD.desconexion(conn);
            }

        }
        public int ObtenerIdTipoOperacion(string nombreTipo)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                string query = @"
                    SELECT pk_tipo_operacion_cxc_id 
                    FROM tbl_tipo_operacion_cxc 
                    WHERE nombre_tipo_operacion = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@nombreTipo", OdbcType.VarChar).Value = nombreTipo;
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && int.TryParse(resultado.ToString(), out int idTipo))
                    {
                        return idTipo;
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerIdTipoOperacion: " + ex.Message);
                throw;
            }
            finally
            {
                if (conn != null)
                    conexionBD.desconexion(conn);
            }
        }
        public bool ActualizarSaldoPendiente(int idCuentaPorCobrar, decimal nuevoSaldo)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                string query = @"
                    UPDATE tbl_cuentas_por_cobrar 
                    SET Cmp_Monto_Total = ?
                    WHERE Pk_Id_Cuenta_Por_Cobrar = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@nuevoSaldo", OdbcType.Decimal).Value = nuevoSaldo;
                    cmd.Parameters.Add("@idCxc", OdbcType.Int).Value = idCuentaPorCobrar;

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ActualizarSaldoPendiente: " + ex.Message);
                throw;
            }
            finally
            {
                if (conn != null)
                    conexionBD.desconexion(conn);
            }
        }
        
        public bool ActualizarEstadoCXC(int idCuentaPorCobrar, string nuevoEstado)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                string query = @"
                    UPDATE tbl_cuentas_por_cobrar 
                    SET Cmp_Estado = ?
                    WHERE Pk_Id_Cuenta_Por_Cobrar = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@estado", OdbcType.VarChar).Value = nuevoEstado;
                    cmd.Parameters.Add("@idCxc", OdbcType.Int).Value = idCuentaPorCobrar;

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ActualizarEstadoCXC: " + ex.Message);
                throw;
            }
            finally
            {
                if (conn != null)
                    conexionBD.desconexion(conn);
            }
        }

    }
}
