using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_RO;
using Capa_Controlador_Seguridad;
using Capa_Modelo_Seguridad;

namespace Capa_Controlador_RO
{
    public class Cls_Controlador_Orden
    {

        private Cls_Sentencias modelo = new Cls_Sentencias();
        private Cls_Consultas_Ordenes _modelo = new Cls_Consultas_Ordenes();
        private Cls_Sentencias_Detalle detalle = new Cls_Sentencias_Detalle();

        // Arón Ricardo Esquit - 0901-22-13036 - 04/05/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();


        // ------ KEVIN NATARENO - 0901-21-635, 28/04/2026 --------
        public DataTable ObtenerOrdenes()
        {
            return modelo.ObtenerOrdenes();
        }
        public DataTable ObtenerEstados()
        {
            return modelo.ObtenerEstados();
        }

        public DataTable FiltrarOrdenes(string idExterno, int idEstado)
        {
            return modelo.FiltrarOrdenes(idExterno, idEstado);
        }
        // ------ KEVIN NATARENO - 0901-21-635, 28/04/2026 --------

        // ------ LETICIA SONTAY - 9959-21-9664, 28/04/2026 --------
        public DataTable ObtenerOrdenesCombo()
        {
            return detalle.ObtenerOrdenesCombo();
        }

        public DataTable ObtenerDetalleOrden(int idOrden)
        {
            return detalle.ObtenerDetalleOrden(idOrden);
        }

        public DataTable ObtenerOrdenPorId(int idOrden)
        {
            return detalle.ObtenerOrdenPorId(idOrden);
        }

        public DataTable ObtenerEstadosOrden()
        {
            return detalle.ObtenerEstadosOrden();
        }
        // ------ LETICIA SONTAY - 9959-21-9664, 28/04/2026 --------



        // ------ PAULA DANIELA LEONARDO - 0901-22-9580, 28/04/2026 --------
        public DataTable ObtenerMateriales()
        {
            return detalle.ObtenerMateriales();
        }

        public DataTable ObtenerMaterialPorId(int idMaterial)
        {
            return detalle.ObtenerMaterialPorId(idMaterial);
        }

        public DataTable ObtenerMaterialPorCodigo(string codigoMaterial)
        {
            return detalle.ObtenerMaterialPorCodigo(codigoMaterial);
        }

        public DataTable ObtenerMaterialPorNombre(string nombreMaterial)
        {
            return detalle.ObtenerMaterialPorNombre(nombreMaterial);
        }
        // ------ PAULA DANIELA LEONARDO - 0901-22-9580, 28/04/2026 --------

        // Arón Ricardo Esquit - 0901-22-13036 - 04/05/26
        public bool GuardarOrdenCompleta(string idLog, int estado, DateTime req, string obs, DataTable detalle)
        {
            bool resultado = _modelo.GuardarOrden(idLog, estado, req, obs, detalle);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    731,
                    $"Registró una nueva orden recibida con ID externo '{idLog}'",
                    true
                );
            }

            return resultado;
        }

        // Método para modificar
        // Arón Ricardo Esquit - 0901-22-13036 - 04/05/26
        public bool ActualizarOrden(int pk, string idLog, int estado, DateTime req, string obs)
        {
            bool resultado = _modelo.ModificarOrden(pk, idLog, estado, req, obs);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    731,
                    $"Modificó la orden recibida con ID interno '{pk}' y ID externo '{idLog}'",
                    true
                );
            }

            return resultado;
        }
        // Método para eliminar
        // Arón Ricardo Esquit - 0901-22-13036 - 04/05/26
        public bool BorrarOrden(int pk)
        {
            bool resultado = _modelo.EliminarOrden(pk);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    731,
                    $"Eliminó la orden recibida con ID interno '{pk}'",
                    true
                );
            }

            return resultado;
        }

        public int ObtenerIdPorCodigo(string codigo)
        {
            return 1; 
        }

        // Arón Ricardo Esquit - 0901-22-13036 - 30/04/26
        // Arón Ricardo Esquit - 0901-22-13036 - 04/05/26
        public bool GuardarDetalleOrden(int idOrden, DataTable detalle)
        {
            bool resultado = _modelo.GuardarDetalleOrden(idOrden, detalle);

            if (resultado)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    731,
                    $"Agregó materiales al detalle de la orden recibida con ID interno '{idOrden}'",
                    true
                );
            }

            return resultado;
        }

        // Arón Ricardo Esquit - 0901-22-13036 - 01/05/26
        public DataTable FiltrarOrdenesPorFecha(string fechaInicio, string fechaFin)
        {
            return modelo.FiltrarOrdenesPorFecha(fechaInicio, fechaFin);
        }

        // Arón Ricardo Esquit - 0901-22-13036 - 04/05/26
        public (bool ingresar, bool consultar, bool modificar, bool eliminar, bool imprimir)? ObtenerPermisosOrden(int idAplicacion, int idModulo)
        {
            Cls_Permiso_Usuario_Controlador ctrlPermisos = new Cls_Permiso_Usuario_Controlador();

            return ctrlPermisos.ConsultarPermisos(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                idModulo
            );
        }

    }
}
