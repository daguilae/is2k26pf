/*
    Autor: Richard Anthony de León Milian 0901-22-10245
    Clase: Cls_Conexion
    Descripción: Manejo de conexión ODBC por DSN "bd_migracion"
*/

using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Cls_Conexion
    {
        // ============================
        // Variables globales (g)
        // ============================
        private OdbcConnection gConOdbc = null;

        // ============================
        // Constante DSN
        // ============================
        private const string gSNombreDsn = "bd_migracion";

        // ============================
        // Función: Abrir Conexión
        // ============================
        public bool funAbrirConexion(out string sMensaje)
        {
            sMensaje = "";

            try
            {
                // Validar si ya está abierta
                if (gConOdbc != null && gConOdbc.State == ConnectionState.Open)
                {
                    sMensaje = "La conexión ya está abierta.";
                    return true;
                }

                // Cadena de conexión usando DSN manual
                string sCadenaConexion = $"DSN={gSNombreDsn};";

                gConOdbc = new OdbcConnection(sCadenaConexion);
                gConOdbc.Open();

                sMensaje = "Conexión exitosa a la base de datos.";
                return true;
            }
            catch (OdbcException ex)
            {
                sMensaje = "Error ODBC al conectar: " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                sMensaje = "Error general al conectar: " + ex.Message;
                return false;
            }
        }

        // ============================
        // Función: Cerrar Conexión
        // ============================
        public bool funCerrarConexion(out string sMensaje)
        {
            sMensaje = "";

            try
            {
                if (gConOdbc != null && gConOdbc.State != ConnectionState.Closed)
                {
                    gConOdbc.Close();
                    gConOdbc.Dispose();
                    gConOdbc = null;

                    sMensaje = "Conexión cerrada correctamente.";
                    return true;
                }

                sMensaje = "No hay conexión abierta.";
                return false;
            }
            catch (Exception ex)
            {
                sMensaje = "Error al cerrar conexión: " + ex.Message;
                return false;
            }
        }

        // ============================
        // Función: Validar Estado
        // ============================
        public bool funEstadoConexion()
        {
            if (gConOdbc != null && gConOdbc.State == ConnectionState.Open)
                return true;

            return false;
        }
        // ============================
        // Función: Obtener conexión abierta
        // ============================
        public OdbcConnection funObtenerConexion()
        {
            return gConOdbc;
        }
    }
}