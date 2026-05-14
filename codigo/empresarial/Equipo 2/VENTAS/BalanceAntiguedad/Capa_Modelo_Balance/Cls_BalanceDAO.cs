using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Ventas;
namespace Capa_Modelo_Balance
{
    public class Cls_BalanceDAO
    {
        private Cls_ConexionBD conexion = new Cls_ConexionBD();
        private const string SQL_ANTIGUEDAD_SALDOS = @"
             SELECT
    cxc.Pk_Id_Cuenta_Por_Cobrar,
    cxc.Fk_Id_Venta AS NoVenta,
    cxc.FK_Id_Cliente,
    CONCAT(cli.Cmp_Nombre, ' ', cli.Cmp_Apellido) AS Cliente,
    cxc.Cmp_Fecha_De_Deuda AS Cmp_Fecha_Deuda,
    cxc.Cmp_Fecha_Vencimiento,
    cxc.Cmp_Monto_Total,

    IFNULL(SUM(det.Cmp_Monto_Pagado), 0) AS MontoPagado,
    (cxc.Cmp_Monto_Total - IFNULL(SUM(det.Cmp_Monto_Pagado), 0)) AS SaldoPendiente,

  GREATEST(DATEDIFF(CURDATE(), DATE(cxc.Cmp_Fecha_Vencimiento)), 0) AS DiasVencidos
FROM tbl_cuentas_por_cobrar cxc
INNER JOIN tbl_clientes cli
    ON cxc.FK_Id_Cliente = cli.Pk_Id_Cliente
LEFT JOIN tbl_cuentas_por_cobrar_detalle det
    ON cxc.Pk_Id_Cuenta_Por_Cobrar = det.Fk_Id_Cuenta_Por_Cobrar
WHERE cxc.Cmp_Estado = 'Activo'
  AND DATE(cxc.Cmp_Fecha_De_Deuda) BETWEEN ? AND ?
GROUP BY
    cxc.Pk_Id_Cuenta_Por_Cobrar,
    cxc.Fk_Id_Venta,
    cxc.FK_Id_Cliente,
    cli.Cmp_Nombre,
    cli.Cmp_Apellido,
    cxc.Cmp_Fecha_De_Deuda,
    cxc.Cmp_Fecha_Vencimiento,
    cxc.Cmp_Monto_Total
HAVING SaldoPendiente > 0
ORDER BY Cliente, cxc.Cmp_Fecha_Vencimiento;
        ";

        public DataTable ObtenerAntiguedadSaldos(DateTime fechaInicio, DateTime fechaFin)
        {
            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(SQL_ANTIGUEDAD_SALDOS, conn))
            {
                cmd.Parameters.AddWithValue("?", fechaInicio.Date);
                cmd.Parameters.AddWithValue("?", fechaFin.Date);

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable("AntiguedadSaldos"); // <-- IMPORTANTE
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
