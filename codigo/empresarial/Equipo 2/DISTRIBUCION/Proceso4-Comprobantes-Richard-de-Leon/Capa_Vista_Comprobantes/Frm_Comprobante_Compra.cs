using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador;
using System.Drawing;
using System.IO;

namespace Capa_Vista_Comprobantes
{
    public partial class Frm_Comprobante_Compra : Form
    {
        Cls_Controlador_Sentencias controlador = new Cls_Controlador_Sentencias();
        private bool cargandoCombos = false;
        private int I_Id_Entrega_Seleccionada = 0;
        private int I_Id_Comprobante_Seleccionado = 0;

        public Frm_Comprobante_Compra()
        {
            InitializeComponent();

            this.Load += Frm_Comprobante_Compra_Load;
            this.Shown += Frm_Comprobante_Compra_Shown;

            Dvg_Comprobante_Compra.CellClick += Dvg_Comprobante_Compra_CellContentClick;
        }

        private void Frm_Comprobante_Compra_Load(object sender, EventArgs e)
        {
            Cbo_Id_Comprobante_Compra.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Id_Entrega_Comprobante_Compra.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Id_Proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Estado.DropDownStyle = ComboBoxStyle.DropDownList;

            fun_CargarCombos();
            fun_CargarDataGrid();
            fun_LimpiarCampos();

            fun_BloquearFormularioInicial();
            //Esilos
            AplicarEstiloDGV();

            // IMPORTANTE: este debe ir al final
            fun_EstadoBotonesInicio();
        }
        private void fun_CargarCombos()
        {
            cargandoCombos = true;

            Cbo_Id_Comprobante_Compra.DataSource = controlador.fun_ObtenerIdComprobanteCompra();
            Cbo_Id_Comprobante_Compra.DisplayMember = "Pk_ID_Comprobante_Compra";
            Cbo_Id_Comprobante_Compra.ValueMember = "Pk_ID_Comprobante_Compra";

            Cbo_Id_Entrega_Comprobante_Compra.DataSource = controlador.fun_ObtenerIdEntregaCompra();
            Cbo_Id_Entrega_Comprobante_Compra.DisplayMember = "Pk_ID_Entrega_Compra";
            Cbo_Id_Entrega_Comprobante_Compra.ValueMember = "Pk_ID_Entrega_Compra";

            Cbo_Id_Proveedor.DataSource = controlador.fun_ObtenerIdProveedor();
            Cbo_Id_Proveedor.DisplayMember = "cmp_Nombre_Proveedor";
            Cbo_Id_Proveedor.ValueMember = "pk_id_proveedor";

            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Pendiente");
            Cbo_Estado.Items.Add("Entregado");
            Cbo_Estado.Items.Add("Cancelado");

            Cbo_Id_Comprobante_Compra.SelectedIndex = -1;
            Cbo_Id_Entrega_Comprobante_Compra.SelectedIndex = -1;
            Cbo_Id_Proveedor.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;

            cargandoCombos = false;
        }

        private void fun_HabilitarCampos(bool estado)
        {
            Cbo_Id_Comprobante_Compra.Enabled = estado;
            Cbo_Id_Entrega_Comprobante_Compra.Enabled = estado;
            Cbo_Id_Proveedor.Enabled = estado;
            Txt_Nombre_Receptor.Enabled = estado;
            Dtp_Fecha_Hora_Entrega.Enabled = estado;
            Cbo_Estado.Enabled = estado;
            Txt_Observaciones.Enabled = estado;
        }

