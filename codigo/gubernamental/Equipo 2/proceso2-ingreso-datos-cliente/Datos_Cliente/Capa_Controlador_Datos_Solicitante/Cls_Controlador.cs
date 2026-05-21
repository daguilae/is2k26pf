/*
    Autor: Richard Anthony de León Milian
    Clase: Cls_Controlador
    Descripción: Controlador para probar la conexión a la BD
*/

using System;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Cls_Controlador
    {
        // =============================
        // Variable global (g)
        // =============================
        private Cls_Conexion gObjConexion;

        // =============================
        // Constructor
        // =============================
        public Cls_Controlador()
        {
            gObjConexion = new Cls_Conexion();
        }

        // =============================
        // Función para probar conexión
        // =============================
        public bool funProbarConexion(out string sMensaje)
        {
            bool bResultado = false;

            try
            {
                bResultado = gObjConexion.funAbrirConexion(out sMensaje);

                if (bResultado)
                {
                    // Cerramos inmediatamente después de probar
                    gObjConexion.funCerrarConexion(out string sCerrarMensaje);
                }

                return bResultado;
            }
            catch (Exception ex)
            {
                sMensaje = "Error en controlador: " + ex.Message;
                return false;
            }
        }

        private Cls_Sentencias gObjSentencias = new Cls_Sentencias();

        public bool funGuardarSolicitante(
            string sDpi,
            string sNombre,
            string sApellido,
            string sSexo,
            string sDepartamento,
            string sEstadoCivil,
            DateTime dtFechaNacimiento,
            out string sMensaje)
        {
            return gObjSentencias.funInsertarSolicitante(
                sDpi, sNombre, sApellido, sSexo,
                sDepartamento, sEstadoCivil,
                dtFechaNacimiento, out sMensaje);
        }
    }
}