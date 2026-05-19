using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador;
using System.Drawing;
using System.IO;

namespace Capa_Vista_Comprobantes
{
    public partial class Frm_Comprobante_Produccion : Form
    {
        Cls_Controlador_Sentencias_Produccion controlador = new Cls_Controlador_Sentencias_Produccion();

        private int I_Id_Entrega_Seleccionada = 0;
        private int I_Id_Comprobante_Seleccionado = 0;

        public Frm_Comprobante_Produccion()
        {
            InitializeComponent();

            this.Load += Frm_Comprobante_Produccion_Load;
            Dvg_Comprobante_Produccion.CellClick += Dvg_Comprobante_Produccion_CellClick;
        }

        private void Frm_Comprobante_Produccion_Load(object sender, EventArgs e)
        {
            Cbo_Id_Comprobante_Produccion.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Id_Entrega_Comprobante_Produccion.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Id_Cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Estado.DropDownStyle = ComboBoxStyle.DropDownList;

            fun_CargarCombos();
            fun_CargarDataGrid();
            fun_LimpiarCampos();
            fun_BloquearFormularioInicial();
            fun_EstadoBotonesInicio();
            AplicarEstiloDGV();

        }

        private void fun_CargarCombos()
        {
            Cbo_Id_Comprobante_Produccion.DataSource = controlador.fun_ObtenerIdComprobanteProduccion();
            Cbo_Id_Comprobante_Produccion.DisplayMember = "Pk_ID_Comprobante_Produccion";
            Cbo_Id_Comprobante_Produccion.ValueMember = "Pk_ID_Comprobante_Produccion";

            Cbo_Id_Entrega_Comprobante_Produccion.DataSource = controlador.fun_ObtenerIdEntregaProduccion();
            Cbo_Id_Entrega_Comprobante_Produccion.DisplayMember = "Pk_ID_Entrega_Produccion";
            Cbo_Id_Entrega_Comprobante_Produccion.ValueMember = "Pk_ID_Entrega_Produccion";

            Cbo_Id_Cliente.DataSource = controlador.fun_ObtenerIdCliente();
            Cbo_Id_Cliente.DisplayMember = "Pk_Id_Cliente";
            Cbo_Id_Cliente.ValueMember = "Pk_Id_Cliente";

            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Pendiente");
            Cbo_Estado.Items.Add("Entregado");
            Cbo_Estado.Items.Add("Cancelado");

            fun_LimpiarCampos();
        }

        private void fun_EstadoBotonesInicio()
        {
            Btn_Crear_Comprobante.Enabled = true;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

            Btn_Limpiar_Comprobante.Enabled = true;
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir.Enabled = true;
        }

        private void fun_EstadoBotonesCrear()
        {
            Btn_Crear_Comprobante.Enabled = false;
            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

            Btn_Limpiar_Comprobante.Enabled = true;
            Btn_Reporte.Enabled = false;
            Btn_Ayuda.Enabled = false;
            Btn_Salir.Enabled = true;
        }

        private void fun_EstadoBotonesSeleccion()
        {
            Btn_Crear_Comprobante.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;

            Btn_Limpiar_Comprobante.Enabled = true;
            Btn_Reporte.Enabled = false;
            Btn_Ayuda.Enabled = false;
            Btn_Salir.Enabled = true;
        }

        private void fun_BloquearFormularioInicial()
        {
            Cbo_Id_Comprobante_Produccion.Enabled = false;
            Cbo_Id_Entrega_Comprobante_Produccion.Enabled = false;
            Cbo_Id_Cliente.Enabled = false;
            Txt_Nombre_Receptor.Enabled = false;
            Txt_Observaciones.Enabled = false;
            Cbo_Estado.Enabled = false;
            Dtp_Fecha_Hora_Entrega.Enabled = false;
        }

        private void fun_DesbloquearFormulario()
        {
            Cbo_Id_Comprobante_Produccion.Enabled = false;
            Cbo_Id_Entrega_Comprobante_Produccion.Enabled = true;
            Cbo_Id_Cliente.Enabled = true;
            Txt_Nombre_Receptor.Enabled = true;
            Txt_Observaciones.Enabled = true;
            Cbo_Estado.Enabled = true;
            Dtp_Fecha_Hora_Entrega.Enabled = true;
        }

