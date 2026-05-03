// Diego Monterroso
using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;
namespace Capa_Modelo_Recetas
{
    public class Sentencia_detalle_Materiales
    {

        private readonly Cls_Conexion conexion = new Cls_Conexion();
        // ── PRODUCTOS
        // Diego Monterroso
        public DataTable obtenerProductos()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                SELECT m.Pk_Id_Materiales, m.Nombre_Material
                FROM Tbl_Materiales m
                INNER JOIN Tbl_Categoria_Material c ON m.Fk_Id_Categoria = c.Pk_Id_Categoria_Material
                INNER JOIN Tbl_Tipo_Material t ON c.Fk_Tipo_Material = t.Pk_Id_Tipo_Material
                WHERE t.Nombre_Tipo_Material = 'Producto Terminado';";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(tabla);
            }
            return tabla;
        }


        // ── MATERIA PRIMA 
        // Diego Monterroso
        public DataTable obtenerMateriales()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                SELECT m.Pk_Id_Materiales, m.Nombre_Material
                FROM Tbl_Materiales m
                INNER JOIN Tbl_Categoria_Material c ON m.Fk_Id_Categoria = c.Pk_Id_Categoria_Material
                INNER JOIN Tbl_Tipo_Material t ON c.Fk_Tipo_Material = t.Pk_Id_Tipo_Material
                WHERE t.Nombre_Tipo_Material = 'Materia Prima';";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(tabla);

            }
            return tabla;
        }

        // ── UNIDADES 
        // Diego Monterroso
        public DataTable obtenerUnidades()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = "SELECT Pk_Id_Unidad_Medida, Nombre_Unidad_Medida FROM Tbl_Unidad_Medida;";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(tabla);

            }
            return tabla;
        }


        // ── LISTAR DETALLE
        // Diego Monterroso
        public DataTable obtenerDetalles()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                SELECT 
                    d.Pk_Id_BOM_Detalle,
                    b.Fk_Id_Material,
                    p.Nombre_Material AS Producto,
                    d.Fk_Id_Materiales,
                    m.Nombre_Material AS Material,
                    u.Nombre_Unidad_Medida,
                    d.Cantidad_Requerida_BOM_Detalle
                FROM Tbl_BOM_Detalle d
                INNER JOIN Tbl_BOM b ON d.Fk_Id_BOM = b.Pk_Id_BOM
                INNER JOIN Tbl_Materiales p ON b.Fk_Id_Material = p.Pk_Id_Materiales
                INNER JOIN Tbl_Materiales m ON d.Fk_Id_Materiales = m.Pk_Id_Materiales
                INNER JOIN Tbl_Unidad_Medida u ON d.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida;";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(tabla);

            }
            return tabla;
        }


        // Ruben Lopez 0901-20-4620
        // ── INSERT 
        public bool insertarDetalle(int idProducto, int idMaterial, int idUnidad, decimal cantidad)
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {

                // obtener BOM del producto
                string queryBOM = "SELECT Pk_Id_BOM FROM Tbl_BOM WHERE Fk_Id_Material = ?";
                OdbcCommand cmdBOM = new OdbcCommand(queryBOM, conn);
                cmdBOM.Parameters.Add("p1", OdbcType.Int).Value = idProducto;

                object result = cmdBOM.ExecuteScalar();

                if (result == null)
                    throw new Exception("El producto no tiene BOM creado.");

                int idBOM = Convert.ToInt32(result);

                string query = @"
                INSERT INTO Tbl_BOM_Detalle
                (Fk_Id_BOM, Fk_Id_Materiales, Fk_Id_Unidad_Medida, Cantidad_Requerida_BOM_Detalle)
                VALUES (?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.Add("p1", OdbcType.Int).Value = idBOM;
                cmd.Parameters.Add("p2", OdbcType.Int).Value = idMaterial;
                cmd.Parameters.Add("p3", OdbcType.Int).Value = idUnidad;
                cmd.Parameters.Add("p4", OdbcType.Decimal).Value = cantidad;

                int filas = cmd.ExecuteNonQuery();


                return filas > 0;
            }
        }

        // Ruben Lopez 0901-20-4620
        // ── UPDATE 

        public bool actualizarDetalle(int idDetalle, int idProducto, int idMaterial, int idUnidad, decimal cantidad)
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {

                string query = @"
                UPDATE Tbl_BOM_Detalle
                SET Fk_Id_Materiales = ?, 
                    Fk_Id_Unidad_Medida = ?, 
                    Cantidad_Requerida_BOM_Detalle = ?
                WHERE Pk_Id_BOM_Detalle = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.Add("p1", OdbcType.Int).Value = idMaterial;
                cmd.Parameters.Add("p2", OdbcType.Int).Value = idUnidad;
                cmd.Parameters.Add("p3", OdbcType.Decimal).Value = cantidad;
                cmd.Parameters.Add("p4", OdbcType.Int).Value = idDetalle;

                int filas = cmd.ExecuteNonQuery();


                return filas > 0;
            }
        }

        // Ruben Lopez 0901-20-4620
        // ── DELETE 
        public bool eliminarDetalle(int idDetalle)
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {

                string query = "DELETE FROM Tbl_BOM_Detalle WHERE Pk_Id_BOM_Detalle = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.Add("p1", OdbcType.Int).Value = idDetalle;

                int filas = cmd.ExecuteNonQuery();


                return filas > 0;
            }
        }

        // Realizado por: Anderson Trigueros

        public DataTable fun_ObtenerFasesProducción(int iCodigoBOM)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaFase = @"SELECT f.Pk_Id_Fase_Producto as CodigoFase, f.Nombre_Fase_Produccion as Fase, 
                                                f.Descripcion_Fase_Produccion AS Descripcion, f.Horas_Hombre as Horas
                                                FROM Tbl_Fases_Produccion f
                                                WHERE f.Fk_Id_BOM = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaFase, con);
                    cmd.Parameters.AddWithValue("", iCodigoBOM);
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
        // ------------------- Sentencias para realizar una sola transacción en la base de datos ----------------- //
    }
}


    
