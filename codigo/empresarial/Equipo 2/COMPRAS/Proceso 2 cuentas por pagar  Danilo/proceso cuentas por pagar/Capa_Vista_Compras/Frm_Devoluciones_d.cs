using Capa_Controlador_Compras;
using Capa_Vista_CXP;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Capa_Vista_Compras
{
    public partial class Frm_Devoluciones_d : Form
    {
        private readonly Cls_Devoluciones_Controlador controlador = new Cls_Devoluciones_Controlador();

        private int idCompraRecibida = 0;
        private int idCompraActual = 0;
        private int idProveedorActual = 0;
        private int? idCuentaPorPagarActual = null;

        private int idDetalleCompraActual = 0;
        private int idInventarioActual = 0;
        private decimal cantidadDisponibleActual = 0;
        private decimal precioUnitarioActual = 0;

        public Frm_Devoluciones_d()
        {
            InitializeComponent();
            InicializarEventos();
        }

        public Frm_Devoluciones_d(int idCompra)
        {
            InitializeComponent();
            idCompraRecibida = idCompra;
            InicializarEventos();
        }

        private void InicializarEventos()
        {
            this.Load += Frm_Devoluciones_d_Load;

            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            Btn_salir.Click += Btn_salir_Click;
            Btn_confirmar.Click += Btn_confirmar_Click;
            Btn_imprimir.Click += Btn_imprimir_Click;

            Cbo_id_compra.SelectionChangeCommitted += Cbo_id_compra_SelectionChangeCommitted;
            Dgv_detalle_devolucion.CellClick += Dgv_detalle_devolucion_CellClick;
        }

        private void Frm_Devoluciones_d_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarValoresIniciales();
            ConfigurarGridDetalle();

            if (idCompraRecibida > 0)
            {
                CargarCompra(idCompraRecibida);
                CargarDetalleCompra(idCompraRecibida);
            }
        }

        private void CargarValoresIniciales()
        {
            Cbo_motivo.Items.Clear();
            Cbo_motivo.Items.Add("Producto dañado");
            Cbo_motivo.Items.Add("Producto equivocado");
            Cbo_motivo.Items.Add("Exceso de compra");
            Cbo_motivo.Items.Add("Garantía");
            Cbo_motivo.Items.Add("Otro");

            Cbo_tipo_devolucion.Items.Clear();
            Cbo_tipo_devolucion.Items.Add("efectivo");
            Cbo_tipo_devolucion.Items.Add("credito");
            Cbo_tipo_devolucion.Items.Add("producto");
            Cbo_tipo_devolucion.Items.Add("ajuste");

            Txt_estado.Text = "pendiente";
            Txt_valor_monetario.Text = "0.00";
            Dtp_fecha_devolucion.Value = DateTime.Now;
        }

        private void CargarCombos()
        {
            try
            {
                Cbo_id_compra.DataSource = controlador.ObtenerIdsCompra();
                Cbo_id_compra.DisplayMember = "pk_id_compra";
                Cbo_id_compra.ValueMember = "pk_id_compra";
                Cbo_id_compra.SelectedIndex = -1;

                Cbo_numero_factura.DataSource = controlador.ObtenerFacturas();
                Cbo_numero_factura.DisplayMember = "cmp_numero_factura";
                Cbo_numero_factura.ValueMember = "cmp_numero_factura";
                Cbo_numero_factura.SelectedIndex = -1;

                Cbo_proveedor.DataSource = controlador.ObtenerProveedores();
                Cbo_proveedor.DisplayMember = "cmp_Nombre_Proveedor";
                Cbo_proveedor.ValueMember = "pk_id_proveedor";
                Cbo_proveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void ConfigurarGridDetalle()
        {
            Dgv_detalle_devolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_detalle_devolucion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_detalle_devolucion.MultiSelect = false;
            Dgv_detalle_devolucion.ReadOnly = true;
            Dgv_detalle_devolucion.AllowUserToAddRows = false;
            Dgv_detalle_devolucion.RowHeadersVisible = false;
        }

        private void ConfigurarEncabezadosDetalle()
        {
            if (Dgv_detalle_devolucion.Columns.Count == 0)
                return;

            if (Dgv_detalle_devolucion.Columns.Contains("IdDetalleCompra"))
                Dgv_detalle_devolucion.Columns["IdDetalleCompra"].HeaderText = "Id Detalle";

            if (Dgv_detalle_devolucion.Columns.Contains("IdCompra"))
                Dgv_detalle_devolucion.Columns["IdCompra"].Visible = false;

            if (Dgv_detalle_devolucion.Columns.Contains("IdInventario"))
                Dgv_detalle_devolucion.Columns["IdInventario"].Visible = false;

            if (Dgv_detalle_devolucion.Columns.Contains("Producto"))
                Dgv_detalle_devolucion.Columns["Producto"].HeaderText = "Producto";

            if (Dgv_detalle_devolucion.Columns.Contains("CantidadComprada"))
                Dgv_detalle_devolucion.Columns["CantidadComprada"].HeaderText = "Comprado";

            if (Dgv_detalle_devolucion.Columns.Contains("CantidadDevuelta"))
                Dgv_detalle_devolucion.Columns["CantidadDevuelta"].HeaderText = "Devuelto";

            if (Dgv_detalle_devolucion.Columns.Contains("CantidadDisponible"))
                Dgv_detalle_devolucion.Columns["CantidadDisponible"].HeaderText = "Disponible";

            if (Dgv_detalle_devolucion.Columns.Contains("Unidad"))
                Dgv_detalle_devolucion.Columns["Unidad"].HeaderText = "Unidad";

            if (Dgv_detalle_devolucion.Columns.Contains("PrecioUnitario"))
                Dgv_detalle_devolucion.Columns["PrecioUnitario"].HeaderText = "Precio";

            if (Dgv_detalle_devolucion.Columns.Contains("SubtotalCompra"))
                Dgv_detalle_devolucion.Columns["SubtotalCompra"].HeaderText = "Subtotal Compra";

            if (Dgv_detalle_devolucion.Columns.Contains("SubtotalDisponible"))
                Dgv_detalle_devolucion.Columns["SubtotalDisponible"].HeaderText = "Subtotal Disponible";
        }

        private decimal ConvertirDecimal(string texto)
        {
            decimal valor;

            if (!decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                decimal.TryParse(texto, NumberStyles.Any, CultureInfo.CurrentCulture, out valor);
            }

            return valor;
        }

        private void CargarCompra(int idCompra)
        {
            try
            {
                DataTable dt = controlador.BuscarCompraPorId(idCompra);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la compra seleccionada.");
                    return;
                }

                DataRow fila = dt.Rows[0];

                idCompraActual = Convert.ToInt32(fila["IdCompra"]);
                idProveedorActual = Convert.ToInt32(fila["IdProveedor"]);

                if (fila["IdCuentaPorPagar"] != DBNull.Value)
                    idCuentaPorPagarActual = Convert.ToInt32(fila["IdCuentaPorPagar"]);
                else
                    idCuentaPorPagarActual = null;

                Cbo_id_compra.SelectedValue = idCompraActual;
                Cbo_numero_factura.SelectedValue = fila["NumeroFactura"].ToString();
                Cbo_proveedor.SelectedValue = idProveedorActual;

                if (fila["FechaCompra"] != DBNull.Value)
                    Dtp_fecha_facturacion.Value = Convert.ToDateTime(fila["FechaCompra"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de compra: " + ex.Message);
            }
        }

        private void CargarDetalleCompra(int idCompra)
        {
            try
            {
                Dgv_detalle_devolucion.DataSource = controlador.ObtenerDetalleCompra(idCompra);
                ConfigurarGridDetalle();
                ConfigurarEncabezadosDetalle();
                PintarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle de compra: " + ex.Message);
            }
        }

        private void PintarDetalle()
        {
            foreach (DataGridViewRow row in Dgv_detalle_devolucion.Rows)
            {
                decimal disponible = ConvertirDecimal(row.Cells["CantidadDisponible"].Value?.ToString() ?? "0");

                if (disponible <= 0)
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void Dgv_detalle_devolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila = Dgv_detalle_devolucion.Rows[e.RowIndex];

                idDetalleCompraActual = Convert.ToInt32(fila.Cells["IdDetalleCompra"].Value);
                idInventarioActual = Convert.ToInt32(fila.Cells["IdInventario"].Value);
                cantidadDisponibleActual = ConvertirDecimal(fila.Cells["CantidadDisponible"].Value.ToString());
                precioUnitarioActual = ConvertirDecimal(fila.Cells["PrecioUnitario"].Value.ToString());

                Txt_valor_monetario.Text = "0.00";
                Txt_estado.Text = cantidadDisponibleActual <= 0 ? "sin disponible" : "pendiente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar detalle: " + ex.Message);
            }
        }

        private decimal PedirCantidadDevuelta()
        {
            Form frm = new Form();
            Label lbl = new Label();
            TextBox txt = new TextBox();
            Button btnOk = new Button();
            Button btnCancel = new Button();

            frm.Text = "Cantidad a devolver";
            frm.Width = 360;
            frm.Height = 160;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;

            lbl.Text = "Cantidad a devolver:";
            lbl.Left = 20;
            lbl.Top = 20;
            lbl.Width = 280;

            txt.Left = 20;
            txt.Top = 45;
            txt.Width = 300;

            btnOk.Text = "Aceptar";
            btnOk.Left = 70;
            btnOk.Top = 80;
            btnOk.Width = 90;
            btnOk.DialogResult = DialogResult.OK;

            btnCancel.Text = "Cancelar";
            btnCancel.Left = 170;
            btnCancel.Top = 80;
            btnCancel.Width = 90;
            btnCancel.DialogResult = DialogResult.Cancel;

            frm.Controls.Add(lbl);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOk);
            frm.Controls.Add(btnCancel);

            frm.AcceptButton = btnOk;
            frm.CancelButton = btnCancel;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                return ConvertirDecimal(txt.Text);
            }

            return 0;
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            ConfirmarDevolucion();
        }

        private void ConfirmarDevolucion()
        {
            try
            {
                if (idCompraActual <= 0)
                {
                    MessageBox.Show("Debe seleccionar una compra.");
                    return;
                }

                if (idDetalleCompraActual <= 0)
                {
                    MessageBox.Show("Seleccione un producto del detalle.");
                    return;
                }

                if (cantidadDisponibleActual <= 0)
                {
                    MessageBox.Show("Este producto ya no tiene cantidad disponible para devolver.");
                    return;
                }

                if (Cbo_motivo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione el motivo de devolución.");
                    return;
                }

                if (Cbo_tipo_devolucion.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione el tipo de devolución.");
                    return;
                }

                decimal cantidadDevuelta = PedirCantidadDevuelta();

                if (cantidadDevuelta <= 0)
                {
                    MessageBox.Show("Cantidad inválida.");
                    return;
                }

                if (cantidadDevuelta > cantidadDisponibleActual)
                {
                    MessageBox.Show("La cantidad devuelta no puede ser mayor a la cantidad disponible.");
                    return;
                }

                decimal valorMonetario = cantidadDevuelta * precioUnitarioActual;
                Txt_valor_monetario.Text = valorMonetario.ToString("0.00");

                string observacion = "Devolución parcial registrada desde el formulario.";

                string mensaje = controlador.RegistrarDevolucionParcial(
                    idCompraActual,
                    idProveedorActual,
                    idCuentaPorPagarActual,
                    idDetalleCompraActual,
                    idInventarioActual,
                    cantidadDevuelta,
                    precioUnitarioActual,
                    Cbo_motivo.Text,
                    Cbo_tipo_devolucion.Text,
                    Dtp_fecha_devolucion.Value,
                    observacion
                );

                MessageBox.Show(mensaje);

                if (mensaje == "Devolución registrada correctamente.")
                {
                    Txt_estado.Text = "aplicada";
                    CargarCompra(idCompraActual);
                    CargarDetalleCompra(idCompraActual);

                    idDetalleCompraActual = 0;
                    idInventarioActual = 0;
                    cantidadDisponibleActual = 0;
                    precioUnitarioActual = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar devolución: " + ex.Message);
            }
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_id_compra.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una compra.");
                    return;
                }

                int idCompra = Convert.ToInt32(Cbo_id_compra.SelectedValue);

                CargarCompra(idCompra);
                CargarDetalleCompra(idCompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar: " + ex.Message);
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            Cbo_id_compra.SelectedIndex = -1;
            Cbo_numero_factura.SelectedIndex = -1;
            Cbo_proveedor.SelectedIndex = -1;

            Txt_id_devolucion.Clear();
            Txt_estado.Text = "pendiente";
            Txt_valor_monetario.Text = "0.00";

            Cbo_motivo.SelectedIndex = -1;
            Cbo_tipo_devolucion.SelectedIndex = -1;

            Dtp_fecha_facturacion.Value = DateTime.Now;
            Dtp_fecha_devolucion.Value = DateTime.Now;

            Dgv_detalle_devolucion.DataSource = null;

            idCompraActual = 0;
            idProveedorActual = 0;
            idCuentaPorPagarActual = null;
            idDetalleCompraActual = 0;
            idInventarioActual = 0;
            cantidadDisponibleActual = 0;
            precioUnitarioActual = 0;
        }


        private void button14_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Frm_Visor_Reportes frm = new Frm_Visor_Reportes("Rpt_Devoluciones_Simple.rpt");
            frm.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbo_id_compra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_id_compra.SelectedValue == null)
                    return;

                int idCompra = Convert.ToInt32(Cbo_id_compra.SelectedValue);

                CargarCompra(idCompra);
                CargarDetalleCompra(idCompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar compra: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}