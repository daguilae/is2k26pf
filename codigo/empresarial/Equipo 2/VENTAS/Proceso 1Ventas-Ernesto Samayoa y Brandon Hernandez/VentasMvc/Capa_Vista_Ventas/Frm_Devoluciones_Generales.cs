using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ventas;


namespace Capa_Vista_Ventas
{
    public partial class Frm_Devoluciones_Generales : Form
    {

        Cls_Devolucion_Ventas_Controlador controlador = new Cls_Devolucion_Ventas_Controlador();
        public Frm_Devoluciones_Generales()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_Devoluciones_Generales_Load(object sender, EventArgs e)
        {
            fun_CargarDevoluciones();
        }


        private void fun_CargarDevoluciones()
        {
            DataTable dt = controlador.ObtenerListadoDevoluciones();

            Dgv_Ventas_Generales.DataSource = dt;

            if (Dgv_Ventas_Generales.Columns.Count == 0) return;

            Dgv_Ventas_Generales.Columns["Id_Devolucion"].HeaderText = "ID Devolución";
            Dgv_Ventas_Generales.Columns["Fecha_Venta"].HeaderText = "Fecha Venta";
            Dgv_Ventas_Generales.Columns["Fecha_Devolucion"].HeaderText = "Fecha Devolución";
            Dgv_Ventas_Generales.Columns["Cliente"].HeaderText = "Cliente";
            Dgv_Ventas_Generales.Columns["Motivo"].HeaderText = "Motivo";
            Dgv_Ventas_Generales.Columns["Producto"].HeaderText = "Producto";
            Dgv_Ventas_Generales.Columns["Cantidad"].HeaderText = "Cantidad";
            Dgv_Ventas_Generales.Columns["Subtotal"].HeaderText = "Subtotal";
            Dgv_Ventas_Generales.Columns["SaldoTotal"].HeaderText = "Saldo Total";
        }
        private void Btn_Agregar_Devolucion_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Devoluciones_Ventas detalle_devolucion_Ventas = new Frm_Detalle_Devoluciones_Ventas();
            //(MDI + CENTRADO)
            detalle_devolucion_Ventas.MdiParent = this.MdiParent;
            detalle_devolucion_Ventas.StartPosition = FormStartPosition.CenterParent;
            // ESCUCHAR CUANDO SE GUARDA
            detalle_devolucion_Ventas.DevolucionGuardada += () =>
            {
                fun_CargarDevoluciones(); //Recarga automática del grid
            };

            detalle_devolucion_Ventas.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
