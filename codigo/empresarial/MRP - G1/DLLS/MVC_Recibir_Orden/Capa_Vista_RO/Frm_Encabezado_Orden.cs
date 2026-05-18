using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_RO;

namespace Capa_Vista_RO
{
    public partial class Frm_Encabezado_Orden : Form
    {
        // ------ KEVIN NATARENO - 0901-21-635, 28/04/2026 --------
       
        Cls_Controlador_Orden controlador = new  Cls_Controlador_Orden ();
        public Frm_Encabezado_Orden()
        {
            InitializeComponent();
            this.Load += Frm_Encabezado_Orden_Load;
        }
        private void Frm_Encabezado_Orden_Load(object sender, EventArgs e)
        {
            // Arón Ricardo Esquit - 0901-22-13036 - 01/05/26
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker2.ShowCheckBox = true;
            dateTimePicker1.Value = new DateTime(2026, 4, 1);
            dateTimePicker2.Value = new DateTime(2026, 5, 1);
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;

            CargarGrid();
            CargarEstadosCombo();

            dgvOrdenes.CellClick += dgvOrdenes_CellClick;
            txtID.TextChanged += Filtrar;
            cmbEstado.SelectedIndexChanged += Filtrar;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
        }

        private void CargarEstadosCombo()
        {
            var estados = controlador.ObtenerEstados();

            // Agregar opción "Todos" al inicio
            DataRow todos = estados.NewRow();
            todos["Pk_Id_Estado_Orden_Recibida"] = 0;
            todos["Nombre_Estado_Orden_Recibida"] = "Todos";
            estados.Rows.InsertAt(todos, 0);

            cmbEstado.DataSource = estados;
            cmbEstado.DisplayMember = "Nombre_Estado_Orden_Recibida";
            cmbEstado.ValueMember = "Pk_Id_Estado_Orden_Recibida";
            cmbEstado.SelectedIndex = 0;
        }

        private void Filtrar(object sender, EventArgs e)
        {
            string idExterno = txtID.Text.Trim();
            int idEstado = Convert.ToInt32(cmbEstado.SelectedValue);

            dgvOrdenes.DataSource = controlador.FiltrarOrdenes(idExterno, idEstado);
            ConfigurarGrid();
            AgregarBotonVer();
            MarcarFacturasExistentes();
        }
        private void CargarGrid()
        {
            var datos = controlador.ObtenerOrdenes();
            dgvOrdenes.DataSource = null;
            dgvOrdenes.Columns.Clear();
            dgvOrdenes.DataSource = datos;
            ConfigurarGrid();
            AgregarBotonVer();
            MarcarFacturasExistentes();
        }


        private void ConfigurarGrid()
        {
            if (dgvOrdenes.Columns.Count == 0) return;

            // Ocultar ID interno
            if (dgvOrdenes.Columns.Contains("Pk_Id_Orden_Recibida"))
                dgvOrdenes.Columns["Pk_Id_Orden_Recibida"].Visible = false;

            // Cambiar nombres
            if (dgvOrdenes.Columns.Contains("Orden"))
                dgvOrdenes.Columns["Orden"].HeaderText = "Orden";

            if (dgvOrdenes.Columns.Contains("Fecha_Recepcion"))
                dgvOrdenes.Columns["Fecha_Recepcion"].HeaderText = "Fecha Recepción";

            if (dgvOrdenes.Columns.Contains("Fecha_Requerida"))
                dgvOrdenes.Columns["Fecha_Requerida"].HeaderText = "Fecha Requerida";

            if (dgvOrdenes.Columns.Contains("Estado"))
                dgvOrdenes.Columns["Estado"].HeaderText = "Estado";

           
            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdenes.ReadOnly = true;
            dgvOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenes.MultiSelect = false;
        }


        private void AgregarBotonVer()
        {
            if (!dgvOrdenes.Columns.Contains("Ver"))
            {
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "Ver";
                btnVer.HeaderText = "Acciones";
                btnVer.Text = "Ver";
                btnVer.UseColumnTextForButtonValue = true;
                dgvOrdenes.Columns.Add(btnVer);
            }

            if (!dgvOrdenes.Columns.Contains("Factura"))
            {
                DataGridViewButtonColumn btnFactura = new DataGridViewButtonColumn();
                btnFactura.Name = "Factura";
                btnFactura.HeaderText = "Factura";
                btnFactura.Text = "Generar Factura";
                btnFactura.UseColumnTextForButtonValue = true;
                dgvOrdenes.Columns.Add(btnFactura);
            }

            if (!dgvOrdenes.Columns.Contains("EstadoFactura"))
            {
                DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
                colEstado.Name = "EstadoFactura";
                colEstado.HeaderText = "Estado Factura";
                colEstado.ReadOnly = true;
                dgvOrdenes.Columns.Add(colEstado);
            }
        }


