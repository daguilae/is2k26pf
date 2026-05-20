using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Prod;
using Capa_Controlador_Seguridad;


namespace Capa_Controlador_Prod
{
    public class Cls_Controlador_Prod
    {
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();
        private int idAplicacion = 737; 

        private readonly Cls_Sentencias_Prod sentencias = new Cls_Sentencias_Prod();
        private readonly Cls_Sentencias_Prod sentenciasDetalle = new Cls_Sentencias_Prod();
        private readonly Cls_Sentencias_CI sentenciasCI = new Cls_Sentencias_CI();
        private readonly Cls_Sentencias_Materiales sentenciasM = new Cls_Sentencias_Materiales();
        private readonly Cls_Sentencias_Merma sentenciasMerma = new Cls_Sentencias_Merma();

        public DataTable ObtenerOrdenesProduccion()
        {
            return sentencias.ObtenerOrdenesProduccion();
        }

        public DataTable ObtenerManoObra(int idOrden)
        {
            return sentencias.ObtenerManoObra(idOrden);
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool GuardarManoObra(int idOrden, int idEmpleado, decimal horas, decimal costoHora)
        {
            bool resultado = sentencias.GuardarManoObra(idOrden, idEmpleado, horas, costoHora);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    idAplicacion,
                    $"Registró mano de obra del empleado '{idEmpleado}' en la orden de producción '{idOrden}'",
                    true
                );
            }

            return resultado;
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool EliminarManoObra(int idManoObra)
        {
            bool resultado = sentencias.EliminarManoObra(idManoObra);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    idAplicacion,
                    $"Eliminó el registro de mano de obra '{idManoObra}'",
                    true
                );
            }

            return resultado;
        }

        public DataTable ObtenerCostosProduccion(int idOrden)
        {
            return sentencias.ObtenerCostosProduccion(idOrden);
        }
        public DataTable ObtenerEmpleados()
        {
            return sentencias.ObtenerEmpleados();
        }

        public DataTable ObtenerCostosIndirectos(int idOrden)
        {
            return sentenciasCI.ObtenerCostosIndirectos(idOrden);
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool GuardarCostoIndirecto(int idOrden, string concepto, decimal monto, string descripcion)
        {
            bool resultado = sentenciasCI.GuardarCostoIndirecto(idOrden, concepto, monto, descripcion);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    idAplicacion,
                    $"Registró costo indirecto '{concepto}' por Q{monto} en la orden de producción '{idOrden}'",
                    true
                );
            }

            return resultado;
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool EliminarCostoIndirecto(int idCosto)
        {
            bool resultado = sentenciasCI.EliminarCostoIndirecto(idCosto);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    idAplicacion,
                    $"Eliminó el costo indirecto '{idCosto}'",
                    true
                );
            }

            return resultado;
        }

        public DataTable ObtenerMaterialesConsumidos(int idOrden)
        {
            return sentenciasM.ObtenerMaterialesConsumidos(idOrden);
        }
        public int ObtenerOrdenRecibidaPorOrdenProduccion(int idOrdenProduccion)
        {
            return sentencias.ObtenerOrdenRecibidaPorOrdenProduccion(idOrdenProduccion);
        }



        // Empieza codigo hecho por: Maria Morales 0901-22-1226

        // ---------------------- MERMAS ------------------------------

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool DescontarMateriales(int idOrden)
        {
            bool resultado = sentenciasM.DescontarMateriales(idOrden);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    idAplicacion,
                    $"Descontó materiales de inventario para la orden de producción '{idOrden}'",
                    true
                );
            }

            return resultado;
        }

        public DataTable ObtenerTiposMerma()
        {
            return sentenciasMerma.ObtenerTiposMerma();
        }

        public DataTable ObtenerMaterialesPorOrden(int idOrden)
        {
            return sentenciasMerma.ObtenerMaterialesPorOrden(idOrden);
        }

        public DataTable ObtenerMermas(int idOrden)
        {
            return sentenciasMerma.ObtenerMermas(idOrden);
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool GuardarMerma(int idOrden, int idMaterial, int idTipo,
                          decimal cantidad, string motivo)
        {
            bool resultado = sentenciasMerma.GuardarMerma(idOrden, idMaterial, idTipo, cantidad, motivo);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    idAplicacion,
                    $"Registró merma del material '{idMaterial}' en la orden '{idOrden}' por cantidad '{cantidad}'. Motivo: {motivo}",
                    true
                );
            }

            return resultado;
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public bool EliminarMerma(int idMerma)
        {
            bool resultado = sentenciasMerma.EliminarMerma(idMerma);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    idAplicacion,
                    $"Eliminó la merma '{idMerma}'",
                    true
                );
            }

            return resultado;
        }

        // Termina codigo hecho por: Maria Morales 0901-22-1226
    }
}
