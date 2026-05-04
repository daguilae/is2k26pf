using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_RO;
using System.IO;

namespace Capa_Vista_RO
{
    // ------ LETICIA SONTAY - 9959-21-9664, 28/04/2026 --------
    public partial class Frm_Detalle_Orden : Form
    {
        private bool _modoCreacion = false;
        private readonly Cls_Controlador_Orden _controlador = new Cls_Controlador_Orden();
        private int _idOrden;
        private bool _cargando = false;
        private bool _cargandoMat = false;
        // Arón Ricardo Esquit - 0901-22-13036 - 30/04/26
        private bool editandoDetalle = false;
        

        // Constructor sin parámetros llama al principal
        public Frm_Detalle_Orden() : this(0) { }

        public Frm_Detalle_Orden(int idOrden)
        {
            InitializeComponent();
            _idOrden = idOrden;
            Btn_ingresar.Enabled = true;
            EstadoControles(false);
        }

        // ------ DANI - 0901-22-9136, 29/04/2026 --------
        private void EstadoControles(bool habilitar)
        {
            panel2.Enabled = habilitar;
            panel3.Enabled = habilitar;

            Btn_modificar.Enabled = habilitar;
            Btn_eliminar.Enabled = habilitar;
            Btn_consultar.Enabled = habilitar;
            Btn_refrescar.Enabled = habilitar;
            Btn_imprimir.Enabled = habilitar;
            Btn_inicio.Enabled = habilitar;
            Btn_anterior.Enabled = habilitar;
            Btn_sig.Enabled = habilitar;
            Btn_fin.Enabled = habilitar;
            Btn_ayuda.Enabled = habilitar;

            Btn_guardar.Enabled = habilitar;
            Btn_cancelar.Enabled = habilitar;

            Btn_ingresar.Enabled = !habilitar;
            Btn_salir.Enabled = true;
        }

        private void LimpiarCampos()
        {
            Cmb_ID.SelectedIndex = -1;
            Rtxt_Observaciones.Clear();
            Nud_Cantidad.Value = 0;
        }
        // ------ DANI - 0901-22-9136, 29/04/2026 --------

        private void Frm_Detalle_Orden_Load(object sender, EventArgs e)
        {
            CargarComboEstados();
            CargarComboOrdenes();

            // ------ PAULA DANIELA LEONARDO - 0901-22-9580, 28/04/2026 --------
            InicializarColumnasMateriales(); // columnas para ingreso manual
            CargarCombosMateriales();
            // ------ PAULA DANIELA LEONARDO - 0901-22-9580, 28/04/2026 --------

            if (_idOrden > 0)
                Cmb_ID.SelectedValue = _idOrden;
        }

        // ------ DANI - 0901-22-9136, 29/04/2026 --------
        private void CargarComboEstados()
        {
            DataTable dt = _controlador.ObtenerEstadosOrden();
            Cmb_Estado.DataSource = dt;
            Cmb_Estado.DisplayMember = "NombreEstado";
            Cmb_Estado.ValueMember = "IdEstado";
            Cmb_Estado.SelectedIndex = -1;
        }
        // ------ DANI - 0901-22-9136, 29/04/2026 --------

        private void CargarComboOrdenes()
        {
            _cargando = true;
            try
            {
                DataTable dt = _controlador.ObtenerOrdenesCombo();
                Cmb_ID.DataSource = dt;
                Cmb_ID.DisplayMember = "Orden";
                Cmb_ID.ValueMember = "IdOrden";
                Cmb_ID.SelectedIndex = -1;
            }
            finally
            {
                _cargando = false;
            }
        }

        private void Cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            if (Cmb_ID.SelectedValue == null || Cmb_ID.SelectedIndex < 0) return;

            int idOrden = Convert.ToInt32(Cmb_ID.SelectedValue);
            CargarMateriales(idOrden);
            CargarDatosOrden(idOrden);
        }

