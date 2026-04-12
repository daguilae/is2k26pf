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

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EstadoInicialControles()
        {
            Cbo_Id_Movimiento.Enabled = false;
            CBO_ID_Tipo_Movimiento.Enabled = false;
            DTP_FECHA_Movimiento.Enabled = false;
            txt_descripcion.Enabled = false;
            Cbo_ID_Inventario.Enabled = false;
            NUD_Cant_mov.Enabled = false;

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
            BTN_LIMPIAR_DETALE.Enabled = false;
        }

        private void EstadoControlesUso()
        {
            Cbo_Id_Movimiento.Enabled = true;
            CBO_ID_Tipo_Movimiento.Enabled = true;
            DTP_FECHA_Movimiento.Enabled = true;
            txt_descripcion.Enabled = true;
            Cbo_ID_Inventario.Enabled = true;
            NUD_Cant_mov.Enabled = true;

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
            BTN_LIMPIAR_DETALE.Enabled = true;
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
            Cbo_ID_Inventario.SelectedIndex = -1;
            NUD_Cant_mov.Value = 1;
            DGV_DETALLE_MOVIMIENTO.Rows.Clear();
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

            DataTable dtIdInv = ctrl.fun_CargarIdInventario();
            Cbo_ID_Inventario.DataSource = dtIdInv;
            Cbo_ID_Inventario.DisplayMember = "INVENTARIO";
            Cbo_ID_Inventario.ValueMember = "pk_inventario_id";
            Cbo_ID_Inventario.SelectedIndex = -1;
        }
        
        private void Btn_Agregar_Detalle_Click(object sender, EventArgs e)
        {
                if (Cbo_ID_Inventario.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un producto", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            if (NUD_Cant_mov.Value>5000)
            {
                MessageBox.Show("Valor de cantidad no puede ser mayor a 5000", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Capturar el ID (ValueMember)
            int idProducto = Convert.ToInt32(Cbo_ID_Inventario.SelectedValue);

            // Capturar el Nombre (DisplayMember)
            DataRowView filaSeleccionada = (DataRowView)Cbo_ID_Inventario.SelectedItem;
            string nombreProducto = filaSeleccionada["INVENTARIO"].ToString();

            // Capturar cantidad
            int cantidad = (int)NUD_Cant_mov.Value;

            // Agregar fila al DataGridView con las 3 columnas: ID, Nombre, Cantidad
            DGV_DETALLE_MOVIMIENTO.Rows.Add(idProducto, nombreProducto, cantidad);

            // Limpiar controles
            Cbo_ID_Inventario.SelectedIndex = -1;
            NUD_Cant_mov.Value = 1;
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

        private void BTN_LIMPIAR_DETALE_Click(object sender, EventArgs e)
        {
            LimpiarControlesDetalle();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            EstadoInicialControles();
            EstadoInicialBotones();
            LimpiarControlesEncabezado();
            LimpiarControlesDetalle();
        }

        private void Btn_Remover_Detalle_Click(object sender, EventArgs e)
        {
            if (DGV_DETALLE_MOVIMIENTO.SelectedRows.Count > 0)
            {
                DGV_DETALLE_MOVIMIENTO.Rows.Remove(DGV_DETALLE_MOVIMIENTO.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