        private void fun_LimpiarCampos()
        {
            if (Cbo_Id_Comprobante_Produccion.DataSource != null)
                Cbo_Id_Comprobante_Produccion.SelectedIndex = -1;

            if (Cbo_Id_Entrega_Comprobante_Produccion.DataSource != null)
                Cbo_Id_Entrega_Comprobante_Produccion.SelectedIndex = -1;

            if (Cbo_Id_Cliente.DataSource != null)
                Cbo_Id_Cliente.SelectedIndex = -1;

            Cbo_Estado.SelectedIndex = -1;
            Txt_Nombre_Receptor.Clear();
            Txt_Observaciones.Clear();
            Dtp_Fecha_Hora_Entrega.Value = DateTime.Now;

            I_Id_Comprobante_Seleccionado = 0;
            I_Id_Entrega_Seleccionada = 0;
        }

        private bool fun_ValidarCampos()
        {
            if (Cbo_Id_Entrega_Comprobante_Produccion.SelectedIndex == -1 ||
                Cbo_Id_Cliente.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(Txt_Nombre_Receptor.Text) ||
                Cbo_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos obligatorios.");
                return false;
            }

            return true;
        }

        private void Btn_Crear_Comprobante_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
            fun_DesbloquearFormulario();
            fun_EstadoBotonesCrear();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!fun_ValidarCampos()) return;

            bool resultado = controlador.InsertarComprobante(
                Convert.ToInt32(Cbo_Id_Entrega_Comprobante_Produccion.SelectedValue),
                Convert.ToInt32(Cbo_Id_Cliente.SelectedValue),
                Txt_Nombre_Receptor.Text.Trim(),
                Dtp_Fecha_Hora_Entrega.Value,
                Txt_Observaciones.Text.Trim(),
                Cbo_Estado.Text
            );