        private void fun_LimpiarCampos()
        {
            // Combos
            Cbo_Id_Comprobante_Compra.SelectedIndex = -1;
            Cbo_Id_Entrega_Comprobante_Compra.SelectedIndex = -1;
            Cbo_Id_Proveedor.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;

            // Textos
            Txt_Nombre_Receptor.Clear();
            Txt_Observaciones.Clear();

            // Fecha
            Dtp_Fecha_Hora_Entrega.Value = DateTime.Now;
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

        private void fun_EstadoBotonesNormal()
        {
            Btn_Crear_Comprobante.Enabled = true;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;

            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true; 

            Btn_Limpiar_Comprobante.Enabled = true;
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir.Enabled = true;
        }

        private bool fun_ValidarCampos()
        {
            if (Cbo_Id_Entrega_Comprobante_Compra.SelectedIndex == -1 ||
                Cbo_Id_Proveedor.SelectedIndex == -1 ||
                Txt_Nombre_Receptor.Text.Trim() == "" ||
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

            Cbo_Id_Comprobante_Compra.Enabled = false;
            Cbo_Id_Entrega_Comprobante_Compra.Enabled = true;
            Cbo_Id_Proveedor.Enabled = true;
            Txt_Nombre_Receptor.Enabled = true;
            Dtp_Fecha_Hora_Entrega.Enabled = true;
            Cbo_Estado.Enabled = true;
            Txt_Observaciones.Enabled = true;

            Btn_Crear_Comprobante.Enabled = false;
            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Btn_Modificar.Enabled = false;

            Btn_Limpiar_Comprobante.Enabled = true; // ✅ AQUÍ
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!fun_ValidarCampos())
            {
                return;
            }

            int fkIdEntregaCompra = Convert.ToInt32(Cbo_Id_Entrega_Comprobante_Compra.SelectedValue);
            int fkIdProveedor = Convert.ToInt32(Cbo_Id_Proveedor.SelectedValue);

            string nombreReceptor = Txt_Nombre_Receptor.Text.Trim();
            DateTime fechaHoraEntrega = Dtp_Fecha_Hora_Entrega.Value;
            string observaciones = Txt_Observaciones.Text.Trim();
            string estado = Cbo_Estado.Text;



            bool resultado = controlador.InsertarComprobante(
                fkIdEntregaCompra,
                fkIdProveedor,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );

            if (resultado)
            {
                MessageBox.Show("Comprobante guardado correctamente.");

                fun_CargarCombos();
                fun_CargarDataGrid();
                fun_LimpiarCampos();
                fun_BloquearFormularioInicial();
            }
            else
            {
                MessageBox.Show("Error al guardar el comprobante.");
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Cbo_Id_Comprobante_Compra.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un comprobante del listado.");
                return;
            }

            if (!fun_ValidarCampos())
            {
                return;
            }

            int pkIdComprobante = Convert.ToInt32(Cbo_Id_Comprobante_Compra.SelectedValue);
            int fkIdEntregaCompra = Convert.ToInt32(Cbo_Id_Entrega_Comprobante_Compra.SelectedValue);
            int fkIdProveedor = Convert.ToInt32(Cbo_Id_Proveedor.SelectedValue);

            string nombreReceptor = Txt_Nombre_Receptor.Text.Trim();
            DateTime fechaHoraEntrega = Dtp_Fecha_Hora_Entrega.Value;
            string observaciones = Txt_Observaciones.Text.Trim();
            string estado = Cbo_Estado.Text;



            bool resultado = controlador.ActualizarComprobante(
                pkIdComprobante,
                fkIdEntregaCompra,
                fkIdProveedor,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
            if (resultado)
            {
                MessageBox.Show("Comprobante modificado correctamente.");

                fun_CargarCombos();
                fun_CargarDataGrid();
                fun_LimpiarCampos();
                fun_BloquearFormularioInicial();
            }
            else
            {
                MessageBox.Show("Error al modificar el comprobante.");
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
            fun_BloquearFormularioInicial();
        }

        private void Btn_Limpiar_Comprobante_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbo_Id_Comprobante_Compra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoCombos || !Cbo_Id_Comprobante_Compra.Enabled)
            {
                return;
            }

            if (Cbo_Id_Comprobante_Compra.SelectedIndex == -1 || Cbo_Id_Comprobante_Compra.SelectedValue == null)
            {
                return;
            }

            int idComprobante;

            if (!int.TryParse(Cbo_Id_Comprobante_Compra.SelectedValue.ToString(), out idComprobante))
            {
                return;
            }

            DataTable tabla = controlador.BuscarComprobante(idComprobante);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                Cbo_Id_Entrega_Comprobante_Compra.SelectedValue = fila["Fk_ID_Entrega_Compra"];
                Cbo_Id_Proveedor.SelectedValue = fila["Fk_ID_Proveedor"];
                Txt_Nombre_Receptor.Text = fila["Cmp_Nombre_Receptor"].ToString();

                if (fila["Cmp_Fecha_Hora_Entrega"] != DBNull.Value)
                {
                    Dtp_Fecha_Hora_Entrega.Value = Convert.ToDateTime(fila["Cmp_Fecha_Hora_Entrega"]);
                }

                Txt_Observaciones.Text = fila["Cmp_Observaciones"].ToString();
                Cbo_Estado.Text = fila["Cmp_Estado"].ToString();

                fun_HabilitarCampos(true);
                Btn_Guardar.Enabled = false;
                Btn_Modificar.Enabled = true;
                Btn_Cancelar.Enabled = true;
                Btn_Crear_Comprobante.Enabled = false;
            }
        }

