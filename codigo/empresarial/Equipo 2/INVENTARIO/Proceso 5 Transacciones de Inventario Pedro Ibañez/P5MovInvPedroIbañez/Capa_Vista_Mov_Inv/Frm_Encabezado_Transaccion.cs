using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Mov_Inv;
using Capa_Modelo_Mov_Inv;

namespace Capa_Vista_Mov_Inv
{
    public partial class Frm_Encabezado_Transaccion : Form
    {
        public Frm_Encabezado_Transaccion()
        {
            InitializeComponent();
            fun_cargar_combos();
            EstadoInicialControles();
            EstadoInicialBotones();
        }

        Cls_Mov_Inv_Controlador ctrl = new Cls_Mov_Inv_Controlador();

        private Cls_Constructor_Encabezado _encabezado;
        public Frm_Encabezado_Transaccion(int idMovimiento, int idTipo, string tipoMovimiento, DateTime fecha, string descripcion)
        {
            InitializeComponent();



            fun_cargar_combos();
            EstadoInicialControles();
            EstadoInicialBotones();
            // Mapeo exacto con los controles del formulario
            Cbo_Id_Movimiento.SelectedValue = idMovimiento;       // ID Movimiento -> 1, 2, 3...
            CBO_ID_Tipo_Movimiento.SelectedValue = idTipo;        // ID Tipo -> 1, 2...
            DTP_FECHA_Movimiento.Value = fecha;                   // Fecha -> 1/10/2025 8:00 AM
            txt_descripcion.Text = descripcion;                   // Descripción -> "Compra inicial..."

            CargarDetallesEnGrid(idMovimiento);
        }



