using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Capa_Controlador_CXP;

namespace Capa_Vista_CXP
{
    public partial class Frm_Compra_manual : Form
    {
        private readonly Cls_Compras_Controlador cm = new Cls_Compras_Controlador();
        private DataTable dtDetalles = new DataTable();

        public Frm_Compra_manual()
        {
            InitializeComponent();

            this.Load += Frm_Compra_manual_Load;

            Btn_agregar_detalle.Click += Btn_agregar_detalle_Click;
            Btn_quitar_detalle.Click += Btn_quitar_detalle_Click;

            Btn_guardar.Click += Btn_guardar_Click;
            Btn_ingresar.Click += Btn_ingresar_Click;
            Btn_cancelar.Click += Btn_cancelar_Click;
            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_fin.Click += Btn_fin_Click;

            Txt_cantidad_detalle.TextChanged += CalcularSubtotalDetalle_Evento;
            Txt_precio_detalle.TextChanged += CalcularSubtotalDetalle_Evento;
            Cbo_producto_detalle.SelectedIndexChanged += Cbo_producto_detalle_SelectedIndexChanged;
        }

        private void Frm_Compra_manual_Load(object sender, EventArgs e)
        {
            PrepararDetalleTemporal();
            ConfigurarGridDetalle();
            CargarCombos();
            PrepararFormulario();
        }

        private void PrepararFormulario()
        {
            Cbo_tipo_compra_ingreso.Items.Clear();
            Cbo_tipo_compra_ingreso.Items.Add("credito");
            Cbo_tipo_compra_ingreso.Items.Add("contado");
            Cbo_tipo_compra_ingreso.SelectedIndex = 0;

            Txt_subtotal_ingreso.ReadOnly = true;
            Txt_total_ingreso.ReadOnly = true;
            Txt_subtotal_detalle.ReadOnly = true;

            Txt_subtotal_ingreso.Text = "0";
            Txt_total_ingreso.Text = "0";
            Txt_subtotal_detalle.Text = "0";
        }

        private void PrepararDetalleTemporal()
        {
            dtDetalles = new DataTable();

            dtDetalles.Columns.Add("IdProducto", typeof(int));
            dtDetalles.Columns.Add("Producto", typeof(string));
            dtDetalles.Columns.Add("IdUnidad", typeof(int));
            dtDetalles.Columns.Add("Unidad", typeof(string));
            dtDetalles.Columns.Add("Cantidad", typeof(decimal));
            dtDetalles.Columns.Add("Precio", typeof(decimal));
            dtDetalles.Columns.Add("Subtotal", typeof(decimal));

            Dgv_detalle_ingreso.DataSource = dtDetalles;
        }

        private void ConfigurarGridDetalle()
        {
            Dgv_detalle_ingreso.ReadOnly = true;
            Dgv_detalle_ingreso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_detalle_ingreso.MultiSelect = false;
            Dgv_detalle_ingreso.AllowUserToAddRows = false;
            Dgv_detalle_ingreso.RowHeadersVisible = false;
            Dgv_detalle_ingreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (Dgv_detalle_ingreso.Columns.Contains("IdProducto"))
                Dgv_detalle_ingreso.Columns["IdProducto"].Visible = false;

            if (Dgv_detalle_ingreso.Columns.Contains("IdUnidad"))
                Dgv_detalle_ingreso.Columns["IdUnidad"].Visible = false;
        }

        private void CargarCombos()
        {
            Cbo_proveedor_ingreso.DataSource = cm.ObtenerProveedores();
            Cbo_proveedor_ingreso.DisplayMember = "Proveedor";
            Cbo_proveedor_ingreso.ValueMember = "IdProveedor";
            Cbo_proveedor_ingreso.SelectedIndex = -1;

            Cbo_bodega_ingreso.DataSource = cm.ObtenerBodegas();
            Cbo_bodega_ingreso.DisplayMember = "Bodega";
            Cbo_bodega_ingreso.ValueMember = "IdBodega";
            Cbo_bodega_ingreso.SelectedIndex = -1;

            Cbo_producto_detalle.DataSource = cm.ObtenerProductos();
            Cbo_producto_detalle.DisplayMember = "Producto";
            Cbo_producto_detalle.ValueMember = "IdProducto";
            Cbo_producto_detalle.SelectedIndex = -1;

            Cbo_unidad_detalle.DataSource = cm.ObtenerUnidades();
            Cbo_unidad_detalle.DisplayMember = "Unidad";
            Cbo_unidad_detalle.ValueMember = "IdUnidad";
            Cbo_unidad_detalle.SelectedIndex = -1;
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

        private void CalcularSubtotalDetalle_Evento(object sender, EventArgs e)
        {
            decimal cantidad = ConvertirDecimal(Txt_cantidad_detalle.Text);
            decimal precio = ConvertirDecimal(Txt_precio_detalle.Text);

            decimal subtotal = cantidad * precio;
            Txt_subtotal_detalle.Text = subtotal.ToString("0.00");
        }

        private void Cbo_producto_detalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_producto_detalle.SelectedIndex == -1)
                return;

