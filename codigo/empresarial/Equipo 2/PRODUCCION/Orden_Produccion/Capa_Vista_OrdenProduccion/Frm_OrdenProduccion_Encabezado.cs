using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_OrdenProduccion;

namespace Capa_Vista_OrdenProduccion
{
    //Elaborado por Kenph Luna 9959-22-6326
    public partial class Frm_OrdenProduccion_Encabezado : Form
    {
        private Cls_ControladorOrdenP oControlador = new Cls_ControladorOrdenP();
        public Frm_OrdenProduccion_Encabezado()
        {
            InitializeComponent();
        }

        private void AplicarEstilosDGV(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            dgv.AllowUserToAddRows = false;
        }

        private void Frm_Ordenes_Encabezados_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
            AplicarEstilosDGV(Dgv_EncabezadoOrdenP);
        }

        private void ActualizarTabla()
        {
            Dgv_EncabezadoOrdenP.DataSource = oControlador.ObtenerEncabezados();
        }

        private void dgvEncabezados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = Dgv_EncabezadoOrdenP.Rows[e.RowIndex];
                    AbrirDetalle(fila, false); //Modo Lectura
                }
            }
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Frm_OrdenProduccion_Detalle FrmDetalle = new Frm_OrdenProduccion_Detalle();
            FrmDetalle.ShowDialog();
            ActualizarTabla();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (Dgv_EncabezadoOrdenP.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una orden de la lista para borrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idOrdenStr = Dgv_EncabezadoOrdenP.CurrentRow.Cells["Pk_ID_OrdenProduccion"].Value.ToString();

            // Confirmación
            DialogResult dialogo = MessageBox.Show($"¿Está completamente seguro que desea eliminar la Orden No. {idOrdenStr} y todos sus detalles? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                try
                {
                    oControlador.EliminarOrden(idOrdenStr);
                    MessageBox.Show("Orden eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar el DGV
                    Dgv_EncabezadoOrdenP.DataSource = oControlador.ObtenerEncabezados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Pnl_Botones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (Dgv_EncabezadoOrdenP.CurrentRow != null)
            {
                AbrirDetalle(Dgv_EncabezadoOrdenP.CurrentRow, true); // true = Modo Edición
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una orden de la lista para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AbrirDetalle(DataGridViewRow fila, bool iniciarEnModoEdicion)
        {
            int idOrden = Convert.ToInt32(fila.Cells["Pk_ID_OrdenProduccion"].Value);
            string idVendedor = fila.Cells["Fk_ID_Vendedor"].Value.ToString();
            DateTime fechaEmision = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Emision"].Value);
            DateTime fechaEstimada = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Estimada_Entrega"].Value);
            string estado = fila.Cells["Cmp_Estado"].Value.ToString();

            Frm_OrdenProduccion_Detalle frmDetalles = new Frm_OrdenProduccion_Detalle(idOrden, idVendedor, fechaEmision, fechaEstimada, estado, iniciarEnModoEdicion);

            frmDetalles.ShowDialog();
            ActualizarTabla(); // Refrescar al cerrar
        }

        //navegación del Encabezado
        private void NavegarGrid(string accion)
        {
            //Verificar que dgv tenga datos
            if (Dgv_EncabezadoOrdenP.Rows.Count == 0) return;

            // Fila actual y última
            int indiceActual = Dgv_EncabezadoOrdenP.CurrentRow != null ? Dgv_EncabezadoOrdenP.CurrentRow.Index : 0;
            int indiceFinal = Dgv_EncabezadoOrdenP.Rows.Count - 1;
            int nuevoIndice = indiceActual;

            if (accion == "Inicio")
                nuevoIndice = 0;
            else if (accion == "Anterior")
                nuevoIndice = (indiceActual > 0) ? indiceActual - 1 : 0;
            else if (accion == "Siguiente")
                nuevoIndice = (indiceActual < indiceFinal) ? indiceActual + 1 : indiceFinal;
            else if (accion == "Fin")
                nuevoIndice = indiceFinal;

            // Se mueve el puntero activo a la nueva fila
            Dgv_EncabezadoOrdenP.CurrentCell = Dgv_EncabezadoOrdenP.Rows[nuevoIndice].Cells[0];
            // se selecciona toda la fila
            Dgv_EncabezadoOrdenP.Rows[nuevoIndice].Selected = true;
        }

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            NavegarGrid("Inicio");
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            NavegarGrid("Anterior");
        }

        private void Btn_sig_Click(object sender, EventArgs e)
        {
            NavegarGrid("Siguiente");
        }

        private void Btn_fin_Click(object sender, EventArgs e)
        {
            NavegarGrid("Fin");
        }
    }
}