        private void CargarMateriales(int idOrden)
        {
            Dgv_Materiales.DataSource = null;
            InicializarColumnasMateriales();

            DataTable dt = _controlador.ObtenerDetalleOrden(idOrden);

            if (dt.Rows.Count == 0)
            {
                label10.Text = "0.00";
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                Dgv_Materiales.Rows.Add(
                    row["Id_Material"],
                    row["Nombre_Material"],
                    row["UnidadMedida"],
                    row["CantidadSolicitada"]
                );
            }

            ActualizarTotal();
        }

        private void CargarDatosOrden(int idOrden)
        {
            DataTable dt = _controlador.ObtenerOrdenPorId(idOrden);
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];

            Cmb_Estado.SelectedValue = row["IdEstado"];

            if (row["FechaRecepcion"] != DBNull.Value)
                Dtp_Recepcion.Value = Convert.ToDateTime(row["FechaRecepcion"]);

            if (row["FechaRequerida"] != DBNull.Value)
                Dtp_Requerida.Value = Convert.ToDateTime(row["FechaRequerida"]);

            Rtxt_Observaciones.Text = row["Observacion"] != DBNull.Value
                                      ? row["Observacion"].ToString()
                                      : string.Empty;
        }
        // ------ LETICIA SONTAY - 9959-21-9664, 28/04/2026 --------


        // ------ PAULA DANIELA LEONARDO - 0901-22-9580, 28/04/2026 --------
        private void InicializarColumnasMateriales()
        {
            Dgv_Materiales.AutoGenerateColumns = false;
            Dgv_Materiales.Columns.Clear();

            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id_Material",
                HeaderText = "ID Material",
                Width = 100
            });
            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre_Material",
                HeaderText = "Nombre Material",
                Width = 200
            });
            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "UnidadMedida",
                HeaderText = "Unidad de Medida",
                Width = 120
            });
            Dgv_Materiales.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                Width = 80
            });
        }

        private void CargarCombosMateriales()
        {
            DataTable dt = _controlador.ObtenerMateriales();

            _cargandoMat = true;

            Cmb_IDMat.DataSource = dt.Copy();
            Cmb_IDMat.DisplayMember = "Codigo_Material";
            Cmb_IDMat.ValueMember = "Id_Material";
            Cmb_IDMat.SelectedIndex = -1;

            Cmb_NombreMat.DataSource = dt.Copy();
            Cmb_NombreMat.DisplayMember = "Nombre_Material";
            Cmb_NombreMat.ValueMember = "Id_Material";
            Cmb_NombreMat.SelectedIndex = -1;

            _cargandoMat = false;
            txt_UnidadDeMedida.Text = "";
        }

        private void Cmb_IDMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargandoMat || Cmb_IDMat.SelectedValue == null) return;

            _cargandoMat = true;

            int idMat = Convert.ToInt32(Cmb_IDMat.SelectedValue);
            DataTable dt = _controlador.ObtenerMaterialPorId(idMat);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Cmb_NombreMat.SelectedValue = row["Id_Material"];
                txt_UnidadDeMedida.Text = row["UnidadMedida"].ToString();
            }

            _cargandoMat = false;
        }

        private void Cmb_NombreMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargandoMat || Cmb_NombreMat.SelectedValue == null) return;

            _cargandoMat = true;

            int idMat = Convert.ToInt32(Cmb_NombreMat.SelectedValue);
            DataTable dt = _controlador.ObtenerMaterialPorId(idMat);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Cmb_IDMat.SelectedValue = row["Id_Material"];
                txt_UnidadDeMedida.Text = row["UnidadMedida"].ToString();
            }

            _cargandoMat = false;
        }

        private void txt_UnidadDeMedida_TextChanged(object sender, EventArgs e) { }

        private void Nud_Cantidad_ValueChanged(object sender, EventArgs e) { }

        private void Btn_agregarMat_Click(object sender, EventArgs e)
        {

            if (Cmb_IDMat.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un material.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Nud_Cantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow fila in Dgv_Materiales.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells["Id_Material"].Value != null &&
                    fila.Cells["Id_Material"].Value.ToString() == Cmb_IDMat.SelectedValue.ToString())
                {
                    MessageBox.Show("Este material ya fue agregado.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            Dgv_Materiales.Rows.Add(
                Cmb_IDMat.SelectedValue,
                Cmb_NombreMat.Text,
                txt_UnidadDeMedida.Text,
                Nud_Cantidad.Value
            );
            

            ActualizarTotal();

            Cmb_IDMat.SelectedIndex = -1;
            Cmb_NombreMat.SelectedIndex = -1;
            txt_UnidadDeMedida.Text = "";
            Nud_Cantidad.Value = 0;
        }

        private void Btn_eliminarMat_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un material para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dgv_Materiales.Rows.Remove(Dgv_Materiales.SelectedRows[0]);
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in Dgv_Materiales.Rows)
            {
                if (fila.Cells["Cantidad"].Value != null)
                    total += Convert.ToDecimal(fila.Cells["Cantidad"].Value);
            }
            label10.Text = total.ToString("N2");
        }
        // ------ PAULA DANIELA LEONARDO - 0901-22-9580, 28/04/2026 --------

        private void label2_Click(object sender, EventArgs e) { }
        private void Dgv_Materiales_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }

        // ------ DANI - 0901-22-9136, 29/04/2026 --------
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            _modoCreacion = true;
            EstadoControles(true);
            InicializarColumnasMateriales();
            Cmb_ID.DropDownStyle = ComboBoxStyle.Simple; 
            Cmb_ID.SelectedIndex = -1;
            Cmb_ID.Text = "";
            Cmb_ID.Focus();
        }


        // Arón Ricardo Esquit - 0901-22-13036 - 30/04/26
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea cancelar la operación?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            _modoCreacion = false;
            Cmb_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_ID.Enabled = true;

            if (resp == DialogResult.Yes)
            {
                EstadoControles(false);
                LimpiarCampos();
                InicializarColumnasMateriales();

                editandoDetalle = false;
                Cmb_ID.Enabled = true;

                Btn_guardar.Enabled = true; 
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Estado.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un estado.");
                    return;
                }

                string idLogistica = Cmb_ID.Text;
                int estado = Convert.ToInt32(Cmb_Estado.SelectedValue);
                DateTime fechaReq = Dtp_Requerida.Value;
                string obs = Rtxt_Observaciones.Text;

                DataTable dtDetalle = new DataTable();
                dtDetalle.Columns.Add("Fk_Id_Material", typeof(int));
                dtDetalle.Columns.Add("Cantidad_Solicitada", typeof(decimal));

                foreach (DataGridViewRow fila in Dgv_Materiales.Rows)
                {
                    if (fila.IsNewRow) continue;

                    if (fila.Cells["Id_Material"].Value != null)
                    {
                        DataRow dr = dtDetalle.NewRow();

                        dr["Fk_Id_Material"] = Convert.ToInt32(fila.Cells["Id_Material"].Value);
                        dr["Cantidad_Solicitada"] = Convert.ToDecimal(fila.Cells["Cantidad"].Value);

                        dtDetalle.Rows.Add(dr);
                    }
                }

                if (dtDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un material al detalle.");
                    return;
                }

                // Arón Ricardo Esquit - 0901-22-13036 - 30/04/26
                if (!_modoCreacion)
                {
                    if (Cmb_ID.SelectedValue == null)
                    {
                        MessageBox.Show("Debe seleccionar una orden.");
                        return;
                    }
                    int idOrden = Convert.ToInt32(Cmb_ID.SelectedValue);
                    bool exito = _controlador.GuardarDetalleOrden(idOrden, dtDetalle);

                    if (exito)
                    {
                        MessageBox.Show("Materiales agregados correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EstadoControles(false);
                        LimpiarCampos();
                        InicializarColumnasMateriales();
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar guardar.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    if (string.IsNullOrWhiteSpace(idLogistica))
                    {
                        MessageBox.Show("Debe ingresar un ID de logística.");
                        return;
                    }

                    bool exito = _controlador.GuardarOrdenCompleta(idLogistica, estado, fechaReq, obs, dtDetalle);

                    if (exito)
                    {
                        MessageBox.Show("Orden creada exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _modoCreacion = false;
                        Cmb_ID.DropDownStyle = ComboBoxStyle.DropDownList; // 👈 vuelve a modo solo lectura
                        Cmb_ID.Enabled = true;
                        EstadoControles(false);
                        LimpiarCampos();
                        InicializarColumnasMateriales();
                        CargarComboOrdenes();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear la orden.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Arón Ricardo Esquit - 0901-22-13036 - 30/04/26
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            if (Cmb_ID.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una orden primero.");
                return;
            }

            if (!editandoDetalle)
            {
                // Entrar en modo edición
                EstadoControles(true);
                Cmb_ID.Enabled = false;
                Btn_guardar.Enabled = false; 
                editandoDetalle = true;

                MessageBox.Show("Modo edición activado.");
                return;
            }

            // Guardar cambios (segunda vez)
            Btn_guardar_Click(sender, e);

            editandoDetalle = false;
            Cmb_ID.Enabled = true;
            Btn_guardar.Enabled = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Cmb_ID.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una orden para eliminar.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Seguro que desea eliminar esta orden y sus detalles?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                int idOrden = Convert.ToInt32(Cmb_ID.SelectedValue);
                if (_controlador.BorrarOrden(idOrden))
                {
                    MessageBox.Show("Registro eliminado correctamente.");
                    CargarComboOrdenes();
                    LimpiarCampos();
                    InicializarColumnasMateriales(); // limpia el grid al eliminar
                    EstadoControles(false);
                }
            }
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarComboOrdenes();
            CargarComboEstados();
            CargarCombosMateriales();

            LimpiarCampos();

            Cmb_Estado.SelectedIndex = -1;
            Cmb_IDMat.SelectedIndex = -1;
            Cmb_NombreMat.SelectedIndex = -1;
            txt_UnidadDeMedida.Text = "";
            Nud_Cantidad.Value = 0;

            Dgv_Materiales.DataSource = null;
            InicializarColumnasMateriales();

            label10.Text = "0.00";

            MessageBox.Show("Catálogos actualizados.");
        }
        // ------ DANI - 0901-22-9136, 29/04/2026 --------



        // Arón Ricardo Esquit - 0901-22-13036 - 30/04/26
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
                int ultimaFila = Dgv_Materiales.Rows.Count - 1;

                Dgv_Materiales.ClearSelection();
                Dgv_Materiales.Rows[ultimaFila].Selected = true;
                Dgv_Materiales.CurrentCell = Dgv_Materiales.Rows[ultimaFila].Cells[0];
            }
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.Rows.Count > 0 && Dgv_Materiales.CurrentRow != null)
            {
                int filaActual = Dgv_Materiales.CurrentRow.Index;

                if (filaActual > 0)
                {
                    Dgv_Materiales.ClearSelection();
                    Dgv_Materiales.Rows[filaActual - 1].Selected = true;
                    Dgv_Materiales.CurrentCell = Dgv_Materiales.Rows[filaActual - 1].Cells[0];
                }
            }
        }

        private void Btn_sig_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.Rows.Count > 0 && Dgv_Materiales.CurrentRow != null)
            {
                int filaActual = Dgv_Materiales.CurrentRow.Index;

                if (filaActual < Dgv_Materiales.Rows.Count - 1)
                {
                    Dgv_Materiales.ClearSelection();
                    Dgv_Materiales.Rows[filaActual + 1].Selected = true;
                    Dgv_Materiales.CurrentCell = Dgv_Materiales.Rows[filaActual + 1].Cells[0];
                }
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaBase = Path.Combine(Application.StartupPath, "Ayuda_de_Recibir_Orden.chm");

                if (File.Exists(rutaBase))
                {
                    Help.ShowHelp(this, rutaBase, HelpNavigator.Topic, "ayuda-RecibirOrden.html");
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo de ayuda.\nRuta buscada: " + rutaBase,
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ayuda:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}