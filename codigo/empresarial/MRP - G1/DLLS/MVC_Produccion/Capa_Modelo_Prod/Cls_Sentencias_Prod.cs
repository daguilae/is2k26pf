using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Prod
{
    public class Cls_Sentencias_Prod
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable ObtenerOrdenesRecibidas()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                o.Pk_Id_Orden_Recibida,
                CONCAT(o.Id_Externo_Logistica, ' | ', 
                       DATE_FORMAT(o.Fecha_Requerida, '%Y-%m-%d')) AS Descripcion
            FROM Tbl_Orden_Recibida o
            INNER JOIN Tbl_Estado_Orden_Recibida e
                ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida
            ORDER BY o.Fecha_Recepcion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }


        public DataTable ObtenerInfoOrdenRecibida(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                o.Id_Externo_Logistica          AS No_Orden,
                e.Nombre_Estado_Orden_Recibida  AS Estado,
                DATE_FORMAT(o.Fecha_Recepcion, '%Y-%m-%d')  AS Fecha_Recepcion,
                DATE_FORMAT(o.Fecha_Requerida, '%Y-%m-%d')  AS Fecha_Requerida,
                o.Observacion
            FROM Tbl_Orden_Recibida o
            INNER JOIN Tbl_Estado_Orden_Recibida e
                ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida
            WHERE o.Pk_Id_Orden_Recibida = ?";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // Productos a fabricar (detalle de la orden recibida)
        public DataTable ObtenerProductosOrdenRecibida(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                m.Codigo_Material                   AS Codigo,
                m.Nombre_Material                   AS Producto,
                d.Cantidad_Solicitada               AS Cantidad,
                um.Abreviatura_Unidad_Medida        AS Unidad,
                m.Lead_Time_Produccion_Dias         AS Lead_Time_Dias
            FROM Tbl_Orden_Recibida_Detalle d
            INNER JOIN Tbl_Materiales m 
                ON d.Fk_Id_Material = m.Pk_Id_Materiales
            INNER JOIN Tbl_Unidad_Medida um 
                ON m.Fk_Id_Unidad_Medida = um.Pk_Id_Unidad_Medida
            WHERE d.Fk_Id_Orden_Recibida = ?";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // ############################ METODOS PARA MANO DE OBRA #############################################
        // Mano de obra por orden de producción
        public DataTable ObtenerManoObra(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                m.Pk_Id_Mano_Obra                           AS Id,
                CONCAT(e.Cmp_Nombres_Empleado, ' ', e.Cmp_Apellidos_Empleado) AS Empleado,
                m.Hora_Trabajada_Mano_Obra                  AS Horas,
                m.Costo_Hora_Mano_Obra                      AS CostoHora,
                m.Subtotal_Mano_Obra                        AS Subtotal
            FROM Tbl_Mano_Obra m
            INNER JOIN Tbl_Empleado e ON m.Fk_Id_Empleado = e.Pk_Id_Empleado
            WHERE m.Fk_Id_Orden_Produccion = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public bool GuardarManoObra(int idOrden, int idEmpleado, decimal horas, decimal costoHora)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    decimal subtotal = horas * costoHora;
                    string query = @"
                INSERT INTO Tbl_Mano_Obra 
                    (Fk_Id_Orden_Produccion, Fk_Id_Empleado, Hora_Trabajada_Mano_Obra, Costo_Hora_Mano_Obra, Subtotal_Mano_Obra)
                VALUES (?, ?, ?, ?, ?)";

                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", idOrden);
                    cmd.Parameters.AddWithValue("?", idEmpleado);
                    cmd.Parameters.AddWithValue("?", horas);
                    cmd.Parameters.AddWithValue("?", costoHora);
                    cmd.Parameters.AddWithValue("?", subtotal);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error (GuardarManoObra): " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarManoObra(int idManoObra)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand(
                        "DELETE FROM Tbl_Mano_Obra WHERE Pk_Id_Mano_Obra = ?", conn);
                    cmd.Parameters.AddWithValue("?", idManoObra);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error (EliminarManoObra): " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable ObtenerCostosProduccion(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT
                COALESCE((
                    SELECT SUM(om.Cantidad_Consumida_Orden_Material * i.Costo_Unitario)
                    FROM Tbl_Orden_Material om
                    INNER JOIN Tbl_Inventario i ON om.Fk_Id_Materiales = i.Fk_Id_Material
                    WHERE om.Fk_Id_Orden_Produccion = ?
                ), 0) AS CostoMateriales,

                COALESCE((
                    SELECT SUM(mo.Hora_Trabajada_Mano_Obra * mo.Costo_Hora_Mano_Obra)
                    FROM Tbl_Mano_Obra mo
                    WHERE mo.Fk_Id_Orden_Produccion = ?
                ), 0) AS CostoManoObra,

                COALESCE((
                    SELECT SUM(ci.Monto_Costo_Indirecto_Produccion)
                    FROM Tbl_Costo_Indirecto_Produccion ci
                    WHERE ci.Fk_Id_Orden_Produccion = ?
                ), 0) AS CostoIndirecto,

                COALESCE((
                    SELECT SUM(me.Cantidad_Merma * i.Costo_Unitario)
                    FROM Tbl_Merma me
                    INNER JOIN Tbl_Inventario i ON me.Fk_Id_Materiales = i.Fk_Id_Material
                    WHERE me.Fk_Id_Orden_Produccion = ?
                ), 0) AS CostoMermas";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden);
                cmd.Parameters.AddWithValue("?", idOrden);
                cmd.Parameters.AddWithValue("?", idOrden);
                cmd.Parameters.AddWithValue("?", idOrden);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }


        public DataTable ObtenerEmpleados()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                Pk_Id_Empleado AS IdEmpleado,
                CONCAT(Cmp_Nombres_Empleado, ' ', Cmp_Apellidos_Empleado) AS NombreCompleto
            FROM Tbl_Empleado
            ORDER BY Cmp_Nombres_Empleado";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
        // ############################ METODOS PARA MANO DE OBRA #############################################


    }
}
