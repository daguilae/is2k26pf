using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Expl_Mat;
using Capa_Controlador_Seguridad;

namespace Capa_Controlador_Expl_Mat
{
    public class Cls_Controlador_Expl
    {

        // PAULA DANIELA LEONARDO PAREDES  0901-22-9580
        private readonly Cls_Sentencias_Expl_e_Impl sentencias
                       = new Cls_Sentencias_Expl_e_Impl();

        // Arón Ricardo Esquit Silva 0901-22-13036 11/05/2026
        private readonly Cls_Api_OrdenMaterial apiOrdenMaterial = new Cls_Api_OrdenMaterial();

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();

        public DataTable ObtenerExplosiones()
        {
            return sentencias.ObtenerExplosiones();
        }

        public DataTable ObtenerDetalleExplosionPorId(int idExplosion)
        {
            return sentenciasDetalle.ObtenerDetalleExplosionPorId(idExplosion);
        }

        public DataTable ObtenerExplosionPorId(int idExplosion)
        {
            return sentenciasDetalle.ObtenerExplosionPorId(idExplosion);
        }

        public DataTable FiltrarPorId(string idExplosion)
        {
            return sentencias.FiltrarPorId(idExplosion);
        }

        public DataTable FiltrarPorFechas(string fechaInicio, string fechaFin)
        {
            return sentencias.FiltrarPorFechas(fechaInicio, fechaFin);
        }

        public DataTable FiltrarPorNombre(string nombreOrden)
        {
            return sentencias.FiltrarPorNombre(nombreOrden);
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool EliminarExplosion(int idExplosion)
        {
            bool resultado = sentencias.EliminarExplosion(idExplosion);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    734,
                    $"Eliminó la explosión de materiales con ID '{idExplosion}'",
                    true
                );
            }

            return resultado;
        }

        private readonly Cls_Sentencias_Expl sentenciasDetalle
                       = new Cls_Sentencias_Expl();

        public DataTable ObtenerOrdenesRecibidas()
        {
            return sentenciasDetalle.ObtenerOrdenesRecibidas();
        }

        public DataTable ObtenerInfoOrdenRecibida(int idOrden)
        {
            return sentenciasDetalle.ObtenerInfoOrdenRecibida(idOrden);
        }

        public DataTable ObtenerProductosOrdenRecibida(int idOrden)
        {
            return sentenciasDetalle.ObtenerProductosOrdenRecibida(idOrden);
        }

        public DataTable ObtenerBOMParaExplosion(int idOrden)
        {
            return sentenciasDetalle.ObtenerBOMParaExplosion(idOrden);
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public int GuardarExplosion(int idOrden)
        {
            int idExplosion = sentenciasDetalle.GuardarExplosion(idOrden);

            if (idExplosion > 0)
            {
                gCtrlBitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    734,
                    $"Generó una explosión de materiales para la orden '{idOrden}'",
                    true
                );
            }

            return idExplosion;
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool GuardarDetalleExplosion(int idExplosion, DataTable detalle)
        {
            bool resultado = sentenciasDetalle.GuardarDetalleExplosion(idExplosion, detalle);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    735,
                    $"Registró detalle de materiales para la explosión '{idExplosion}'",
                    true
                );
            }

            return resultado;
        }

        // PAULA DANIELA LEONARDO PAREDES  0901-22-9580






        //DANIELA SALGUERO
        public DataTable ObtenerImplosion(int idOrden)
        {
            return sentencias.ObtenerDetalleExplosion(idOrden);
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool GenerarOrdenMaterial(int idOrden, DataTable faltantes)
        {
            bool resultado = sentencias.GuardarOrdenMaterial(idOrden, faltantes);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    732,
                    $"Generó orden de material desde implosión para la orden '{idOrden}'",
                    true
                );
            }

            return resultado;
        }

        public bool OrdenYaGenerada(int idOrden)
        {
            return sentencias.OrdenYaGenerada(idOrden);
        }

        //DANIELA SALGUERO

        // Arón Ricardo Esquit Silva 0901-22-13036 17/05/2026
        public RespuestaApiOrdenMaterial GenerarYEnviarOrdenMaterialApi(int idOrden, DataTable faltantes)
        {
            try
            {
                int idOrdenMaterial = sentencias.GuardarOrdenMaterialApi(idOrden, faltantes);

                if (idOrdenMaterial <= 0)
                {
                    return new RespuestaApiOrdenMaterial
                    {
                        Exitoso = false,
                        Mensaje = "No se pudo guardar la orden de material."
                    };
                }

                gCtrlBitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    732,
                    $"Generó la orden de material '{idOrdenMaterial}' desde la orden '{idOrden}'",
                    true
                );

                OrdenMaterialApi ordenApi = new OrdenMaterialApi
                {
                    idOrdenMaterial = idOrdenMaterial,
                    fechaSolicitud = DateTime.Now,
                    detalle = new List<DetalleOrdenMaterialApi>()
                };

                foreach (DataRow row in faltantes.Rows)
                {
                    decimal faltante = Convert.ToDecimal(row["Faltante"]);
                    if (faltante <= 0) continue;

                    ordenApi.detalle.Add(new DetalleOrdenMaterialApi
                    {
                        nombreMaterial = row["Material"].ToString(),
                        cantidadSolicitada = faltante
                    });
                }

                if (ordenApi.detalle.Count == 0)
                {
                    return new RespuestaApiOrdenMaterial
                    {
                        Exitoso = false,
                        Mensaje = "No hay materiales faltantes para enviar a Logística."
                    };
                }

                RespuestaApiOrdenMaterial respuesta = apiOrdenMaterial.EnviarOrdenMaterial(ordenApi);

                if (respuesta.Exitoso)
                {
                    sentencias.ActualizarEstadoOrdenMaterialEnviado(idOrdenMaterial);

                    gCtrlBitacora.RegistrarAccion(
                        Cls_Usuario_Conectado.iIdUsuario,
                        732,
                        $"Envió la orden de material '{idOrdenMaterial}' a Logística por API",
                        true
                    );
                }
                else
                {
                    gCtrlBitacora.RegistrarAccion(
                        Cls_Usuario_Conectado.iIdUsuario,
                        732,
                        $"No se pudo enviar la orden de material '{idOrdenMaterial}' a Logística por API. Motivo: {respuesta.Mensaje}",
                        false
                    );
                }

                respuesta.IdOrdenMaterial = idOrdenMaterial;
                return respuesta;
            }
            catch (Exception ex)
            {
                gCtrlBitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    732,
                    $"Error al generar o enviar orden de material por API desde la orden '{idOrden}'. Error: {ex.Message}",
                    false
                );

                return new RespuestaApiOrdenMaterial
                {
                    Exitoso = false,
                    Mensaje = ex.Message
                };
            }
        }
    }
}