        private void Frm_Comprobante_Compra_Shown(object sender, EventArgs e)
        {
            fun_BloquearFormularioInicial();
        }

        private void fun_BloquearFormularioInicial()
        {
            Cbo_Id_Comprobante_Compra.Enabled = false;
            Cbo_Id_Entrega_Comprobante_Compra.Enabled = false;
            Cbo_Id_Proveedor.Enabled = false;
            Txt_Nombre_Receptor.Enabled = false;
            Dtp_Fecha_Hora_Entrega.Enabled = false;
            Cbo_Estado.Enabled = false;
            Txt_Observaciones.Enabled = false;

            Btn_Crear_Comprobante.Enabled = true;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

            Btn_Limpiar_Comprobante.Enabled = false; 
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir.Enabled = true;

        }

        private void Btn_Limpiar_Comprobante_Click_1(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
        }
        private void fun_CargarDataGrid()
        {
            Dvg_Comprobante_Compra.DataSource = controlador.MostrarComprobantes();

            Dvg_Comprobante_Compra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dvg_Comprobante_Compra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dvg_Comprobante_Compra.MultiSelect = false;
            Dvg_Comprobante_Compra.ReadOnly = true;
            Dvg_Comprobante_Compra.AllowUserToAddRows = false;

            // NOMBRES VISUALES
            Dvg_Comprobante_Compra.Columns["Pk_ID_Comprobante_Compra"].HeaderText = "ID Comprobante";
            Dvg_Comprobante_Compra.Columns["Fk_ID_Entrega_Compra"].HeaderText = "ID Entrega";
            Dvg_Comprobante_Compra.Columns["Fk_ID_Proveedor"].HeaderText = "ID Proveedor";
            Dvg_Comprobante_Compra.Columns["Proveedor"].HeaderText = "Proveedor";
            Dvg_Comprobante_Compra.Columns["Cmp_Nombre_Receptor"].HeaderText = "Nombre Receptor";
            Dvg_Comprobante_Compra.Columns["Cmp_Fecha_Hora_Entrega"].HeaderText = "Fecha de Entrega";
            Dvg_Comprobante_Compra.Columns["Cmp_Observaciones"].HeaderText = "Observaciones";
            Dvg_Comprobante_Compra.Columns["Cmp_Estado"].HeaderText = "Estado";

            // OCULTAR ID
            Dvg_Comprobante_Compra.Columns["Fk_ID_Proveedor"].Visible = false;
        }

        private void Dvg_Comprobante_Compra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = Dvg_Comprobante_Compra.Rows[e.RowIndex];

            I_Id_Comprobante_Seleccionado = Convert.ToInt32(
                fila.Cells["Pk_ID_Comprobante_Compra"].Value
            );
            I_Id_Entrega_Seleccionada = Convert.ToInt32(fila.Cells["Fk_ID_Entrega_Compra"].Value);

            Cbo_Id_Comprobante_Compra.SelectedValue = Convert.ToInt32(fila.Cells["Pk_ID_Comprobante_Compra"].Value);
            Cbo_Id_Entrega_Comprobante_Compra.SelectedValue = Convert.ToInt32(fila.Cells["Fk_ID_Entrega_Compra"].Value);
            Cbo_Id_Proveedor.SelectedValue = Convert.ToInt32(fila.Cells["Fk_ID_Proveedor"].Value);

            Txt_Nombre_Receptor.Text = fila.Cells["Cmp_Nombre_Receptor"].Value.ToString();

            if (fila.Cells["Cmp_Fecha_Hora_Entrega"].Value != DBNull.Value)
            {
                Dtp_Fecha_Hora_Entrega.Value = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Hora_Entrega"].Value);
            }