        private void CargarDetallesEnGrid(int idMovimiento)
        {
            try
            {
                DataTable dtDetalles = ctrl.fun_ObtenerDetallesPorMovimiento(idMovimiento);

                DGV_DETALLE_MOVIMIENTO.Rows.Clear();

                foreach (DataRow row in dtDetalles.Rows)
                {
                    int index = DGV_DETALLE_MOVIMIENTO.Rows.Add();
                    DataGridViewRow fila = DGV_DETALLE_MOVIMIENTO.Rows[index];

                    fila.Cells["Clm_ID_Producto"].Value = row["fk_inventario_id"];
                    fila.Cells["Clm_Producto"].Value = row["nombre_prod"];
                    fila.Cells["ID_unidad"].Value = row["fk_id_unidad_medida"];
                    fila.Cells["UnidadMedida"].Value = row["Nombre_Unidad"];
                    fila.Cells["ID_Bodega"].Value = row["fk_bodega_id"];
                    fila.Cells["Bodega"].Value = row["Cmp_Nombre_Bodega"];
                    fila.Cells["Clm_Cantidad"].Value = row["cantidad_transaccionada"];
                }

                DGV_DETALLE_MOVIMIENTO.AllowUserToAddRows = false;
                DGV_DETALLE_MOVIMIENTO.ReadOnly = true;
                DGV_DETALLE_MOVIMIENTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Encabezado_Transaccion_Load(object sender, EventArgs e)
        {
            fun_LlenarControles();
        }

        private void fun_LlenarControles()
        {
            try
            {
                // Llenar cada control con los datos recibidos
                Cbo_Id_Movimiento.Text = _encabezado.ID.ToString();
                DTP_FECHA_Movimiento.Value = _encabezado.Fecha;
                txt_descripcion.Text = _encabezado.Descripcion;

                // Seleccionar el tipo de movimiento en el CBO
                CBO_ID_Tipo_Movimiento.SelectedValue = _encabezado.IdTipoMovimiento;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar controles: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EstadoInicialControles()
        {
            Cbo_Id_Movimiento.Enabled = false;
            CBO_ID_Tipo_Movimiento.Enabled = false;
            Cbo_IDBodega.Enabled = false;
            DTP_FECHA_Movimiento.Enabled = false;
            txt_descripcion.Enabled = false;
            Cbo_ID_Inventario.Enabled = false;
            NUD_Cant_mov.Enabled = false;
            cbo_unidad_medida.Enabled = false;
        }

        private void EstadoInicialBotones()
        {
            Btn_Agregar_Movimiento.Enabled = true;
            Btn_Cancelar.Enabled = false;
            Btn_Modificar.Enabled = true;
            btn_buscar.Enabled = true;
            BTN_LIMPIAR_ENCABEZADO.Enabled = true;
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            btn_Guardar.Enabled = false;
            Btn_Agregar_Detalle.Enabled = false;
            Btn_Remover_Detalle.Enabled = false;
        }

        private void EstadoControlesUso()
        {
            Cbo_Id_Movimiento.Enabled = true;
            CBO_ID_Tipo_Movimiento.Enabled = true;
            Cbo_IDBodega.Enabled = true;
            DTP_FECHA_Movimiento.Enabled = true;
            txt_descripcion.Enabled = true;
            Cbo_ID_Inventario.Enabled = true;
            NUD_Cant_mov.Enabled = true;
            cbo_unidad_medida.Enabled = true;
        }

        private void EstadoBotonesUso()
        {
            Btn_Agregar_Movimiento.Enabled = false;
            Btn_Cancelar.Enabled = true;
            Btn_Modificar.Enabled = false;
            btn_buscar.Enabled = false;
            BTN_LIMPIAR_ENCABEZADO.Enabled = true;
            Btn_Reporte.Enabled = false;
            Btn_Ayuda.Enabled = false;
            btn_Guardar.Enabled = true;
            Btn_Agregar_Detalle.Enabled = true;
            Btn_Remover_Detalle.Enabled = true;
        }

        private void LimpiarControlesEncabezado()
        {
            Cbo_Id_Movimiento.SelectedIndex = -1;
            CBO_ID_Tipo_Movimiento.SelectedIndex = -1;
            DTP_FECHA_Movimiento.Value = DateTime.Today;
            txt_descripcion.Text = "";

        }

        private void LimpiarControlesDetalle()
        {
            Cbo_IDBodega.SelectedIndex = -1;
            Cbo_ID_Inventario.SelectedIndex = -1;
            NUD_Cant_mov.Value = 1;
            cbo_unidad_medida.SelectedIndex = -1;
        }

        //Cargar ComBoBoxes
        private void fun_cargar_combos()
        {
            DataTable dtIDMovInv = ctrl.fun_CargarIdsMovimiento();
            Cbo_Id_Movimiento.DataSource = dtIDMovInv;
            Cbo_Id_Movimiento.DisplayMember = "pk_movimiento_id";
            Cbo_Id_Movimiento.ValueMember = "pk_movimiento_id";
            Cbo_Id_Movimiento.SelectedIndex = -1;

            DataTable dtIdTypeMov = ctrl.fun_CargarIdTypeMov();
            CBO_ID_Tipo_Movimiento.DataSource = dtIdTypeMov;
            CBO_ID_Tipo_Movimiento.DisplayMember = "TipoMov";
            CBO_ID_Tipo_Movimiento.ValueMember = "pk_tipo_movimiento_id";
            CBO_ID_Tipo_Movimiento.SelectedIndex = -1;

            DataTable dtIdBod = ctrl.fun_CargarIdBodega();
            Cbo_IDBodega.DataSource = dtIdBod;
            Cbo_IDBodega.DisplayMember = "BODEGA";
            Cbo_IDBodega.ValueMember = "Pk_Id_Bodega";
            Cbo_IDBodega.SelectedIndex = -1;

            DataTable dtIdInv = ctrl.fun_CargarIdInventario();
            Cbo_ID_Inventario.DataSource = dtIdInv;
            Cbo_ID_Inventario.DataSource = dtIdInv;
            Cbo_ID_Inventario.DisplayMember = "INVENTARIO";
            Cbo_ID_Inventario.ValueMember = "pk_inventario_id";
            Cbo_ID_Inventario.SelectedIndex = -1;

            DataTable dtestado = ctrl.fun_UnidadMedida();
            cbo_unidad_medida.DataSource = dtestado;
            cbo_unidad_medida.DisplayMember = "UNIDAD";
            cbo_unidad_medida.ValueMember = "ID_Unidad";
            cbo_unidad_medida.SelectedIndex = -1;
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Agregar_Movimiento_Click(object sender, EventArgs e)
        {
            EstadoControlesUso();
            EstadoBotonesUso();
        }

        private void BTN_LIMPIAR_ENCABEZADO_Click(object sender, EventArgs e)
        {
            LimpiarControlesEncabezado();
        }


        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            EstadoInicialControles();
            EstadoInicialBotones();
            LimpiarControlesEncabezado();
            DGV_DETALLE_MOVIMIENTO.Rows.Clear();
        }


        private bool verificar_controles()
        {
            // Validaciones

            if (CBO_ID_Tipo_Movimiento.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de movimiento", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                MessageBox.Show("Ingresa una descripción", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                verificar_controles();

                int idTipoMovimiento = Convert.ToInt32(CBO_ID_Tipo_Movimiento.SelectedValue);
                DateTime fechaMovimiento = DTP_FECHA_Movimiento.Value;
                string descripcion = txt_descripcion.Text.Trim();

                // Capturar detalle del DGV en una lista
                List<(int idInventario,  int idBodega, float cantidad, int idUnidad)> detalle = new List<(int, int, float, int)>();
                foreach (DataGridViewRow fila in DGV_DETALLE_MOVIMIENTO.Rows)
                {
                    // Ignora la fila vacía del DGV (la que tiene *)
                    if (fila.IsNewRow) continue;

                    // También verifica que las celdas no sean null
                    if (fila.Cells[0].Value == null || fila.Cells[2].Value == null || fila.Cells[4].Value == null || fila.Cells[6].Value == null) continue;

                    int idInventario = Convert.ToInt32(fila.Cells[0].Value);   // Celda 0 = ID Producto
                    int idUnidad = Convert.ToInt32(fila.Cells[2].Value);
                    int idBodega = Convert.ToInt32(fila.Cells[4].Value);   // Celda 4 = ID Bodega
                    float cantidad = Convert.ToSingle(fila.Cells[6].Value);     // Celda 6 = Cantidad
                    detalle.Add((idInventario, idBodega, cantidad, idUnidad));
                }

                bool resultado = ctrl.fun_GuardarMovimiento(idTipoMovimiento, fechaMovimiento, descripcion, detalle);

                if (resultado)
                {
                    MessageBox.Show("Movimiento guardado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControlesEncabezado();
                    LimpiarControlesDetalle();
                    DGV_DETALLE_MOVIMIENTO.Rows.Clear();
                }
            }
            catch (InvalidOperationException ex)
            {
                // Errores de validación o stock insuficiente desde cualquier capa
                MessageBox.Show(ex.Message, "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Errores de BD o conexión desde DAO o Controlador
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Agregar_Detalle_Click(object sender, EventArgs e)
        {
            if (Cbo_ID_Inventario.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Cbo_IDBodega.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una bodega", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NUD_Cant_mov.Value < 0)
            {
                MessageBox.Show("Valor de cantidad no puede ser menor a 0", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Capturar ID y Nombre del inventario
            int idProducto = Convert.ToInt32(Cbo_ID_Inventario.SelectedValue);
            DataRowView filaInventario = (DataRowView)Cbo_ID_Inventario.SelectedItem;
            string nombreProducto = filaInventario["INVENTARIO"].ToString();

            // Capturar ID y Nombre de la bodega corregido
            int idBodega = Convert.ToInt32(Cbo_IDBodega.SelectedValue);
            DataRowView filaBodega = (DataRowView)Cbo_IDBodega.SelectedItem;
            string nombreBodega = filaBodega["BODEGA"].ToString();

            // Capturar cantidad
            int cantidad = (int)NUD_Cant_mov.Value;

            //capturar unidad
            int idUnidad = Convert.ToInt32(cbo_unidad_medida.SelectedValue);
            DataRowView filaunidad = (DataRowView)cbo_unidad_medida.SelectedItem;
            string nombreunidad = filaunidad["UNIDAD"].ToString();
            // Agregar fila al DataGridView
            DGV_DETALLE_MOVIMIENTO.Rows.Add(idProducto, nombreProducto, idUnidad,nombreunidad, idBodega, nombreBodega, cantidad);

            LimpiarControlesDetalle();
        }


        private void Btn_Remover_Detalle_Click(object sender, EventArgs e)
        {
            if (DGV_DETALLE_MOVIMIENTO.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DGV_DETALLE_MOVIMIENTO.SelectedRows[0];

                // Verificar que no sea la fila nueva vacía del DGV
                if (!filaSeleccionada.IsNewRow)
                {
                    DGV_DETALLE_MOVIMIENTO.Rows.Remove(filaSeleccionada);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_LIMPIAR_DETALE_Click(object sender, EventArgs e)
        {
            LimpiarControlesDetalle();
        }
    }
    }





