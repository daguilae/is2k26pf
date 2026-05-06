using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Seguridad;
using System.Data.Odbc;

namespace Capa_Modelo_recepcion
{
    public class Sentencias
    {
        //cesar santizo 0901-22-5215
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable obtenerMateriales()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"SELECT 
                        Pk_Id_Materiales, 
                        Nombre_Material 
                       FROM Tbl_Materiales
                       WHERE Activo = 1;";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }
        //cesar santizo 0901-22-5215

        public DataTable obtenerUbi()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
        SELECT 
            Pk_Id_Almacen,
            Nombre_Almacen
        FROM Tbl_Almacen
        WHERE Estado_Almacen = 1;";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }
        //cesar santizo 0901-22-5215

        public DataTable estado()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
        SELECT 
            Pk_Id_Estado_Recepcion_Material,
            Nombre_Estado_Recepcion_Material
        FROM Tbl_estado_recepcion_material;";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}