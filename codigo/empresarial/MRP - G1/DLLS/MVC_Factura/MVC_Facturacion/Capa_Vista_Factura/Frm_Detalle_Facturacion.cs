using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Factura;


namespace Capa_Vista_Factura
{
    public partial class Frm_Detalle_Facturacion : Form
    {
        Cls_Controlador_Detalle controladorDetalle = new Cls_Controlador_Detalle();
        int IDFactura = 0;

        public Frm_Detalle_Facturacion(int iCodigoFactura)
        {
            InitializeComponent();
            IDFactura = iCodigoFactura;

            Dgv_Detalle.Rows.Clear();
            Dgv_Detalle.Columns.Add("totalMateriales", "Total Materiales");
            Dgv_Detalle.Columns.Add("totalManoObra", "Total Mano de Obra");
            Dgv_Detalle.Columns.Add("totalCostos", "Total Costos Indirectos");
            Dgv_Detalle.Columns.Add("totalMermas", "Total Mermas");
            Dgv_Detalle.Columns.Add("totalFases", "Total Fases");

            Dgv_Detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Detalle.AllowUserToAddRows = false;

            pro_CargarDetalle();
        }
        private void pro_CargarDetalle()
        {
            try
            {
                DataTable tabla = controladorDetalle.fun_DatosDetalle(IDFactura);

                Dgv_Detalle.Rows.Clear();

                if (tabla.Rows.Count > 0)
                {
                    DataRow encabezado = tabla.Rows[0];

                    Cmb_ID_Detalle.Text = encabezado["CodigoDetalle"].ToString();
                    Cmb_ID_Factura.Text = encabezado["CodigoEncabezado"].ToString();
                    Cmb_ID_Orden.Text = encabezado["CodigoOrden"].ToString();
                    Lbl_Suma.Text = encabezado["Subtotal"].ToString();

                }

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Detalle.Rows.Add();

                    Dgv_Detalle.Rows[iIndice].Cells["totalMateriales"].Value = fila["TotalMateriales"];
                    Dgv_Detalle.Rows[iIndice].Cells["totalManoObra"].Value = fila["TotalManoObra"];
                    Dgv_Detalle.Rows[iIndice].Cells["totalCostos"].Value = fila["TotalCostos"];
                    Dgv_Detalle.Rows[iIndice].Cells["totalMermas"].Value = fila["TotalMermas"];
                    Dgv_Detalle.Rows[iIndice].Cells["totalFases"].Value = fila["TotalFases"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

}
