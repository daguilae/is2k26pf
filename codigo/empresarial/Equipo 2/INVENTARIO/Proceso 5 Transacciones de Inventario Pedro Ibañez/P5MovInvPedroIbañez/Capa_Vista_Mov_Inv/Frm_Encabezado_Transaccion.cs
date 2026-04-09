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
        }

        Cls_Mov_Inv_Controlador ctrl = new Cls_Mov_Inv_Controlador();

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
