using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Orden_Material;

namespace Capa_Vista_Orden_Material
{
    // ------ LETICIA SONTAY - 9959-21-9664, 07/05/2026 --------
    public partial class Frm_Detalle_Orden_Material : Form
    {
        private readonly Cls_Controlador_Orden_Material _controlador
            = new Cls_Controlador_Orden_Material();

        private int _idOrdenActual = 0;
        private bool _cargando = false;
        private bool _modoEdicion = false;

        public Frm_Detalle_Orden_Material()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------
        // Carga del formulario
        // -------------------------------------------------------
        private void Frm_Detalle_Orden_Material_Load(object sender, EventArgs e)
        {
            CargarComboEstados();
            CargarComboOrdenes();
            InicializarColumnasDetalle();
            EstadoControles(false);
        }

        // -------------------------------------------------------
        // Estado de controles
        // -------------------------------------------------------
        private void EstadoControles(bool editando)
        {
            _modoEdicion = editando;

            Cmb_Estado.Enabled = editando;
            Dtp_Recibida.Enabled = editando;

            Dgv_Materiales.ReadOnly = true;

            Btn_modificar.Enabled = !editando && _idOrdenActual > 0;
            Btn_guardar.Enabled = editando;
            Btn_cancelar.Enabled = editando;
            Btn_consultar.Enabled = !editando;
            Btn_refrescar.Enabled = true;
            Btn_imprimir.Enabled = !editando && _idOrdenActual > 0;

            Btn_inicio.Enabled = !editando;
            Btn_anterior.Enabled = !editando;
            Btn_sig.Enabled = !editando;
            Btn_fin.Enabled = !editando;

            Btn_salir.Enabled = true;
        }

        // -------------------------------------------------------
        // Cargar catálogos
        // -------------------------------------------------------
        private void CargarComboOrdenes()
        {
            _cargando = true;
            try
            {
                DataTable dt = _controlador.ObtenerOrdenesCombo();
                Cmb_ID.DataSource = dt;
                Cmb_ID.DisplayMember = "OrdenDescripcion";
                Cmb_ID.ValueMember = "IdOrden";
                Cmb_ID.SelectedIndex = -1;
            }
            finally
            {
                _cargando = false;
            }
        }

        private void CargarComboEstados()
        {
            DataTable dt = _controlador.ObtenerEstadosOrden();
            Cmb_Estado.DataSource = dt;
            Cmb_Estado.DisplayMember = "NombreEstado";
            Cmb_Estado.ValueMember = "IdEstado";
            Cmb_Estado.SelectedIndex = -1;
        }

