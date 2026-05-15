using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

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

                
                string validarQuery = "SELECT COUNT(*) FROM tbl_cuentas_por_cobrar WHERE Pk_Id_Cuenta_Por_Cobrar = ?";
                using (OdbcCommand cmdValidar = new OdbcCommand(validarQuery, conn))
                {
                    cmdValidar.Parameters.Add("idCxc", OdbcType.Int).Value = detalle.Fk_Id_Cuenta_Por_Cobrar;
                    object resultado = cmdValidar.ExecuteScalar();
                    int existe = Convert.ToInt32(resultado);

                    if (existe == 0)
                    {
                     
                        throw new Exception($"La Cuenta por Cobrar {detalle.Fk_Id_Cuenta_Por_Cobrar} no existe");
                    }
                    else
                    {
                      
                    }
                }

             
                string validarTipoQuery = "SELECT COUNT(*) FROM tbl_tipo_operacion_cxc WHERE pk_tipo_operacion_cxc_id = ?";
                using (OdbcCommand cmdValidarTipo = new OdbcCommand(validarTipoQuery, conn))
                {
                    cmdValidarTipo.Parameters.Add("idTipo", OdbcType.Int).Value = detalle.Fk_Id_Tipo_Operacion;
                    object resultadoTipo = cmdValidarTipo.ExecuteScalar();
                    int existeTipo = Convert.ToInt32(resultadoTipo);

                    if (existeTipo == 0)
                    {
                      
                        throw new Exception($"El tipo de operación {detalle.Fk_Id_Tipo_Operacion} no existe");
                    }
                    else
                    {
                       
                    }
                }

  
                string query = @"
            INSERT INTO tbl_cuentas_por_cobrar_detalle 
            (
                Fk_Id_Cuenta_Por_Cobrar,
                Fk_Id_Tipo_Operacion,
                Cmp_No_Documento,
                Cmp_Fecha_Pago,
                Cmp_Monto_Pagado,
                Cmp_Saldo_Pendiente
            )
            VALUES (?, ?, ?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
              
                    cmd.Parameters.Add("idCxc", OdbcType.Int).Value = detalle.Fk_Id_Cuenta_Por_Cobrar;
                    cmd.Parameters.Add("idTipo", OdbcType.Int).Value = detalle.Fk_Id_Tipo_Operacion;
                    cmd.Parameters.Add("documento", OdbcType.VarChar, 50).Value = detalle.Cmp_No_Documento ?? "";
                    cmd.Parameters.Add("fechaPago", OdbcType.Date).Value = detalle.Cmp_Fecha_Pago.Date;
                    
                    cmd.Parameters.Add("montoPagado", OdbcType.Real).Value = detalle.Cmp_Monto_Pagado;
                    cmd.Parameters.Add("saldoPendiente", OdbcType.Real).Value = detalle.Cmp_Saldo_Pendiente;

           

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("✓ GUARDADO EXITOSAMENTE");

                        return true;
                    }

                    Console.WriteLine("✗ NO SE GUARDÓ");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERROR: {ex.Message}");
                Console.WriteLine($"Stack: {ex.StackTrace}");
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
                    WHERE Cmp_Operacion = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@nombreTipo", OdbcType.VarChar).Value = nombreTipo;
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        if (int.TryParse(resultado.ToString(), out int idTipo))
                        {
                            Console.WriteLine($"✓ Encontré tipo operación '{nombreTipo}' con ID: {idTipo}");
                            return idTipo;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"✗ No encontré '{nombreTipo}' en la BD");
                        // Mostrar todos los disponibles
                       
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
    
        
        

        public int ObtenerIdClientePorCXC(int idCuentaPorCobrar)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                string query = @"
            SELECT FK_Id_Cliente 
            FROM tbl_cuentas_por_cobrar 
            WHERE Pk_Id_Cuenta_Por_Cobrar = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("idCxc", OdbcType.Int).Value = idCuentaPorCobrar;
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && int.TryParse(resultado.ToString(), out int idCliente))
                    {
                        Console.WriteLine($"✓ Cliente encontrado: {idCliente} para CXC: {idCuentaPorCobrar}");
                        return idCliente;
                    }
                    else
                    {
                        Console.WriteLine($"❌ No se encontró cliente para CXC: {idCuentaPorCobrar}");
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERROR en ObtenerIdClientePorCXC: {ex.Message}");
                throw;
            }
            finally
            {
                if (conn != null)
                    conexionBD.desconexion(conn);
            }
        }

        // Actualizar saldo del cliente
        public bool ActualizarSaldoCliente(int idCliente, decimal montoPagado)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                // RESTAR del saldo total del cliente
                string query = @"
            UPDATE tbl_clientes 
            SET Cmp_Saldo_Total = Cmp_Saldo_Total - ?
            WHERE Pk_Id_Cliente = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("monto", OdbcType.Real).Value = montoPagado;
                    cmd.Parameters.Add("idCliente", OdbcType.Int).Value = idCliente;

                    Console.WriteLine($"=== ACTUALIZANDO SALDO CLIENTE ===");
                    Console.WriteLine($"Cliente: {idCliente}");
                    Console.WriteLine($"Resta: {montoPagado}");

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("✓ SALDO CLIENTE ACTUALIZADO");
                        return true;
                    }

                    Console.WriteLine("✗ NO SE ACTUALIZÓ SALDO CLIENTE");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERROR: {ex.Message}");
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
        public DataTable ListarCxcActivasConSaldo()
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

            
                string query = @"
            SELECT
                cxc.Pk_Id_Cuenta_Por_Cobrar AS IdCxc,
                cxc.FK_Id_Cliente          AS IdCliente,
                CONCAT(cli.Cmp_Nombre, ' ', cli.Cmp_Apellido) AS Cliente,
                cxc.Cmp_Monto_Total        AS MontoTotal,
                COALESCE(
                    (
                        SELECT d.Cmp_Saldo_Pendiente
                        FROM tbl_cuentas_por_cobrar_detalle d
                        WHERE d.Fk_Id_Cuenta_Por_Cobrar = cxc.Pk_Id_Cuenta_Por_Cobrar
                        ORDER BY d.Pk_Id_Cuenta_Por_Cobrar_Detalle DESC
                        LIMIT 1
                    ),
                    cxc.Cmp_Monto_Total
                ) AS SaldoPendiente
            FROM tbl_cuentas_por_cobrar cxc
            INNER JOIN tbl_clientes cli ON cli.Pk_Id_Cliente = cxc.FK_Id_Cliente
            WHERE cxc.Cmp_Estado = 'Activo';";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            finally
            {
                if (conn != null)
                    conexionBD.desconexion(conn);
            }
        }
        public decimal ObtenerSaldoPendienteActual(int idCuentaPorCobrar)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                string query = @"
            SELECT COALESCE(
                (
                    SELECT d.Cmp_Saldo_Pendiente
                    FROM tbl_cuentas_por_cobrar_detalle d
                    WHERE d.Fk_Id_Cuenta_Por_Cobrar = cxc.Pk_Id_Cuenta_Por_Cobrar
                    ORDER BY d.Pk_Id_Cuenta_Por_Cobrar_Detalle DESC
                    LIMIT 1
                ),
                cxc.Cmp_Monto_Total
            ) AS SaldoPendiente
            FROM tbl_cuentas_por_cobrar cxc
            WHERE cxc.Pk_Id_Cuenta_Por_Cobrar = ?;";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("idCxc", OdbcType.Int).Value = idCuentaPorCobrar;

                    object r = cmd.ExecuteScalar();
                    if (r == null || r == DBNull.Value) return 0m;
                    return Convert.ToDecimal(r);
                }
            }
            finally
            {
                if (conn != null)
                    conexionBD.desconexion(conn);
            }
        }

    }
}
