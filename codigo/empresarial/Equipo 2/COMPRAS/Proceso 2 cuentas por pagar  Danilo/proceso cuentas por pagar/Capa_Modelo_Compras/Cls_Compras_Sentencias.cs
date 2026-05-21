using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CXP
{
    public class Cls_Compras_Sentencias
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable Fun_ObtenerTodasCuentas()
        {
            string sql = @"
                SELECT 
                    cxp.pk_id_cuenta_por_pagar AS IdCuentaPorPagar,
                    c.pk_id_compra AS IdCompra,
                    c.cmp_numero_factura AS NumeroFactura,
                    c.cmp_fecha AS FechaFactura,
                    p.cmp_Nombre_Proveedor AS Proveedor,
                    IFNULL(c.fk_id_orden_compra, 0) AS IdOrdenCompra,
                    cxp.cmp_monto_total AS TotalCompra,
                    IFNULL(SUM(CASE 
                        WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                        THEN det.cmp_monto_pagado ELSE 0 END), 0) AS TotalPagado,
                    cxp.cmp_monto_total - IFNULL(SUM(CASE 
                        WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                        THEN det.cmp_monto_pagado ELSE 0 END), 0) AS SaldoPendiente,
                    cxp.cmp_estado AS Estado
                FROM tbl_cuentas_por_pagar cxp
                INNER JOIN tbl_compra c 
                    ON cxp.fk_id_compra = c.pk_id_compra
                INNER JOIN tbl_proveedores p 
                    ON c.fk_id_proveedor = p.pk_id_proveedor
                LEFT JOIN tbl_cuentas_por_pagar_detalle det 
                    ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
                GROUP BY 
                    cxp.pk_id_cuenta_por_pagar,
                    c.pk_id_compra,
                    c.cmp_numero_factura,
                    c.cmp_fecha,
                    p.cmp_Nombre_Proveedor,
                    c.fk_id_orden_compra,
                    cxp.cmp_monto_total,
                    cxp.cmp_estado
                ORDER BY c.pk_id_compra DESC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_ObtenerCuentasPendientes()
        {
            string sql = @"
                SELECT 
                    c.pk_id_compra AS IdCompra,
                    c.cmp_numero_factura AS NumeroFactura,
                    c.cmp_fecha AS FechaFactura,
                    p.cmp_Nombre_Proveedor AS Proveedor,
                    IFNULL(c.fk_id_orden_compra, 0) AS IdOrdenCompra,
                    cxp.cmp_monto_total AS TotalCompra,
                    IFNULL(SUM(CASE 
                        WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                        THEN det.cmp_monto_pagado ELSE 0 END), 0) AS TotalPagado,
                    cxp.cmp_monto_total - IFNULL(SUM(CASE 
                        WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                        THEN det.cmp_monto_pagado ELSE 0 END), 0) AS SaldoPendiente,
                    cxp.cmp_estado AS Estado
                FROM tbl_cuentas_por_pagar cxp
                INNER JOIN tbl_compra c 
                    ON cxp.fk_id_compra = c.pk_id_compra
                INNER JOIN tbl_proveedores p 
                    ON c.fk_id_proveedor = p.pk_id_proveedor
                LEFT JOIN tbl_cuentas_por_pagar_detalle det 
                    ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
                WHERE cxp.cmp_estado IN ('pendiente', 'parcial')
                GROUP BY 
                    c.pk_id_compra,
                    c.cmp_numero_factura,
                    c.cmp_fecha,
                    p.cmp_Nombre_Proveedor,
                    c.fk_id_orden_compra,
                    cxp.cmp_monto_total,
                    cxp.cmp_estado
                ORDER BY c.pk_id_compra DESC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_ObtenerProveedores()
        {
            string sql = @"
                SELECT 
                    pk_id_proveedor AS IdProveedor,
                    cmp_Nombre_Proveedor AS Proveedor
                FROM tbl_proveedores
                ORDER BY cmp_Nombre_Proveedor";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_ObtenerIdsComprasPendientes()
        {
            string sql = @"
                SELECT 
                    c.pk_id_compra AS IdCompra
                FROM tbl_cuentas_por_pagar cxp
                INNER JOIN tbl_compra c 
                    ON cxp.fk_id_compra = c.pk_id_compra
                WHERE cxp.cmp_estado IN ('pendiente', 'parcial')
                ORDER BY c.pk_id_compra DESC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_ObtenerNumerosFacturasPendientes()
        {
            string sql = @"
                SELECT 
                    c.cmp_numero_factura AS NumeroFactura
                FROM tbl_cuentas_por_pagar cxp
                INNER JOIN tbl_compra c 
                    ON cxp.fk_id_compra = c.pk_id_compra
                WHERE cxp.cmp_estado IN ('pendiente', 'parcial')
                ORDER BY c.cmp_numero_factura";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_BuscarCuentasFiltradas(string idCompra, string numeroFactura, string proveedor, DateTime? fecha)
        {
            string sql = @"
                SELECT 
                    c.pk_id_compra AS IdCompra,
                    c.cmp_numero_factura AS NumeroFactura,
                    c.cmp_fecha AS FechaFactura,
                    p.cmp_Nombre_Proveedor AS Proveedor,
                    IFNULL(c.fk_id_orden_compra, 0) AS IdOrdenCompra,
                    cxp.cmp_monto_total AS TotalCompra,
                    IFNULL(SUM(CASE 
                        WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                        THEN det.cmp_monto_pagado ELSE 0 END), 0) AS TotalPagado,
                    cxp.cmp_monto_total - IFNULL(SUM(CASE 
                        WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                        THEN det.cmp_monto_pagado ELSE 0 END), 0) AS SaldoPendiente,
                    cxp.cmp_estado AS Estado
                FROM tbl_cuentas_por_pagar cxp
                INNER JOIN tbl_compra c 
                    ON cxp.fk_id_compra = c.pk_id_compra
                INNER JOIN tbl_proveedores p 
                    ON c.fk_id_proveedor = p.pk_id_proveedor
                LEFT JOIN tbl_cuentas_por_pagar_detalle det 
                    ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
                WHERE 1 = 1";

            if (!string.IsNullOrWhiteSpace(idCompra))
                sql += " AND c.pk_id_compra = ?";

            if (!string.IsNullOrWhiteSpace(numeroFactura))
                sql += " AND c.cmp_numero_factura = ?";

            if (!string.IsNullOrWhiteSpace(proveedor))
                sql += " AND p.cmp_Nombre_Proveedor LIKE ?";

            if (fecha.HasValue)
                sql += " AND DATE(c.cmp_fecha) = ?";

            sql += @"
                GROUP BY 
                    c.pk_id_compra,
                    c.cmp_numero_factura,
                    c.cmp_fecha,
                    p.cmp_Nombre_Proveedor,
                    c.fk_id_orden_compra,
                    cxp.cmp_monto_total,
                    cxp.cmp_estado
                ORDER BY c.pk_id_compra DESC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);

                if (!string.IsNullOrWhiteSpace(idCompra))
                    cmd.Parameters.Add("idCompra", OdbcType.Int).Value = Convert.ToInt32(idCompra);

                if (!string.IsNullOrWhiteSpace(numeroFactura))
                    cmd.Parameters.Add("numeroFactura", OdbcType.VarChar).Value = numeroFactura;

                if (!string.IsNullOrWhiteSpace(proveedor))
                    cmd.Parameters.Add("proveedor", OdbcType.VarChar).Value = "%" + proveedor.Trim() + "%";

                if (fecha.HasValue)
                    cmd.Parameters.Add("fecha", OdbcType.Date).Value = fecha.Value.Date;

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_ObtenerDetalleCompra(int idCompra)
        {
            string sql = @"
                SELECT
                    dc.pk_id_detalle_compra AS IdDetalleCompra,
                    dc.fk_id_compra AS IdCompra,
                    i.nombre_prod AS Producto,
                    dc.cmp_cantidad AS Cantidad,
                    um.Nombre_Unidad AS Unidad,
                    dc.cmp_precio AS PrecioUnitario,
                    dc.cmp_cantidad * dc.cmp_precio AS TotalDetalle,
                    IFNULL(SUM(CASE 
                        WHEN cxpd.cmp_anulado = 0 OR cxpd.cmp_anulado IS NULL 
                        THEN cxpd.cmp_monto_pagado ELSE 0 END), 0) AS PagadoDetalle,
                    (dc.cmp_cantidad * dc.cmp_precio) - IFNULL(SUM(CASE 
                        WHEN cxpd.cmp_anulado = 0 OR cxpd.cmp_anulado IS NULL 
                        THEN cxpd.cmp_monto_pagado ELSE 0 END), 0) AS SaldoDetalle
                FROM tbl_detalle_compra dc
                INNER JOIN tbl_inventario i 
                    ON dc.fk_inventario_id = i.pk_inventario_id
                INNER JOIN tbl_unidad_de_medida um
                    ON dc.fk_id_unidad = um.ID_Unidad
                LEFT JOIN tbl_cuentas_por_pagar cxp
                    ON cxp.fk_id_compra = dc.fk_id_compra
                LEFT JOIN tbl_cuentas_por_pagar_detalle cxpd
                    ON cxpd.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
                    AND cxpd.fk_id_detalle_compra = dc.pk_id_detalle_compra
                WHERE dc.fk_id_compra = ?
                GROUP BY
                    dc.pk_id_detalle_compra,
                    dc.fk_id_compra,
                    i.nombre_prod,
                    dc.cmp_cantidad,
                    um.Nombre_Unidad,
                    dc.cmp_precio
                ORDER BY dc.pk_id_detalle_compra";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }


        public DataTable Fun_ObtenerDetallesCuentasPorPagar()
        {
            string sql = @"
        SELECT
            cxp.pk_id_cuenta_por_pagar AS IdCuentaPorPagar,
            c.pk_id_compra AS IdCompra,
            c.cmp_numero_factura AS NumeroFactura,
            c.cmp_fecha AS FechaFactura,
            p.cmp_Nombre_Proveedor AS Proveedor,
            dc.pk_id_detalle_compra AS IdDetalleCompra,
            i.nombre_prod AS Producto,
            dc.cmp_cantidad AS Cantidad,
            um.Nombre_Unidad AS Unidad,
            dc.cmp_precio AS PrecioUnitario,
            dc.cmp_cantidad * dc.cmp_precio AS TotalDetalle,
            IFNULL(SUM(CASE 
                WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                THEN det.cmp_monto_pagado ELSE 0 END), 0) AS PagadoDetalle,
            (dc.cmp_cantidad * dc.cmp_precio) - IFNULL(SUM(CASE 
                WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                THEN det.cmp_monto_pagado ELSE 0 END), 0) AS SaldoDetalle,
            cxp.cmp_estado AS EstadoCuenta
        FROM tbl_cuentas_por_pagar cxp
        INNER JOIN tbl_compra c 
            ON cxp.fk_id_compra = c.pk_id_compra
        INNER JOIN tbl_proveedores p 
            ON c.fk_id_proveedor = p.pk_id_proveedor
        INNER JOIN tbl_detalle_compra dc 
            ON dc.fk_id_compra = c.pk_id_compra
        INNER JOIN tbl_inventario i 
            ON dc.fk_inventario_id = i.pk_inventario_id
        INNER JOIN tbl_unidad_de_medida um
            ON dc.fk_id_unidad = um.ID_Unidad
        LEFT JOIN tbl_cuentas_por_pagar_detalle det 
            ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
            AND det.fk_id_detalle_compra = dc.pk_id_detalle_compra
        GROUP BY
            cxp.pk_id_cuenta_por_pagar,
            c.pk_id_compra,
            c.cmp_numero_factura,
            c.cmp_fecha,
            p.cmp_Nombre_Proveedor,
            dc.pk_id_detalle_compra,
            i.nombre_prod,
            dc.cmp_cantidad,
            um.Nombre_Unidad,
            dc.cmp_precio,
            cxp.cmp_estado
        ORDER BY c.pk_id_compra DESC, dc.pk_id_detalle_compra ASC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }
        public int RegistrarPagoDetalle(int idCompra, int idDetalleCompra, decimal montoPago, string noDocumento)
        {
            using (OdbcConnection conn = conexion.conexion())
            using (OdbcTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    int idCxp = 0;

                    string sqlBuscarCxp = @"
                        SELECT pk_id_cuenta_por_pagar
                        FROM tbl_cuentas_por_pagar
                        WHERE fk_id_compra = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlBuscarCxp, conn, trans))
                    {
                        cmd.Parameters.Add("fk_id_compra", OdbcType.Int).Value = idCompra;
                        object resultado = cmd.ExecuteScalar();

                        if (resultado == null)
                        {
                            trans.Rollback();
                            return 0;
                        }

                        idCxp = Convert.ToInt32(resultado);
                    }

                    decimal totalCuenta = 0;
                    decimal totalPagadoActual = 0;

                    string sqlSaldo = @"
                        SELECT 
                            cxp.cmp_monto_total,
                            IFNULL(SUM(CASE 
                                WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                                THEN det.cmp_monto_pagado ELSE 0 END), 0)
                        FROM tbl_cuentas_por_pagar cxp
                        LEFT JOIN tbl_cuentas_por_pagar_detalle det
                            ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
                        WHERE cxp.pk_id_cuenta_por_pagar = ?
                        GROUP BY cxp.cmp_monto_total";

                    using (OdbcCommand cmd = new OdbcCommand(sqlSaldo, conn, trans))
                    {
                        cmd.Parameters.Add("idCxp", OdbcType.Int).Value = idCxp;

                        using (OdbcDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                totalCuenta = Convert.ToDecimal(dr[0]);
                                totalPagadoActual = Convert.ToDecimal(dr[1]);
                            }
                        }
                    }



                    decimal saldoNuevo = totalCuenta - totalPagadoActual - montoPago;

                    if (saldoNuevo < 0)
                    {
                        trans.Rollback();
                        return 0;
                    }

                    string tipoOperacion = saldoNuevo <= 0 ? "pago_total" : "abono";
                    string estadoNuevo = saldoNuevo <= 0 ? "pagado" : "parcial";

                    string sqlDetalle = @"
                        INSERT INTO tbl_cuentas_por_pagar_detalle
                        (
                            fk_id_cuenta_por_pagar,
                            fk_id_detalle_compra,
                            cmp_tipo_operacion,
                            cmp_no_documento,
                            cmp_fecha,
                            cmp_monto_pagado,
                            cmp_saldo_pendiente,
                            cmp_anulado
                        )
                        VALUES (?, ?, ?, ?, ?, ?, ?, 0)";

                    using (OdbcCommand cmd = new OdbcCommand(sqlDetalle, conn, trans))
                    {
                        cmd.Parameters.Add("fk_id_cuenta_por_pagar", OdbcType.Int).Value = idCxp;
                        cmd.Parameters.Add("fk_id_detalle_compra", OdbcType.Int).Value = idDetalleCompra;
                        cmd.Parameters.Add("cmp_tipo_operacion", OdbcType.VarChar).Value = tipoOperacion;
                        cmd.Parameters.Add("cmp_no_documento", OdbcType.VarChar).Value = noDocumento;
                        cmd.Parameters.Add("cmp_fecha", OdbcType.Date).Value = DateTime.Now.Date;
                        cmd.Parameters.Add("cmp_monto_pagado", OdbcType.Double).Value = Convert.ToDouble(montoPago);
                        cmd.Parameters.Add("cmp_saldo_pendiente", OdbcType.Double).Value = Convert.ToDouble(saldoNuevo);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlActualizarCxp = @"
                        UPDATE tbl_cuentas_por_pagar
                        SET cmp_estado = ?
                        WHERE pk_id_cuenta_por_pagar = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlActualizarCxp, conn, trans))
                    {
                        cmd.Parameters.Add("estado", OdbcType.VarChar).Value = estadoNuevo;
                        cmd.Parameters.Add("idCxp", OdbcType.Int).Value = idCxp;
                        cmd.ExecuteNonQuery();
                    }

                    string sqlActualizarCompra = @"
                        UPDATE tbl_compra
                        SET cmp_estado = ?
                        WHERE pk_id_compra = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlActualizarCompra, conn, trans))
                    {
                        cmd.Parameters.Add("estado", OdbcType.VarChar).Value = estadoNuevo;
                        cmd.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;
                        cmd.ExecuteNonQuery();
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

        public DataTable Fun_ObtenerIdsComprasTodas()
        {
            string sql = @"
        SELECT c.pk_id_compra AS IdCompra
        FROM tbl_cuentas_por_pagar cxp
        INNER JOIN tbl_compra c ON cxp.fk_id_compra = c.pk_id_compra
        ORDER BY c.pk_id_compra DESC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_ObtenerNumerosFacturasTodas()
        {
            string sql = @"
        SELECT c.cmp_numero_factura AS NumeroFactura
        FROM tbl_cuentas_por_pagar cxp
        INNER JOIN tbl_compra c ON cxp.fk_id_compra = c.pk_id_compra
        ORDER BY c.cmp_numero_factura";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_BuscarDetallesCuentasFiltradas(string idCompra, string numeroFactura, string proveedor, DateTime? fecha)
        {
            string sql = @"
        SELECT
            cxp.pk_id_cuenta_por_pagar AS IdCuentaPorPagar,
            c.pk_id_compra AS IdCompra,
            c.cmp_numero_factura AS NumeroFactura,
            c.cmp_fecha AS FechaFactura,
            p.cmp_Nombre_Proveedor AS Proveedor,
            dc.pk_id_detalle_compra AS IdDetalleCompra,
            i.nombre_prod AS Producto,
            dc.cmp_cantidad AS Cantidad,
            um.Nombre_Unidad AS Unidad,
            dc.cmp_precio AS PrecioUnitario,
            dc.cmp_cantidad * dc.cmp_precio AS TotalDetalle,
            IFNULL(SUM(CASE 
                WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                THEN det.cmp_monto_pagado ELSE 0 END), 0) AS PagadoDetalle,
            (dc.cmp_cantidad * dc.cmp_precio) - IFNULL(SUM(CASE 
                WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                THEN det.cmp_monto_pagado ELSE 0 END), 0) AS SaldoDetalle,
            cxp.cmp_estado AS EstadoCuenta
        FROM tbl_cuentas_por_pagar cxp
        INNER JOIN tbl_compra c 
            ON cxp.fk_id_compra = c.pk_id_compra
        INNER JOIN tbl_proveedores p 
            ON c.fk_id_proveedor = p.pk_id_proveedor
        INNER JOIN tbl_detalle_compra dc 
            ON dc.fk_id_compra = c.pk_id_compra
        INNER JOIN tbl_inventario i 
            ON dc.fk_inventario_id = i.pk_inventario_id
        INNER JOIN tbl_unidad_de_medida um
            ON dc.fk_id_unidad = um.ID_Unidad
        LEFT JOIN tbl_cuentas_por_pagar_detalle det 
            ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
            AND det.fk_id_detalle_compra = dc.pk_id_detalle_compra
        WHERE 1 = 1";

            if (!string.IsNullOrWhiteSpace(idCompra))
                sql += " AND c.pk_id_compra = ?";

            if (!string.IsNullOrWhiteSpace(numeroFactura))
                sql += " AND c.cmp_numero_factura = ?";

            if (!string.IsNullOrWhiteSpace(proveedor))
                sql += " AND p.cmp_Nombre_Proveedor LIKE ?";

            if (fecha.HasValue)
                sql += " AND DATE(c.cmp_fecha) = ?";

            sql += @"
        GROUP BY
            cxp.pk_id_cuenta_por_pagar,
            c.pk_id_compra,
            c.cmp_numero_factura,
            c.cmp_fecha,
            p.cmp_Nombre_Proveedor,
            dc.pk_id_detalle_compra,
            i.nombre_prod,
            dc.cmp_cantidad,
            um.Nombre_Unidad,
            dc.cmp_precio,
            cxp.cmp_estado
        ORDER BY c.pk_id_compra DESC, dc.pk_id_detalle_compra ASC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);

                if (!string.IsNullOrWhiteSpace(idCompra))
                    cmd.Parameters.Add("idCompra", OdbcType.Int).Value = Convert.ToInt32(idCompra);

                if (!string.IsNullOrWhiteSpace(numeroFactura))
                    cmd.Parameters.Add("numeroFactura", OdbcType.VarChar).Value = numeroFactura;

                if (!string.IsNullOrWhiteSpace(proveedor))
                    cmd.Parameters.Add("proveedor", OdbcType.VarChar).Value = "%" + proveedor.Trim() + "%";

                if (fecha.HasValue)
                    cmd.Parameters.Add("fecha", OdbcType.Date).Value = fecha.Value.Date;

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }


        public DataTable Fun_ObtenerBodegas()
        {
            string sql = @"
        SELECT 
            Pk_Id_Bodega AS IdBodega,
            Cmp_Nombre_Bodega AS Bodega
        FROM tbl_bodega
        WHERE Cmp_Estado_Bodega = 'Activo'
        ORDER BY Cmp_Nombre_Bodega";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_ObtenerProductos()
        {
            string sql = @"
        SELECT 
            pk_inventario_id AS IdProducto,
            nombre_prod AS Producto,
            precio_unitario AS Precio
        FROM tbl_inventario
        WHERE estado_producto = 'ACTIVO'
        ORDER BY nombre_prod";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_ObtenerUnidades()
        {
            string sql = @"
        SELECT 
            ID_Unidad AS IdUnidad,
            Nombre_Unidad AS Unidad
        FROM tbl_unidad_de_medida
        ORDER BY Nombre_Unidad";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public int RegistrarCompraManual(
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
            using (OdbcConnection conn = conexion.conexion())
            using (OdbcTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    int idCompra = 0;

                    string sqlCompra = @"
                INSERT INTO tbl_compra
                (
                    fk_id_proveedor,
                    fk_id_orden_compra,
                    fk_id_bodega,
                    cmp_serie_factura,
                    cmp_numero_factura,
                    cmp_fecha,
                    cmp_dias_credito,
                    cmp_fecha_vencimiento,
                    cmp_tipo_compra,
                    cmp_subtotal,
                    cmp_total,
                    cmp_estado
                )
                VALUES (?, NULL, ?, ?, ?, ?, ?, ?, ?, ?, ?, 'pendiente')";

                    using (OdbcCommand cmd = new OdbcCommand(sqlCompra, conn, trans))
                    {
                        cmd.Parameters.Add("fk_id_proveedor", OdbcType.Int).Value = idProveedor;
                        cmd.Parameters.Add("fk_id_bodega", OdbcType.Int).Value = idBodega;
                        cmd.Parameters.Add("cmp_serie_factura", OdbcType.VarChar).Value = serieFactura;
                        cmd.Parameters.Add("cmp_numero_factura", OdbcType.VarChar).Value = numeroFactura;
                        cmd.Parameters.Add("cmp_fecha", OdbcType.DateTime).Value = fecha;
                        cmd.Parameters.Add("cmp_dias_credito", OdbcType.Int).Value = diasCredito;

                        if (fechaVencimiento.HasValue)
                            cmd.Parameters.Add("cmp_fecha_vencimiento", OdbcType.DateTime).Value = fechaVencimiento.Value;
                        else
                            cmd.Parameters.Add("cmp_fecha_vencimiento", OdbcType.DateTime).Value = DBNull.Value;

                        cmd.Parameters.Add("cmp_tipo_compra", OdbcType.VarChar).Value = tipoCompra;
                        cmd.Parameters.Add("cmp_subtotal", OdbcType.Double).Value = Convert.ToDouble(subtotal);
                        cmd.Parameters.Add("cmp_total", OdbcType.Double).Value = Convert.ToDouble(total);

                        cmd.ExecuteNonQuery();
                    }

                    using (OdbcCommand cmd = new OdbcCommand("SELECT LAST_INSERT_ID()", conn, trans))
                    {
                        idCompra = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    foreach (DataRow row in detalles.Rows)
                    {
                        string sqlDetalle = @"
                    INSERT INTO tbl_detalle_compra
                    (
                        fk_id_compra,
                        fk_inventario_id,
                        fk_id_unidad,
                        cmp_cantidad,
                        cmp_precio
                    )
                    VALUES (?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(sqlDetalle, conn, trans))
                        {
                            cmd.Parameters.Add("fk_id_compra", OdbcType.Int).Value = idCompra;
                            cmd.Parameters.Add("fk_inventario_id", OdbcType.Int).Value = Convert.ToInt32(row["IdProducto"]);
                            cmd.Parameters.Add("fk_id_unidad", OdbcType.Int).Value = Convert.ToInt32(row["IdUnidad"]);
                            cmd.Parameters.Add("cmp_cantidad", OdbcType.Double).Value = Convert.ToDouble(row["Cantidad"]);
                            cmd.Parameters.Add("cmp_precio", OdbcType.Double).Value = Convert.ToDouble(row["Precio"]);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    string sqlCxp = @"
                INSERT INTO tbl_cuentas_por_pagar
                (
                    fk_id_compra,
                    cmp_fecha_deuda,
                    cmp_fecha_vencimiento,
                    cmp_monto_total,
                    cmp_estado
                )
                VALUES (?, ?, ?, ?, 'pendiente')";

                    using (OdbcCommand cmd = new OdbcCommand(sqlCxp, conn, trans))
                    {
                        cmd.Parameters.Add("fk_id_compra", OdbcType.Int).Value = idCompra;
                        cmd.Parameters.Add("cmp_fecha_deuda", OdbcType.DateTime).Value = fecha;

                        if (fechaVencimiento.HasValue)
                            cmd.Parameters.Add("cmp_fecha_vencimiento", OdbcType.DateTime).Value = fechaVencimiento.Value;
                        else
                            cmd.Parameters.Add("cmp_fecha_vencimiento", OdbcType.DateTime).Value = DBNull.Value;

                        cmd.Parameters.Add("cmp_monto_total", OdbcType.Double).Value = Convert.ToDouble(total);
                        cmd.ExecuteNonQuery();
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


        public int DeshacerUltimoPagoDetalle(int idCompra)
        {
            using (OdbcConnection conn = conexion.conexion())
            using (OdbcTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    int idCxp = 0;
                    int idUltimoPago = 0;

                    string sqlCxp = @"
                        SELECT pk_id_cuenta_por_pagar
                        FROM tbl_cuentas_por_pagar
                        WHERE fk_id_compra = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlCxp, conn, trans))
                    {
                        cmd.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;
                        object r = cmd.ExecuteScalar();

                        if (r == null)
                        {
                            trans.Rollback();
                            return 0;
                        }

                        idCxp = Convert.ToInt32(r);
                    }

                    string sqlUltimo = @"
                        SELECT pk_id_cuenta_por_pagar_detalle
                        FROM tbl_cuentas_por_pagar_detalle
                        WHERE fk_id_cuenta_por_pagar = ?
                          AND (cmp_anulado = 0 OR cmp_anulado IS NULL)
                        ORDER BY pk_id_cuenta_por_pagar_detalle DESC
                        LIMIT 1";

                    using (OdbcCommand cmd = new OdbcCommand(sqlUltimo, conn, trans))
                    {
                        cmd.Parameters.Add("idCxp", OdbcType.Int).Value = idCxp;
                        object r = cmd.ExecuteScalar();

                        if (r == null)
                        {
                            trans.Rollback();
                            return 0;
                        }

                        idUltimoPago = Convert.ToInt32(r);
                    }

                    string sqlAnular = @"
                        UPDATE tbl_cuentas_por_pagar_detalle
                        SET cmp_anulado = 1
                        WHERE pk_id_cuenta_por_pagar_detalle = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlAnular, conn, trans))
                    {
                        cmd.Parameters.Add("idPago", OdbcType.Int).Value = idUltimoPago;
                        cmd.ExecuteNonQuery();
                    }

                    decimal totalCuenta = 0;
                    decimal totalPagado = 0;

                    string sqlTotales = @"
                        SELECT 
                            cxp.cmp_monto_total,
                            IFNULL(SUM(CASE 
                                WHEN det.cmp_anulado = 0 OR det.cmp_anulado IS NULL 
                                THEN det.cmp_monto_pagado ELSE 0 END), 0)
                        FROM tbl_cuentas_por_pagar cxp
                        LEFT JOIN tbl_cuentas_por_pagar_detalle det
                            ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
                        WHERE cxp.pk_id_cuenta_por_pagar = ?
                        GROUP BY cxp.cmp_monto_total";

                    using (OdbcCommand cmd = new OdbcCommand(sqlTotales, conn, trans))
                    {
                        cmd.Parameters.Add("idCxp", OdbcType.Int).Value = idCxp;

                        using (OdbcDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                totalCuenta = Convert.ToDecimal(dr[0]);
                                totalPagado = Convert.ToDecimal(dr[1]);
                            }
                        }
                    }

                    string estadoNuevo = "pendiente";

                    if (totalPagado > 0 && totalPagado < totalCuenta)
                        estadoNuevo = "parcial";
                    else if (totalPagado >= totalCuenta)
                        estadoNuevo = "pagado";

                    string sqlActualizarCxp = @"
                        UPDATE tbl_cuentas_por_pagar
                        SET cmp_estado = ?
                        WHERE pk_id_cuenta_por_pagar = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlActualizarCxp, conn, trans))
                    {
                        cmd.Parameters.Add("estado", OdbcType.VarChar).Value = estadoNuevo;
                        cmd.Parameters.Add("idCxp", OdbcType.Int).Value = idCxp;
                        cmd.ExecuteNonQuery();
                    }

                    string sqlActualizarCompra = @"
                        UPDATE tbl_compra
                        SET cmp_estado = ?
                        WHERE pk_id_compra = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlActualizarCompra, conn, trans))
                    {
                        cmd.Parameters.Add("estado", OdbcType.VarChar).Value = estadoNuevo;
                        cmd.Parameters.Add("idCompra", OdbcType.Int).Value = idCompra;
                        cmd.ExecuteNonQuery();
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
}