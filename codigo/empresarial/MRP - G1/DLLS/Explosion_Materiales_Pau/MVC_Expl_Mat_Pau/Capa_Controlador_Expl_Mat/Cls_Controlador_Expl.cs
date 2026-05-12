using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Expl_Mat;

namespace Capa_Controlador_Expl_Mat
{
    public class Cls_Controlador_Expl
    {
        // PAULA DANIELA LEONARDO PAREDES  0901-22-9580
        private readonly Cls_Sentencias_Expl_e_Impl sentencias
                       = new Cls_Sentencias_Expl_e_Impl();

        // Arón Ricardo Esquit Silva 0901-22-13036 11/05/2026
        private readonly Cls_Api_OrdenMaterial apiOrdenMaterial = new Cls_Api_OrdenMaterial();

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

        public bool EliminarExplosion(int idExplosion)
        {
            return sentencias.EliminarExplosion(idExplosion);
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

        public int GuardarExplosion(int idOrden)
        {
            return sentenciasDetalle.GuardarExplosion(idOrden);
        }

        public bool GuardarDetalleExplosion(int idExplosion, DataTable detalle)
        {
            return sentenciasDetalle.GuardarDetalleExplosion(idExplosion, detalle);
        }

        // PAULA DANIELA LEONARDO PAREDES  0901-22-9580






        //DANIELA SALGUERO
        public DataTable ObtenerImplosion(int idOrden)
        {
            return sentencias.ObtenerDetalleExplosion(idOrden);
        }

        public bool GenerarOrdenMaterial(int idOrden, DataTable faltantes)
        {
            return sentencias.GuardarOrdenMaterial(idOrden, faltantes);
        }

        public bool OrdenYaGenerada(int idOrden)
        {
            return sentencias.OrdenYaGenerada(idOrden);
        }

        //DANIELA SALGUERO

        // Arón Ricardo Esquit Silva 0901-22-13036 11/05/2026
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

                // Cambio en caso de que no envie a logística 
                RespuestaApiOrdenMaterial respuesta = apiOrdenMaterial.EnviarOrdenMaterial(ordenApi);

                if (respuesta.Exitoso)
                {
                    sentencias.ActualizarEstadoOrdenMaterialEnviado(idOrdenMaterial);
                }

                respuesta.IdOrdenMaterial = idOrdenMaterial;
                return respuesta;

            }
            catch (Exception ex)
            {
                return new RespuestaApiOrdenMaterial
                {
                    Exitoso = false,
                    Mensaje = ex.Message
                };
            }
        }
    }
}