        private void dgvOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var valor = dgvOrdenes.Rows[e.RowIndex].Cells["Pk_Id_Orden_Recibida"].Value;
            if (valor == DBNull.Value || valor == null)
            {
                MessageBox.Show("La celda está vacía o no existe");
                return;
            }

            int idOrden = Convert.ToInt32(valor);

            if (dgvOrdenes.Columns[e.ColumnIndex].Name == "Ver")
            {
                Frm_Detalle_Orden frm = new Frm_Detalle_Orden(idOrden);
                frm.ShowDialog();
                CargarGrid();
            }
            else if (dgvOrdenes.Columns[e.ColumnIndex].Name == "Factura")
            {
                DialogResult confirm = MessageBox.Show(
                    "¿Desea generar la factura para esta orden?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (controlador.GenerarFactura(idOrden))
                        {
                            controlador.CambiarEstadoOrden(idOrden, 3);
                            MessageBox.Show("Factura generada correctamente.");
                            CargarGrid();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (dgvOrdenes.Columns[e.ColumnIndex].Name == "Factura")
            {
                
                if (dgvOrdenes.Rows[e.RowIndex].Cells["Factura"].Value.ToString() == "Facturada")
                {
                    MessageBox.Show("Esta orden ya fue facturada.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    "¿Desea generar la factura para esta orden?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    if (controlador.GenerarFactura(idOrden))
                    {
                        controlador.CambiarEstadoOrden(idOrden, 3);
                        MessageBox.Show("Factura generada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error al generar la factura.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_CrearOrdenN_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Orden frm = new Frm_Detalle_Orden();
            frm.ShowDialog();
            CargarGrid();
        }

        // Arón Ricardo Esquit - 0901-22-13036 - 01/05/26
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FiltrarSiAmbosChecked();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FiltrarSiAmbosChecked();
        }

        private void FiltrarSiAmbosChecked()
        {
            if (!dateTimePicker1.Checked || !dateTimePicker2.Checked)
            {
                CargarGrid();
                return;
            }

            string fechaInicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fechaFin = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            dgvOrdenes.DataSource = controlador.FiltrarOrdenesPorFecha(fechaInicio, fechaFin);
            ConfigurarGrid();
            AgregarBotonVer();
            MarcarFacturasExistentes();
        }

        private void MarcarFacturasExistentes()
        {
            foreach (DataGridViewRow fila in dgvOrdenes.Rows)
            {
                if (fila.Cells["Pk_Id_Orden_Recibida"].Value == null) continue;
                int idOrden = Convert.ToInt32(fila.Cells["Pk_Id_Orden_Recibida"].Value);

               
                if (controlador.ExisteFactura(idOrden))
                {
                    fila.Cells["EstadoFactura"].Value = "✓ Facturada";
                    fila.Cells["EstadoFactura"].Style.BackColor = Color.LightGreen;
                    fila.Cells["EstadoFactura"].Style.ForeColor = Color.DarkGreen;
                }
                else
                {
                    fila.Cells["EstadoFactura"].Value = "Pendiente";
                    fila.Cells["EstadoFactura"].Style.BackColor = Color.LightYellow;
                    fila.Cells["EstadoFactura"].Style.ForeColor = Color.DarkOrange;
                }
                dgvOrdenes.Refresh(); 
                dgvOrdenes.Update();  
            }
        }

        // Maria Morales 0901-22-1226 16/05/2026
        private void btn_eliminar_orden_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una orden para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var valor = dgvOrdenes.SelectedRows[0].Cells["Pk_Id_Orden_Recibida"].Value;
            if (valor == null || valor == DBNull.Value)
            {
                MessageBox.Show("No se pudo obtener el ID de la orden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idOrden = Convert.ToInt32(valor);

            // Verificar si ya tiene factura — no se debería eliminar
            if (controlador.ExisteFactura(idOrden))
            {
                MessageBox.Show("No se puede eliminar una orden que ya tiene factura generada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Está seguro que desea eliminar esta orden?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                if (controlador.BorrarOrden(idOrden))
                {
                    MessageBox.Show("Orden eliminada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la orden.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_refrescar_grid_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }
        // Maria Morales 0901-22-1226 16/05/2026

    }



}  // ------ KEVIN NATARENO - 0901-21-635, 28/04/2026 --------
