using System;
using System.Data;
using Capa_Modelo_Ventas;
using Capa_Controlador_Mov_Inv;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Controlador_Ventas
{
    public class Cls_Ventas_Controlador
    {
        private Cls_VentasDAO dao = new Cls_VentasDAO();
        //OBTENER CLIENTES (COMBOBOX)
        public DataTable ObtenerClientes()
        {
            return dao.ObtenerClientes();
        }
        //OBTENER SUCURSALES (COMBOBOX)
        public DataTable ObtenerSucursales()
        {
            return dao.ObtenerSucursales();
        }
        //OBTENER INVENTARIO (COMBOBOX)
        public DataTable ObtenerInventario()
        {
            return dao.ObtenerInventario();
        }
        //OBTENER BODEGAS (COMBOBOX)
        public DataTable ObtenerBodegas()
        {
            return dao.ObtenerBodegas();
        }

        //OBTENER UNIDADES DE MEDIAS COMOBOX
        public DataTable ObtenerUnidades()
        {
            return dao.ObtenerUnidades();
        }


        //OBTENER INVENTARIOS PARA GRID
        public DataTable ObtenerInventarioGrid()
        {
            return dao.ObtenerInventarioGrid();
        }

        //OBTENER ESTADOVENTA PARA COMBOBOX
        /*public DataTable ObtenerEstadoVenta()
        {
            return dao.ObtenerEstadoVenta();
        }*/

        //OBTENER Tipo operacion PARA COMBOBOX
        public DataTable ObtenerTipoOperacion()
        {
            return dao.ObtenerTipoOperacion();
        }



        //ID venta
        public int ObtenerSiguienteIdVenta()
        {
            return dao.ObtenerSiguienteIdVenta();
        }

        //Validar la asignaciones de vendedores cliente
        public (bool tieneVendedor, string Cmp_NombreVendedor) ValidarClienteVendedor(int iFk_Id_Cliente)
        {
            DataTable dt = dao.ObtenerVendedorDeCliente(iFk_Id_Cliente);

            if (dt.Rows.Count > 0)
            {
                string Cmp_NombreVendedor = dt.Rows[0]["Vendedor"].ToString();
                return (true, Cmp_NombreVendedor);
            }

            return (false, "");
        }

        //PARA VENTAS GENERALES
        public DataTable ObtenerListadoVentas()
        {
            return dao.ObtenerListadoVentas();
        }


        //NUEVO METODO PARA APLICAR DESCUENTO POR TIPO DE CLIENTE
        public (string sTipoCliente, float fDescuento) ObtenerDescuentoCliente(int iFk_Id_Cliente, float fCantidad)
        {
            return dao.ObtenerDescuentoCliente(iFk_Id_Cliente, fCantidad);
        }

        //CALCULAR SUBTOTAL CON DESCUENTO APLICADO
        public float CalcularSubtotal(float fPrecio, float fCantidad, float fDescuento)
        {
            float subtotal = fPrecio * fCantidad;
            float descuentoAplicado = subtotal * fDescuento;

            return subtotal - descuentoAplicado;
        }

        //CALCULAR SUBTOTAL SIN DESCUENTO APLICADO
        /*public float CalcularSubtotal(float fPrecio, int iCantidad)
        {
            return fPrecio * iCantidad;
        }*/

        public float CalcularTotal(DataTable dt)
        {
            float fSaldototal = 0;

            foreach (DataRow row in dt.Rows)
            {
                fSaldototal += Convert.ToSingle(row["Subtotal"]);
            }

            return fSaldototal;
        }

        //OBTENER UNIDAD DE MEDIDA POR PRODUCTOS
        public DataTable ObtenerUnidadPorProducto(int iIdProducto)
        {
            return dao.ObtenerUnidadPorProducto(iIdProducto);
        }

        //OBTENER BODEGAS POR PRODUCTO
        public DataTable ObtenerBodegasPorProducto(int pk_inventario_id)
        {
            return dao.ObtenerBodegasPorProducto(pk_inventario_id);
        }




        //NUevo
        public DataTable ObtenerVentaPorId(int idVenta)
        {
            return dao.ObtenerVentaPorId(idVenta);
        }

        //NUevos cambios 18 de mayo
        public bool ActualizarVenta(int iPk_Id_Venta, DateTime dCmp_Fecha_Venta, int iFk_Id_Cliente, int iFk_Id_Sucursal,
        string sCmp_Estado_Venta, string sCmp_Tipo_Operacion, float fCmp_Saldo_Total, bool convertirAVenta, DataTable detalle)
        {
            return dao.ActualizarVenta(iPk_Id_Venta, dCmp_Fecha_Venta, iFk_Id_Cliente, iFk_Id_Sucursal, sCmp_Estado_Venta,
                sCmp_Tipo_Operacion, fCmp_Saldo_Total, convertirAVenta, detalle);
        }

        public DataTable ObtenerDetalleVenta(int idVenta)
        {
            return dao.ObtenerDetalleVenta(idVenta);
        }


        public bool ExisteCuentaPorCobrar(int idVenta)
        {
            return dao.ExisteCuentaPorCobrar(idVenta);
        }

        public DataTable ObtenerDetalleOriginal(int idVenta)
        {
            return dao.ObtenerDetalleOriginal(idVenta);
        }









        //GUARDAR VENTA-COTIZACION-PEDIDO
        public bool GuardarVenta(DateTime dCmp_Fecha_Venta, int iFk_Id_Cliente, int iFk_Id_Sucursal,
          string sCmp_Estado_Venta, string sCmp_Tipo_Operacion, float fCmp_Saldo_Total,
          DataTable detalle, DateTime dFecha_Especial, DateTime dCmp_Fecha_Vencimiento, bool bEsVenta)
        {

            return dao.GuardarVentaCompleta(dCmp_Fecha_Venta, iFk_Id_Cliente, iFk_Id_Sucursal,
            sCmp_Estado_Venta, sCmp_Tipo_Operacion, fCmp_Saldo_Total, detalle,
            dFecha_Especial, dCmp_Fecha_Vencimiento, bEsVenta);
        }

        public int ObtenerIdCXCPorVenta(int idVenta)
        {
            try
            {
                if (idVenta <= 0)
                {
                    MessageBox.Show("ID de venta inválido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }

                int idCXC = dao.ObtenerIdCXCPorVenta(idVenta);

                if (idCXC == 0)
                {
                    MessageBox.Show("No se encontró una cuenta por cobrar para esta venta.\n" +
                        "Asegúrese de haber guardado la venta correctamente.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }

                return idCXC;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener CXC: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}