            if (resultado)
            {
                MessageBox.Show("Comprobante guardado correctamente.");
                fun_CargarCombos();
                fun_CargarDataGrid();
                fun_LimpiarCampos();
                fun_BloquearFormularioInicial();
                fun_EstadoBotonesInicio();
            }
            else
            {
                MessageBox.Show("Error al guardar el comprobante.");
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (I_Id_Comprobante_Seleccionado == 0)
            {
                MessageBox.Show("Seleccione un comprobante para modificar.");
                return;
            }

            if (!fun_ValidarCampos()) return;

            bool resultado = controlador.ActualizarComprobante(
                I_Id_Comprobante_Seleccionado,
                Convert.ToInt32(Cbo_Id_Entrega_Comprobante_Produccion.SelectedValue),
                Convert.ToInt32(Cbo_Id_Cliente.SelectedValue),
                Txt_Nombre_Receptor.Text.Trim(),
                Dtp_Fecha_Hora_Entrega.Value,
                Txt_Observaciones.Text.Trim(),
                Cbo_Estado.Text
            );

            if (resultado)
            {
                MessageBox.Show("Comprobante modificado correctamente.");
                fun_CargarCombos();
                fun_CargarDataGrid();
                fun_LimpiarCampos();
                fun_BloquearFormularioInicial();
                fun_EstadoBotonesInicio();
            }
            else
            {
                MessageBox.Show("Error al modificar el comprobante.");
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (I_Id_Comprobante_Seleccionado == 0)
            {
                MessageBox.Show("Seleccione un comprobante para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este comprobante?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            bool resultado = controlador.Fun_Eliminar_Comprobante_Produccion(I_Id_Comprobante_Seleccionado);

            if (resultado)
            {
                MessageBox.Show("Comprobante eliminado correctamente.");
                fun_CargarCombos();
                fun_CargarDataGrid();
                fun_LimpiarCampos();
                fun_BloquearFormularioInicial();
                fun_EstadoBotonesInicio();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el comprobante.");
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
            fun_BloquearFormularioInicial();
            fun_EstadoBotonesInicio();
        }

        private void Btn_Limpiar_Comprobante_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dvg_Comprobante_Produccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = Dvg_Comprobante_Produccion.Rows[e.RowIndex];

            I_Id_Comprobante_Seleccionado = Convert.ToInt32(fila.Cells["Pk_ID_Comprobante_Produccion"].Value);
            I_Id_Entrega_Seleccionada = Convert.ToInt32(fila.Cells["Fk_ID_Entrega_Produccion"].Value);

            Cbo_Id_Comprobante_Produccion.SelectedValue = I_Id_Comprobante_Seleccionado;
            Cbo_Id_Entrega_Comprobante_Produccion.SelectedValue = I_Id_Entrega_Seleccionada;
            Cbo_Id_Cliente.SelectedValue = Convert.ToInt32(fila.Cells["Fk_ID_Cliente"].Value);

            Txt_Nombre_Receptor.Text = fila.Cells["Cmp_Nombre_Receptor"].Value.ToString();
            Txt_Observaciones.Text = fila.Cells["Cmp_Observaciones"].Value.ToString();
            Cbo_Estado.Text = fila.Cells["Cmp_Estado"].Value.ToString();

            if (fila.Cells["Cmp_Fecha_Hora_Entrega"].Value != DBNull.Value)
            {
                Dtp_Fecha_Hora_Entrega.Value =
                    Convert.ToDateTime(fila.Cells["Cmp_Fecha_Hora_Entrega"].Value);
            }

            fun_DesbloquearFormulario();
            fun_EstadoBotonesSeleccion();
        }

        private void Btn_Ver_Detalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (I_Id_Entrega_Seleccionada == 0)
                {
                    MessageBox.Show("Seleccione un comprobante para ver su detalle.");
                    return;
                }

                string S_Estado_Comprobante = Cbo_Estado.Text;

                controlador.Fun_Actualizar_Estado_Entrega_Produccion(
                    I_Id_Entrega_Seleccionada,
                    S_Estado_Comprobante
                );

                Dgv_Detalle_Entrega.DataSource =
                    controlador.Fun_Obtener_Detalle_Entrega_Produccion(I_Id_Entrega_Seleccionada);

                Dgv_Detalle_Entrega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_Detalle_Entrega.ReadOnly = true;
                Dgv_Detalle_Entrega.AllowUserToAddRows = false;
                Dgv_Detalle_Entrega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                Dgv_Detalle_Entrega.Columns["No_Entrega"].HeaderText = "No. Entrega";
                Dgv_Detalle_Entrega.Columns["Produccion"].HeaderText = "Orden Producción";
                Dgv_Detalle_Entrega.Columns["Producto"].HeaderText = "Producto";
                Dgv_Detalle_Entrega.Columns["Cantidad"].HeaderText = "Cantidad";
                Dgv_Detalle_Entrega.Columns["Transporte"].HeaderText = "Transporte";
                Dgv_Detalle_Entrega.Columns["Direccion"].HeaderText = "Dirección";
                Dgv_Detalle_Entrega.Columns["Fecha"].HeaderText = "Fecha Entrega";
                Dgv_Detalle_Entrega.Columns["Estado"].HeaderText = "Estado";

                AplicarEstiloDGVDetalle();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar detalle: " + Ex.Message);
            }
        }

        private void fun_CargarDataGrid()
        {
            Dvg_Comprobante_Produccion.DataSource = controlador.MostrarComprobantes();

            Dvg_Comprobante_Produccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dvg_Comprobante_Produccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dvg_Comprobante_Produccion.MultiSelect = false;
            Dvg_Comprobante_Produccion.ReadOnly = true;
            Dvg_Comprobante_Produccion.AllowUserToAddRows = false;

            Dvg_Comprobante_Produccion.Columns["Pk_ID_Comprobante_Produccion"].HeaderText = "ID Comprobante";
            Dvg_Comprobante_Produccion.Columns["Fk_ID_Entrega_Produccion"].HeaderText = "ID Entrega";
            Dvg_Comprobante_Produccion.Columns["Cliente"].HeaderText = "Cliente";
            Dvg_Comprobante_Produccion.Columns["Cmp_Nombre_Receptor"].HeaderText = "Nombre Receptor";
            Dvg_Comprobante_Produccion.Columns["Cmp_Fecha_Hora_Entrega"].HeaderText = "Fecha de Entrega";
            Dvg_Comprobante_Produccion.Columns["Cmp_Observaciones"].HeaderText = "Observaciones";
            Dvg_Comprobante_Produccion.Columns["Cmp_Estado"].HeaderText = "Estado";
            Dvg_Comprobante_Produccion.Columns["Fk_ID_Cliente"].Visible = false;
        }

        private void Dgv_Detalle_Entrega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*            Dgv_Detalle_Entrega.Columns["Pk_Id_Entrega_Produccion"].HeaderText = "No. Entrega";
            Dgv_Detalle_Entrega.Columns["Fk_Id_OrdenP"].HeaderText = "Orden Producción";
            Dgv_Detalle_Entrega.Columns["Fk_Id_Transporte"].HeaderText = "Transporte";
            Dgv_Detalle_Entrega.Columns["Cmp_Direccion"].HeaderText = "Dirección";
            Dgv_Detalle_Entrega.Columns["Cmp_Fecha"].HeaderText = "Fecha Entrega";
            Dgv_Detalle_Entrega.Columns["Cmp_Estado_Entrega"].HeaderText = "Estado";*/

        }

