using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_Ventas
{ 
    public class Cls_Asignacion_ClientesDAO
    {
        private Cls_ConexionBD conexion = new Cls_ConexionBD();

        private static readonly string SQL_INSERT =
            "INSERT INTO tbl_asignacion_clientes (Fk_Id_Vendedor, Fk_Id_Cliente) VALUES (?, ?)";

        private static readonly string SQL_EXISTE =
            "SELECT COUNT(*) FROM tbl_asignacion_clientes WHERE Fk_Id_Vendedor = ? AND Fk_Id_Cliente = ?";

        private static readonly string SQL_SELECT_JOIN = @"
            SELECT 
                v.Pk_Id_Vendedor,
                CONCAT(v.Pk_Id_Vendedor, ' - ', v.Cmp_Nombre, ' ', v.Cmp_Apellido) AS Vendedor,
                c.Pk_Id_Cliente,
                CONCAT(c.Pk_Id_Cliente, ' - ', c.Cmp_Nombre, ' ', c.Cmp_Apellido) AS Cliente
            FROM tbl_asignacion_clientes a
            INNER JOIN tbl_vendedor v ON a.Fk_Id_Vendedor = v.Pk_Id_Vendedor
            INNER JOIN tbl_clientes c ON a.Fk_Id_Cliente = c.Pk_Id_Cliente
            ORDER BY v.Pk_Id_Vendedor ASC";

        private static readonly string SQL_VENDEDORES = @"
            SELECT 
                Pk_Id_Vendedor,
                CONCAT(Pk_Id_Vendedor, ' - ', Cmp_Nombre, ' ', Cmp_Apellido) AS NombreCompleto
            FROM tbl_vendedor";

        private static readonly string SQL_CLIENTES = @"
            SELECT 
                Pk_Id_Cliente,
                CONCAT(Pk_Id_Cliente, ' - ', Cmp_Nombre, ' ', Cmp_Apellido) AS NombreCompleto
            FROM tbl_clientes";

        private static readonly string SQL_DELETE =
            "DELETE FROM tbl_asignacion_clientes WHERE Fk_Id_Vendedor = ? AND Fk_Id_Cliente = ?";

        public int EliminarAsignacion(int idVendedor, int idCliente)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_DELETE, conn))
                {
                    cmd.Parameters.AddWithValue("?", idVendedor);
                    cmd.Parameters.AddWithValue("?", idCliente);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int InsertarAsignacion(int idVendedor, int idCliente)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("?", idVendedor);
                    cmd.Parameters.AddWithValue("?", idCliente);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ExisteAsignacion(int idVendedor, int idCliente)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_EXISTE, conn))
                {
                    cmd.Parameters.AddWithValue("?", idVendedor);
                    cmd.Parameters.AddWithValue("?", idCliente);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public DataTable ObtenerAsignacionesConNombres()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_SELECT_JOIN, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerVendedores()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_VENDEDORES, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerClientes()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_CLIENTES, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}