using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;


namespace Capa_Modelo_Costo_Fase
{

    public class Cls_Datos_Material
    {
        public int iIdMaterial { get; set; }
        public string sNombreMaterial { get; set; }
    }

    public class Cls_Datos_Fase
    {
        public int iIdFase { get; set; }
        public string sNombreFase { get; set; }
    }

    public class Cls_Datos_Tipo_Costo
    {
        public int iIdTipoCosto { get; set; }
        public string sNombreTipoCosto { get; set; }
    }

    
    public class Cls_Datos_Costo_Fase
    {
        public int iIdCostoFase { get; set; }
        public int iIdFase { get; set; }
        public int iIdTipoCosto { get; set; }
        public decimal dCosto { get; set; }

        public string sNombreProducto { get; set; } 
        public string sNombreFase { get; set; }
        public string sNombreTipoCosto { get; set; }
    }

    public class Cls_Sentencias
    {
        Cls_Conexion conexion = new Cls_Conexion();

        public List<Cls_Datos_Tipo_Costo> fun_ObtenerTiposCosto()
        {
            List<Cls_Datos_Tipo_Costo> lista = new List<Cls_Datos_Tipo_Costo>();

           
            using (OdbcConnection con = conexion.conexion())
            {
                string query = @"SELECT 
                                Pk_Id_Tipo_Costo_Fase AS Codigo,
                                Nombre_Tipo_Costo AS Nombre
                                FROM Tbl_Tipo_Costo_Fase";

                OdbcCommand cmd = new OdbcCommand(query, con);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cls_Datos_Tipo_Costo()
                        {
                            iIdTipoCosto = Convert.ToInt32(reader["Codigo"]),
                            sNombreTipoCosto = reader["Nombre"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public void fun_InsertarCostoFase(int idFase, int idTipoCosto, decimal costo)
        {
            using (OdbcConnection con = conexion.conexion())
            {
                string query = @"INSERT INTO Tbl_Costo_Fase 
                                (Fk_Id_Fase_Producto, Fk_Id_Tipo_Costo_Fase, Costo) 
                                VALUES (?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idFase;
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idTipoCosto;
                    cmd.Parameters.Add("?", OdbcType.Decimal).Value = costo;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cls_Datos_Costo_Fase> fun_ObtenerCostoFase()
        {
            List<Cls_Datos_Costo_Fase> lista = new List<Cls_Datos_Costo_Fase>();

            using (OdbcConnection con = conexion.conexion())
            {
                
                string query = "SELECT Pk_Id_Costo_Fase, Fk_Id_Fase_Producto, Fk_Id_Tipo_Costo_Fase, Costo FROM Tbl_Costo_Fase";

                OdbcCommand cmd = new OdbcCommand(query, con);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cls_Datos_Costo_Fase()
                        {
                            iIdCostoFase = Convert.ToInt32(reader["Pk_Id_Costo_Fase"]),
                            iIdFase = Convert.ToInt32(reader["Fk_Id_Fase_Producto"]),
                            iIdTipoCosto = Convert.ToInt32(reader["Fk_Id_Tipo_Costo_Fase"]),
                            dCosto = Convert.ToDecimal(reader["Costo"]),
                            sNombreProducto = "", 
                            sNombreFase = "",
                            sNombreTipoCosto = ""
                        });
                    }
                }
            }
            return lista;
        }

        public void fun_ModificarCostoFase(int id, int idFase, int idTipoCosto, decimal costo)
        {
            using (OdbcConnection con = conexion.conexion())
            {
                string query = @"UPDATE Tbl_Costo_Fase 
                                 SET Fk_Id_Fase_Producto = ?, 
                                     Fk_Id_Tipo_Costo_Fase = ?, 
                                     Costo = ?
                                 WHERE Pk_Id_Costo_Fase = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idFase;
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idTipoCosto;
                    cmd.Parameters.Add("?", OdbcType.Decimal).Value = costo;
                    cmd.Parameters.Add("?", OdbcType.Int).Value = id;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void fun_EliminarCostoFase(int id)
        {
            using (OdbcConnection con = conexion.conexion())
            {
                string query = @"DELETE FROM Tbl_Costo_Fase 
                                 WHERE Pk_Id_Costo_Fase = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?", OdbcType.Int).Value = id;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cls_Datos_Material> fun_ObtenerMateriales()
        {
            List<Cls_Datos_Material> lista = new List<Cls_Datos_Material>();

            using (OdbcConnection con = conexion.conexion())
            {
                string query = @"SELECT 
                                Pk_Id_Materiales AS Codigo,
                                Nombre_Material AS Nombre
                                FROM tbl_materiales";

                OdbcCommand cmd = new OdbcCommand(query, con);

                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cls_Datos_Material()
                        {
                            iIdMaterial = Convert.ToInt32(reader["Codigo"]),
                            sNombreMaterial = reader["Nombre"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public List<Cls_Datos_Fase> fun_ObtenerFasesPorMaterial(int idMaterial)
        {
            List<Cls_Datos_Fase> lista = new List<Cls_Datos_Fase>();

            using (OdbcConnection con = conexion.conexion())
            {
                string query = @"
                SELECT 
                    fp.Pk_Id_Fase_Producto AS Codigo,
                    fp.Nombre_Fase_Produccion AS Nombre
                FROM tbl_fases_produccion fp
                INNER JOIN tbl_bom bom ON fp.Fk_Id_BOM = bom.Pk_Id_BOM
                WHERE bom.Fk_Id_Material = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idMaterial;

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cls_Datos_Fase()
                            {
                                iIdFase = Convert.ToInt32(reader["Codigo"]),
                                sNombreFase = reader["Nombre"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool fun_ExisteCostoFase(int idFase, int idTipoCosto)
        {
            bool existe = false;

            using (OdbcConnection con = conexion.conexion())
            {
                string query = "SELECT COUNT(*) FROM Tbl_Costo_Fase WHERE Fk_Id_Fase_Producto = ? AND Fk_Id_Tipo_Costo_Fase = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idFase;
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idTipoCosto;

                    int conteo = Convert.ToInt32(cmd.ExecuteScalar());
                    if (conteo > 0)
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }
    }
}
