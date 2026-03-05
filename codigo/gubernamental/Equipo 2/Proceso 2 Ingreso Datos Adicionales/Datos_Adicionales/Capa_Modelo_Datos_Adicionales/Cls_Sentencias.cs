using System;
using System.Data.Odbc;

namespace Capa_Modelo_Datos_Adicionales
{
    public class Cls_Sentencias_DatosAdicionales
    {
        private Cls_Conexion gObjConexion = new Cls_Conexion();

        // INSERTAR
        public bool funInsertarDatosAdicionales(
            int iSolicitanteId,
            int iTipoTramiteId,
            int iTipoAtencionId,
            string sDomicilio,
            int iCantidadPersonas,
            string sInformacionViaje,
            out string sMensaje)
        {
            sMensaje = "";

            if (!gObjConexion.funAbrirConexion(out sMensaje))
                return false;

            try
            {
                string sSql = @"INSERT INTO tbl_datos_adicionales_solicitante
                                (fk_solicitante_id,
                                 fk_tipo_tramite_id,
                                 fk_tipo_atencion_id,
                                 Cmp_Domicilio,
                                 Cmp_Cantidad_Personas,
                                 Cmp_Informacion_Viaje)
                                VALUES (?, ?, ?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(sSql, gObjConexion.funObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("p1", iSolicitanteId);
                    cmd.Parameters.AddWithValue("p2", iTipoTramiteId);
                    cmd.Parameters.AddWithValue("p3", iTipoAtencionId);
                    cmd.Parameters.AddWithValue("p4", sDomicilio);
                    cmd.Parameters.AddWithValue("p5", iCantidadPersonas);
                    cmd.Parameters.AddWithValue("p6", sInformacionViaje);

                    int iFilas = cmd.ExecuteNonQuery();

                    if (iFilas > 0)
                    {
                        sMensaje = "Datos adicionales guardados correctamente.";
                        return true;
                    }
                }

                sMensaje = "No se pudo insertar el registro.";
                return false;
            }
            catch (Exception ex)
            {
                sMensaje = "Error al insertar: " + ex.Message;
                return false;
            }
            finally
            {
                gObjConexion.funCerrarConexion(out _);
            }
        }

        // MODIFICAR
        public bool funModificarDatosAdicionales(
            int iDatosAdicionalesId,
            string sDomicilio,
            int iCantidadPersonas,
            out string sMensaje)
        {
            sMensaje = "";

            if (!gObjConexion.funAbrirConexion(out sMensaje))
                return false;

            try
            {
                string sSql = @"UPDATE tbl_datos_adicionales_solicitante
                                SET Cmp_Domicilio = ?,
                                    Cmp_Cantidad_Personas = ?
                                WHERE pk_datos_adicionales_id = ?";

                using (OdbcCommand cmd = new OdbcCommand(sSql, gObjConexion.funObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("p1", sDomicilio);
                    cmd.Parameters.AddWithValue("p2", iCantidadPersonas);
                    cmd.Parameters.AddWithValue("p3", iDatosAdicionalesId);

                    int iFilas = cmd.ExecuteNonQuery();

                    if (iFilas > 0)
                    {
                        sMensaje = "Registro modificado correctamente.";
                        return true;
                    }
                }

                sMensaje = "No se pudo modificar.";
                return false;
            }
            catch (Exception ex)
            {
                sMensaje = "Error al modificar: " + ex.Message;
                return false;
            }
            finally
            {
                gObjConexion.funCerrarConexion(out _);
            }
        }

        // ELIMINAR
        public bool funEliminarDatosAdicionales(
            int iDatosAdicionalesId,
            out string sMensaje)
        {
            sMensaje = "";

            if (!gObjConexion.funAbrirConexion(out sMensaje))
                return false;

            try
            {
                string sSql = @"DELETE FROM tbl_datos_adicionales_solicitante
                                WHERE pk_datos_adicionales_id = ?";

                using (OdbcCommand cmd = new OdbcCommand(sSql, gObjConexion.funObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("p1", iDatosAdicionalesId);

                    int iFilas = cmd.ExecuteNonQuery();

                    if (iFilas > 0)
                    {
                        sMensaje = "Registro eliminado correctamente.";
                        return true;
                    }
                }

                sMensaje = "No se pudo eliminar.";
                return false;
            }
            catch (Exception ex)
            {
                sMensaje = "Error al eliminar: " + ex.Message;
                return false;
            }
            finally
            {
                gObjConexion.funCerrarConexion(out _);
            }
        }
    }
}