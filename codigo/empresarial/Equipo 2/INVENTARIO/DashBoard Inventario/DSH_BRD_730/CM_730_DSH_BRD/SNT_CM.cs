using System;
using System.Data;
using System.Data.Odbc;

public class DSH_BRD_MOD
{
    // ── ULTIMOS MOVIMIENTOS ──────────────────────────────────────────────
    // Tablas: tbl_movimiento_inventario_encabezado (enc)
    //         tbl_movimiento_inventario_detalle    (det)
    //         tbl_inventario                       (inv)
    //         tbl_tipo_movimiento_inventario       (tip)
    // ── ULTIMOS MOVIMIENTOS CON FILTROS COMPLETOS ───────
    public DataTable ObtenerUltimosMovimientos(DateTime fechaInicio, DateTime fechaFin,
                                                string nombre = null, string tipoMov = null)
    {
        DataTable dt = new DataTable();
        try
        {
            using (OdbcConnection con = CNX.ObtenerConexion())
            {
                string filtroFecha = fechaInicio == DateTime.MinValue ? "" :
                    $"AND DATE(enc.fecha_transaccion) BETWEEN '{fechaInicio:yyyy-MM-dd}' AND '{fechaFin:yyyy-MM-dd}'";

                string filtroNombre = string.IsNullOrEmpty(nombre) ? "" :
                    $"AND inv.nombre_prod = '{nombre}'";

                string filtroTipo = string.IsNullOrEmpty(tipoMov) ? "" :
                    $"AND tip.nombre_tipo_inv = '{tipoMov}'";

                string sql = $@"
                SELECT 
                    enc.fecha_transaccion       AS Fecha,
                    tip.efecto                  AS Tipo,
                    tip.nombre_tipo_inv         AS Movimiento,
                    inv.nombre_prod             AS Producto,
                    det.cantidad_transaccionada AS Cantidad,
                    enc.descripcion             AS Descripcion
                FROM tbl_movimiento_inventario_encabezado enc
                INNER JOIN tbl_movimiento_inventario_detalle det 
                    ON enc.pk_movimiento_id = det.fk_movimiento_id
                INNER JOIN tbl_inventario inv 
                    ON det.fk_inventario_id = inv.pk_inventario_id
                INNER JOIN tbl_tipo_movimiento_inventario tip 
                    ON enc.fk_tipo_movimiento_id = tip.pk_tipo_movimiento_id
                WHERE 1=1
                {filtroFecha}
                {filtroNombre}
                {filtroTipo}
                ORDER BY enc.fecha_transaccion DESC
                LIMIT 100";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener movimientos: " + ex.Message);
        }
        return dt;
    }

    // ── STOCK CRITICO ────────────────────────────────────────────────────
    // Tablas: tbl_existencias  (ex)
    //         tbl_inventario   (inv)
    //         tbl_bodega       (bod)
    // Stock crítico = productos con stock menor o igual a 50 (ajusta el umbral)
    public DataTable ObtenerStockCritico()
    {
        DataTable dt = new DataTable();
        try
        {
            using (OdbcConnection con = CNX.ObtenerConexion())
            {
                con.Open();
                string sql = @"
                SELECT 
                    inv.pk_inventario_id        AS Código,
                    inv.nombre_prod             AS Producto,
                    inv.tipo_producto           AS Tipo,
                    bod.Cmp_Nombre_Bodega       AS Bodega,
                    ex.stock                    AS Stock,
                    inv.precio_unitario         AS Precio_Unitario,
                    niv.nombre_nivel            AS Nivel
                FROM tbl_existencias ex
                INNER JOIN tbl_inventario inv 
                    ON ex.fk_inventario_id = inv.pk_inventario_id
                INNER JOIN tbl_bodega bod 
                    ON ex.fk_bodega_id = bod.Pk_Id_Bodega
                INNER JOIN tbl_nivel_stock niv
                    ON ex.stock BETWEEN niv.stock_minimo AND niv.stock_maximo
                WHERE inv.estado_producto = 'ACTIVO'
                  AND bod.Cmp_Estado_Bodega = 'Activo'
                  AND niv.estado = 'Activo'
                ORDER BY ex.stock ASC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener stock crítico: " + ex.Message);
        }
        return dt;
    }
    // ── NOMBRES DE PRODUCTOS PARA COMBOBOX ──────────────
    public DataTable ObtenerNombresProductos()
    {
        DataTable dt = new DataTable();
        try
        {
            using (OdbcConnection con = CNX.ObtenerConexion())
            {
                string sql = @"
                SELECT DISTINCT inv.nombre_prod
                FROM tbl_inventario inv
                WHERE inv.estado_producto = 'ACTIVO'
                ORDER BY inv.nombre_prod ASC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener productos: " + ex.Message);
        }
        return dt;
    }

    // ── TIPOS DE MOVIMIENTO PARA COMBOBOX ───────────────
    public DataTable ObtenerTiposMovimiento()
    {
        DataTable dt = new DataTable();
        try
        {
            using (OdbcConnection con = CNX.ObtenerConexion())
            {
                string sql = @"
                SELECT nombre_tipo_inv
                FROM tbl_tipo_movimiento_inventario
                ORDER BY nombre_tipo_inv ASC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener tipos de movimiento: " + ex.Message);
        }
        return dt;
    }

}