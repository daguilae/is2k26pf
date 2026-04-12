using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mantenimiento_tipo_MOV_inv;
using Capa_Vista_LineaProd;
using Capa_Vista_Ventas;
using Mantenimiento_Proveedores;
using Capa_Vista_Marca;
using Capa_Vista_Empresa_Transporte;
using Capa_Vista_Reporteador;
using Capa_Vista_Seguridad;
using Capa_Vista_Bodegaa;
using Capa_Vista_Mov_Inv;
using Mantenimiento_cuentas_por_pagar;
using Capa_Vista_OrdenProduccion;
using Capa_vista_Factura;
using Capa_Vista_OrdenDetalle;
namespace Capa_Vista_Logista
{
    public partial class Frm_MDI : Form
    {
        public Frm_MDI()
        {
            InitializeComponent();
        }
        

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
  

        }

        private void cuentaPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Tipo_Op_CXC CXC = new Frm_Mantenimiento_Tipo_Op_CXC();
            CXC.ShowDialog();
        }

        private void lineaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_LineaProducto LineaProducto = new Frm_Mantenimiento_LineaProducto();
            LineaProducto.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Vendedores vendedores = new Frm_Vendedores();
            vendedores.ShowDialog();
        }

        private void Frm_MDI_Load(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_proveedores proveedores = new Frm_proveedores();
            proveedores.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Clientes Clientes = new Frm_Clientes();
            Clientes.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Marca Marca = new Frm_Marca();
            Marca.ShowDialog();
            
        }

        private void empresaTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empresa_Transporte transporte = new Frm_Empresa_Transporte();
            transporte.ShowDialog();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reportes Reporteador = new Frm_Reportes();
            Reporteador.ShowDialog();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Seguridad MDI_seguridad = new Frm_Seguridad();
            MDI_seguridad.ShowDialog();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bodega bodega = new Frm_Bodega();
            bodega.ShowDialog();
        }

        private void movimientoOperacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mantenimiento_tipo_mov_inv Movimiento = new Frm_mantenimiento_tipo_mov_inv();
            Movimiento.ShowDialog();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_cuentas_por_pagar CXP = new Frm_Mantenimiento_cuentas_por_pagar();
            CXP.ShowDialog();
        }

        private void pagosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Pagos pagos = new Frm_Pagos();
            pagos.ShowDialog();
        }

        private void movimientoDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Encabezado_Transaccion Trans = new Frm_Encabezado_Transaccion();
            Trans.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inventario_Mantenimiento Inv = new Frm_Inventario_Mantenimiento();
            Inv.ShowDialog();
        }

       

        

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrdenProduccion_Encabezado Orden = new Frm_OrdenProduccion_Encabezado();
            Orden.ShowDialog();
        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ventas ventas = new Frm_Ventas();
            ventas.ShowDialog();

        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sucursales sucursales = new Frm_Sucursales();
            sucursales.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_factura factura = new Frm_factura();
            factura.ShowDialog();
        }

        private void detalleOrdenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Orden_Produccion_Detalle OrdenProd = new Frm_Orden_Produccion_Detalle();
            OrdenProd.ShowDialog();
           
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cuentaporcobrar CXC = new Frm_Cuentaporcobrar();
            CXC.ShowDialog();

        }

        private void devoluconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Devolucion devolucion = new Frm_Devolucion();
            devolucion.ShowDialog();
        }

        private void trasnportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Transporte tipo_Transporte = new Frm_Tipo_Transporte();
            tipo_Transporte.ShowDialog();
        }

        private void entregaDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Entrega_Produccion entrega_Produccion = new Frm_Entrega_Produccion();
            entrega_Produccion.ShowDialog();
        }

        private void entregaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Entrega_Venta entrega_Venta = new Frm_Entrega_Venta();
            entrega_Venta.ShowDialog();
        }

        private void entregaDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Entrega_Compra entrega_Compra = new Frm_Entrega_Compra();
            entrega_Compra.ShowDialog();
        }
    }
}