            Txt_Observaciones.Text = fila.Cells["Cmp_Observaciones"].Value.ToString();
            Cbo_Estado.Text = fila.Cells["Cmp_Estado"].Value.ToString();

            fun_HabilitarCampos(true);

            Cbo_Id_Comprobante_Compra.Enabled = false;

            Btn_Crear_Comprobante.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Limpiar_Comprobante.Enabled = true;
            Btn_Eliminar.Enabled = true;

            //Fuente
            Dgv_Detalle_Entrega.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            Dgv_Detalle_Entrega.ColumnHeadersDefaultCellStyle.Font =
                new Font("Rockwell", 9, FontStyle.Bold);

            Dgv_Detalle_Entrega.EnableHeadersVisualStyles = false;
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

                controlador.Fun_Actualizar_Estado_Entrega_Compra(
                    I_Id_Entrega_Seleccionada,
                    S_Estado_Comprobante
                );

                Dgv_Detalle_Entrega.DataSource =
                    controlador.Fun_Obtener_Detalle_Entrega_Compra(I_Id_Entrega_Seleccionada);

                Dgv_Detalle_Entrega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_Detalle_Entrega.ReadOnly = true;
                Dgv_Detalle_Entrega.AllowUserToAddRows = false;

                Configurar_Dgv_Detalle_Entrega();

                AplicarEstiloDGV();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar detalle: " + Ex.Message);
            }
        }

        private void Configurar_Dgv_Detalle_Entrega()
        {
            Dgv_Detalle_Entrega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Detalle_Entrega.ReadOnly = true;
            Dgv_Detalle_Entrega.AllowUserToAddRows = false;
            Dgv_Detalle_Entrega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Dgv_Detalle_Entrega.Columns["No_Entrega"].HeaderText = "No. Entrega";
            Dgv_Detalle_Entrega.Columns["Compra"].HeaderText = "Orden de Compra";
            Dgv_Detalle_Entrega.Columns["Producto"].HeaderText = "Producto";
            Dgv_Detalle_Entrega.Columns["Cantidad"].HeaderText = "Cantidad";
            Dgv_Detalle_Entrega.Columns["Transporte"].HeaderText = "Transporte Asignado";
            Dgv_Detalle_Entrega.Columns["Direccion"].HeaderText = "Dirección de Entrega";
            Dgv_Detalle_Entrega.Columns["Fecha"].HeaderText = "Fecha Programada";
            Dgv_Detalle_Entrega.Columns["Estado"].HeaderText = "Estado de Entrega";
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (I_Id_Comprobante_Seleccionado == 0)
                {
                    MessageBox.Show("Seleccione un comprobante para eliminar.");
                    return;
                }

                DialogResult R_Respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este comprobante?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (R_Respuesta == DialogResult.No)
                {
                    return;
                }

                bool B_Resultado = controlador.Fun_Eliminar_Comprobante_Compra(
                    I_Id_Comprobante_Seleccionado
                );

                if (B_Resultado)
                {
                    MessageBox.Show("Comprobante eliminado correctamente.");

                    I_Id_Comprobante_Seleccionado = 0;
                    Limpiar_Comprobante();

                    Dvg_Comprobante_Compra.DataSource =
                        controlador.MostrarComprobantes();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el comprobante.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al eliminar: " + Ex.Message);
            }
        }

        private void Limpiar_Comprobante()
        {
            Cbo_Id_Entrega_Comprobante_Compra.SelectedIndex = -1;
            Cbo_Id_Proveedor.SelectedIndex = -1;
            Txt_Nombre_Receptor.Clear();
            Txt_Observaciones.Clear();
            Dtp_Fecha_Hora_Entrega.Value = DateTime.Now;
            Cbo_Estado.SelectedIndex = -1;
        }

        private void Frm_Comprobante_Compra_Load_1(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AplicarEstiloDGV()
        {
            Dvg_Comprobante_Compra.DefaultCellStyle.Font = new Font("Rockwell", 9);
            Dvg_Comprobante_Compra.ColumnHeadersDefaultCellStyle.Font =
                new Font("Rockwell", 9, FontStyle.Bold);

            Dvg_Comprobante_Compra.EnableHeadersVisualStyles = false;
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Comprobante_Compra reporte = new Frm_Reporte_Comprobante_Compra();
            reporte.Show();
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