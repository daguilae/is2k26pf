using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_OrdenProduccion;

using System.Net.Http;
using Newtonsoft.Json;

namespace Capa_Vista_OrdenProduccion
{
    //Elaborado por Kenph Luna 9959-22-6326
    public partial class Frm_OrdenProduccion_Detalle : Form
    {
        private Cls_ControladorOrdenP oControlador = new Cls_ControladorOrdenP();
        private int _idOrdenEditar = 0;

        // Variables para guardar el estado original si se cancela
        private string _idVendedorOrig;
        private DateTime _fechaEmiOrig;
        private DateTime _fechaEstOrig;
        private string _estadoOrig;

        //estilo del dgv
        private void AplicarEstilosDGV(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            dgv.AllowUserToAddRows = false;
        }

        public Frm_OrdenProduccion_Detalle()
        {
            InitializeComponent();
            ConfigurarColumnas();
            LlenarCombos();
            AplicarEstilosDGV(Dgv_DetalleOrdenProduccion);

            Txt_IDOrden.ReadOnly = true;
            Txt_IDOrden.Text = "NUEVA ORDEN";
        }

        public Frm_OrdenProduccion_Detalle(int idOrden, string idVendedor, DateTime fechaEmi, DateTime fechaEst, string estado, bool iniciarEnModoEdicion)
        {
            InitializeComponent();
            ConfigurarColumnas();
            LlenarCombos();
            AplicarEstilosDGV(Dgv_DetalleOrdenProduccion);

            _idOrdenEditar = idOrden;

            //Guarda la copia de seguridad
            _idVendedorOrig = idVendedor;
            _fechaEmiOrig = fechaEmi;
            _fechaEstOrig = fechaEst;
            _estadoOrig = estado;

            // Cargar datos al encabezado
            Txt_IDOrden.ReadOnly = true; // Bloqueado
            Txt_IDOrden.Text = idOrden.ToString();
            Cmb_Vendedor.SelectedValue = idVendedor;
            Dtp_FechaEmision.Value = fechaEmi;
            Dtp_FechaEntrega.Value = fechaEst;
            Cmb_Estado.SelectedItem = estado;

            CargarDetallesEnGrid(idOrden);
            ActivarControles(iniciarEnModoEdicion);

            Btn_Editar.Enabled = !iniciarEnModoEdicion;
        }

        private void ConfigurarColumnas()
        {
            Dgv_DetalleOrdenProduccion.Columns.Add("IdProducto", "ID Producto");
            Dgv_DetalleOrdenProduccion.Columns.Add("NombreProducto", "Producto");
            Dgv_DetalleOrdenProduccion.Columns.Add("CantidadSolicitada", "Cantidad Solicitada");
            Dgv_DetalleOrdenProduccion.Columns.Add("CantidadRecibida", "Cantidad Recibida");
        }

        private void ActivarControles(bool activo)
        {

            // Controles del encabezado
            Cmb_Vendedor.Enabled = activo;
            Dtp_FechaEmision.Enabled = activo;
            Dtp_FechaEntrega.Enabled = activo;
            Cmb_Estado.Enabled = activo;

            // Controles del detalle
            Cmb_Producto.Enabled = activo;
            Txt_CantidadSolicitada.Enabled = activo;
            Txt_CantidadRecibida.Enabled = activo;

            // Botones de acción
            Btn_Aceptar.Enabled = activo; 
            Btn_Quitar.Enabled = activo; 
            Btn_Grabar.Enabled = activo;
            Btn_Cancelar.Enabled = activo;
        }

        private void LlenarCombos()
        {
            //Combo Vendedores
            Cmb_Vendedor.DataSource = oControlador.ObtenerVendedores();
            Cmb_Vendedor.DisplayMember = "NombreCompleto"; // El AS de MySQL
            Cmb_Vendedor.ValueMember = "Pk_Id_Vendedor";   // El ID real
            Cmb_Vendedor.SelectedIndex = -1;

            //Combo Productos
            Cmb_Producto.DataSource = oControlador.ObtenerProductos();
            Cmb_Producto.DisplayMember = "NombreProducto"; // El AS de MySQL
            Cmb_Producto.ValueMember = "pk_inventario_id"; // El ID real
            Cmb_Producto.SelectedIndex = -1;

            // Combo Estado
            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.AddRange(new string[] { "Emitida", "En Proceso", "Finalizada", "Recibida", "Cancelada" });
            Cmb_Estado.SelectedIndex = -1;
        }

        private void CargarDetallesEnGrid(int idOrden)
        {
            DataTable dtDetalles = oControlador.ObtenerDetallesPorId(idOrden);
            Dgv_DetalleOrdenProduccion.Rows.Clear();

            foreach (DataRow row in dtDetalles.Rows)
            {
                Dgv_DetalleOrdenProduccion.Rows.Add(
                    row["Fk_ID_Producto"].ToString(),           
                    row["NombreProducto"].ToString(),           
                    row["Cmp_Cantidad_Solicitada"].ToString(),  
                    row["Cmp_Cantidad_Recibida"].ToString()     
                );
            }
        }

