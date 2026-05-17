using System;
using System.Data;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Cls_Controlador_Sentencias
    {
        Cls_Sentencias_Comprobante_Compra modelo = new Cls_Sentencias_Comprobante_Compra();

        public bool InsertarComprobante(
            int fkIdEntregaCompra,
            int fkIdProveedor,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            return modelo.InsertarComprobanteCompra(
                fkIdEntregaCompra,
                fkIdProveedor,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
        }

        public bool ActualizarComprobante(
            int pkIdComprobante,
            int fkIdEntregaCompra,
            int fkIdProveedor,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            return modelo.ActualizarComprobanteCompra(
                pkIdComprobante,
                fkIdEntregaCompra,
                fkIdProveedor,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
        }

        public bool EliminarComprobante(int pkIdComprobante)
        {
            return modelo.EliminarComprobanteCompra(pkIdComprobante);
        }

        public DataTable MostrarComprobantes()
        {
            return modelo.MostrarComprobantesCompra();
        }

        public DataTable BuscarComprobante(int pkIdComprobante)
        {
            return modelo.BuscarComprobanteCompra(pkIdComprobante);
        }

        public DataTable fun_ObtenerIdComprobanteCompra()
        {
            return modelo.fun_ObtenerIdComprobanteCompra();
        }

        public DataTable fun_ObtenerIdEntregaCompra()
        {
            return modelo.fun_ObtenerIdEntregaCompra();
        }

        public DataTable fun_ObtenerIdProveedor()
        {
            return modelo.fun_ObtenerIdProveedor();
        }

        public DataTable Fun_Obtener_Detalle_Entrega_Compra(int I_Id_Entrega_Compra)
        {
            return modelo.Fun_Obtener_Detalle_Entrega_Compra(I_Id_Entrega_Compra);
        }

        public bool Fun_Eliminar_Comprobante_Compra(int I_Id_Comprobante_Compra)
        {
            return modelo.Fun_Eliminar_Comprobante_Compra(I_Id_Comprobante_Compra);
        }
    }
}