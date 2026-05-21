using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Fase
{
    public class Cls_Sentencias
    {
        Cls_Conexion conexion = new Cls_Conexion();
        public DataTable fun_ObtenerProductos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaProductos = @"SELECT m.Pk_Id_Materiales AS codigoProducto, m.Nombre_Material as Producto
                                                   FROM Tbl_Materiales m";
                    OdbcCommand cmd = new OdbcCommand(sConsultaProductos, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los menús: " + ex.Message, ex);
            }
            return tabla;
        }

        public DataTable fun_ObtenerFasesProducción(int iCodigoProducto)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaProducto = @"SELECT f.Pk_Id_Fase_Producto as CodigoFase, m.Nombre_Material AS Producto,
                                              f.Nombre_Fase_Produccion as Fase, f.Descripcion_Fase_Produccion AS Descripcion,
                                              f.Horas_Hombre as Horas
                                              FROM Tbl_Fases_Produccion f
                                              JOIN Tbl_Materiales m ON f.Fk_Id_Material = m.Pk_Id_Materiales
                                              WHERE m.Pk_Id_Materiales = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaProducto, con);
                    cmd.Parameters.AddWithValue("", iCodigoProducto);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las fases del producto: " + ex.Message, ex);
            }
            return tabla;
        }

        public void pro_GuardarDatosFase(int iProducto, string sFase, string sDescripcion, int iHoras)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sIngresarFase =
                        @"INSERT INTO Tbl_Fases_Produccion
                        (Fk_Id_Material, Nombre_Fase_Produccion, Descripcion_Fase_Produccion, Horas_Hombre)
                         VALUES (?, ?, ?, ?)";
                    OdbcCommand cmdGuardar = new OdbcCommand(sIngresarFase, con);
                    cmdGuardar.Parameters.AddWithValue("", iProducto);
                    cmdGuardar.Parameters.AddWithValue("", sFase);
                    cmdGuardar.Parameters.AddWithValue("", sDescripcion);
                    cmdGuardar.Parameters.AddWithValue("", iHoras);
                    cmdGuardar.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar fase de producción: " + ex.Message);
            }
        }

        public void pro_EliminarReceta(int iCodigoFase)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sEliminar = @"DELETE FROM Tbl_Fases_Produccion
                                           WHERE Pk_Id_Fase_Producto = ?";
                    OdbcCommand cmd = new OdbcCommand(sEliminar, con);
                    cmd.Parameters.AddWithValue("", iCodigoFase);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message, ex);
            }
        }

        public void pro_Actualizar(int iCodigoFase, string sFase, string sDescripcion, int iHoras)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sActualizar = @"UPDATE Tbl_Fases_Produccion
                       SET  Nombre_Fase_Produccion = ?, Descripcion_Fase_Produccion = ?,
                       Horas_Hombre = ? WHERE Pk_Id_Fase_Producto = ? ";

                    OdbcCommand cmd = new OdbcCommand(sActualizar, con);
                    cmd.Parameters.AddWithValue("", sFase);
                    cmd.Parameters.AddWithValue("", sDescripcion);
                    cmd.Parameters.AddWithValue("", iHoras);
                    cmd.Parameters.AddWithValue("", iCodigoFase);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar: " + ex.Message, ex);
            }
        }
    }
}
    
