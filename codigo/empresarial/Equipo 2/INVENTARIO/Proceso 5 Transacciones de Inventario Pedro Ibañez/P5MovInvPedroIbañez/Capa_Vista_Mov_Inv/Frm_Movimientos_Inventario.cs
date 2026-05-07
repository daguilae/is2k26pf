using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Mov_Inv;
using Capa_Modelo_Mov_Inv;
namespace Capa_Vista_Mov_Inv
{
    public partial class Frm_Movimientos_Inventario : Form
    {
        Cls_Controlador_Encabezado ctrl = new Cls_Controlador_Encabezado();
        
        public Frm_Movimientos_Inventario()
        {
            InitializeComponent();
            fun_CargarDGV();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Frm_Encabezado_Transaccion Trans = new Frm_Encabezado_Transaccion();
            Trans.ShowDialog();
        }

        private void fun_CargarDGV()
        {
            try
            {
                DataTable dtMovimientos = ctrl.fun_CargarMovimientos();
                Dgv_Encabezado_Movimiento_Inventarios.DataSource = dtMovimientos;

                // Personalizar encabezados de columnas
                Dgv_Encabezado_Movimiento_Inventarios.Columns["ID"].HeaderText = "ID Movimiento";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["ID_Tipo"].HeaderText = "ID Tipo";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Tipo_Movimiento"].HeaderText = "Tipo Movimiento";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Fecha"].HeaderText = "Fecha";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Descripcion"].HeaderText = "Descripción";

                Dgv_Encabezado_Movimiento_Inventarios.AllowUserToAddRows = false;
                Dgv_Encabezado_Movimiento_Inventarios.ReadOnly = true;
                Dgv_Encabezado_Movimiento_Inventarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_Encabezado_Movimiento_Inventarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de doble clic en el DataGridView
        private void dgvEncabezados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Encabezado_Movimiento_Inventarios.Rows[e.RowIndex];

                // Extraer datos usando las columnas exactas del DGV
                int idMovimiento = Convert.ToInt32(fila.Cells["ID"].Value);
                int idTipo = Convert.ToInt32(fila.Cells["ID_Tipo"].Value);
                string tipoMovimiento = fila.Cells["Tipo_Movimiento"].Value?.ToString() ?? string.Empty;
                DateTime fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                string descripcion = fila.Cells["Descripcion"].Value?.ToString() ?? string.Empty;

                Frm_Encabezado_Transaccion frmDetalles = new Frm_Encabezado_Transaccion(
                    idMovimiento,
                    idTipo,
                    tipoMovimiento,
                    fecha,
                    descripcion
                );

                frmDetalles.ShowDialog();

                // Refrescar el DGV al cerrar
                fun_CargarDGV();
            }
        }
        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            fun_CargarDGV();
        }
    }
}