        private void Dgv_DetalleOrdenProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Dgv_DetalleOrdenProduccion.CurrentRow != null)
            {
                DataGridViewRow fila = Dgv_DetalleOrdenProduccion.CurrentRow;

                // Cargar los datos a los controles
                Cmb_Producto.SelectedValue = fila.Cells["IdProducto"].Value.ToString();
                Txt_CantidadSolicitada.Text = fila.Cells["CantidadSolicitada"].Value.ToString();
                Txt_CantidadRecibida.Text = fila.Cells["CantidadRecibida"].Value.ToString();
            }
        }

        private void Txt_CantidadRecibida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void Btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturar datos del encabezado
                string sIdVendedor = Cmb_Vendedor.SelectedValue?.ToString();
                DateTime dEmision = Dtp_FechaEmision.Value;
                DateTime dEstimada = Dtp_FechaEntrega.Value;
                string sEstado = Cmb_Estado.SelectedItem?.ToString();

                //Preparar lista de detalle para guardar localmente (AHORA CON 3 DATOS)
                List<(string, string, string)> lDetalles = new List<(string, string, string)>();
                foreach (DataGridViewRow fila in Dgv_DetalleOrdenProduccion.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string sIdProd = fila.Cells["IdProducto"].Value.ToString();
                    string sCantSol = fila.Cells["CantidadSolicitada"].Value.ToString();
                    string sCantRec = fila.Cells["CantidadRecibida"].Value.ToString();

                    lDetalles.Add((sIdProd, sCantSol, sCantRec));
                }

                if (_idOrdenEditar == 0)
                {
                    //Guardar primero en la BD local de Logística
                    // (Asegúrate de que tu controlador ya no pida los datos de Orden de Compra)
                    int idOrdenGenerada = oControlador.InsertarOrdenProduccion(
                        sIdVendedor, dEmision, dEstimada, sEstado, lDetalles);

                    if (idOrdenGenerada > 0)
                    {
                        MessageBox.Show(
                            $"¡Orden No. {idOrdenGenerada} guardada localmente!",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Sincronizar con la API del MRP
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;

                            //construir el objeto para la API
                            var ordenParaApi = new
                            {
                                idOrdenProduccion = idOrdenGenerada,
                                fechaEmision = dEmision,
                                estado = sEstado,
                                detalle = Dgv_DetalleOrdenProduccion.Rows
                                    .Cast<DataGridViewRow>()
                                    .Where(f => !f.IsNewRow)
                                    .Select(f =>
                                    {
                                // Limpieza de nombre
                                string nombreBruto = f.Cells["NombreProducto"].Value.ToString();
                                        string nombreLimpio = nombreBruto.Contains("-")
                                            ? string.Join("-", nombreBruto.Split('-').Skip(1)).Trim()
                                            : nombreBruto.Trim();

                                // Parseo con cultura invariante
                                decimal cantidad = decimal.Parse(
                                            f.Cells["CantidadSolicitada"].Value.ToString(),
                                            CultureInfo.InvariantCulture);

                                        return new
                                        {
                                            nombreProducto = nombreLimpio,
                                            cantidadSolicitada = cantidad
                                        };
                                    }).ToList()
                            };

                            // Llamada asíncrona al servicio API
                            Cls_ServicioAPI servicio = new Cls_ServicioAPI();
                            string errorApi = await servicio.EnviarOrdenAProduccion(ordenParaApi);

                            this.Cursor = Cursors.Default;

                            if (errorApi == null)
                            {
                                // La API aceptó la orden correctamente
                                MessageBox.Show(
                                    "Sincronizado con Producción (MRP) correctamente.",
                                    "API OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // La API rechazó la orden — se muestra el motivo exacto
                                MessageBox.Show(
                                    "Orden guardada localmente, pero el MRP la rechazó.\n\n" +
                                    "Motivo del MRP:\n" + errorApi + "\n\n" +
                                    "Causa probable: el nombre del producto no coincide\n" +
                                    "exactamente con la tabla de materiales del MRP.",
                                    "Aviso de Sincronización",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception exApi)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(
                                "Error de conexión con el MRP:\n" + exApi.Message,
                                "Error de Red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LimpiarFormulario();
                    }
                }
                else
                {                   
                    oControlador.ModificarOrdenProduccion(
                        _idOrdenEditar, sIdVendedor, dEmision, dEstimada, sEstado, lDetalles);

                    MessageBox.Show(
                        $"¡Orden No. {_idOrdenEditar} modificada con éxito!",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (ArgumentException ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Error al procesar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            Cmb_Vendedor.SelectedIndex = -1;
            Cmb_Estado.SelectedIndex = -1;
            Dtp_FechaEmision.Value = DateTime.Now;
            Dtp_FechaEntrega.Value = DateTime.Now;
            Txt_CantidadSolicitada.Clear();
            Txt_CantidadRecibida.Clear();
            Dgv_DetalleOrdenProduccion.Rows.Clear();
        }

        private void Btn_Quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_DetalleOrdenProduccion.CurrentRow != null)
            {
                Dgv_DetalleOrdenProduccion.Rows.Remove(Dgv_DetalleOrdenProduccion.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            // Validaciones visuales
            if (Cmb_Producto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_CantidadSolicitada.Text))
            {
                MessageBox.Show("Ingrese una cantidad solicitada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_CantidadSolicitada.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_CantidadRecibida.Text))
            {
                MessageBox.Show("Ingrese una cantidad recibida. Si aún no recibe nada, ingrese 0.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_CantidadRecibida.Focus();
                return;
            }

            int solicitada = Convert.ToInt32(Txt_CantidadSolicitada.Text);
            int recibida = Convert.ToInt32(Txt_CantidadRecibida.Text);

            if (recibida > solicitada)
            {
                MessageBox.Show("La cantidad recibida no puede ser mayor a la cantidad solicitada.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_CantidadRecibida.Focus();
                return;
            }

            //verifica si el producto ya esta en  grid para actualizarlo en lugar de duplicarlo
            string idProductoAInsertar = Cmb_Producto.SelectedValue.ToString();
            bool productoExiste = false;

            foreach (DataGridViewRow fila in Dgv_DetalleOrdenProduccion.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == idProductoAInsertar)
                {
                    // Si ya existe actualiza
                    fila.Cells["CantidadSolicitada"].Value = Txt_CantidadSolicitada.Text;
                    fila.Cells["CantidadRecibida"].Value = Txt_CantidadRecibida.Text;
                    productoExiste = true;
                    break;
                }
            }

            // Si no existe lo agrega
            if (!productoExiste)
            {
                Dgv_DetalleOrdenProduccion.Rows.Add(
                    Cmb_Producto.SelectedValue.ToString(),
                    Cmb_Producto.Text,
                    Txt_CantidadSolicitada.Text,
                    Txt_CantidadRecibida.Text
                );
            }

            // Limpiar para el siguiente ingreso
            Txt_CantidadSolicitada.Clear();
            Txt_CantidadRecibida.Clear();
            Cmb_Producto.SelectedIndex = -1;
        }

        //Evita que el usuario ponga letras en Cantidad Solicitada
        private void txtCantidadSolicitada_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_OrdenProduccion_Detalle_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (_idOrdenEditar > 0)
            {
                ActivarControles(true);
                Btn_Editar.Enabled = false;

                MessageBox.Show("Modo edición habilitado. Puede realizar sus cambios y presionar Grabar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay ninguna orden cargada para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            if (_idOrdenEditar > 0)
            {
                CargarDetallesEnGrid(_idOrdenEditar);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (_idOrdenEditar > 0)
            {
                //restaura valores originales
                Cmb_Vendedor.SelectedValue = _idVendedorOrig;
                Dtp_FechaEmision.Value = _fechaEmiOrig;
                Dtp_FechaEntrega.Value = _fechaEstOrig;
                Cmb_Estado.SelectedItem = _estadoOrig;

                CargarDetallesEnGrid(_idOrdenEditar);

                ActivarControles(false);

                Btn_Editar.Enabled = true;

                MessageBox.Show("Se ha cancelado la edición. Los datos han vuelto a su estado original.", "Edición Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarFormulario();
            }
        }

        //Botones de movimiento de filas
        private void NavegarGridDetalle(string accion)
        {
            if (Dgv_DetalleOrdenProduccion.Rows.Count == 0) return;

            int indiceActual = Dgv_DetalleOrdenProduccion.CurrentRow != null ? Dgv_DetalleOrdenProduccion.CurrentRow.Index : 0;
            int indiceFinal = Dgv_DetalleOrdenProduccion.Rows.Count - 1;
            int nuevoIndice = indiceActual;

            if (accion == "Inicio")
                nuevoIndice = 0;
            else if (accion == "Anterior")
                nuevoIndice = (indiceActual > 0) ? indiceActual - 1 : 0;
            else if (accion == "Siguiente")
                nuevoIndice = (indiceActual < indiceFinal) ? indiceActual + 1 : indiceFinal;
            else if (accion == "Fin")
                nuevoIndice = indiceFinal;

            Dgv_DetalleOrdenProduccion.CurrentCell = Dgv_DetalleOrdenProduccion.Rows[nuevoIndice].Cells[0];
            Dgv_DetalleOrdenProduccion.Rows[nuevoIndice].Selected = true;
        }

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            NavegarGridDetalle("Inicio");
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            NavegarGridDetalle("Anterior");
        }

        private void Btn_sig_Click(object sender, EventArgs e)
        {
            NavegarGridDetalle("Siguiente");
        }

        private void Btn_fin_Click(object sender, EventArgs e)
        {
            NavegarGridDetalle("Fin");
        }
    }
}

