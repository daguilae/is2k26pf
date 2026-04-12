using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Modelo_Compras
{
    public class Cls_Compras_Sentencias
    {
        Cls_Conexion conexion = new Cls_Conexion();

        public string[] fun_LlenarComboProveedores()
        {
            List<string> lista = new List<string>();
            string sql = "SELECT pk_id_proveedor, cmp_nombre_proveedor FROM tbl_proveedores WHERE cmp_estado = 'activo'";

            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                    }
                }
                conexion.desconexion(conn);
            }

            return lista.ToArray();
        }

        public DataTable Fun_ObtenerCompras()
        {
            string sql = @"
                SELECT 
                    f.pk_id_factura AS IdFactura,
                    f.cmp_numero_factura AS NumeroFactura,
                    f.cmp_fecha_factura AS FechaFactura,
                    p.cmp_nombre_proveedor AS Proveedor,
                    f.cmp_id_orden_compra AS IdOrdenCompra,
                    f.cmp_total AS TotalCompra,
                    IFNULL(cxp.cmp_estado, 'pagado') AS EstadoPago
                FROM tbl_factura f
                INNER JOIN tbl_proveedores p
                    ON f.fk_id_proveedor = p.pk_id_proveedor
                LEFT JOIN tbl_cuentas_por_pagar cxp
                    ON cxp.fk_id_factura = f.pk_id_factura
                ORDER BY f.pk_id_factura DESC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataRow BuscarCompraPorId(int iPk_Id_Factura)
        {
            string sql = @"SELECT * FROM tbl_factura WHERE pk_id_factura = ?";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.Add("pk_id_factura", OdbcType.Int).Value = iPk_Id_Factura;
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        public int InsertarCompra(Cls_Compras compra)
        {
            OdbcConnection conn = conexion.conexion();
            OdbcTransaction trans = conn.BeginTransaction();

            try
            {
                int idFactura = 0;
                int idCuentaPorPagar = 0;

                string sqlFactura = @"
                    INSERT INTO tbl_factura
                    (
                        cmp_numero_factura,
                        cmp_fecha_factura,
                        fk_id_proveedor,
                        cmp_id_orden_compra,
                        cmp_total
                    )
                    VALUES (?, ?, ?, ?, ?)";

                OdbcCommand cmdFactura = new OdbcCommand(sqlFactura, conn, trans);
                cmdFactura.Parameters.Add("cmp_numero_factura", OdbcType.VarChar, 50).Value = compra.Cmp_Numero_Factura;
                cmdFactura.Parameters.Add("cmp_fecha_factura", OdbcType.DateTime).Value = compra.Cmp_Fecha_Factura;
                cmdFactura.Parameters.Add("fk_id_proveedor", OdbcType.Int).Value = compra.Fk_Id_Proveedor;
                cmdFactura.Parameters.Add("cmp_id_orden_compra", OdbcType.Int).Value = compra.Cmp_Id_Orden_Compra;
                cmdFactura.Parameters.Add("cmp_total", OdbcType.Double).Value = compra.Cmp_Total_Compra;
                cmdFactura.ExecuteNonQuery();

                OdbcCommand cmdIdFactura = new OdbcCommand("SELECT LAST_INSERT_ID()", conn, trans);
                idFactura = Convert.ToInt32(cmdIdFactura.ExecuteScalar());

                if (compra.Cmp_Saldo_Pendiente > 0)
                {
                    string sqlCxp = @"
                        INSERT INTO tbl_cuentas_por_pagar
                        (
                            fk_id_factura,
                            cmp_fecha_deuda,
                            cmp_fecha_vencimiento,
                            cmp_monto_total,
                            cmp_estado
                        )
                        VALUES (?, ?, ?, ?, ?)";

                    OdbcCommand cmdCxp = new OdbcCommand(sqlCxp, conn, trans);
                    cmdCxp.Parameters.Add("fk_id_factura", OdbcType.Int).Value = idFactura;
                    cmdCxp.Parameters.Add("cmp_fecha_deuda", OdbcType.DateTime).Value = DateTime.Now;
                    cmdCxp.Parameters.Add("cmp_fecha_vencimiento", OdbcType.DateTime).Value = DateTime.Now.AddDays(30);
                    cmdCxp.Parameters.Add("cmp_monto_total", OdbcType.Double).Value = compra.Cmp_Total_Compra;
                    cmdCxp.Parameters.Add("cmp_estado", OdbcType.VarChar, 20).Value = compra.Cmp_Estado_Pago;
                    cmdCxp.ExecuteNonQuery();

                    OdbcCommand cmdIdCxp = new OdbcCommand("SELECT LAST_INSERT_ID()", conn, trans);
                    idCuentaPorPagar = Convert.ToInt32(cmdIdCxp.ExecuteScalar());

                    if (compra.Cmp_Adelanto > 0)
                    {
                        string sqlDetalle = @"
                            INSERT INTO tbl_cuentas_por_pagar_detalle
                            (
                                fk_id_cuenta_por_pagar,
                                cmp_tipo_operacion,
                                cmp_no_documento,
                                cmp_fecha,
                                cmp_monto_pagado,
                                cmp_saldo_pendiente
                            )
                            VALUES (?, ?, ?, ?, ?, ?)";

                        OdbcCommand cmdDetalle = new OdbcCommand(sqlDetalle, conn, trans);
                        cmdDetalle.Parameters.Add("fk_id_cuenta_por_pagar", OdbcType.Int).Value = idCuentaPorPagar;
                        cmdDetalle.Parameters.Add("cmp_tipo_operacion", OdbcType.VarChar, 20).Value = "abono";
                        cmdDetalle.Parameters.Add("cmp_no_documento", OdbcType.VarChar, 50).Value = compra.Cmp_Numero_Factura;
                        cmdDetalle.Parameters.Add("cmp_fecha", OdbcType.Date).Value = compra.Cmp_Fecha_Factura;
                        cmdDetalle.Parameters.Add("cmp_monto_pagado", OdbcType.Double).Value = compra.Cmp_Adelanto;
                        cmdDetalle.Parameters.Add("cmp_saldo_pendiente", OdbcType.Double).Value = compra.Cmp_Saldo_Pendiente;
                        cmdDetalle.ExecuteNonQuery();
                    }
                }

                trans.Commit();
                conexion.desconexion(conn);
                return 1;
            }
            catch
            {
                trans.Rollback();
                conexion.desconexion(conn);
                return 0;
            }
        }
    }
}