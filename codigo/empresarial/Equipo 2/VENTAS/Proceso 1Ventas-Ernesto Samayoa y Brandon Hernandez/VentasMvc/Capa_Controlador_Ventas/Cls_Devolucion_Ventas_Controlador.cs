using System;
using System.Data;
using Capa_Modelo_Ventas;
using Capa_Controlador_Mov_Inv;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Controlador_Ventas
{
    public class Cls_Devolucion_Ventas_Controlador
    {
        private Cls_Devolucion_VentasDAO dao = new Cls_Devolucion_VentasDAO();
        //ID Devolucionventa
        public int ObtenerSiguienteIdDevolucionVenta()
        {
            return dao.ObtenerSiguienteIdDevolucionVenta();
        }
        //ID de venta con su fecha realizada
        public DataTable ObtenerVentas()
        {
            return dao.ObtenerVentas();
        }
        //Estado de la devolucion 
        public DataTable ObtenerEstado()
        {
            return dao.ObtenerEstado();
        }
        // Cliente por venta
        public DataTable ObtenerClientePorVenta(int iIdVenta)
        {
            return dao.ObtenerClientePorVenta(iIdVenta);
        }
        //Sucursal por venta
        public DataTable ObtenerSucursalPorVenta(int iIdVenta)
        {
            return dao.ObtenerSucursalPorVenta(iIdVenta);
        }
        //Productos de la venta asignadad
        public DataTable ObtenerProductosPorVenta(int iIdVenta)
        {
            return dao.ObtenerProductosPorVenta(iIdVenta);
        }
        //Bodegas por productos
        public DataTable ObtenerBodegaPorProducto(int ipk_inventario_id)
        {
            return dao.ObtenerBodegaPorProducto(ipk_inventario_id);
        }
        //Obtener la unidad de producto
        public DataTable ObtenerUnidadPorProducto(int ipk_inventario_id)
        {
            return dao.ObtenerUnidadPorProducto(ipk_inventario_id);
        }

        // ======================================================
        // CALCULAR SUBTOTAL
        // ======================================================
        public float CalcularSubtotal(float fPrecio,  float fCantidad, float fDescuento )
        {
            float subtotal = fPrecio * fCantidad;

            float descuentoAplicado =
                subtotal * fDescuento;

            return subtotal - descuentoAplicado;
        }

        // ======================================================
        // CALCULAR TOTAL GENERAL
        // ======================================================
        public float CalcularTotal(DataTable dtDetalle)
        {
            float total = 0;

            foreach (DataRow row in dtDetalle.Rows)
            {
                total += Convert.ToSingle(row["Subtotal"]);
            }

            return total;
        }

        public bool GuardarDevolucionCompleta(int iFk_Id_Venta, DateTime dFecha, string sMotivo, float fTotal, DataTable detalle)
        {
            return dao.GuardarDevolucionCompleta(iFk_Id_Venta, dFecha, sMotivo, fTotal, detalle);
        }


        //PARA VENTAS GENERALES
        public DataTable ObtenerListadoDevoluciones()
        {
            return dao.ObtenerListadoDevoluciones();
        }


    }
}
