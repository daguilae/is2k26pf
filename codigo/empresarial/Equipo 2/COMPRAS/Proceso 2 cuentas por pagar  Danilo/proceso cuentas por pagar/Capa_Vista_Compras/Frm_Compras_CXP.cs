using Capa_Controlador_CXP;
using Capa_Vista_Compras;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Capa_Vista_CXP
{
    public partial class Frm_Compras_CXP : Form
    {
        private readonly Cls_Compras_Controlador cm = new Cls_Compras_Controlador();

        private int idCompraInicial = 0;
        private int idCompraActual = 0;
        private DataGridView Dgv_detalles;
        private Button Btn_deshacer_pago;
        private TextBox Txt_id_detalle_compra;
        private TextBox Txt_saldo_detalle;

        public Frm_Compras_CXP()
        {
            InitializeComponent();

            this.Load += Frm_Compras_CXP_Load;

            Btn_buscar.Click += Btn_buscar_Click;
            Btn_grabar.Click += Btn_grabar_Click;
            Btn_editar.Click += Btn_editar_Click;
            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_imprimir.Click += Btn_imprimir_Click;
            Btn_salir.Click += Btn_salir_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            Btn_aceptar.Click += Btn_aceptar_Click;

            Dgv_compras.CellClick += Dgv_compras_CellClick;
            Txt_adelanto.TextChanged += Txt_adelanto_TextChanged;
        }

        public Frm_Compras_CXP(int idCompra) : this()
        {
            idCompraInicial = idCompra;
        }

        private void Frm_Compras_CXP_Load(object sender, EventArgs e)
        {
            PrepararFormulario();
            CrearControlesDetalle();
            CargarIdsCompras();
            CargarNumerosFacturas();
            CargarProveedores();
            CargarCuentasPendientes();

            if (idCompraInicial > 0)
            {
                CargarCompraInicial(idCompraInicial);
            }
        }

        private void PrepararFormulario()
        {
            Cbo_id_compra.Enabled = true;
            Cbo_numero_factura.Enabled = true;
            Cbo_proveedor.Enabled = true;

            Txt_orden.ReadOnly = true;
            Txt_total.ReadOnly = true;
            Txt_saldo.ReadOnly = true;
            Txt_estado.ReadOnly = true;
            Txt_documento.ReadOnly = true;

            Dtp_fecha.Enabled = true;
            Dtp_fecha.ShowCheckBox = true;
            Dtp_fecha.Checked = false;

            Btn_grabar.Enabled = false;
            Btn_editar.Enabled = true;

            LimpiarCampos();
        }

        private void CrearControlesDetalle()
        {
            if (Dgv_detalles != null)
                return;

            Dgv_detalles = new DataGridView();
            Dgv_detalles.Name = "Dgv_detalles";
            Dgv_detalles.Left = Dgv_compras.Left;
            Dgv_detalles.Top = Dgv_compras.Bottom + 10;
            Dgv_detalles.Width = Dgv_compras.Width;
            Dgv_detalles.Height = 160;
            Dgv_detalles.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Dgv_detalles.ReadOnly = true;
            Dgv_detalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_detalles.MultiSelect = false;
            Dgv_detalles.AllowUserToAddRows = false;
            Dgv_detalles.RowHeadersVisible = false;
            Dgv_detalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_detalles.CellClick += Dgv_detalles_CellClick;

            Txt_id_detalle_compra = new TextBox();
            Txt_id_detalle_compra.Visible = false;

            Txt_saldo_detalle = new TextBox();
            Txt_saldo_detalle.Visible = false;

            Btn_deshacer_pago = new Button();
            Btn_deshacer_pago.Text = "Deshacer último pago";
            Btn_deshacer_pago.Left = Dgv_detalles.Left;
            Btn_deshacer_pago.Top = Dgv_detalles.Bottom + 10;
            Btn_deshacer_pago.Width = 170;
            Btn_deshacer_pago.Height = 30;
            Btn_deshacer_pago.Click += Btn_deshacer_pago_Click;

            this.Controls.Add(Dgv_detalles);
            this.Controls.Add(Txt_id_detalle_compra);
            this.Controls.Add(Txt_saldo_detalle);
            this.Controls.Add(Btn_deshacer_pago);
        }

        private void CargarCompraInicial(int idCompra)
        {
            idCompraActual = idCompra;

            DataTable dt = cm.BuscarDetallesCuentasFiltradas(idCompra.ToString(), "", "", null);

            Dgv_compras.DataSource = dt;
            ConfigurarGrid();
            PintarFilasPorEstado();

            if (dt.Rows.Count > 0)
            {
                Dgv_compras.ClearSelection();
                Dgv_compras.Rows[0].Selected = true;
                Dgv_compras.CurrentCell = Dgv_compras.Rows[0].Cells[0];

                CargarDatosDesdeDetalle(dt.Rows[0]);
            }
        }

        private void CargarIdsCompras()
        {
            Cbo_id_compra.DataSource = cm.ObtenerIdsComprasTodas();
            Cbo_id_compra.DisplayMember = "IdCompra";
            Cbo_id_compra.ValueMember = "IdCompra";
            Cbo_id_compra.SelectedIndex = -1;
        }

        private void CargarNumerosFacturas()
        {
            Cbo_numero_factura.DataSource = cm.ObtenerNumerosFacturasTodas();
            Cbo_numero_factura.DisplayMember = "NumeroFactura";
            Cbo_numero_factura.ValueMember = "NumeroFactura";
            Cbo_numero_factura.SelectedIndex = -1;
        }

        private void CargarProveedores()
        {
            Cbo_proveedor.DataSource = cm.ObtenerProveedores();
            Cbo_proveedor.DisplayMember = "Proveedor";
            Cbo_proveedor.ValueMember = "IdProveedor";
            Cbo_proveedor.SelectedIndex = -1;
        }


        private void CargarCuentasPendientes()
        {
            Dgv_compras.DataSource = cm.ObtenerDetallesCuentasPorPagar();
            ConfigurarGrid();
            PintarFilasPorEstado();
        }




        private void CargarDetalleCompra(int idCompra)
        {
            Dgv_detalles.DataSource = cm.ObtenerDetalleCompra(idCompra);
            ConfigurarGridDetalles();
        }

        private void ConfigurarGrid()
        {
            if (Dgv_compras.Columns.Count > 0)
            {
                Dgv_compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_compras.ReadOnly = true;
                Dgv_compras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv_compras.MultiSelect = false;
                Dgv_compras.AllowUserToAddRows = false;
                Dgv_compras.RowHeadersVisible = false;

                if (Dgv_compras.Columns.Contains("IdCuentaPorPagar"))
                    Dgv_compras.Columns["IdCuentaPorPagar"].HeaderText = "Id CXP";

                if (Dgv_compras.Columns.Contains("IdCompra"))
                    Dgv_compras.Columns["IdCompra"].HeaderText = "Id Compra";

                if (Dgv_compras.Columns.Contains("NumeroFactura"))
                    Dgv_compras.Columns["NumeroFactura"].HeaderText = "No. Factura";

                if (Dgv_compras.Columns.Contains("FechaFactura"))
                    Dgv_compras.Columns["FechaFactura"].HeaderText = "Fecha";

                if (Dgv_compras.Columns.Contains("Proveedor"))
                    Dgv_compras.Columns["Proveedor"].HeaderText = "Proveedor";

                if (Dgv_compras.Columns.Contains("IdDetalleCompra"))
                    Dgv_compras.Columns["IdDetalleCompra"].HeaderText = "Id Detalle";

                if (Dgv_compras.Columns.Contains("Producto"))
                    Dgv_compras.Columns["Producto"].HeaderText = "Producto";

                if (Dgv_compras.Columns.Contains("Cantidad"))
                    Dgv_compras.Columns["Cantidad"].HeaderText = "Cantidad";

                if (Dgv_compras.Columns.Contains("Unidad"))
                    Dgv_compras.Columns["Unidad"].HeaderText = "Unidad";

                if (Dgv_compras.Columns.Contains("PrecioUnitario"))
                    Dgv_compras.Columns["PrecioUnitario"].HeaderText = "Precio";

                if (Dgv_compras.Columns.Contains("TotalDetalle"))
                    Dgv_compras.Columns["TotalDetalle"].HeaderText = "Total Detalle";

                if (Dgv_compras.Columns.Contains("PagadoDetalle"))
                    Dgv_compras.Columns["PagadoDetalle"].HeaderText = "Pagado";

                if (Dgv_compras.Columns.Contains("SaldoDetalle"))
                    Dgv_compras.Columns["SaldoDetalle"].HeaderText = "Saldo";

                if (Dgv_compras.Columns.Contains("EstadoCuenta"))
                    Dgv_compras.Columns["EstadoCuenta"].HeaderText = "Estado";
            }
        }

        private void CargarDatosDesdeDetalle(DataRow fila)
        {
            Cbo_id_compra.SelectedValue = Convert.ToInt32(fila["IdCompra"]);
            Cbo_numero_factura.SelectedValue = fila["NumeroFactura"].ToString();
            Cbo_proveedor.Text = fila["Proveedor"].ToString();

            Txt_orden.Text = "0";
            Txt_total.Text = fila["TotalDetalle"].ToString();
            Txt_saldo.Text = fila["SaldoDetalle"].ToString();
            Txt_estado.Text = fila["EstadoCuenta"].ToString();
            Txt_documento.Text = fila["NumeroFactura"].ToString();

            Txt_id_detalle_compra.Text = fila["IdDetalleCompra"].ToString();
            Txt_saldo_detalle.Text = fila["SaldoDetalle"].ToString();

            DateTime fecha;
            if (DateTime.TryParse(fila["FechaFactura"].ToString(), out fecha))
            {
                Dtp_fecha.Value = fecha;
            }

            Txt_adelanto.Text = "0";
        }

        private void ConfigurarGridDetalles()
        {
            if (Dgv_detalles.Columns.Count > 0)
            {
                if (Dgv_detalles.Columns.Contains("IdDetalleCompra"))
                    Dgv_detalles.Columns["IdDetalleCompra"].HeaderText = "Id Detalle";

                if (Dgv_detalles.Columns.Contains("IdCompra"))
                    Dgv_detalles.Columns["IdCompra"].Visible = false;

                if (Dgv_detalles.Columns.Contains("Producto"))
                    Dgv_detalles.Columns["Producto"].HeaderText = "Producto";

                if (Dgv_detalles.Columns.Contains("Cantidad"))
                    Dgv_detalles.Columns["Cantidad"].HeaderText = "Cantidad";

                if (Dgv_detalles.Columns.Contains("Unidad"))
                    Dgv_detalles.Columns["Unidad"].HeaderText = "Unidad";

                if (Dgv_detalles.Columns.Contains("PrecioUnitario"))
                    Dgv_detalles.Columns["PrecioUnitario"].HeaderText = "Precio";

                if (Dgv_detalles.Columns.Contains("TotalDetalle"))
                    Dgv_detalles.Columns["TotalDetalle"].HeaderText = "Total";

                if (Dgv_detalles.Columns.Contains("PagadoDetalle"))
                    Dgv_detalles.Columns["PagadoDetalle"].HeaderText = "Pagado";

                if (Dgv_detalles.Columns.Contains("SaldoDetalle"))
                    Dgv_detalles.Columns["SaldoDetalle"].HeaderText = "Saldo";
            }
        }

        private void PintarFilasPorEstado()
        {
            foreach (DataGridViewRow row in Dgv_compras.Rows)
            {
                string estado = "";

                if (Dgv_compras.Columns.Contains("EstadoCuenta"))
                    estado = row.Cells["EstadoCuenta"].Value?.ToString()?.ToLower();
                else if (Dgv_compras.Columns.Contains("Estado"))
                    estado = row.Cells["Estado"].Value?.ToString()?.ToLower();

                if (estado == "pendiente")
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                else if (estado == "parcial")
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                else if (estado == "pagado")
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private decimal ConvertirDecimal(string texto)
        {
            decimal valor;

            if (!decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                decimal.TryParse(texto, out valor);
            }

            return valor;
        }

        private void CalcularSaldoTemporal()
        {
            decimal saldoActual = ConvertirDecimal(Txt_saldo.Text);
            decimal pago = ConvertirDecimal(Txt_adelanto.Text);

            if (pago < 0)
            {
                MessageBox.Show("El pago no puede ser negativo.");
                Txt_adelanto.Text = "0";
                return;
            }

            if (pago > saldoActual)
            {
                MessageBox.Show("El pago no puede ser mayor al saldo pendiente.");
                Txt_adelanto.Text = "0";
                return;
            }

            decimal saldoNuevo = cm.CalcularSaldo(saldoActual, pago);
            Txt_estado.Text = cm.ObtenerEstado(saldoNuevo);
        }

        private void DeshacerUltimoPago()
        {
            if (Cbo_id_compra.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una compra.");
                return;
            }

            idCompraActual = Convert.ToInt32(Cbo_id_compra.SelectedValue);

            DialogResult r = MessageBox.Show(
                "¿Seguro que desea deshacer el último pago de esta cuenta?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r != DialogResult.Yes)
                return;

            string mensaje = cm.DeshacerUltimoPagoDetalle(idCompraActual.ToString());

            MessageBox.Show(mensaje);

            CargarIdsCompras();
            CargarNumerosFacturas();
            CargarProveedores();

            RefrescarCompraActual();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string idCompra = "";

            if (Cbo_id_compra.SelectedIndex != -1)
                idCompra = Cbo_id_compra.SelectedValue.ToString();

            string numeroFactura = "";

            if (Cbo_numero_factura.SelectedIndex != -1)
                numeroFactura = Cbo_numero_factura.SelectedValue.ToString();

            string proveedor = "";

            if (Cbo_proveedor.SelectedIndex != -1)
                proveedor = Cbo_proveedor.Text.Trim();

            DateTime? fecha = null;

            if (Dtp_fecha.Checked)
                fecha = Dtp_fecha.Value.Date;

            if (string.IsNullOrWhiteSpace(idCompra) &&
                string.IsNullOrWhiteSpace(numeroFactura) &&
                string.IsNullOrWhiteSpace(proveedor) &&
                !fecha.HasValue)
            {
                MessageBox.Show("Ingrese al menos un filtro: Id Compra, No. Factura, Proveedor o Fecha.");
                return;
            }

            DataTable resultado = cm.BuscarDetallesCuentasFiltradas(idCompra, numeroFactura, proveedor, fecha);

            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.");
            }

            Dgv_compras.DataSource = resultado;
            ConfigurarGrid();
            PintarFilasPorEstado();
        }

        private void Btn_grabar_Click(object sender, EventArgs e)
        {
            RegistrarPago();
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            RegistrarPago();
        }

        private void RegistrarPago()
        {
            if (Cbo_id_compra.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una cuenta.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_id_detalle_compra.Text))
            {
                MessageBox.Show("Debe seleccionar un producto o detalle de la compra.");
                return;
            }

            if (ConvertirDecimal(Txt_saldo.Text) <= 0)
            {
                MessageBox.Show("Este detalle ya está pagado.");
                return;
            }

            idCompraActual = Convert.ToInt32(Cbo_id_compra.SelectedValue);

            string mensaje = cm.RegistrarPagoDetalle(
                Cbo_id_compra.SelectedValue.ToString(),
                Txt_id_detalle_compra.Text,
                Txt_saldo.Text,
                Txt_adelanto.Text,
                Txt_documento.Text
            );

            MessageBox.Show(mensaje);

            if (mensaje == "Pago de detalle registrado correctamente.")
            {
                CargarIdsCompras();
                CargarNumerosFacturas();
                CargarProveedores();

                RefrescarCompraActual();
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            DeshacerUltimoPago();
        }

        private void Btn_deshacer_pago_Click(object sender, EventArgs e)
        {
            if (Cbo_id_compra.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una compra.");
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Seguro que desea deshacer el último pago de esta cuenta?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r != DialogResult.Yes)
                return;

            int idCompra = Convert.ToInt32(Cbo_id_compra.SelectedValue);

            string mensaje = cm.DeshacerUltimoPagoDetalle(idCompra.ToString());
            MessageBox.Show(mensaje);

            CargarIdsCompras();
            CargarNumerosFacturas();
            CargarProveedores();
            CargarCuentasPendientes();
            CargarDetalleCompra(idCompra);
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarIdsCompras();
            CargarNumerosFacturas();
            CargarProveedores();
            CargarCuentasPendientes();
            LimpiarCampos();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se llamará el reporte de cuentas por pagar.");
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Txt_adelanto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_adelanto.Text))
            {
                CalcularSaldoTemporal();
            }
        }

        private void Dgv_compras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila = Dgv_compras.Rows[e.RowIndex];

                idCompraActual = Convert.ToInt32(fila.Cells["IdCompra"].Value);

                Cbo_id_compra.SelectedValue = idCompraActual;
                Cbo_numero_factura.SelectedValue = fila.Cells["NumeroFactura"].Value?.ToString() ?? "";
                Cbo_proveedor.Text = fila.Cells["Proveedor"].Value?.ToString() ?? "";

                Txt_orden.Text = "0";
                Txt_total.Text = fila.Cells["TotalDetalle"].Value?.ToString() ?? "0";
                Txt_saldo.Text = fila.Cells["SaldoDetalle"].Value?.ToString() ?? "0";
                Txt_estado.Text = fila.Cells["EstadoCuenta"].Value?.ToString() ?? "pendiente";
                Txt_documento.Text = fila.Cells["NumeroFactura"].Value?.ToString() ?? "";

                Txt_id_detalle_compra.Text = fila.Cells["IdDetalleCompra"].Value?.ToString() ?? "";
                Txt_saldo_detalle.Text = fila.Cells["SaldoDetalle"].Value?.ToString() ?? "0";

                if (fila.Cells["FechaFactura"].Value != null)
                {
                    DateTime fecha;

                    if (DateTime.TryParse(fila.Cells["FechaFactura"].Value.ToString(), out fecha))
                    {
                        Dtp_fecha.Value = fecha;
                    }
                }

                Txt_adelanto.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del grid: " + ex.Message);
            }
        }

        private void Dgv_detalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                idCompraActual = Convert.ToInt32(Cbo_id_compra.SelectedValue);
                DataGridViewRow fila = Dgv_detalles.Rows[e.RowIndex];

                Txt_id_detalle_compra.Text = fila.Cells["IdDetalleCompra"].Value.ToString();
                Txt_saldo_detalle.Text = fila.Cells["SaldoDetalle"].Value.ToString();

                Txt_total.Text = fila.Cells["TotalDetalle"].Value.ToString();
                Txt_saldo.Text = fila.Cells["SaldoDetalle"].Value.ToString();
                Txt_estado.Text = ConvertirDecimal(Txt_saldo.Text) <= 0 ? "pagado" : "parcial";
                Txt_adelanto.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message);
            }
        }

        private void RefrescarCompraActual()
        {
            if (idCompraActual > 0)
            {
                CargarCompraInicial(idCompraActual);
            }
            else
            {
                CargarCuentasPendientes();
            }
        }

        private void CargarDatosDesdeFila(DataRow fila)
        {
            Cbo_id_compra.SelectedValue = Convert.ToInt32(fila["IdCompra"]);
            Cbo_numero_factura.SelectedValue = fila["NumeroFactura"].ToString();
            Cbo_proveedor.Text = fila["Proveedor"].ToString();

            Txt_orden.Text = fila["IdOrdenCompra"].ToString();
            Txt_total.Text = fila["TotalCompra"].ToString();
            Txt_saldo.Text = fila["SaldoPendiente"].ToString();
            Txt_estado.Text = fila["Estado"].ToString();
            Txt_documento.Text = fila["NumeroFactura"].ToString();

            DateTime fecha;
            if (DateTime.TryParse(fila["FechaFactura"].ToString(), out fecha))
            {
                Dtp_fecha.Value = fecha;
            }

            Txt_adelanto.Text = "0";
        }

        private void LimpiarCampos()
        {
            Cbo_id_compra.SelectedIndex = -1;
            Cbo_id_compra.Text = "";

            Cbo_numero_factura.SelectedIndex = -1;
            Cbo_numero_factura.Text = "";

            Cbo_proveedor.SelectedIndex = -1;
            Cbo_proveedor.Text = "";

            Txt_orden.Clear();
            Txt_total.Text = "0";
            Txt_adelanto.Text = "0";
            Txt_saldo.Text = "0";
            Txt_estado.Text = "pendiente";
            Txt_documento.Clear();

            if (Txt_id_detalle_compra != null)
                Txt_id_detalle_compra.Clear();

            if (Txt_saldo_detalle != null)
                Txt_saldo_detalle.Clear();

            Dtp_fecha.Value = DateTime.Now;
            Dtp_fecha.Checked = false;
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Frm_Compra_manual frm = new Frm_Compra_manual();
            frm.ShowDialog();

            CargarIdsCompras();
            CargarNumerosFacturas();
            CargarProveedores();
            CargarCuentasPendientes();
        }
    }
}