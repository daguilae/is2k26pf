using Capa_controlador_Facturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            MessageBox.Show("Columnas encontradas:\n" + columnas, "Info");

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

            
            string busqueda = Txt_NumeroFactura.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese el número de factura.");
                return;
            }

            
            DataTable resultado = cont.buscarCompra(busqueda);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];

                
                idCompraSeleccionada = Convert.ToInt32(fila["pk_id_compra"]);

                // 4. Llenar campos de cabecera
                Txt_serieFactura.Text = fila["cmp_serie_factura"].ToString();
                string tipoPago = fila["cmp_tipo_compra"].ToString().ToLower().Trim();
                Cmb_tipo.Text = tipoPago;

                if (tipoPago == "credito")
                {
                    Txt_diascredito.Text = fila["cmp_dias_credito"].ToString();
                    Lbl_diascredito.Enabled = true;
                    Txt_diascredito.Enabled = true;
                }

                
                Btn_limpiar.Enabled = true;
                Btn_remover.Enabled = true;
                Btn_Agregar.Enabled = true;

                
                DataTable detalle = cont.obtenerDetalle(idCompraSeleccionada);

                if (detalle != null && detalle.Rows.Count > 0)
                {
                    Dgv_DetalleProductos.AutoGenerateColumns = false;

                   
                    Dgv_DetalleProductos.Columns["ColumnProducto"].DataPropertyName = "Producto";
                    Dgv_DetalleProductos.Columns["ColumnUnidad"].DataPropertyName = "Unidad";
                    Dgv_DetalleProductos.Columns["ColumnCantidad"].DataPropertyName = "Cantidad";
                    Dgv_DetalleProductos.Columns["ColumnPrecio"].DataPropertyName = "Precio";
                    Dgv_DetalleProductos.Columns["ColumnSubtotal"].DataPropertyName = "Subtotal";
                    Dgv_DetalleProductos.Columns["Columntotal"].DataPropertyName = "Total";

                    Dgv_DetalleProductos.DataSource = detalle;

                    decimal totalCalculado = cont.calcularTotalCompra(detalle);
                    Txt_total.Text = totalCalculado.ToString("N2");
                }
                else
                {
                    Dgv_DetalleProductos.DataSource = null;
                    Txt_total.Text = "0.00";
                    MessageBox.Show("La factura existe pero no tiene productos detallados.");
                }
            }
            else
            {
                MessageBox.Show("No se encontró ninguna factura con el número: " + busqueda);
                idCompraSeleccionada = -1;
            }
        }

             private void Btn_Editar_Click(object sender, EventArgs e)
            {

           /*
            if (idCompraSeleccionada <= 0)
            {
                MessageBox.Show("Debe buscar y seleccionar una factura antes de intentar editarla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Validaciones de campos 
            if (string.IsNullOrWhiteSpace(Txt_serieFactura.Text) || string.IsNullOrWhiteSpace(Txt_NumeroFactura.Text))
            {
                MessageBox.Show("La serie y el número de factura son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                int idProveedor = Convert.ToInt32(Cmb_proveedor.SelectedValue);
                int idOrdenCompra = Convert.ToInt32(Cmb_ordencompra.SelectedValue);
                string serie = Txt_serieFactura.Text.Trim();
                string numero = Txt_NumeroFactura.Text.Trim();
                DateTime fechaFactura = Dtp_fechaCompra.Value; 

                // Obtenemos el texto limpio para el ENUM ('contado' o 'credito')
                string tipoPago = Cmb_tipo.SelectedItem.ToString().Trim().ToLower();

                int diasCredito = 0;
                DateTime? fechaVencimiento = null;

                if (tipoPago == "credito")
                {
                    int.TryParse(Txt_diascredito.Text, out diasCredito);
                   
                    fechaVencimiento = fechaFactura.AddDays(diasCredito);
                }

           
                decimal totalFinal = 0;
                foreach (DataGridViewRow fila in Dgv_DetalleProductos.Rows)
                {
                    if (fila.IsNewRow) continue;
                    totalFinal += Convert.ToDecimal(fila.Cells["ColumnSubtotal"].Value);
                }

                cont.actualizarCompra(idCompraSeleccionada, idProveedor, idOrdenCompra, serie, numero,
                                       fechaFactura, tipoPago, totalFinal, totalFinal,
                                       diasCredito, fechaVencimiento);

               
                cont.eliminarDetalleCompra(idCompraSeleccionada);

                
                foreach (DataGridViewRow filaGrid in Dgv_DetalleProductos.Rows)
                {
                    if (filaGrid.IsNewRow) continue;

                    // Extraer valores de las celdas
                    string nombreProducto = filaGrid.Cells["ColumnProducto"].Value.ToString();
                    int idInventario = cont.obtenerIdInventario(nombreProducto);
                    string unidad = filaGrid.Cells["ColumnUniad"].Value.ToString();
                    int cantidad = Convert.ToInt32(filaGrid.Cells["ColumnCantidad"].Value);
                    decimal precio = Convert.ToDecimal(filaGrid.Cells["ColumnPrecio"].Value);

                    // Guardar línea por línea
                    cont.guardarDetalleCompra(idCompraSeleccionada, idInventario, cantidad, unidad, precio);
                }

                MessageBox.Show("Factura y detalles actualizados exitosamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                Btn_Refrescar_Click(null, null);

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("No se pudo actualizar la factura: " + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            
            */
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
    }

}


