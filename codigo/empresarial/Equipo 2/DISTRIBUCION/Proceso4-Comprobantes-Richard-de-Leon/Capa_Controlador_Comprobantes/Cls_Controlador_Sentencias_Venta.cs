using System;
using System.Data;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Cls_Controlador_Sentencias_Venta
    {
        Cls_Sentencias_Comprobante_Venta modelo = new Cls_Sentencias_Comprobante_Venta();

        public bool InsertarComprobante(
            int fkIdEntregaVenta,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            return modelo.InsertarComprobanteVenta(
                fkIdEntregaVenta,
                fkIdCliente,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
        }

        public bool ActualizarComprobante(
            int pkIdComprobante,
            int fkIdEntregaVenta,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            return modelo.ActualizarComprobanteVenta(
                pkIdComprobante,
                fkIdEntregaVenta,
                fkIdCliente,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
        }

        public bool EliminarComprobante(int pkIdComprobante)
        {
            return modelo.EliminarComprobanteVenta(pkIdComprobante);
        }

        public DataTable MostrarComprobantes()
        {
            return modelo.MostrarComprobantesVenta();
        }

        public DataTable BuscarComprobante(int pkIdComprobante)
        {
            return modelo.BuscarComprobanteVenta(pkIdComprobante);
        }

        public DataTable fun_ObtenerIdComprobanteVenta()
        {
            return modelo.fun_ObtenerIdComprobanteVenta();
        }

        public DataTable fun_ObtenerIdEntregaVenta()
        {
            return modelo.fun_ObtenerIdEntregaVenta();
        }

        public DataTable fun_ObtenerIdCliente()
        {
            return modelo.fun_ObtenerIdCliente();
        }

        public DataTable Fun_Obtener_Detalle_Entrega_Venta(int I_Id_Entrega_Venta)
        {
            return modelo.Fun_Obtener_Detalle_Entrega_Venta(I_Id_Entrega_Venta);
        }

        public bool Fun_Eliminar_Comprobante_Venta(int I_Id_Comprobante_Venta)
        {
            return modelo.EliminarComprobanteVenta(I_Id_Comprobante_Venta);
        }

        public bool Fun_Actualizar_Estado_Entrega_Venta(int I_Id_Entrega_Venta, string S_Estado)
        {
            return modelo.Fun_Actualizar_Estado_Entrega_Venta(I_Id_Entrega_Venta, S_Estado);
        }
    }
}