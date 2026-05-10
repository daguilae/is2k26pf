using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Orden_Material;

namespace Capa_Vista_Orden_Material
{
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

        // Este queda vacío o lo puedes borrar
        private void Frm_Detalle_Orden_Material_Load(object sender, EventArgs e)
        {

        }

        // ✅ Toda la carga va aquí
        private void Frm_Detalle_Orden_Material_Shown(object sender, EventArgs e)
        {
            _cargando = true;
            try
            {
                InicializarColumnasDetalle();
                CargarComboEstados();
                CargarComboOrdenes();
                EstadoControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false;
            }
        }

        private void EstadoControles(bool editando)
        {
            _modoEdicion = editando;

            Cmb_Estado.Enabled = editando;
            Dtp_Recibida.Enabled = editando;
            Dtp_Solicitud.Enabled = false; // fecha solicitud nunca se edita

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

        private void CargarComboOrdenes()
        {
            _cargando = true; // ✅ bloquear el evento antes de tocar el combo
            try
            {
                DataTable dt = _controlador.ObtenerOrdenesCombo();
                Cmb_ID.DataSource = dt;
                Cmb_ID.DisplayMember = "OrdenDescripcion";
                Cmb_ID.ValueMember = "IdOrden";
                Cmb_ID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando órdenes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false; // ✅ desbloquear al terminar
            }
        }

        private void CargarComboEstados()
        {
            try
            {
                DataTable dt = _controlador.ObtenerEstadosOrden();
                Cmb_Estado.DataSource = dt;
                Cmb_Estado.DisplayMember = "NombreEstado";
                Cmb_Estado.ValueMember = "IdEstado";
                Cmb_Estado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando estados: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        // ✅ CLAVE: solo actúa si _cargando es false
        private void Cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;                                    // ✅ bloquea durante carga
            if (Cmb_ID.SelectedValue == null) return;
            if (Cmb_ID.SelectedIndex < 0) return;

            _idOrdenActual = Convert.ToInt32(Cmb_ID.SelectedValue);
            CargarEncabezado(_idOrdenActual);
            CargarDetalle(_idOrdenActual);
            EstadoControles(false);
        }

        private void CargarEncabezado(int idOrden)
        {
            try
            {
                DataTable dt = _controlador.ObtenerOrdenPorId(idOrden);
                if (dt.Rows.Count == 0) return;

                DataRow row = dt.Rows[0];

                // ✅ bloquear para que cambiar estado no dispare eventos
                _cargando = true;
                Cmb_Estado.SelectedValue = row["IdEstado"];
                _cargando = false;

                Dtp_Solicitud.Value = row["FechaSolicitud"] != DBNull.Value
                    ? Convert.ToDateTime(row["FechaSolicitud"])
                    : DateTime.Today;

                Dtp_Recibida.Value = row["FechaRecibida"] != DBNull.Value
                    ? Convert.ToDateTime(row["FechaRecibida"])
                    : DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando encabezado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetalle(int idOrden)
        {
            try
            {
                Dgv_Materiales.Rows.Clear();

                DataTable dt = _controlador.ObtenerDetalleOrden(idOrden);

                foreach (DataRow row in dt.Rows)
                {
                    Dgv_Materiales.Rows.Add(
                        row["CodigoMaterial"],
                        row["NombreMaterial"],
                        row["UnidadMedida"],
                        row["CantidadSolicitada"],
                        row["CantidadEntregada"],
                        row["CantidadPendiente"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando detalle: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            _idOrdenActual = 0;
            _cargando = true;
            Cmb_ID.SelectedIndex = -1;
            Cmb_Estado.SelectedIndex = -1;
            _cargando = false;

            Dtp_Solicitud.Value = DateTime.Today;
            Dtp_Recibida.Value = DateTime.Today;
            Dgv_Materiales.Rows.Clear();
        }

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

                    int idGuardado = _idOrdenActual;
                    CargarComboOrdenes();

                    // ✅ reseleccionar la misma orden después de recargar
                    _cargando = true;
                    Cmb_ID.SelectedValue = idGuardado;
                    _cargando = false;

                    _idOrdenActual = idGuardado;
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

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            CargarComboEstados();
            CargarComboOrdenes();
            InicializarColumnasDetalle();
            EstadoControles(false);
            MessageBox.Show("Catálogos actualizados.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de impresión en construcción.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda del módulo Detalle de Orden de Material.", "Ayuda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}