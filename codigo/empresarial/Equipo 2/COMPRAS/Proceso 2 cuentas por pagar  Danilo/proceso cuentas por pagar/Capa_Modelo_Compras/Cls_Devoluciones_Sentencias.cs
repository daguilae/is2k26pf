using Capa_Modelo_CXP;
using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Compras
{
    public class Cls_Devoluciones_Sentencias
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable Fun_MostrarComprasParaDevolucion()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT 
                        c.pk_id_compra AS IdCompra,
                        c.cmp_numero_factura AS NumeroFactura,
                        p.cmp_Nombre_Proveedor AS Proveedor,
                        c.cmp_fecha AS FechaCompra,
                        c.cmp_total AS TotalCompra,
                        c.cmp_estado AS EstadoCompra,
                        IFNULL(SUM(dd.cmp_subtotal), 0) AS TotalDevuelto
                    FROM tbl_compra c
                    INNER JOIN tbl_proveedores p 
                        ON c.fk_id_proveedor = p.pk_id_proveedor
                    LEFT JOIN tbl_devoluciones d
                        ON d.fk_id_compra = c.pk_id_compra
                        AND d.cmp_estado <> 'anulada'
                    LEFT JOIN tbl_devoluciones_detalle dd
                        ON dd.fk_id_devolucion = d.pk_id_devolucion
                    GROUP BY
                        c.pk_id_compra,
                        c.cmp_numero_factura,
                        p.cmp_Nombre_Proveedor,
                        c.cmp_fecha,
                        c.cmp_total,
                        c.cmp_estado
                    ORDER BY c.pk_id_compra DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_ObtenerIdsCompra()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT pk_id_compra 
                    FROM tbl_compra
                    ORDER BY pk_id_compra DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_ObtenerFacturas()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT cmp_numero_factura
                    FROM tbl_compra
                    ORDER BY cmp_numero_factura";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_ObtenerProveedores()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT 
                        pk_id_proveedor,
                        cmp_Nombre_Proveedor
                    FROM tbl_proveedores
                    ORDER BY cmp_Nombre_Proveedor";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_BuscarCompraPorId(int idCompra)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT 
                        c.pk_id_compra AS IdCompra,
                        c.cmp_numero_factura AS NumeroFactura,
                        c.cmp_fecha AS FechaCompra,
                        c.fk_id_proveedor AS IdProveedor,
                        p.cmp_Nombre_Proveedor AS Proveedor,
                        c.cmp_total AS TotalCompra,
                        c.cmp_estado AS EstadoCompra,
                        cxp.pk_id_cuenta_por_pagar AS IdCuentaPorPagar,
                        cxp.cmp_estado AS EstadoCXP
                    FROM tbl_compra c
                    INNER JOIN tbl_proveedores p 
                        ON c.fk_id_proveedor = p.pk_id_proveedor
                    LEFT JOIN tbl_cuentas_por_pagar cxp
                        ON c.pk_id_compra = cxp.fk_id_compra
                    WHERE c.pk_id_compra = ?";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_ObtenerDetalleCompra(int idCompra)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT 
                        dc.pk_id_detalle_compra AS IdDetalleCompra,
                        dc.fk_id_compra AS IdCompra,
                        dc.fk_inventario_id AS IdInventario,
                        i.nombre_prod AS Producto,
                        dc.cmp_cantidad AS CantidadComprada,
                        IFNULL(SUM(dd.cmp_cantidad_devuelta), 0) AS CantidadDevuelta,
                        dc.cmp_cantidad - IFNULL(SUM(dd.cmp_cantidad_devuelta), 0) AS CantidadDisponible,
                        um.Nombre_Unidad AS Unidad,
                        dc.cmp_precio AS PrecioUnitario,
                        dc.cmp_cantidad * dc.cmp_precio AS SubtotalCompra,
                        (dc.cmp_cantidad - IFNULL(SUM(dd.cmp_cantidad_devuelta), 0)) * dc.cmp_precio AS SubtotalDisponible
                    FROM tbl_detalle_compra dc
                    INNER JOIN tbl_inventario i
                        ON dc.fk_inventario_id = i.pk_inventario_id
                    INNER JOIN tbl_unidad_de_medida um
                        ON dc.fk_id_unidad = um.ID_Unidad
                    LEFT JOIN tbl_devoluciones_detalle dd
                        ON dd.fk_id_detalle_compra = dc.pk_id_detalle_compra
                    LEFT JOIN tbl_devoluciones d
                        ON d.pk_id_devolucion = dd.fk_id_devolucion
                        AND d.cmp_estado <> 'anulada'
                    WHERE dc.fk_id_compra = ?
                    GROUP BY 
                        dc.pk_id_detalle_compra,
                        dc.fk_id_compra,
                        dc.fk_inventario_id,
                        i.nombre_prod,
                        dc.cmp_cantidad,
                        um.Nombre_Unidad,
                        dc.cmp_precio
                    ORDER BY dc.pk_id_detalle_compra ASC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_MostrarDevoluciones()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT
                        d.pk_id_devolucion AS IdDevolucion,
                        d.fk_id_compra AS IdCompra,
                        c.cmp_numero_factura AS NumeroFactura,
                        p.cmp_Nombre_Proveedor AS Proveedor,
                        d.cmp_fecha_devolucion AS FechaDevolucion,
                        d.cmp_motivo AS Motivo,
                        d.cmp_tipo_devolucion AS TipoDevolucion,
                        d.cmp_valor_monetario AS ValorMonetario,
                        d.cmp_estado AS Estado,
                        d.cmp_observaciones AS Observaciones
                    FROM tbl_devoluciones d
                    INNER JOIN tbl_compra c
                        ON d.fk_id_compra = c.pk_id_compra
                    INNER JOIN tbl_proveedores p
                        ON d.fk_id_proveedor = p.pk_id_proveedor
                    ORDER BY d.pk_id_devolucion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public int Fun_RegistrarDevolucionParcial(
            int idCompra,
            int idProveedor,
            int? idCuentaPorPagar,
            int idDetalleCompra,
            int idInventario,
            decimal cantidadDevuelta,
            decimal precioUnitario,
            decimal valorMonetario,
            string motivo,
            string tipoDevolucion,
            DateTime fechaDevolucion,
            string observacion)
        {
            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                conn.Open();

                using (OdbcTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        decimal cantidadComprada = 0;
                        decimal cantidadYaDevuelta = 0;

                        string sqlValidar = @"
                            SELECT 
                                dc.cmp_cantidad,
                                IFNULL(SUM(dd.cmp_cantidad_devuelta), 0) AS CantidadDevuelta
                            FROM tbl_detalle_compra dc
                            LEFT JOIN tbl_devoluciones_detalle dd
                                ON dd.fk_id_detalle_compra = dc.pk_id_detalle_compra
                            LEFT JOIN tbl_devoluciones d
                                ON d.pk_id_devolucion = dd.fk_id_devolucion
                                AND d.cmp_estado <> 'anulada'
                            WHERE dc.pk_id_detalle_compra = ?
                            GROUP BY dc.cmp_cantidad";

                        using (OdbcCommand cmd = new OdbcCommand(sqlValidar, conn, trans))
                        {
                            cmd.Parameters.Add("idDetalleCompra", OdbcType.Int).Value = idDetalleCompra;

                            using (OdbcDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    cantidadComprada = Convert.ToDecimal(dr["cmp_cantidad"]);
                                    cantidadYaDevuelta = Convert.ToDecimal(dr["CantidadDevuelta"]);
                                }
                                else
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                            }
                        }

                        decimal cantidadDisponible = cantidadComprada - cantidadYaDevuelta;

                        if (cantidadDevuelta <= 0 || cantidadDevuelta > cantidadDisponible)
                        {
                            trans.Rollback();
                            return 0;
                        }

                        int idDevolucion = 0;

                        string sqlDevolucion = @"
                            INSERT INTO tbl_devoluciones
                            (
                                fk_id_compra,
                                fk_id_proveedor,
                                fk_id_cuenta_por_pagar,
                                cmp_fecha_devolucion,
                                cmp_motivo,
                                cmp_tipo_devolucion,
                                cmp_valor_monetario,
                                cmp_estado,
                                cmp_observaciones
                            )
                            VALUES (?, ?, ?, ?, ?, ?, ?, 'aplicada', ?)";

                        using (OdbcCommand cmd = new OdbcCommand(sqlDevolucion, conn, trans))
                        {
                            cmd.Parameters.Add("fk_id_compra", OdbcType.Int).Value = idCompra;
                            cmd.Parameters.Add("fk_id_proveedor", OdbcType.Int).Value = idProveedor;

                            if (idCuentaPorPagar.HasValue)
                                cmd.Parameters.Add("fk_id_cuenta_por_pagar", OdbcType.Int).Value = idCuentaPorPagar.Value;
                            else
                                cmd.Parameters.Add("fk_id_cuenta_por_pagar", OdbcType.Int).Value = DBNull.Value;

                            cmd.Parameters.Add("cmp_fecha_devolucion", OdbcType.DateTime).Value = fechaDevolucion;
                            cmd.Parameters.Add("cmp_motivo", OdbcType.VarChar).Value = motivo;
                            cmd.Parameters.Add("cmp_tipo_devolucion", OdbcType.VarChar).Value = tipoDevolucion;
                            cmd.Parameters.Add("cmp_valor_monetario", OdbcType.Double).Value = Convert.ToDouble(valorMonetario);
                            cmd.Parameters.Add("cmp_observaciones", OdbcType.VarChar).Value = observacion ?? "";

                            cmd.ExecuteNonQuery();
                        }

                        using (OdbcCommand cmd = new OdbcCommand("SELECT LAST_INSERT_ID()", conn, trans))
                        {
                            idDevolucion = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string sqlDetalle = @"
                            INSERT INTO tbl_devoluciones_detalle
                            (
                                fk_id_devolucion,
                                fk_id_detalle_compra,
                                fk_inventario_id,
                                cmp_cantidad_devuelta,
                                cmp_precio_unitario,
                                cmp_subtotal,
                                cmp_observacion
                            )
                            VALUES (?, ?, ?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(sqlDetalle, conn, trans))
                        {
                            cmd.Parameters.Add("fk_id_devolucion", OdbcType.Int).Value = idDevolucion;
                            cmd.Parameters.Add("fk_id_detalle_compra", OdbcType.Int).Value = idDetalleCompra;
                            cmd.Parameters.Add("fk_inventario_id", OdbcType.Int).Value = idInventario;
                            cmd.Parameters.Add("cmp_cantidad_devuelta", OdbcType.Double).Value = Convert.ToDouble(cantidadDevuelta);
                            cmd.Parameters.Add("cmp_precio_unitario", OdbcType.Double).Value = Convert.ToDouble(precioUnitario);
                            cmd.Parameters.Add("cmp_subtotal", OdbcType.Double).Value = Convert.ToDouble(valorMonetario);
                            cmd.Parameters.Add("cmp_observacion", OdbcType.VarChar).Value = observacion ?? "";
                            cmd.ExecuteNonQuery();
                        }

                        decimal totalComprado = 0;
                        decimal totalDevuelto = 0;

                        string sqlTotales = @"
                            SELECT 
                                IFNULL(SUM(dc.cmp_cantidad), 0) AS TotalComprado,
                                IFNULL(SUM(dev.TotalDevuelto), 0) AS TotalDevuelto
                            FROM tbl_detalle_compra dc
                            LEFT JOIN
                            (
                                SELECT 
                                    dd.fk_id_detalle_compra,
                                    SUM(dd.cmp_cantidad_devuelta) AS TotalDevuelto
                                FROM tbl_devoluciones_detalle dd
                                INNER JOIN tbl_devoluciones d
                                    ON d.pk_id_devolucion = dd.fk_id_devolucion
                                WHERE d.cmp_estado <> 'anulada'
                                GROUP BY dd.fk_id_detalle_compra
                            ) dev
                                ON dev.fk_id_detalle_compra = dc.pk_id_detalle_compra
                            WHERE dc.fk_id_compra = ?";

                        using (OdbcCommand cmd = new OdbcCommand(sqlTotales, conn, trans))
                        {
                            cmd.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;

                            using (OdbcDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    totalComprado = Convert.ToDecimal(dr["TotalComprado"]);
                                    totalDevuelto = Convert.ToDecimal(dr["TotalDevuelto"]);
                                }
                            }
                        }

                        if (totalComprado > 0 && totalDevuelto >= totalComprado)
                        {
                            string sqlUpdateCompra = @"
                                UPDATE tbl_compra
                                SET cmp_estado = 'devuelto'
                                WHERE pk_id_compra = ?";

                            using (OdbcCommand cmd = new OdbcCommand(sqlUpdateCompra, conn, trans))
                            {
                                cmd.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;
                                cmd.ExecuteNonQuery();
                            }

                            string sqlUpdateCxp = @"
                                UPDATE tbl_cuentas_por_pagar
                                SET cmp_estado = 'devuelto'
                                WHERE fk_id_compra = ?";

                            using (OdbcCommand cmd = new OdbcCommand(sqlUpdateCxp, conn, trans))
                            {
                                cmd.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;
                                cmd.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        return 1;
                    }
                    catch
                    {
                        trans.Rollback();
                        return 0;
                    }
                }
            }
        }
    }
}