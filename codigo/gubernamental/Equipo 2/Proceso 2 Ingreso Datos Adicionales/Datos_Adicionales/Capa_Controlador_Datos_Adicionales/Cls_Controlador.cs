/*
    Autor: Diego Andre Monterroso Rabarique
    Clase: Cls_Controlador_DatosAdicionales
    Descripción: Controlador para manejar datos adicionales del solicitante
*/

using System;
using Capa_Modelo_Datos_Adicionales;

namespace Capa_Controlador
{
    public class Cls_Controlador_DatosAdicionales
    {
        // =============================
        // Variable global (g)
        // =============================
        private Cls_Conexion gObjConexion;
        private Cls_Sentencias_DatosAdicionales gObjSentencias;

        // =============================
        // Constructor
        // =============================
        public Cls_Controlador_DatosAdicionales()
        {
            gObjConexion = new Cls_Conexion();
            gObjSentencias = new Cls_Sentencias_DatosAdicionales();
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

        // =============================
        // GUARDAR
        // =============================
        public bool funGuardarDatosAdicionales(
            int iSolicitanteId,
            int iTipoTramiteId,
            int iTipoAtencionId,
            string sDomicilio,
            int iCantidadPersonas,
            string sInformacionViaje,
            out string sMensaje)
        {
            return gObjSentencias.funInsertarDatosAdicionales(
                iSolicitanteId,
                iTipoTramiteId,
                iTipoAtencionId,
                sDomicilio,
                iCantidadPersonas,
                sInformacionViaje,
                out sMensaje);
        }

        // =============================
        // MODIFICAR
        // =============================
        public bool funModificarDatosAdicionales(
            int iDatosAdicionalesId,
            string sDomicilio,
            int iCantidadPersonas,
            out string sMensaje)
        {
            return gObjSentencias.funModificarDatosAdicionales(
                iDatosAdicionalesId,
                sDomicilio,
                iCantidadPersonas,
                out sMensaje);
        }

        // =============================
        // ELIMINAR
        // =============================
        public bool funEliminarDatosAdicionales(
            int iDatosAdicionalesId,
            out string sMensaje)
        {
            return gObjSentencias.funEliminarDatosAdicionales(
                iDatosAdicionalesId,
                out sMensaje);
        }
    }
}