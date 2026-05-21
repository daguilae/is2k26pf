//dal
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo__DispoInve
{
    public class DAL_Inventario
    {
        private readonly string _cnx = "DSN=bd_SIG;";

        public List<Inventario> ObtenerInventario(
            int tipoInventario,
            int idAlmacen,
            string busqueda)
        {
            var lista = new List<Inventario>();

            string sql = @"
                SELECT
                    i.Pk_Id_Inventario,
                    m.Codigo_Material,
                    m.Nombre_Material,
                    ti.Nombre_Tipo_Inventario,
                    COALESCE(a.Nombre_Almacen, 'En producción') AS Nombre_Almacen,
                    um.Abreviatura_Unidad_Medida,
                    i.Cantidad_Disponible,
                    m.Stock_Minimo,
                    i.Costo_Unitario,
                    i.Fecha_Actualizacion
                FROM Tbl_Inventario i
                INNER JOIN Tbl_Materiales      m  ON i.Fk_Id_Material        = m.Pk_Id_Materiales
                INNER JOIN Tbl_Tipo_Inventario ti ON i.Fk_Id_Tipo_Inventario = ti.Pk_Id_Tipo_Inventario
                LEFT  JOIN Tbl_Almacen         a  ON i.Fk_Id_Almacen         = a.Pk_Id_Almacen
                INNER JOIN Tbl_Unidad_Medida   um ON m.Fk_Id_Unidad_Medida   = um.Pk_Id_Unidad_Medida
                WHERE
                    (? = 0 OR i.Fk_Id_Tipo_Inventario = ?)
                    AND (? = 0 OR i.Fk_Id_Almacen = ?)
                    AND (? = '' OR m.Codigo_Material LIKE ?
                               OR m.Nombre_Material  LIKE ?)
                ORDER BY ti.Nombre_Tipo_Inventario, m.Nombre_Material";

            using (var con = new OdbcConnection(_cnx))
            using (var cmd = new OdbcCommand(sql, con))
            {
                string like = "%" + busqueda + "%";

                cmd.Parameters.AddWithValue("?", tipoInventario);
                cmd.Parameters.AddWithValue("?", tipoInventario);
                cmd.Parameters.AddWithValue("?", idAlmacen);
                cmd.Parameters.AddWithValue("?", idAlmacen);
                cmd.Parameters.AddWithValue("?", busqueda);
                cmd.Parameters.AddWithValue("?", like);
                cmd.Parameters.AddWithValue("?", like);

                con.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new Inventario
                        {
                            IdInventario = rd.GetInt32(0),
                            CodigoMaterial = rd.GetString(1),
                            NombreMaterial = rd.GetString(2),
                            TipoInventario = rd.GetString(3),
                            NombreAlmacen = rd.GetString(4),
                            UnidadMedida = rd.GetString(5),
                            CantidadDisponible = rd.GetDecimal(6),
                            StockMinimo = rd.GetDecimal(7),
                            CostoUnitario = rd.GetDecimal(8),
                            FechaActualizacion = rd.GetDateTime(9)
                        });
                    }
                }
            }

            return lista;
        }

        public DataTable ObtenerAlmacenes()
        {
            var dt = new DataTable();
            string sql = "SELECT Pk_Id_Almacen, Nombre_Almacen FROM Tbl_Almacen ORDER BY Nombre_Almacen";

            using (var con = new OdbcConnection(_cnx))
            using (var cmd = new OdbcCommand(sql, con))
            using (var da = new OdbcDataAdapter(cmd))
            {
                con.Open();
                da.Fill(dt);
            }
            return dt;
        }
    }
}
