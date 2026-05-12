using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_OrdenProduccion;

namespace Capa_Vista_OrdenProduccion
{
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

            // 3. Combo Estado (Desde código ya que es Enum)
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

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Recopilar datos del Encabezado
                string sIdVendedor = Cmb_Vendedor.SelectedValue?.ToString();
                DateTime dEmision = Dtp_FechaEmision.Value;
                DateTime dEstimada = Dtp_FechaEntrega.Value;
                string sEstado = Cmb_Estado.SelectedItem?.ToString();

                //Recopilar datos del detalle
                List<(string, string)> lDetalles = new List<(string, string)>();

                foreach (DataGridViewRow fila in Dgv_DetalleOrdenProduccion.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string sIdProd = fila.Cells["IdProducto"].Value.ToString();
                    string sCant = fila.Cells["CantidadSolicitada"].Value.ToString();

                    lDetalles.Add((sIdProd, sCant));
                }

                //si es editar o insertar
                if (_idOrdenEditar == 0)
                {
                    //Insertar
                    int idOrdenGenerada = oControlador.InsertarOrdenProduccion(sIdVendedor, dEmision, dEstimada, sEstado, lDetalles);

                    MessageBox.Show($"¡Orden de Producción No. {idOrdenGenerada} guardada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    //Editar
                    oControlador.ModificarOrdenProduccion(_idOrdenEditar, sIdVendedor, dEmision, dEstimada, sEstado, lDetalles);

                    MessageBox.Show($"¡Orden de Producción No. {_idOrdenEditar} modificada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            Cmb_Vendedor.SelectedIndex = -1;
            Cmb_Estado.SelectedIndex = -1;
            Dtp_FechaEmision.Value = DateTime.Now;
            Dtp_FechaEntrega.Value = DateTime.Now;
            Txt_CantidadSolicitada.Clear();
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
            // Validaciones
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

            // Agregar
            Dgv_DetalleOrdenProduccion.Rows.Add(Cmb_Producto.SelectedValue.ToString(), Cmb_Producto.Text, Txt_CantidadSolicitada.Text);

            // Limpiar
            Txt_CantidadSolicitada.Clear();
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
    }
}

