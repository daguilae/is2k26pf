using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Cls_Sentencias_Bodega
    {
        Cls_Conexion cn = new Cls_Conexion();

        // INSERTAR
        public bool fun_InsertarBodega(string sNombre, string sDireccion, string sEstado)
        {
            try
            {
                OdbcConnection conn = cn.fun_AbrirConexion();

                string sSql = "INSERT INTO Tbl_Bodega (Nombre_Bodega, Direccion_Bodega, Estado_Bodega) VALUES (?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(sSql, conn);

                cmd.Parameters.AddWithValue("@Nombre", sNombre);
                cmd.Parameters.AddWithValue("@Direccion", sDireccion);
                cmd.Parameters.AddWithValue("@Estado", sEstado);

                int iFilas = cmd.ExecuteNonQuery();

                cn.fun_CerrarConexion();

                return iFilas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Insertar: " + ex.Message);
                return false;
            }
        }

        // CONSULTAR
        public DataTable fun_ConsultarBodega()
        {
            DataTable dt = new DataTable();

            try
            {
                OdbcConnection conn = cn.fun_AbrirConexion();

                string sSql = "SELECT * FROM Tbl_Bodega";

                OdbcDataAdapter da = new OdbcDataAdapter(sSql, conn);
                da.Fill(dt);

                cn.fun_CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Consultar: " + ex.Message);
            }

            return dt;
        }

        // BUSCAR
        public DataTable fun_BuscarBodega(int iId)
        {
            DataTable dt = new DataTable();

            try
            {
                OdbcConnection conn = cn.fun_AbrirConexion();

                string sSql = "SELECT * FROM Tbl_Bodega WHERE ID_Bodega = ?";

                OdbcCommand cmd = new OdbcCommand(sSql, conn);
                cmd.Parameters.AddWithValue("@ID", iId);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);

                cn.fun_CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Buscar: " + ex.Message);
            }

            return dt;
        }

        // MODIFICAR
        public bool fun_ModificarBodega(int iId, string sNombre, string sDireccion, string sEstado)
        {
            try
            {
                OdbcConnection conn = cn.fun_AbrirConexion();

                string sSql = "UPDATE Tbl_Bodega SET Nombre_Bodega = ?, Direccion_Bodega = ?, Estado_Bodega = ? WHERE ID_Bodega = ?";

                OdbcCommand cmd = new OdbcCommand(sSql, conn);

                cmd.Parameters.AddWithValue("@Nombre", sNombre);
                cmd.Parameters.AddWithValue("@Direccion", sDireccion);
                cmd.Parameters.AddWithValue("@Estado", sEstado);
                cmd.Parameters.AddWithValue("@ID", iId);

                int iFilas = cmd.ExecuteNonQuery();

                cn.fun_CerrarConexion();

                return iFilas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Modificar: " + ex.Message);
                return false;
            }
        }

        // ELIMINAR
        public bool fun_EliminarBodega(int iId)
        {
            try
            {
                OdbcConnection conn = cn.fun_AbrirConexion();

                string sSql = "DELETE FROM Tbl_Bodega WHERE ID_Bodega = ?";

                OdbcCommand cmd = new OdbcCommand(sSql, conn);
                cmd.Parameters.AddWithValue("@ID", iId);

                int iFilas = cmd.ExecuteNonQuery();

                cn.fun_CerrarConexion();

                return iFilas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Eliminar: " + ex.Message);
                return false;
            }
        }
    }
}