        // -------------------------------------------------------
        // Inicializar columnas del DataGridView
        // -------------------------------------------------------
        private void InicializarColumnasDetalle()
        {
            Dgv_Materiales.AutoGenerateColumns = false;
            Dgv_Materiales.Columns.Clear();

            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CodigoMaterial",
                HeaderText = "Código",
                Width = 100
            });
            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreMaterial",
                HeaderText = "Material",
                Width = 220
            });
            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnidadMedida",
                HeaderText = "Unidad",
                Width = 80
            });
            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadSolicitada",
                HeaderText = "Cant. Solicitada",
                Width = 110,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            });
            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadEntregada",
                HeaderText = "Cant. Entregada",
                Width = 110,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            });
            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadPendiente",
                HeaderText = "Cant. Pendiente",
                Width = 110,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            });
        }

        // -------------------------------------------------------
        // Selección de orden en el ComboBox
        // -------------------------------------------------------
        private void Cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando || Cmb_ID.SelectedValue == null || Cmb_ID.SelectedIndex < 0)
                return;

            _idOrdenActual = Convert.ToInt32(Cmb_ID.SelectedValue);
            CargarEncabezado(_idOrdenActual);
            CargarDetalle(_idOrdenActual);
            EstadoControles(false);
        }

        // -------------------------------------------------------
        // Cargar encabezado
        // -------------------------------------------------------
        private void CargarEncabezado(int idOrden)
        {
            DataTable dt = _controlador.ObtenerOrdenPorId(idOrden);
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];

            Cmb_Estado.SelectedValue = row["IdEstado"];

            if (row["FechaSolicitud"] != DBNull.Value)
                Dtp_Solicitud.Value = Convert.ToDateTime(row["FechaSolicitud"]);

            if (row["FechaRecibida"] != DBNull.Value)
                Dtp_Recibida.Value = Convert.ToDateTime(row["FechaRecibida"]);
            else
                Dtp_Recibida.Value = DateTime.Today;
        }

        // -------------------------------------------------------
        // Cargar detalle en el grid
        // -------------------------------------------------------
        private void CargarDetalle(int idOrden)
        {
            Dgv_Materiales.Rows.Clear();

            DataTable dt = _controlador.ObtenerDetalleOrden(idOrden);

            foreach (DataRow row in dt.Rows)
            {
                Dgv_Materiales.Rows.Add(
                    row["CodigoMaterial"],
                    row["NombreMaterial"],
                    row["UnidadMedida"],       // ✅ columna agregada
                    row["CantidadSolicitada"],
                    row["CantidadEntregada"],
                    row["CantidadPendiente"]
                );
            }
        }

        // -------------------------------------------------------
        // Limpiar formulario
        // -------------------------------------------------------
        private void LimpiarFormulario()
        {
            _idOrdenActual = 0;
            _cargando = true;
            Cmb_ID.SelectedIndex = -1;
            _cargando = false;

            Cmb_Estado.SelectedIndex = -1;
            Dtp_Solicitud.Value = DateTime.Today;
            Dtp_Recibida.Value = DateTime.Today;
            Dgv_Materiales.Rows.Clear();
        }

        // -------------------------------------------------------
        // Botón Modificar
        // -------------------------------------------------------
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            if (_idOrdenActual <= 0)
            {
                MessageBox.Show("Seleccione una orden primero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EstadoControles(true);
            Cmb_ID.Enabled = false;
        }

        // -------------------------------------------------------
        // Botón Guardar
        // -------------------------------------------------------
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Estado.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un estado.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idEstado = Convert.ToInt32(Cmb_Estado.SelectedValue);
                DateTime fechaRecibida = Dtp_Recibida.Value;

                bool exito = _controlador.ModificarOrden(_idOrdenActual, idEstado, fechaRecibida);

                if (exito)
                {
                    MessageBox.Show("Orden actualizada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarComboOrdenes();

                    _cargando = true;
                    Cmb_ID.SelectedValue = _idOrdenActual;
                    _cargando = false;

                    CargarEncabezado(_idOrdenActual);
                    CargarDetalle(_idOrdenActual);

                    Cmb_ID.Enabled = true;
                    EstadoControles(false);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la orden.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------------------------------------
        // Botón Cancelar
        // -------------------------------------------------------
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                "¿Desea cancelar la edición? Se perderán los cambios no guardados.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                if (_idOrdenActual > 0)
                {
                    CargarEncabezado(_idOrdenActual);
                    CargarDetalle(_idOrdenActual);
                }

                Cmb_ID.Enabled = true;
                EstadoControles(false);
            }
        }

        // -------------------------------------------------------
        // Botón Consultar
        // -------------------------------------------------------
        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (_idOrdenActual <= 0)
            {
                MessageBox.Show("Seleccione una orden primero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarEncabezado(_idOrdenActual);
            CargarDetalle(_idOrdenActual);
        }

        // -------------------------------------------------------
        // Botón Refrescar
        // -------------------------------------------------------
        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarComboOrdenes();
            CargarComboEstados();
            LimpiarFormulario();
            InicializarColumnasDetalle();
            EstadoControles(false);
            MessageBox.Show("Catálogos actualizados.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // -------------------------------------------------------
        // Botón Imprimir
        // -------------------------------------------------------
        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            // TODO: conectar con tu reporteador cuando esté listo
            MessageBox.Show("Función de impresión en construcción.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // -------------------------------------------------------
        // Botón Ayuda
        // -------------------------------------------------------
        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda del módulo Detalle de Orden de Material.", "Ayuda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // -------------------------------------------------------
        // Navegación en el DataGridView
        // -------------------------------------------------------
        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.Rows.Count > 0)
            {
                Dgv_Materiales.ClearSelection();
                Dgv_Materiales.Rows[0].Selected = true;
                Dgv_Materiales.CurrentCell = Dgv_Materiales.Rows[0].Cells[0];
            }
        }

        private void Btn_fin_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.Rows.Count > 0)
            {
                int ultima = Dgv_Materiales.Rows.Count - 1;
                Dgv_Materiales.ClearSelection();
                Dgv_Materiales.Rows[ultima].Selected = true;
                Dgv_Materiales.CurrentCell = Dgv_Materiales.Rows[ultima].Cells[0];
            }
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.CurrentRow == null) return;
            int actual = Dgv_Materiales.CurrentRow.Index;
            if (actual > 0)
            {
                Dgv_Materiales.ClearSelection();
                Dgv_Materiales.Rows[actual - 1].Selected = true;
                Dgv_Materiales.CurrentCell = Dgv_Materiales.Rows[actual - 1].Cells[0];
            }
        }

        private void Btn_sig_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.CurrentRow == null) return;
            int actual = Dgv_Materiales.CurrentRow.Index;
            if (actual < Dgv_Materiales.Rows.Count - 1)
            {
                Dgv_Materiales.ClearSelection();
                Dgv_Materiales.Rows[actual + 1].Selected = true;
                Dgv_Materiales.CurrentCell = Dgv_Materiales.Rows[actual + 1].Cells[0];
            }
        }

        // -------------------------------------------------------
        // Botón Salir
        // -------------------------------------------------------
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    // ------ LETICIA SONTAY - 9959-21-9664, 07/05/2026 --------
}