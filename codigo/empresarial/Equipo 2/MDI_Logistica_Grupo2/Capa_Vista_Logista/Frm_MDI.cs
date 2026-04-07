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
    }
}
