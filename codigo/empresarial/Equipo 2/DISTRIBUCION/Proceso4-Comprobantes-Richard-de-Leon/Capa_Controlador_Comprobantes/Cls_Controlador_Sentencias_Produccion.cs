using System;
using System.Data;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Cls_Controlador_Sentencias_Produccion
    {
        Cls_Sentencias_Comprobante_Produccion modelo = new Cls_Sentencias_Comprobante_Produccion();

        public bool InsertarComprobante(
            int fkIdEntregaProduccion,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            return modelo.InsertarComprobanteProduccion(
                fkIdEntregaProduccion,
                fkIdCliente,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
        }

        public bool ActualizarComprobante(
            int pkIdComprobante,
            int fkIdEntregaProduccion,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            return modelo.ActualizarComprobanteProduccion(
                pkIdComprobante,
                fkIdEntregaProduccion,
                fkIdCliente,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
        }

        public bool EliminarComprobante(int pkIdComprobante)
        {
            return modelo.EliminarComprobanteProduccion(pkIdComprobante);
        }

        public DataTable MostrarComprobantes()
        {
            return modelo.MostrarComprobantesProduccion();
        }

        public DataTable BuscarComprobante(int pkIdComprobante)
        {
            return modelo.BuscarComprobanteProduccion(pkIdComprobante);
        }

        public DataTable fun_ObtenerIdComprobanteProduccion()
        {
            return modelo.fun_ObtenerIdComprobanteProduccion();
        }

        public DataTable fun_ObtenerIdEntregaProduccion()
        {
            return modelo.fun_ObtenerIdEntregaProduccion();
        }

        public DataTable fun_ObtenerIdCliente()
        {
            return modelo.fun_ObtenerIdCliente();
        }

        public DataTable Fun_Obtener_Detalle_Entrega_Produccion(int I_Id_Entrega_Produccion)
        {
            return modelo.Fun_Obtener_Detalle_Entrega_Produccion(I_Id_Entrega_Produccion);
        }

        public bool Fun_Eliminar_Comprobante_Produccion(int I_Id_Comprobante_Produccion)
        {
            return modelo.EliminarComprobanteProduccion(I_Id_Comprobante_Produccion);
        }
        public bool Fun_Actualizar_Estado_Entrega_Produccion(int I_Id_Entrega_Produccion, string S_Estado)
        {
            return modelo.Fun_Actualizar_Estado_Entrega_Produccion(I_Id_Entrega_Produccion, S_Estado);
        }
    }
}