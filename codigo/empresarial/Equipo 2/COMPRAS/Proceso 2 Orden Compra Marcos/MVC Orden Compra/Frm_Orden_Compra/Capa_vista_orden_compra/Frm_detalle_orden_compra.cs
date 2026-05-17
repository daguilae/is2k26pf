using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_controlador_orden_compra;


namespace Capa_vista_orden_compra
{
    public partial class Frm_detalle_orden_compra : Form
    {
        Cls_controlador cont = new Cls_controlador();

        bool registroBuscado = false;
        string numeroOrdenActual = "";
        bool cargandoDatos = false;
        public Frm_detalle_orden_compra()
        {
            InitializeComponent();
            cargarProductos();
            cargarProveedores();
            cargarUnidadMedida();
            cargarBodegas();

            CalcularTotal();
            CalcularTotalresta();
            

         
            Cmb_tipoPago.Items.Add("");
            Cmb_tipoPago.Items.Add("Contado");
            Cmb_tipoPago.Items.Add("Credito");
            Cmb_tipoPago.SelectedIndex = 0;

            Txt_estado.Enabled = false;

            Txt_NumeroOrden.Text = cont.generarNumeroOrden();
            Txt_NumeroOrden.Enabled = false;

            Txt_estado.Enabled = false;

            Dtp_fechaRegistro.Value = DateTime.Now;



        }

