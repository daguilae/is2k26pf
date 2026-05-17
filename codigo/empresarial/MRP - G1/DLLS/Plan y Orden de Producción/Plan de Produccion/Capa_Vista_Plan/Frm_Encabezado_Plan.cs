using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Plan;

namespace Capa_Vista_Plan
{
    public partial class Frm_Encabezado_Plan : Form
    {
        Cls_Controlador_Cronograma cronograma = new Cls_Controlador_Cronograma();
        Cls_Controlador_General controladorGeneral = new Cls_Controlador_General();

        int? codigoPlan = null;
        int icodigoPlanSeleccionado = 0;
        int? estadoPlan = null;
        DateTime? fechaDesde = null;
        DateTime? fechaHasta = null;

        public Frm_Encabezado_Plan()
        {
            InitializeComponent();
        }

        private void Frm_Encabezado_Plan_Load(object sender, EventArgs e)
        {
            pro_EstadosPlan();
            pro_ObtenerPlanes();

            Dgv_BOM.Columns.Clear();
            Dgv_BOM.Columns.Add("codigoPlan", "Código Plan");
            Dgv_BOM.Columns.Add("noOrden", "No. Orden Recbida");
            Dgv_BOM.Columns.Add("descripcionPlan", "Descripción del Plan");
            Dgv_BOM.Columns.Add("fechaPlan", "Fecha De Registro");
            Dgv_BOM.Columns.Add("estadoPlan", "Estado del Plan");

            DataGridViewButtonColumn btnDetalles = new DataGridViewButtonColumn();

            btnDetalles.Name = "detalles";
            btnDetalles.HeaderText = "Detalles";
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseColumnTextForButtonValue = true;

            Dgv_BOM.Columns.Add(btnDetalles);

            Dgv_BOM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_BOM.AllowUserToAddRows = false;

            pro_ObtenerDatosPlanes();

        }

        private void pro_ObtenerPlanes()
        {
            try
            {
                DataTable datos = controladorGeneral.fun_ObtenerCodigosPlan();

                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();

                    fila["CodigoPlan"] = DBNull.Value; // o ""

                    datos.Rows.InsertAt(fila, 0);

                    Cbo_ID_Plan.DataSource = datos;
                    Cbo_ID_Plan.DisplayMember = "CodigoPlan";
                    Cbo_ID_Plan.ValueMember = "CodigoPlan";

                    Cbo_ID_Plan.SelectedIndex = 0;
                }
                else
                {
                    Cbo_ID_Plan.DataSource = null;
                    Cbo_ID_Plan.Items.Clear();
                    Cbo_ID_Plan.Items.Add("No hay planes registrados");
                    Cbo_ID_Plan.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar planes: " + ex.Message);
            }
        }


        public void pro_EstadosPlan()
        {
            try
            {
                DataTable datos = cronograma.fun_EstadosPlan();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["CodigoEstado"] = 0;
                    fila["EstadoPlan"] = "Seleccione un estado";
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_Estado_Plan.DataSource = datos;
                    Cbo_Estado_Plan.DisplayMember = "EstadoPlan";
                    Cbo_Estado_Plan.ValueMember = "CodigoEstado";
                }
                else
                {
                    Cbo_Estado_Plan.DataSource = null;
                    Cbo_Estado_Plan.Items.Clear();
                    Cbo_Estado_Plan.Items.Add("No hay estados de plan");
                    Cbo_Estado_Plan.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los estados: " + ex.Message);
            }
        }

        private void Cbo_ID_Plan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_ID_Plan.SelectedValue == null) return;
            if (Cbo_ID_Plan.SelectedValue is DataRowView) return;

            if (Cbo_ID_Plan.SelectedValue == DBNull.Value)
            {
                codigoPlan = null;
            }
            else
            {
                codigoPlan = Convert.ToInt32(Cbo_ID_Plan.SelectedValue);
            }

            pro_ObtenerDatosPlanes(fechaDesde, fechaHasta);

        }

        private void Cbo_Estado_Plan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Estado_Plan.SelectedValue == null) return;
            if (Cbo_Estado_Plan.SelectedValue is DataRowView) return;

            estadoPlan = Convert.ToInt32(Cbo_Estado_Plan.SelectedValue);

            pro_ObtenerDatosPlanes(fechaDesde, fechaHasta);
        }

        private void pro_ObtenerDatosPlanes(DateTime? fechaInicio = null, DateTime? fechaFinal = null)
        {
            try
            {
                DataTable tabla = controladorGeneral.fun_DatosPlan(
                    codigoPlan,
                    estadoPlan,
                    fechaInicio,
                    fechaFinal
                );

                Dgv_BOM.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_BOM.Rows.Add();

                    Dgv_BOM.Rows[iIndice].Cells["codigoPlan"].Value = fila["CodigoPlan"];
                    Dgv_BOM.Rows[iIndice].Cells["noOrden"].Value = fila["NoOrdenRecibida"];
                    Dgv_BOM.Rows[iIndice].Cells["descripcionPlan"].Value = fila["Descripcion"];
                    Dgv_BOM.Rows[iIndice].Cells["fechaPlan"].Value = Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM/yyyy");
                    Dgv_BOM.Rows[iIndice].Cells["estadoPlan"].Value = fila["EstadoPlan"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Dtp_Desde_plan_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaDesdeCambio = Dtp_Desde_plan.Value.Date;
            fechaDesde = fechaDesdeCambio;
            pro_ObtenerDatosPlanes(fechaDesde, fechaHasta);
        }

        private void Dtp_Hasta_plan_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaHastaCambio = Dtp_Hasta_plan.Value.Date;
            fechaHasta = fechaHastaCambio;
            pro_ObtenerDatosPlanes(fechaDesde, fechaHasta);
        }

        private void Dgv_BOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (Dgv_BOM.Columns[e.ColumnIndex].Name == "detalles")
            {
                int codigoPlan = Convert.ToInt32(
                    Dgv_BOM.Rows[e.RowIndex].Cells["codigoPlan"].Value
                );
                Frm_Plan_Produccion formularioPlan = new Frm_Plan_Produccion(codigoPlan);
                formularioPlan.Show();
            }
        }

        private void Btn_crear_plan_Click(object sender, EventArgs e)
        {
            Frm_Plan_Produccion formularioPlan = new Frm_Plan_Produccion(icodigoPlanSeleccionado);
            formularioPlan.Show();
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            codigoPlan = null;
            estadoPlan = null;
            fechaDesde = null;
            fechaHasta = null;
            pro_ObtenerDatosPlanes(fechaHasta, fechaDesde);

        }
    }
}
