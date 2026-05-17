using Capa_controlador_Facturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista_Factura
{
    public partial class Frm_detalle_compra : Form
    {

        Cls_controlador cont = new Cls_controlador();

        int idCompraSeleccionada = -1;
        bool registroBuscado = false;
        string numeroFacturaActual = "";
        bool cargandoDatos = false;

        private void Frm_detalle_compra_Load(object sender, EventArgs e)
        {

            cargarOrdenesCompra();
            cargarProveedores();
            cargarUnidadMedida();
            cargarProductos();
            cargarBodegas();


            Cmb_proveedor.DataSource = cont.getProveedores();
            Cmb_proveedor.DisplayMember = "cmp_Nombre_Proveedor";
            Cmb_proveedor.ValueMember = "pk_id_proveedor";

            Cmb_ordencompra.DataSource = cont.getOrdenesCompra();
            Cmb_ordencompra.DisplayMember = "cmp_numero";
            Cmb_ordencompra.ValueMember = "pk_id_orden_compra";


            Lbl_diascredito.Enabled = false;
            Lbl_fechavencimiento.Enabled = false;
            Txt_diascredito.Enabled = false;
            Dtp_FechaVencimiento.Enabled = false;



            Txt_estado.Enabled = false;
        }
        public Frm_detalle_compra()
        {
            InitializeComponent();



            Cmb_tipo.Items.Add("");
            Cmb_tipo.Items.Add("contado");
            Cmb_tipo.Items.Add("credito");
            Cmb_tipo.SelectedIndex = 0;



        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {


            if (Cmb_producto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(Txt_Cantidad.Text, out float cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Txt_PrecioUnitario.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (Cmb_unidad.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una unidad de medida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idInventario = Convert.ToInt32(Cmb_producto.SelectedValue);
            string producto = Cmb_producto.Text;
            string unidadNombre = Cmb_unidad.Text; 
            int idUnidad = Convert.ToInt32(Cmb_unidad.SelectedValue);
            int idBodega = Convert.ToInt32(Cmb_bodega.SelectedValue);
            string NombreBodega = Cmb_bodega.Text;


            decimal subtotal = (decimal)cantidad * precio;



            int n = Dgv_DetalleProductos.Rows.Add();

         
            Dgv_DetalleProductos.Rows[n].Cells["ColumnCodigo"].Value = idInventario;
            Dgv_DetalleProductos.Rows[n].Cells["ColumnProducto"].Value = producto;
            Dgv_DetalleProductos.Rows[n].Cells["ColumnUnidad"].Value = unidadNombre;
            Dgv_DetalleProductos.Rows[n].Cells["ColumnIdUnidad"].Value = idUnidad;  
            Dgv_DetalleProductos.Rows[n].Cells["ColumnCantidad"].Value = cantidad;
            Dgv_DetalleProductos.Rows[n].Cells["ColumnPrecio"].Value = precio;
            Dgv_DetalleProductos.Rows[n].Cells["ColumnSubtotal"].Value = subtotal;
            Dgv_DetalleProductos.Rows[n].Cells["ColumnTotal"].Value = subtotal;
            Dgv_DetalleProductos.Rows[n].Cells["ColumnBodega"].Value = NombreBodega;
            Dgv_DetalleProductos.Rows[n].Cells["ColumnBodega"].Tag = idBodega;


            CalcularTotal();

            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {




            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();


        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {


            if (Dgv_DetalleProductos.SelectedRows.Count > 0)
            {
                // Preguntar al usuario para evitar borrados accidentales
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar la fila seleccionada?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada
                    foreach (DataGridViewRow fila in Dgv_DetalleProductos.SelectedRows)
                    {
                        // Solo permite borrar si no es la fila nueva (la que está vacía al final)
                        if (!fila.IsNewRow)
                        {
                            Dgv_DetalleProductos.Rows.Remove(fila);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa haciendo clic en la parte izquierda.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            foreach (DataGridViewRow fila in Dgv_DetalleProductos.SelectedRows)
            {
                if (!fila.IsNewRow)
                {
                    Dgv_DetalleProductos.Rows.Remove(fila);
                }
            }

            CalcularTotal();


        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {


            Txt_serieFactura.Clear();
            Txt_NumeroFactura.Clear();
            Txt_estado.Clear();
            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();




        }

        private void Txt_total_TextChanged(object sender, EventArgs e)
        {

        }




        private void CalcularTotal()
        {
            decimal totalGeneral = 0;

            foreach (DataGridViewRow row in Dgv_DetalleProductos.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["ColumnTotal"].Value != null)
                {
                    totalGeneral += Convert.ToDecimal(row.Cells["ColumnTotal"].Value);
                }
            }

            Txt_total.Text = totalGeneral.ToString("N2");
        }


        private void CalcularTotalresta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in Dgv_DetalleProductos.Rows)
            {
                if (row.IsNewRow) continue;

                int cantidad;
                decimal precio;

                if (!int.TryParse(row.Cells["ColumnCantidad"].Value?.ToString(), out cantidad))
                    continue;

                if (!decimal.TryParse(row.Cells["ColumnPrecio"].Value?.ToString(), out precio))
                    continue;

                total += cantidad * precio;
            }

            Txt_total.Text = total.ToString("0.00");
        }

        private void Cmb_ordencompra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        //Cargar los poroveedores
        private void cargarProveedores()
        {
            Cmb_proveedor.DataSource = cont.getProveedores();
            Cmb_proveedor.DisplayMember = "cmp_Nombre_Proveedor";
            Cmb_proveedor.ValueMember = "pk_id_proveedor";
        }

        //Mostar Orden de Compra
        private void cargarOrdenesCompra()
        {
            Cmb_ordencompra.DataSource = cont.getOrdenesCompra();
            Cmb_ordencompra.DisplayMember = "cmp_numero";
            Cmb_ordencompra.ValueMember = "pk_id_orden_compra";
        }



        //Mostar Orden de Compra
        private void cargarUnidadMedida()
        {
            DataTable dt = cont.obtenerUnidadMedida();

            // DIAGNÓSTICO - Borrar después de confirmar que funciona
            if (dt == null)
            {
                MessageBox.Show("El DataTable es NULL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("El DataTable está vacío (0 filas)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ver qué columnas realmente devuelve el SQL
            string columnas = "";
            foreach (DataColumn col in dt.Columns)
                columnas += col.ColumnName + "\n";

            

            // Asignar en el orden correcto: primero DataSource, luego los members
            Cmb_unidad.DataSource = null;
            Cmb_unidad.DataSource = dt;
            Cmb_unidad.DisplayMember = "Nombre_Unidad"; // Debe coincidir exactamente con lo que muestre el MessageBox
            Cmb_unidad.ValueMember = "ID_Unidad";
            Cmb_unidad.SelectedIndex = -1;
        }

        private void Cmb_unidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void Cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Btn_Grabar_Click(object sender, EventArgs e)
        {

            // --- 1. VALIDACIONES DE CABECERA ---
            if (string.IsNullOrWhiteSpace(Txt_serieFactura.Text) || string.IsNullOrWhiteSpace(Txt_NumeroFactura.Text))
            {
                MessageBox.Show("Ingrese la serie y número de factura.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cmb_tipo.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione el tipo de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cmb_proveedor.SelectedValue == null || Cmb_ordencompra.SelectedValue == null || Cmb_bodega.SelectedValue == null)
            {
                MessageBox.Show("Seleccione proveedor, orden de compra y bodega.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // --- 2. PROCESAR DATOS DE CABECERA ---
                int idProveedor = Convert.ToInt32(Cmb_proveedor.SelectedValue);
                int idOrdenCompra = Convert.ToInt32(Cmb_ordencompra.SelectedValue);
                int idBodega = Convert.ToInt32(Cmb_bodega.SelectedValue);
                string serie = Txt_serieFactura.Text.Trim();
                string numero = Txt_NumeroFactura.Text.Trim();
                DateTime fecha = DateTime.Now;
                string tipoPago = Cmb_tipo.SelectedItem.ToString().Trim().ToLower();

                // Conversión segura de total final (quitando formatos de moneda si existen)
                string totalTxt = Txt_total.Text.Replace("Q", "").Replace("$", "").Trim();
                decimal totalFinal = decimal.Parse(totalTxt, System.Globalization.CultureInfo.InvariantCulture);

                int diasCredito = 0;
                DateTime? fechaVencimiento = null;
                if (tipoPago == "credito")
                {
                    if (!int.TryParse(Txt_diascredito.Text, out diasCredito))
                        throw new Exception("Los días de crédito deben ser un número entero.");
                    fechaVencimiento = Dtp_FechaVencimiento.Value;
                }

                // --- 3. PROCESAR DETALLE (DATATABLE) ---
                DataTable dtDetalles = new DataTable();
                dtDetalles.Columns.Add("idInventario", typeof(int));
                dtDetalles.Columns.Add("cantidad", typeof(float));
                dtDetalles.Columns.Add("idUnidad", typeof(int)); // Nombre de columna que espera tu controlador
                dtDetalles.Columns.Add("precio", typeof(decimal));

                decimal subtotalCalculado = 0;
                int contadorFila = 1;

                foreach (DataGridViewRow fila in Dgv_DetalleProductos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    try
                    {
                        
                        int idBodegaFila = Convert.ToInt32(fila.Cells["ColumnBodega"].Tag);
                        var valCodigo = fila.Cells["ColumnCodigo"].Value;
                        var valCantidad = fila.Cells["ColumnCantidad"].Value;
                        var valUnidadId = fila.Cells["ColumnIdUnidad"].Value;
                        var valPrecio = fila.Cells["ColumnPrecio"].Value;
                        var valSubtotal = fila.Cells["ColumnSubtotal"].Value;

                        if (valCodigo == null || valCantidad == null || valUnidadId == null || valPrecio == null)
                            throw new Exception("Faltan datos en esta fila.");

                        
                        int idProd = Convert.ToInt32(valCodigo);
                        float cant = float.Parse(valCantidad.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                        int idUni = Convert.ToInt32(valUnidadId); 
                        decimal prec = decimal.Parse(valPrecio.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                        decimal subFila = decimal.Parse(valSubtotal.ToString(), System.Globalization.CultureInfo.InvariantCulture);

                        subtotalCalculado += subFila;
                        dtDetalles.Rows.Add(idProd, cant, idUni, prec);
                    }
                    catch (Exception exFila)
                    {
                        throw new Exception($"Error en Fila {contadorFila}: {exFila.Message}");
                    }
                    contadorFila++;
                }

                if (dtDetalles.Rows.Count == 0) throw new Exception("No hay productos en el detalle.");

                
                cont.GuardarCompra(
                    idProveedor,
                    idOrdenCompra,
                    idBodega,
                    serie,
                    numero,
                    fecha,
                    tipoPago,
                    subtotalCalculado,
                    totalFinal,
                    diasCredito,
                    fechaVencimiento,
                    dtDetalles
                );

                MessageBox.Show("¡Compra guardada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- 5. LIMPIEZA ---
                Dgv_DetalleProductos.Rows.Clear();
                Txt_serieFactura.Clear();
                Txt_NumeroFactura.Clear();
                Txt_total.Clear();
                Txt_diascredito.Clear();
                Cmb_tipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GUARDAR:\n" + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            
        

        /*----------------------------------------------------------------------*/



        private void cargarProductos()
        {
            Cmb_producto.DataSource = cont.getProductos();
            Cmb_producto.DisplayMember = "nombre_prod";
            Cmb_producto.ValueMember = "pk_inventario_id";
        }


       
        private void Cmb_tipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string tipo = Cmb_tipo.SelectedItem?.ToString().Trim().ToLower();

            if (tipo == "contado")
            {
                Lbl_diascredito.Enabled = false;
                Lbl_fechavencimiento.Enabled = false;
                Txt_diascredito.Enabled = false;
                Dtp_FechaVencimiento.Enabled = false;

                Txt_estado.Text = "pagado"; // ← siempre pagado
            }
            else if (tipo == "credito")
            {
                Lbl_diascredito.Enabled = true;
                Lbl_fechavencimiento.Enabled = true;
                Txt_diascredito.Enabled = true;
                Dtp_FechaVencimiento.Enabled = true;

                Txt_estado.Text = "pendiente"; // ← siempre pendiente al crear
            }
            else
            {
                // Opción vacía
                Lbl_diascredito.Enabled = false;
                Lbl_fechavencimiento.Enabled = false;
                Txt_diascredito.Enabled = false;
                Dtp_FechaVencimiento.Enabled = false;

                Txt_estado.Text = ""; // ← vacío por defecto
            }
        }

        /*--------------Boton Buscar-----------------*/





        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

            string numeroBusqueda = Txt_NumeroFactura.Text.Trim();

            if (string.IsNullOrEmpty(numeroBusqueda))
            {
                MessageBox.Show("Ingrese un número de factura para buscar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable resultado = cont.buscarCompraCompletaPorNumero(numeroBusqueda);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ninguna compra con ese número.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cargandoDatos = true;
                Dgv_DetalleProductos.Rows.Clear();

                // ── Encabezado ──
                DataRow cab = resultado.Rows[0];

                Txt_serieFactura.Text = cab["cmp_serie_factura"].ToString();
                Txt_NumeroFactura.Text = cab["cmp_numero_factura"].ToString();
                Txt_estado.Text = cab["cmp_estado"].ToString();

                if (cab["cmp_fecha"] != DBNull.Value)
                    Dtp_fechaCompra.Value = Convert.ToDateTime(cab["cmp_fecha"]);

                if (cab["cmp_fecha_vencimiento"] != DBNull.Value)
                    Dtp_FechaVencimiento.Value = Convert.ToDateTime(cab["cmp_fecha_vencimiento"]);

                if (cab["cmp_total"] != DBNull.Value)
                    Txt_total.Text = Convert.ToDecimal(cab["cmp_total"]).ToString("0.00");

                string tipoCompra = cab["cmp_tipo_compra"].ToString().Trim().ToLower();
                Cmb_tipo.SelectedItem = tipoCompra == "credito" ? "Credito" : "Contado";
                Txt_diascredito.Text = cab["cmp_dias_credito"].ToString();

                if (cab["fk_id_proveedor"] != DBNull.Value)
                    Cmb_proveedor.SelectedValue = Convert.ToInt32(cab["fk_id_proveedor"]);

                if (cab["fk_id_bodega"] != DBNull.Value)
                    Cmb_bodega.SelectedValue = Convert.ToInt32(cab["fk_id_bodega"]);

                if (cab["fk_id_orden_compra"] != DBNull.Value)
                    Cmb_ordencompra.SelectedValue = Convert.ToInt32(cab["fk_id_orden_compra"]);

                // ── Detalle ──
                foreach (DataRow fila in resultado.Rows)
                {
                    if (fila["fk_inventario_id"] == DBNull.Value) continue;
                    if (fila["cmp_cantidad"] == DBNull.Value) continue;
                    if (fila["cmp_precio"] == DBNull.Value) continue;

                    decimal cantidad = Convert.ToDecimal(fila["cmp_cantidad"]);
                    decimal precio = Convert.ToDecimal(fila["cmp_precio"]);
                    decimal subtotal = cantidad * precio;

                    int index = Dgv_DetalleProductos.Rows.Add();

                    Dgv_DetalleProductos.Rows[index].Cells["ColumnCodigo"].Value = fila["fk_inventario_id"];
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnProducto"].Value = fila["nombre_prod"] ?? "";
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnUnidad"].Value = fila["Nombre_Unidad"] ?? "";
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnCantidad"].Value = cantidad;
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnPrecio"].Value = precio;
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnSubtotal"].Value = subtotal;
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnTotal"].Value = subtotal;
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnIdUnidad"].Value = fila["fk_id_unidad"] ?? 0;
                }

                CalcularTotal();

                cargandoDatos = false;
                registroBuscado = true;
                numeroFacturaActual = numeroBusqueda;

                MessageBox.Show("Compra cargada correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                cargandoDatos = false;
                MessageBox.Show("Error al buscar:\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

             private void Btn_Editar_Click(object sender, EventArgs e)
            {

            if (!registroBuscado || string.IsNullOrEmpty(numeroFacturaActual))
            {
                MessageBox.Show("Debe buscar un registro primero antes de editar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea editar la compra '{numeroFacturaActual}'?\n\n" +
                "Se actualizarán el encabezado y todo el detalle.",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                // ── Validaciones ──
                if (Cmb_proveedor.SelectedValue == null)
                    throw new Exception("Seleccione un proveedor.");

                if (Cmb_bodega.SelectedValue == null)
                    throw new Exception("Seleccione una bodega.");

                if (Cmb_tipo.SelectedIndex <= 0)
                    throw new Exception("Seleccione el tipo de compra.");

                // ── Encabezado ──
                int idProveedor = Convert.ToInt32(Cmb_proveedor.SelectedValue);
                int idBodega = Convert.ToInt32(Cmb_bodega.SelectedValue);
                int idOrdenCompra = Cmb_ordencompra.SelectedValue != null
                                           ? Convert.ToInt32(Cmb_ordencompra.SelectedValue) : 0;
                string serieFactura = Txt_serieFactura.Text.Trim();
                DateTime fecha = Dtp_fechaCompra.Value;
                DateTime fechaVenc = Dtp_FechaVencimiento.Value;
                string tipoCompra = Cmb_tipo.SelectedItem.ToString().Trim().ToLower();

                int diasCredito = 0;
                if (tipoCompra == "credito")
                {
                    if (!int.TryParse(Txt_diascredito.Text, out diasCredito))
                        throw new Exception("Los días de crédito deben ser numéricos.");
                }

                // ── Detalle ──
                var detalles = new List<(int idInventario, int idUnidad, float cantidad, decimal precio)>();
                decimal subtotal = 0;
                int contadorFila = 1;

                foreach (DataGridViewRow fila in Dgv_DetalleProductos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    var valCodigo = fila.Cells["ColumnCodigo"].Value;
                    var valUnidad = fila.Cells["ColumnIdUnidad"].Value;
                    var valCantidad = fila.Cells["ColumnCantidad"].Value;
                    var valPrecio = fila.Cells["ColumnPrecio"].Value;

                    if (valCodigo == null || valCodigo.ToString() == "") continue;
                    if (valUnidad == null || valUnidad.ToString() == "") continue;
                    if (valCantidad == null || valCantidad.ToString() == "") continue;
                    if (valPrecio == null || valPrecio.ToString() == "") continue;

                    try
                    {
                        int idInventario = Convert.ToInt32(valCodigo);
                        int idUnidad = Convert.ToInt32(valUnidad);
                        float cantidad = float.Parse(valCantidad.ToString(),
                                               System.Globalization.CultureInfo.InvariantCulture);
                        decimal precio = decimal.Parse(valPrecio.ToString(),
                                               System.Globalization.CultureInfo.InvariantCulture);

                        subtotal += Convert.ToDecimal(cantidad) * precio;
                        detalles.Add((idInventario, idUnidad, cantidad, precio));
                    }
                    catch (Exception exFila)
                    {
                        throw new Exception($"Error en fila {contadorFila}: " + exFila.Message);
                    }

                    contadorFila++;
                }

                decimal total = subtotal;

                // ── Una sola llamada ──
                if (detalles.Count == 0)
                {
                    cont.editarSoloEncabezadoCompra(
                        numeroFacturaActual, idProveedor, idBodega, idOrdenCompra,
                        serieFactura, fecha, fechaVenc, tipoCompra,
                        diasCredito, subtotal, total);
                }
                else
                {
                    cont.editarCompra(
                        numeroFacturaActual, idProveedor, idBodega, idOrdenCompra,
                        serieFactura, fecha, fechaVenc, tipoCompra,
                        diasCredito, subtotal, total, detalles);
                }

                MessageBox.Show($"La compra '{numeroFacturaActual}' fue editada correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ── Limpiar ──
                Dgv_DetalleProductos.Rows.Clear();
                Txt_serieFactura.Clear();
                Txt_NumeroFactura.Clear();
                Txt_total.Text = "0.00";
                Txt_diascredito.Clear();
                Txt_estado.Clear();
                Txt_NumeroFactura.Clear();
                Cmb_tipo.SelectedIndex = 0;

                registroBuscado = false;
                numeroFacturaActual = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar:\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        /*-------------Metodo PAra Actualizar Estado----------------*/

        




        private void Txt_estado_TextChanged(object sender, EventArgs e)
        {

            string tipo = Cmb_tipo.SelectedItem?.ToString().Trim().ToLower();

            if (tipo == "credito")
            {
                Lbl_diascredito.Enabled = true;
                Lbl_fechavencimiento.Enabled = true;
                Txt_diascredito.Enabled = true;
                Dtp_FechaVencimiento.Enabled = true;
                Txt_estado.Text = "pendiente"; // ← inicia como pendiente
            }
            else
            {
                Lbl_diascredito.Enabled = false;
                Lbl_fechavencimiento.Enabled = false;
                Txt_diascredito.Enabled = false;
                Dtp_FechaVencimiento.Enabled = false;
                Txt_estado.Text = tipo == "contado" ? "pagado" : "";
            }

        }





        void cargarBodegas()
        {



            Cmb_bodega.DataSource = cont.llenarComboBodega();

            Cmb_bodega.DisplayMember = "Cmp_Nombre_Bodega";           
            Cmb_bodega.ValueMember = "Pk_Id_Bodega";
        }

        private void Dgv_DetalleProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            Frm_reporte frm_Reporte = new Frm_reporte();
            frm_Reporte.ShowDialog();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {


            if (!registroBuscado || string.IsNullOrEmpty(numeroFacturaActual))
            {
                MessageBox.Show("Debe buscar un registro primero antes de eliminar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar la compra '{numeroFacturaActual}'?\n\n" +
                "Esta acción también eliminará todo el detalle y no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                cont.eliminarCompra(numeroFacturaActual);

                MessageBox.Show($"La compra '{numeroFacturaActual}' fue eliminada correctamente.",
                                "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dgv_DetalleProductos.Rows.Clear();
                Txt_serieFactura.Clear();
                Txt_NumeroFactura.Clear();
                Txt_total.Text = "0.00";
                Txt_diascredito.Clear();
                Txt_estado.Clear();
                Txt_NumeroFactura.Clear();
                Cmb_tipo.SelectedIndex = 0;

                registroBuscado = false;
                numeroFacturaActual = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {

            try
            {
                string rutaAyuda = Path.Combine(
                    Application.StartupPath,
                    @"Ayuda Compras.chm"
                );

                MessageBox.Show("Buscando:\n" + rutaAyuda);

                if (File.Exists(rutaAyuda))
                {
                    Help.ShowHelp(
                        this,
                        rutaAyuda,
                        HelpNavigator.Topic,
                        "Compras-Ayudas.html"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró el archivo de ayuda.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al abrir la ayuda:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }
    }

}