        private void Btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AplicarEstiloDGV()
        {
            Dvg_Comprobante_Produccion.DefaultCellStyle.Font = new Font("Rockwell", 9);
            Dvg_Comprobante_Produccion.ColumnHeadersDefaultCellStyle.Font = new Font("Rockwell", 9, FontStyle.Bold);
            Dvg_Comprobante_Produccion.EnableHeadersVisualStyles = false;
        }

        private void AplicarEstiloDGVDetalle()
        {
            Dgv_Detalle_Entrega.EnableHeadersVisualStyles = false;

            Dgv_Detalle_Entrega.DefaultCellStyle.Font =
                new Font("Rockwell", 9);

            Dgv_Detalle_Entrega.ColumnHeadersDefaultCellStyle.Font =
                new Font("Rockwell", 9, FontStyle.Bold);

            Dgv_Detalle_Entrega.RowTemplate.Height = 28;
        }


        private void Btn_Reporte_Click_1(object sender, EventArgs e)
        {
            Frm_Reporte_Comprobante_Produccion reporte = new Frm_Reporte_Comprobante_Produccion();
            reporte.Show();
        }

        private void Configurar_Dgv_Detalle_Entrega()
        {
            if (Dgv_Detalle_Entrega.Columns["No_Entrega"] != null)
                Dgv_Detalle_Entrega.Columns["No_Entrega"].HeaderText = "No. Entrega";

            if (Dgv_Detalle_Entrega.Columns["Orden_Produccion"] != null)
                Dgv_Detalle_Entrega.Columns["Orden_Produccion"].HeaderText = "Orden Producción";

            if (Dgv_Detalle_Entrega.Columns["Transporte"] != null)
                Dgv_Detalle_Entrega.Columns["Transporte"].HeaderText = "Transporte";

            if (Dgv_Detalle_Entrega.Columns["Direccion"] != null)
                Dgv_Detalle_Entrega.Columns["Direccion"].HeaderText = "Dirección";

            if (Dgv_Detalle_Entrega.Columns["Fecha"] != null)
                Dgv_Detalle_Entrega.Columns["Fecha"].HeaderText = "Fecha Entrega";

            if (Dgv_Detalle_Entrega.Columns["Estado"] != null)
                Dgv_Detalle_Entrega.Columns["Estado"].HeaderText = "Estado";
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaAyuda = Path.Combine(Application.StartupPath, "Ayuda_Com_Compra", "Ayuda_Com_Compra.chm");

                if (File.Exists(rutaAyuda))
                {
                    Help.ShowHelp(this, rutaAyuda);
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo de ayuda.",
                                    "Ayuda",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ayuda: " + ex.Message);
            }
        }
    }
}