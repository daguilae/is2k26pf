using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace Capa_Modelo_Antecedentes
{
    public class CiudadanoDAO
    {
        Conexion cn = new Conexion();

        public List<Ciudadano> ObtenerCiudadanos()
        {
            List<Ciudadano> lista = new List<Ciudadano>();

            OdbcConnection conn = cn.conexion();

            string query = @"SELECT 
                             Pk_Id_Ciudadano, 
                             CONCAT(Cmp_Nombres_Ciudadano, ' ', Cmp_Apellidos_Ciudadano) AS NombreCompleto
                             FROM Tbl_Ciudadano";

            OdbcCommand cmd = new OdbcCommand(query, conn);
            OdbcDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Ciudadano c = new Ciudadano();
                c.IdCiudadano = reader.GetInt32(0);
                c.NombreCompleto = reader.GetString(1);

                lista.Add(c);
            }

            cn.desconexion(conn);

            return lista;
        }
    }
}