using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;
namespace Capa_Modelo_Recetas
{
    public class Sentencias
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable obtenerProductosTerminados()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())

            {
                string sql = @"
                SELECT m.Pk_Id_Materiales, m.Nombre_Material
                FROM Tbl_Materiales m
                JOIN Tbl_Categoria_Material c ON m.Fk_Id_Categoria = c.Pk_Id_Categoria_Material
                JOIN Tbl_Tipo_Material t ON c.Fk_Tipo_Material = t.Pk_Id_Tipo_Material
                WHERE t.Nombre_Tipo_Material = 'Producto Terminado';";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }
    


        
        
        public DataTable obtenerBOM(int idProducto)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
                SELECT 
                    b.Pk_Id_BOM,
                    b.Descripcion_BOM,
                    b.Version_BOM,
                    b.Fecha_Creacion_BOM,
                    b.Fk_Id_Estado_BOM
                FROM Tbl_BOM b
                WHERE b.Fk_Id_Material = ?;";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }


        public DataTable obtenerBOMGrid(int idProducto)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
        SELECT 
            b.Pk_Id_BOM AS ID,
            b.Descripcion_BOM AS Descripcion,
            b.Version_BOM AS Version,
            b.Fecha_Creacion_BOM AS Fecha,
            e.Nombre_Estado_BOM AS Estado
        FROM Tbl_BOM b
        JOIN Tbl_Estado_BOM e ON b.Fk_Id_Estado_BOM = e.Pk_Id_Estado_BOM
        WHERE b.Fk_Id_Material = ?;";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

       
        public DataTable obtenerEstados()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = "SELECT * FROM Tbl_Estado_BOM";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        // cesar santizo 0901-22-5215 boton guardar//
        public void insertarBOM(string descripcion, string version, DateTime fecha, int estado, int material)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"INSERT INTO Tbl_BOM
        (Descripcion_BOM, Version_BOM, Fecha_Creacion_BOM, Fk_Id_Estado_BOM, Fk_Id_Material)
        VALUES (?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@version", version);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@material", material);

                cmd.ExecuteNonQuery();
            }
        }

        // cesar santizo 0901-22-5215 boton editar//
        public void editarBOM(int idBOM, string descripcion, string version, DateTime fecha, int estado)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"UPDATE Tbl_BOM SET
        Descripcion_BOM = ?,
        Version_BOM = ?,
        Fecha_Creacion_BOM = ?,
        Fk_Id_Estado_BOM = ?
        WHERE Pk_Id_BOM = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@version", version);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@id", idBOM);

                cmd.ExecuteNonQuery();
            }
        }

        // maria morales 0901-22-1226 boton eliminar
        public void eliminarBOM(int idBOM)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                
                OdbcTransaction trans = conn.BeginTransaction();

                try
                {
                    
                    string sqlDetalle = "DELETE FROM Tbl_BOM_Detalle WHERE Fk_Id_BOM = ?";
                    OdbcCommand cmdDetalle = new OdbcCommand(sqlDetalle, conn, trans);
                    cmdDetalle.Parameters.AddWithValue("@id", idBOM);
                    cmdDetalle.ExecuteNonQuery();

                 
                    string sqlBOM = "DELETE FROM Tbl_BOM WHERE Pk_Id_BOM = ?";
                    OdbcCommand cmdBOM = new OdbcCommand(sqlBOM, conn, trans);
                    cmdBOM.Parameters.AddWithValue("@id", idBOM);
                    cmdBOM.ExecuteNonQuery();

                   
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        // ----------------------------- Sentencias para realizar una sola transacción en la base de datos ----------------- //

        // Método para guardar nuevos materiales o fases de producción. Anderson Trigueros
        public void agregarDatosNuevos(int iCodigoBOM, /*datosBOM*//*listaDetalle*/ List<(string sFase, string sDescripcion, int iHoras)> listaFases)
        {
            using (OdbcConnection con = conexion.conexion())
            {
                using (OdbcTransaction transaccion = con.BeginTransaction())
                {
                    try
                    {
                        // Guardar nuevas fases
                        if (listaFases != null && listaFases.Count > 0)
                        {
                            string sIngresarFase = @"INSERT INTO Tbl_Fases_Produccion
                                                    (Fk_Id_BOM, Nombre_Fase_Produccion, Descripcion_Fase_Produccion, Horas_Hombre) 
                                                    VALUES (?, ?, ?, ?)";

                            OdbcCommand cmdGuardar = new OdbcCommand(sIngresarFase, con, transaccion);

                            foreach (var fase in listaFases)
                            {
                                cmdGuardar.Parameters.Clear();

                                cmdGuardar.Parameters.AddWithValue("", iCodigoBOM);
                                cmdGuardar.Parameters.AddWithValue("", fase.sFase);
                                cmdGuardar.Parameters.AddWithValue("", fase.sDescripcion);
                                cmdGuardar.Parameters.AddWithValue("", fase.iHoras);

                                cmdGuardar.ExecuteNonQuery();
                            }
                        }

                        // Guardar nuevos detalles


                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        // Método para crear el proceso completo desde la creación de BOM, Detalle y Fases. Anderson Trigueros
        public void creaciónCompleta(string descripcion, string version, DateTime fecha, int estado, int material,
            /*listaDetalle*/ List<(string sFase, string sDescripcion, int iHoras)> listaFases)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    OdbcTransaction transaccion = con.BeginTransaction();
                    try
                    {
                        //Código para crear el BOM
                        string sql = @"INSERT INTO Tbl_BOM
                                       (Descripcion_BOM, Version_BOM, Fecha_Creacion_BOM, Fk_Id_Estado_BOM, Fk_Id_Material)
                                       VALUES (?, ?, ?, ?, ?)";

                        OdbcCommand cmd = new OdbcCommand(sql, con, transaccion);
                        cmd.Parameters.AddWithValue("", descripcion);
                        cmd.Parameters.AddWithValue("", version);
                        cmd.Parameters.AddWithValue("", fecha);
                        cmd.Parameters.AddWithValue("", estado);
                        cmd.Parameters.AddWithValue("", material);
                        cmd.ExecuteNonQuery();

                        //Obtener el id del BOM
                        OdbcCommand cmdLastId = new OdbcCommand("SELECT LAST_INSERT_ID();", con, transaccion);
                        int idBOM = Convert.ToInt32(cmdLastId.ExecuteScalar());

                        //Ingresar detalle

                        //Ingresar fases de producción
                        if (listaFases != null && listaFases.Count > 0)
                        {
                            
                            string sIngresarFase = @"INSERT INTO Tbl_Fases_Produccion
                                                (Fk_Id_BOM, Nombre_Fase_Produccion, Descripcion_Fase_Produccion, Horas_Hombre) 
                                                VALUES (?, ?, ?, ?)";

                            OdbcCommand cmdGuardar = new OdbcCommand(sIngresarFase, con, transaccion);

                            foreach (var fase in listaFases)
                            {
                                cmdGuardar.Parameters.Clear();

                                cmdGuardar.Parameters.AddWithValue("", idBOM);
                                cmdGuardar.Parameters.AddWithValue("", fase.sFase);
                                cmdGuardar.Parameters.AddWithValue("", fase.sDescripcion);
                                cmdGuardar.Parameters.AddWithValue("", fase.iHoras);

                                cmdGuardar.ExecuteNonQuery();
                            }
                        }
                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar receta: " + ex.Message);
            }
        }
    }
}