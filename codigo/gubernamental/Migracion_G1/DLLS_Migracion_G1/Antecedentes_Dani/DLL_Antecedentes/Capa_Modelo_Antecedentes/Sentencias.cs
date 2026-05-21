using System;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_Antecedentes
{
    public class Ciudadano
    {
        public int IdCiudadano { get; set; }
        public string NombreCompleto { get; set; }
    }

    public class Sentencias
    {
        Conexion con = new Conexion();

        public void insertarAntecedente(string fecha, string tipo, int estado, string desc, int idCiudadano)
        {
            string cadena = "INSERT INTO Tbl_Antecedentes (Fecha_Antecedente, Cmp_Tipo_Antecedente, Cmp_Estado_Antecedente, Cmp_Descripcion_Antecedente, Fk_Id_Ciudadano) " +
                            "VALUES ('" + fecha + "', '" + tipo + "', " + estado + ", '" + desc + "', " + idCiudadano + ");";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Sentencias: " + ex.Message);
            }
        }



        public void eliminarAntecedentePorCiudadano(int idCiudadano)
        {
            string cadena = "DELETE FROM Tbl_Antecedentes WHERE Fk_Id_Ciudadano = " + idCiudadano + ";";

            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar: " + ex.Message);
            }
        }

        public OdbcDataReader buscarAntecedente(int idCiudadano)
        {
            string cadena = "SELECT Cmp_Tipo_Antecedente, Cmp_Estado_Antecedente, Cmp_Descripcion_Antecedente, Fecha_Antecedente " +
                            "FROM Tbl_Antecedentes WHERE Fk_Id_Ciudadano = " + idCiudadano + " LIMIT 1;";

            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
                return consulta.ExecuteReader(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Modelo: " + ex.Message);
                return null;
            }
        }

        public DataTable obtenerCiudadanos()
        {
            string cadena = "SELECT Pk_Id_Ciudadano, CONCAT(Cmp_Nombres_Ciudadano, ' ', Cmp_Apellidos_Ciudadano) AS NombreCompleto FROM Tbl_Ciudadano;";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con.conexion());
            DataTable dt = new DataTable();
            try
            {
                datos.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        // Método para Modificar
        public void modificarAntecedente(string fecha, string tipo, int estado, string desc, int idCiudadano)
        {
            string cadena = "UPDATE Tbl_Antecedentes SET Fecha_Antecedente='" + fecha + "', Cmp_Tipo_Antecedente='" + tipo + "', " +
                            "Cmp_Estado_Antecedente=" + estado + ", Cmp_Descripcion_Antecedente='" + desc + "' " +
                            "WHERE Fk_Id_Ciudadano = " + idCiudadano + ";";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("Error al modificar: " + ex.Message); }
        }

    }
}