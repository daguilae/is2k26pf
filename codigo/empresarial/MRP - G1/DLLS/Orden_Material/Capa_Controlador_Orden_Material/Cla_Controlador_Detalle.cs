using System;
using System.Data;
using Capa_Modelo_Orden_Material;

namespace Capa_Controlador_Orden_Material
{
    // ------ LETICIA SONTAY - 9959-21-9664, 07/05/2026 --------
    public class Cls_Controlador_Orden_Material
    {
        private readonly Cls_Sentencias_Detalle_Orden_Material _modelo
            = new Cls_Sentencias_Detalle_Orden_Material();

        public DataTable ObtenerOrdenesCombo()
        {
            return _modelo.ObtenerOrdenesCombo();
        }

        public DataTable ObtenerOrdenPorId(int idOrden)
        {
            return _modelo.ObtenerOrdenPorId(idOrden);
        }

        public DataTable ObtenerDetalleOrden(int idOrden)
        {
            return _modelo.ObtenerDetalleOrden(idOrden);
        }

        public DataTable ObtenerEstadosOrden()
        {
            return _modelo.ObtenerEstadosOrden();
        }

        public bool ModificarOrden(int idOrden, int idEstado, DateTime? fechaRecibida)
        {
            return _modelo.ModificarOrden(idOrden, idEstado, fechaRecibida);
        }
    }
    // ------ LETICIA SONTAY - 9959-21-9664, 07/05/2026 --------
}