        private void Gpo_Encabezado_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_estado_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {

            if (Cmb_producto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_Cantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Txt_PrecioUnitario.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int idInventario = Convert.ToInt32(Cmb_producto.SelectedValue);
            string producto = Cmb_producto.Text;
            string unidad = Cmb_unidad.Text;
            int idUnidad = Convert.ToInt32(Cmb_unidad.SelectedValue);

            decimal subtotal = cantidad * precio;



            int fila = Dgv_DetalleProductos.Rows.Add();

            Dgv_DetalleProductos.Rows[fila].Cells["ColumnCodigo"].Value = idInventario;

            Dgv_DetalleProductos.Rows[fila].Cells["ColumnProducto"].Value = producto;

            Dgv_DetalleProductos.Rows[fila].Cells["ColumnUnidad"].Value = unidad;

            Dgv_DetalleProductos.Rows[fila].Cells["ColumnCantidad"].Value = cantidad;

            Dgv_DetalleProductos.Rows[fila].Cells["ColumnPrecioUnitario"].Value = precio;

            Dgv_DetalleProductos.Rows[fila].Cells["ColumnSubtotal"].Value = subtotal;

            Dgv_DetalleProductos.Rows[fila].Cells["ColumnTotal"].Value = subtotal;

            Dgv_DetalleProductos.Rows[fila].Cells["ColumnIdUnidad"].Value = idUnidad;





            CalcularTotal();

            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();


        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {


            
            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();
            
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {

           
           
            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();
            



        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            if (Cmb_proveedor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un proveedor.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (Cmb_bodega.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una bodega.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (Cmb_tipoPago.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione el tipo de pago.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ───────────────── CABECERA ─────────────────

                int idProveedor = Convert.ToInt32(Cmb_proveedor.SelectedValue);

                int idBodega = Convert.ToInt32(Cmb_bodega.SelectedValue);

                string numero = Txt_NumeroOrden.Text.Trim();

                DateTime fecha = Dtp_fechaRegistro.Value;

                DateTime fechaEntrega = Dtp_fecha_entrega.Value;

                string tipoPago = Cmb_tipoPago.SelectedItem
                                                .ToString()
                                                .Trim()
                                                .ToLower();

                int diasCredito = 0;

                if (tipoPago == "credito")
                {
                    if (!int.TryParse(Txt_diascredito.Text,
                                      out diasCredito))
                    {
                        throw new Exception(
                            "Los días de crédito deben ser numéricos.");
                    }
                }

                // ───────────────── DETALLE ─────────────────

                DataTable dtDetalle = new DataTable();

                dtDetalle.Columns.Add("idInventario", typeof(int));

                dtDetalle.Columns.Add("idUnidad", typeof(int));

                dtDetalle.Columns.Add("cantidad", typeof(float));

                dtDetalle.Columns.Add("precio", typeof(decimal));

                decimal subtotalCalculado = 0;

                int contadorFila = 1;

                foreach (DataGridViewRow fila
                         in Dgv_DetalleProductos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    try
                    {
                        var valCodigo =
                            fila.Cells["ColumnCodigo"].Value;

                        var valUnidad =
                            fila.Cells["ColumnIdUnidad"].Value;

                        var valCantidad =
                            fila.Cells["ColumnCantidad"].Value;

                        var valPrecio =
                            fila.Cells["ColumnPrecioUnitario"].Value;

                        var valSubtotal =
                            fila.Cells["ColumnSubtotal"].Value;

                        if (valCodigo == null ||
                            valUnidad == null ||
                            valCantidad == null ||
                            valPrecio == null)
                        {
                            throw new Exception(
                                "Faltan datos en esta fila.");
                        }

                        int idInventario =
                            Convert.ToInt32(valCodigo);

                        int idUnidad =
                            Convert.ToInt32(valUnidad);

                        float cantidad =
                            float.Parse(
                                valCantidad.ToString(),
                                System.Globalization
                                .CultureInfo.InvariantCulture);

                        decimal precio =
                            decimal.Parse(
                                valPrecio.ToString(),
                                System.Globalization
                                .CultureInfo.InvariantCulture);

                        decimal subtotalFila =
                            decimal.Parse(
                                valSubtotal.ToString(),
                                System.Globalization
                                .CultureInfo.InvariantCulture);

                        subtotalCalculado += subtotalFila;

                        dtDetalle.Rows.Add(
                            idInventario,
                            idUnidad,
                            cantidad,
                            precio);
                    }
                    catch (Exception exFila)
                    {
                        throw new Exception(
                            $"Error en fila {contadorFila}: "
                            + exFila.Message);
                    }

                    contadorFila++;
                }

                if (dtDetalle.Rows.Count == 0)
                {
                    throw new Exception(
                        "No hay productos en el detalle.");
                }

                decimal total = subtotalCalculado;

                // ───────────────── GUARDAR ENCABEZADO ─────────────────

                int idOrden = cont.guardarOrdenCompra(
                    idProveedor,
                    idBodega,
                    numero,
                    fecha,
                    fechaEntrega,
                    tipoPago,
                    diasCredito,
                    subtotalCalculado,
                    total);

                // ───────────────── GUARDAR DETALLE ─────────────────

                foreach (DataRow row in dtDetalle.Rows)
                {
                    cont.guardarDetalleOrdenCompra(
                        idOrden,
                        Convert.ToInt32(row["idInventario"]),
                        Convert.ToInt32(row["idUnidad"]),
                        Convert.ToSingle(row["cantidad"]),
                        Convert.ToDecimal(row["precio"]));
                }

                MessageBox.Show(
                    "¡Orden de compra guardada correctamente!",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // ───────────────── LIMPIAR ─────────────────

                Dgv_DetalleProductos.Rows.Clear();

                Txt_NumeroOrden.Text =
                    cont.generarNumeroOrden();

                Txt_total.Text = "0.00";

                Txt_diascredito.Clear();

                Txt_estado.Clear();

                Cmb_tipoPago.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "NO SE PUDO GUARDAR:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }




        //Cargar los poroveedores
        private void cargarProveedores()
        {
            if (cargandoDatos) return;
            Cmb_proveedor.DataSource = cont.getProveedores();
            Cmb_proveedor.DisplayMember = "cmp_Nombre_Proveedor";
            Cmb_proveedor.ValueMember = "pk_id_proveedor";
        }


        private void cargarUnidadMedida()


        {

            if (cargandoDatos) return;
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

           
            string columnas = "";
            foreach (DataColumn col in dt.Columns)
                columnas += col.ColumnName + "\n";

            

           
            Cmb_unidad.DataSource = null;
            Cmb_unidad.DataSource = dt;
            Cmb_unidad.DisplayMember = "Nombre_Unidad"; 
            Cmb_unidad.ValueMember = "ID_Unidad";
            Cmb_unidad.SelectedIndex = -1;
        }

     


        private void cargarProductos()
        {
            if (cargandoDatos) return;
            Cmb_producto.DataSource = cont.getProductos();
            Cmb_producto.DisplayMember = "nombre_prod";
            Cmb_producto.ValueMember = "pk_inventario_id";
        }


        void cargarBodegas()
        {
            if (cargandoDatos) return ;

            Cmb_bodega.DataSource = cont.llenarComboBodega();

            Cmb_bodega.DisplayMember = "Cmp_Nombre_Bodega";
            Cmb_bodega.ValueMember = "Pk_Id_Bodega";
        }

        private void Cmb_tipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cargandoDatos) return;
           

            string tipo = Cmb_tipoPago.SelectedItem?.ToString().Trim().ToLower();

            if (tipo == "contado")
            {
             
                Txt_diascredito.Enabled = false;
             
            }
            else if (tipo == "credito")
            {
                
                Txt_diascredito.Enabled = true;
                   
            }
            else
            {
             
                Txt_diascredito.Enabled = false;
                               
            }


            
        }




        /*---------------Sumar Cnapos datagrid----------------*/




        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in Dgv_DetalleProductos.Rows)
            {
                if (row.IsNewRow) continue;

                decimal subtotal;

                if (decimal.TryParse(row.Cells["ColumnTotal"].Value?.ToString(), out decimal valorTotal))
                {
                    total += valorTotal;
                }
            }

            Txt_total.Text = total.ToString("0.00");
        }


        private void CalcularTotalresta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in Dgv_DetalleProductos.Rows)
            {
                if (row.IsNewRow) continue;

                float cantidad;
                decimal precio;

                if (!float.TryParse(row.Cells["ColumnCantidad"].Value?.ToString(), out cantidad))
                    continue;

                if (!decimal.TryParse(row.Cells["ColumnPrecioUnitario"].Value?.ToString(), out precio))
                    continue;

                total += Convert.ToDecimal(cantidad) * precio;
            }

            Txt_total.Text = total.ToString("0.00");
        }

        private void Txt_NumeroOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Txt_estado.Text = "Pendiente";
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {

            string numeroBusqueda = Txt_buscar.Text.Trim();

            if (string.IsNullOrEmpty(numeroBusqueda))
            {
                MessageBox.Show("Ingrese un número de orden para buscar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable resultado = cont.buscarOrdenCompletaPorNumero(numeroBusqueda);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ninguna orden con ese número.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Activar bandera para evitar que eventos recarguen datos
                cargandoDatos = true;

                // ══════════════ LIMPIAR DETALLE ANTES DE CARGAR ══════════════
                Dgv_DetalleProductos.Rows.Clear();

                // ══════════════ ENCABEZADO ══════════════
                DataRow cab = resultado.Rows[0];

                Txt_NumeroOrden.Text = cab["cmp_numero"].ToString();

                if (cab["cmp_fecha"] != DBNull.Value)
                    Dtp_fechaRegistro.Value = Convert.ToDateTime(cab["cmp_fecha"]);

                if (cab["cmp_fecha_entrega"] != DBNull.Value)
                    Dtp_fecha_entrega.Value = Convert.ToDateTime(cab["cmp_fecha_entrega"]);

                Txt_estado.Text = cab["cmp_estado"].ToString();

                if (cab["cmp_total"] != DBNull.Value)
                    Txt_total.Text = Convert.ToDecimal(cab["cmp_total"]).ToString("0.00");

                // Tipo pago
                string tipoPago = cab["cmp_tipo_pago"].ToString().Trim().ToLower();
                Cmb_tipoPago.SelectedItem = tipoPago == "credito" ? "Credito" : "Contado";
                Txt_diascredito.Text = cab["cmp_dias_credito"].ToString();

                // Proveedor
                if (cab["fk_id_proveedor"] != DBNull.Value)
                    Cmb_proveedor.SelectedValue = Convert.ToInt32(cab["fk_id_proveedor"]);

                // Bodega
                if (cab["fk_id_bodega"] != DBNull.Value)
                    Cmb_bodega.SelectedValue = Convert.ToInt32(cab["fk_id_bodega"]);

                // ══════════════ DETALLE ══════════════
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
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnPrecioUnitario"].Value = precio;
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnSubtotal"].Value = subtotal;
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnTotal"].Value = subtotal;
                    Dgv_DetalleProductos.Rows[index].Cells["ColumnIdUnidad"].Value = fila["fk_id_unidad"] ?? 0;
                }

                CalcularTotal();

                // Desactivar bandera
                cargandoDatos = false;
                registroBuscado = true;
                numeroOrdenActual = numeroBusqueda;

                MessageBox.Show("Orden cargada correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                cargandoDatos = false;
                MessageBox.Show("Error al buscar:\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            Frm_reporte frmreporteorden = new Frm_reporte();
            frmreporteorden.ShowDialog();
        }

        private void Cmb_unidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_fechaRegistro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {


            // Verificar que se haya buscado primero
            if (!registroBuscado || string.IsNullOrEmpty(numeroOrdenActual))
            {
                MessageBox.Show(
                    "Debe buscar un registro primero antes de eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Confirmar eliminación
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar la orden '{numeroOrdenActual}'?\n\n" +
                "Esta acción también eliminará todo el detalle y no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                cont.eliminarOrdenCompra(numeroOrdenActual);

                MessageBox.Show(
                    $"La orden '{numeroOrdenActual}' fue eliminada correctamente.",
                    "Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Limpiar el formulario
                Dgv_DetalleProductos.Rows.Clear();
                Txt_NumeroOrden.Text = cont.generarNumeroOrden();
                Txt_buscar.Clear();
                Txt_total.Text = "0.00";
                Txt_diascredito.Clear();
                Txt_estado.Clear();
                Cmb_tipoPago.SelectedIndex = 0;

                // Resetear variables de control
                registroBuscado = false;
                numeroOrdenActual = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {

            if (!registroBuscado || string.IsNullOrEmpty(numeroOrdenActual))
            {
                MessageBox.Show("Debe buscar un registro primero antes de editar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea editar la orden '{numeroOrdenActual}'?\n\n" +
                "Se actualizarán el encabezado y todo el detalle.",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                // ══════════════ VALIDACIONES ══════════════
                if (Cmb_proveedor.SelectedValue == null)
                    throw new Exception("Seleccione un proveedor.");

                if (Cmb_bodega.SelectedValue == null)
                    throw new Exception("Seleccione una bodega.");

                if (Cmb_tipoPago.SelectedIndex <= 0)
                    throw new Exception("Seleccione el tipo de pago.");

                // ══════════════ ENCABEZADO ══════════════
                int idProveedor = Convert.ToInt32(Cmb_proveedor.SelectedValue);
                int idBodega = Convert.ToInt32(Cmb_bodega.SelectedValue);
                DateTime fecha = Dtp_fechaRegistro.Value;
                DateTime fechaEntrega = Dtp_fecha_entrega.Value;

                string tipoPago = Cmb_tipoPago.SelectedItem
                                               .ToString().Trim().ToLower();
                int diasCredito = 0;
                if (tipoPago == "credito")
                {
                    if (!int.TryParse(Txt_diascredito.Text, out diasCredito))
                        throw new Exception("Los días de crédito deben ser numéricos.");
                }

                // ══════════════ DETALLE ══════════════
                var detalles = new List<(int idInventario, int idUnidad, float cantidad, decimal precio)>();
                decimal subtotal = 0;
                int contadorFila = 1;

                foreach (DataGridViewRow fila in Dgv_DetalleProductos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    var valCodigo = fila.Cells["ColumnCodigo"].Value;
                    var valUnidad = fila.Cells["ColumnIdUnidad"].Value;
                    var valCantidad = fila.Cells["ColumnCantidad"].Value;
                    var valPrecio = fila.Cells["ColumnPrecioUnitario"].Value;

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

                // ══════════════ UNA SOLA LLAMADA ══════════════
                if (detalles.Count == 0)
                {
                    cont.editarSoloEncabezado(
                        numeroOrdenActual, idProveedor, idBodega,
                        fecha, fechaEntrega, tipoPago, diasCredito,
                        subtotal, total);
                }
                else
                {
                    cont.editarOrdenCompra(
                        numeroOrdenActual, idProveedor, idBodega,
                        fecha, fechaEntrega, tipoPago, diasCredito,
                        subtotal, total, detalles);
                }

                // ══════════════ MENSAJE Y LIMPIAR ══════════════
                MessageBox.Show(
                    $"La orden '{numeroOrdenActual}' fue editada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dgv_DetalleProductos.Rows.Clear();
                Txt_NumeroOrden.Text = cont.generarNumeroOrden();
                Txt_buscar.Clear();
                Txt_total.Text = "0.00";
                Txt_diascredito.Clear();
                Txt_estado.Clear();
                Cmb_tipoPago.SelectedIndex = 0;

                registroBuscado = false;
                numeroOrdenActual = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar:\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
    
