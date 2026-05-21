using System;
using System.Data;
using System.Data.Odbc;

public class CNTS_INV_MOD
{
    // ── CARGAR BODEGAS para el ComboBox ─────────────────
    public DataTable ObtenerBodegas()
    {
        DataTable dt = new DataTable();
        try
        {
            using (OdbcConnection con = CNX.ObtenerConexion())
            {
                con.Open();
                string sql = @"
                    SELECT 
                        Pk_Id_Bodega        AS Id,
                        Cmp_Nombre_Bodega   AS Bodega
                    FROM tbl_bodega
                    ORDER BY Cmp_Nombre_Bodega ASC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener bodegas: " + ex.Message);
        }
        return dt;
    }

    // ── CARGAR PRODUCTOS para el ComboBox ───────────────
    public DataTable ObtenerProductos()
    {
        DataTable dt = new DataTable();
        // No va a BD, son valores fijos de la BD (enum MP / PF)
        dt.Columns.Add("Id", typeof(string));
        dt.Columns.Add("Producto", typeof(string));

        dt.Rows.Add("", "-- TODOS --");
        dt.Rows.Add("MP", "Materia Prima");
        dt.Rows.Add("PF", "Producido/Preparado");

        return dt;
    }

    // ── CONSULTA PRINCIPAL del inventario ───────────────
    // Parámetros opcionales: idBodega, idProducto, orden, codigo, nombre
    public DataTable ObtenerInventario(int idBodega, string tipoProducto,
                                   string orden, string codigo, string nombre)
    {
        DataTable dt = new DataTable();
        try
        {
            using (OdbcConnection con = CNX.ObtenerConexion())
            {
                con.Open();

                string filtros = "WHERE inv.estado_producto = 'ACTIVO'";

                if (idBodega > 0)
                    filtros += $" AND ex.fk_bodega_id = {idBodega}";

                if (!string.IsNullOrEmpty(tipoProducto))
                    filtros += $" AND inv.tipo_producto = '{tipoProducto}'";

                if (!string.IsNullOrEmpty(codigo))
                    filtros += $" AND inv.pk_inventario_id = '{codigo}'";

                if (!string.IsNullOrEmpty(nombre))
                    filtros += $" AND inv.nombre_prod LIKE '%{nombre}%'";

                // ── Orden por Stock ──
                string ordenSQL = orden == "DESC" ? "DESC" : "ASC";

                string sql = $@"
                SELECT 
                    inv.pk_inventario_id    AS Codigo,
                    inv.nombre_prod         AS Producto,
                    inv.tipo_producto       AS Tipo,
                    lin.cmp_nombre_linea    AS Linea,
                    mar.Nombre_Marca        AS Marca,
                    bod.Cmp_Nombre_Bodega   AS Bodega,
                    ex.stock                AS Stock,
                    inv.precio_unitario     AS Precio
                FROM tbl_inventario inv
                LEFT JOIN tbl_existencias ex 
                    ON inv.pk_inventario_id = ex.fk_inventario_id
                LEFT JOIN tbl_bodega bod 
                    ON ex.fk_bodega_id = bod.Pk_Id_Bodega
                LEFT JOIN tbl_linea_producto lin 
                    ON inv.fk_linea_id = lin.pk_id_linea
                LEFT JOIN tbl_marca mar 
                    ON inv.fk_marca_id = mar.ID_Marca
                {filtros}
                ORDER BY ex.stock {ordenSQL}";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener inventario: " + ex.Message);
        }
        return dt;
    }
}