            DataRowView fila = Cbo_producto_detalle.SelectedItem as DataRowView;

            if (fila != null && fila.Row.Table.Columns.Contains("Precio"))
            {
                Txt_precio_detalle.Text = fila["Precio"].ToString();
            }
        }

        private void Btn_agregar_detalle_Click(object sender, EventArgs e)
        {
            if (Cbo_producto_detalle.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (Cbo_unidad_detalle.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una unidad.");
                return;
            }

            decimal cantidad = ConvertirDecimal(Txt_cantidad_detalle.Text);
            decimal precio = ConvertirDecimal(Txt_precio_detalle.Text);

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.");
                return;
            }

            decimal subtotal = cantidad * precio;

            DataRow fila = dtDetalles.NewRow();

            fila["IdProducto"] = Convert.ToInt32(Cbo_producto_detalle.SelectedValue);
            fila["Producto"] = Cbo_producto_detalle.Text;
            fila["IdUnidad"] = Convert.ToInt32(Cbo_unidad_detalle.SelectedValue);
            fila["Unidad"] = Cbo_unidad_detalle.Text;
            fila["Cantidad"] = cantidad;
            fila["Precio"] = precio;
            fila["Subtotal"] = subtotal;

            dtDetalles.Rows.Add(fila);

            RecalcularTotales();
            LimpiarDetalle();
        }

        private void Btn_quitar_detalle_Click(object sender, EventArgs e)
        {
            if (Dgv_detalle_ingreso.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un detalle para quitar.");
                return;
            }

            Dgv_detalle_ingreso.Rows.RemoveAt(Dgv_detalle_ingreso.CurrentRow.Index);
            RecalcularTotales();
        }

        private void RecalcularTotales()
        {
            decimal total = 0;

            foreach (DataRow row in dtDetalles.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }

            Txt_subtotal_ingreso.Text = total.ToString("0.00");
            Txt_total_ingreso.Text = total.ToString("0.00");
        }

        private void LimpiarDetalle()
        {
            Cbo_producto_detalle.SelectedIndex = -1;
            Cbo_unidad_detalle.SelectedIndex = -1;
            Txt_cantidad_detalle.Clear();
            Txt_precio_detalle.Clear();
            Txt_subtotal_detalle.Text = "0";
        }

        private void LimpiarTodo()
        {
            Cbo_proveedor_ingreso.SelectedIndex = -1;
            Cbo_bodega_ingreso.SelectedIndex = -1;
            Txt_serie_factura_ingreso.Clear();
            Txt_numero_factura_ingreso.Clear();

            Dtp_fecha_ingreso.Value = DateTime.Now;
            Dtp_vencimiento_ingreso.Value = DateTime.Now;

            Txt_dias_credito_ingreso.Text = "0";

            Cbo_tipo_compra_ingreso.SelectedIndex = 0;

            dtDetalles.Clear();
            Txt_subtotal_ingreso.Text = "0";
            Txt_total_ingreso.Text = "0";

            LimpiarDetalle();
        }

        private bool ValidarEncabezado()
        {
            if (Cbo_proveedor_ingreso.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione proveedor.");
                return false;
            }

            if (Cbo_bodega_ingreso.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione bodega.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Txt_numero_factura_ingreso.Text))
            {
                MessageBox.Show("Ingrese número de factura.");
                return false;
            }

            if (Cbo_tipo_compra_ingreso.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione tipo de compra.");
                return false;
            }

            if (dtDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un detalle.");
                return false;
            }

            return true;
        }

        private void GuardarCompraManual()
        {
            if (!ValidarEncabezado())
                return;

            int idProveedor = Convert.ToInt32(Cbo_proveedor_ingreso.SelectedValue);
            int idBodega = Convert.ToInt32(Cbo_bodega_ingreso.SelectedValue);

            string serie = Txt_serie_factura_ingreso.Text.Trim();
            string factura = Txt_numero_factura_ingreso.Text.Trim();
            DateTime fecha = Dtp_fecha_ingreso.Value;
            string tipoCompra = Cbo_tipo_compra_ingreso.Text;

            int diasCredito = 0;
            int.TryParse(Txt_dias_credito_ingreso.Text, out diasCredito);

            DateTime? fechaVencimiento = Dtp_vencimiento_ingreso.Value;

            decimal subtotal = ConvertirDecimal(Txt_subtotal_ingreso.Text);
            decimal total = ConvertirDecimal(Txt_total_ingreso.Text);

            string mensaje = cm.RegistrarCompraManual(
                idProveedor,
                idBodega,
                serie,
                factura,
                fecha,
                tipoCompra,
                diasCredito,
                fechaVencimiento,
                subtotal,
                total,
                dtDetalles
            );

            MessageBox.Show(mensaje);

            if (mensaje == "Cuenta por pagar creada correctamente.")
            {
                LimpiarTodo();
                this.Close();
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarCompraManual();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarCombos();
            LimpiarTodo();
        }

        private void Btn_fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}