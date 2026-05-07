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
    public partial class Frm_Plan_Produccion : Form
    {
        Cls_Controlador_Ordenes ordenes = new Cls_Controlador_Ordenes();
        Cls_Controlador_Cronograma cronograma = new Cls_Controlador_Cronograma();
        int iCodigoPlan = 0;
        int iNoOrden = 0;
        int iCodigoPlanExistente = 1;
        DateTime fechaInicioOrden;
        DateTime fechaFinOrden;
        public Frm_Plan_Produccion()
        {
            InitializeComponent();
        }

        private void Frm_Plan_Produccion_Load(object sender, EventArgs e)
        {
            pro_OrdenesRecibidas();
            pro_EstadosPlan();
            pro_ObtenerOrdenes(iCodigoPlanExistente);
            pro_ObtenerEmpleados();
            pro_ObtenerEstado();
            Dgv_Cronograma.Columns.Clear();
            Dgv_Cronograma.Columns.Add("faseProduccion", "Fase de Producción");
            Dgv_Cronograma.Columns.Add("fechaInicio", "Fecha Inicio de Fase");
            Dgv_Cronograma.Columns.Add("fechaFinal", "Fecha Final de Fase");
            Dgv_Cronograma.Columns.Add("cantidadPersonal", "Cantidad Personal");
            Dgv_Cronograma.Columns.Add("encargado", "Encargado");
            Dgv_Cronograma.Columns.Add("estadoFase", "Estado de Fase");

            Dgv_Cronograma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Cronograma.AllowUserToAddRows = false;
        }

        /* ---------------------------------- Métodos para el proceso de plan de producción ----------------------------*/
        private void pro_OrdenesRecibidas()
        {
            try
            {
                DataTable datos = cronograma.fun_OrdenesRecibidas();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["NoOrdenRecibida"] = 0;
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_OrdenRecibida.DataSource = datos;
                    Cbo_OrdenRecibida.DisplayMember = "NoOrdenRecibida";
                    Cbo_OrdenRecibida.ValueMember = "NoOrdenRecibida";
                }
                else
                {
                    Cbo_OrdenRecibida.DataSource = null;
                    Cbo_OrdenRecibida.Items.Clear();
                    Cbo_OrdenRecibida.Items.Add("No hay órdenes registradas");
                    Cbo_OrdenRecibida.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las órdenes recibidas: " + ex.Message);
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

                    Cbo_EstadoPlan.DataSource = datos;
                    Cbo_EstadoPlan.DisplayMember = "EstadoPlan";
                    Cbo_EstadoPlan.ValueMember = "CodigoEstado";
                }
                else
                {
                    Cbo_EstadoPlan.DataSource = null;
                    Cbo_EstadoPlan.Items.Clear();
                    Cbo_EstadoPlan.Items.Add("No hay estados de fase");
                    Cbo_EstadoPlan.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los estados: " + ex.Message);
            }

        }







        /* ---------------------------------- Métodos para el proceso completo de transacción ----------------------------*/
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            int iNoPedido = Convert.ToInt32(Cbo_OrdenRecibida.SelectedValue);
            string sDescripcionPlan = Txt_DescripcionPlan.Text;
            int iCodigoEstadoPlan = Convert.ToInt32(Cbo_EstadoPlan.SelectedValue);
            DateTime fechaPlan = Dtp_Fecha.Value.Date;


        }















        /* ---------------------------------- Métodos para el proceso de Ordenes de Producción ----------------------------*/











        /* ---------------------------------- Métodos para el proceso de Cronograma de Fases ----------------------------*/

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Supongamos que quieres bloquear la segunda pestaña
            if (e.TabPage == Cronograma )
            {
                // e.Cancel = true; // Bloquea el acceso
            }
        }

        private void pro_ObtenerFases(int iNoOrden)
        {
            try
            {
                DataTable datos = cronograma.fun_DatosFase(iNoOrden);
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["CodigoFase"] = 0;
                    fila["Fase"] = "Seleccione una fase";
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_Fases.DataSource = datos;
                    Cbo_Fases.DisplayMember = "Fase";
                    Cbo_Fases.ValueMember = "CodigoFase";
                }
                else
                {
                    Cbo_Fases.DataSource = null;
                    Cbo_Fases.Items.Clear();
                    Cbo_Fases.Items.Add("No hay fases registradas");
                    Cbo_Fases.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las fases: " + ex.Message);
            }
        }

        private void pro_ObtenerOrdenes(int iCodigoPlan)
        {
            try
            {
                DataTable datos = cronograma.fun_NoOrden(iCodigoPlan);
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["NoOrden"] = 0;
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_NoOrden.DataSource = datos;
                    Cbo_NoOrden.DisplayMember = "NoOrden";
                    Cbo_NoOrden.ValueMember = "NoOrden";
                }
                else
                {
                    Cbo_NoOrden.DataSource = null;
                    Cbo_NoOrden.Items.Clear();
                    Cbo_NoOrden.Items.Add("No hay órdenes registradas");
                    Cbo_NoOrden.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las órdenes: " + ex.Message);
            }
        }

        public void pro_ObtenerEmpleados()
        {
            try
            {
                DataTable datos = cronograma.fun_DatosEmpleado();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["CodigoEmpleado"] = 0;
                    fila["Empleado"] = "--- Empleados ---";
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_Empleados.DataSource = datos;
                    Cbo_Empleados.DisplayMember = "Empleado";
                    Cbo_Empleados.ValueMember = "CodigoEmpleado";
                }
                else
                {
                    Cbo_Empleados.DataSource = null;
                    Cbo_Empleados.Items.Clear();
                    Cbo_Empleados.Items.Add("No hay empleados registrados");
                    Cbo_Empleados.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los empleados: " + ex.Message);
            }
        }

        public void pro_ObtenerEstado() 
        {
            try
            {
                DataTable datos = cronograma.fun_DatosEstados();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["CodigoEstado"] = 0;
                    fila["EstadoFase"] = "--- Estados ---";
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_EstadoFase.DataSource = datos;
                    Cbo_EstadoFase.DisplayMember = "EstadoFase";
                    Cbo_EstadoFase.ValueMember = "CodigoEstado";
                }
                else
                {
                    Cbo_EstadoFase.DataSource = null;
                    Cbo_EstadoFase.Items.Clear();
                    Cbo_EstadoFase.Items.Add("No hay estados de fase");
                    Cbo_EstadoFase.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los estados: " + ex.Message);
            }
        }

        private void pro_ObtenerCronograma(int iCodigoOrden)
        {
            try
            {
                DataTable tabla = cronograma.fun_ObtenerCronograma(iCodigoOrden);
                Dgv_Cronograma.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Cronograma.Rows.Add();
                    Dgv_Cronograma.Rows[iIndice].Cells["faseProduccion"].Value = fila["Fase"];
                    Dgv_Cronograma.Rows[iIndice].Cells["fechaInicio"].Value = fila["FechaInicio"];
                    Dgv_Cronograma.Rows[iIndice].Cells["fechaFinal"].Value = fila["FechaFin"];
                    Dgv_Cronograma.Rows[iIndice].Cells["cantidadPersonal"].Value = fila["Cantidad"];
                    Dgv_Cronograma.Rows[iIndice].Cells["encargado"].Value = fila["Encargado"];
                    Dgv_Cronograma.Rows[iIndice].Cells["estadoFase"].Value = fila["Estado"];
                    Dgv_Cronograma.Rows[iIndice].Tag = fila["CodigoCronograma"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_NoOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_NoOrden.SelectedValue == null) return;
                if (Cbo_NoOrden.SelectedValue is DataRowView) return;

                int iCodigoOrden = Convert.ToInt32(Cbo_NoOrden.SelectedValue);

                if (iCodigoOrden > 0)
                {
                    pro_ObtenerFases(iCodigoOrden);
                    DataRowView fila = (DataRowView)Cbo_NoOrden.SelectedItem;
                    
                    Txt_ProductoC.Text = fila["Producto"].ToString();
                    fechaInicioOrden = Convert.ToDateTime(fila["FechaInicio"]);
                    fechaFinOrden = Convert.ToDateTime(fila["FechaFin"]);

                    pro_ObtenerCronograma(iCodigoOrden);
                }
                else
                {
                    Dgv_Cronograma.Rows.Clear();
                    Txt_ProductoC.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el cronograma de fases: " + ex.Message);
            }
        }

        List<(int iCodigoFase, int iEmpleado, DateTime FechaInicio, DateTime FechaFin, int iCantidadPersonal, int iEstadoFase)> 
            cronogramaFases = new List<(int, int, DateTime, DateTime, int, int)>();
        private void Btn_agregar_fases_Click(object sender, EventArgs e)
        {
            int iCodigoOrden = Convert.ToInt32(Cbo_NoOrden.SelectedValue);
            int iCodigoFase = Convert.ToInt32(Cbo_Fases.SelectedValue);
            int iCodigoEncargado = Convert.ToInt32(Cbo_Empleados.SelectedValue);
            int iCodigoEstado = Convert.ToInt32(Cbo_EstadoFase.SelectedValue);

            DateTime fechaInicioFase = Dtp_FechaInicio.Value.Date;
            DateTime fechaFinalFase = Dtp_FechaFin.Value.Date;


            if (fechaInicioFase < fechaInicioOrden)
            {
                MessageBox.Show(
                    $"La fecha inicial de la fase no puede ser menor a la fecha inicial de la orden ({fechaInicioOrden:dd/MM/yyyy})."
                );
                return;
            }

            if (fechaFinalFase > fechaFinOrden)
            {
                MessageBox.Show(
                    $"La fecha final de la fase no puede ser mayor a la fecha final de la orden ({fechaFinOrden:dd/MM/yyyy})."
                );
                return;
            }

            if (fechaFinalFase < fechaInicioFase)
            {
                MessageBox.Show("La fecha final de la fase no puede ser menor a la fecha inicial.");
                return;
            }

            int iCantidadPersonal;
            if (!int.TryParse(Txt_CantidadPersonal.Text, out iCantidadPersonal) || iCantidadPersonal <= 0)
            {
                MessageBox.Show("El campo cantidad personal debe ser un número entero positivo mayor a 0.");
                return;
            }

            if (iCodigoOrden == 0 || iCodigoFase == 0 || iCodigoEncargado == 0 || iCodigoEstado == 0)
            {
                MessageBox.Show("Debe seleccionar todas las opciones.");
                return;
            }

            cronogramaFases.Add((iCodigoFase, iCodigoEncargado, fechaInicioFase, fechaFinalFase, iCantidadPersonal,iCodigoEstado));
            ActualizarGridCronograma();

        }

        private void ActualizarGridCronograma()
        {
            var ultimoCronograma = cronogramaFases[cronogramaFases.Count - 1];

            int iIndice = Dgv_Cronograma.Rows.Add();

            Dgv_Cronograma.Rows[iIndice].Cells["faseProduccion"].Value = Cbo_Fases.Text;
            Dgv_Cronograma.Rows[iIndice].Cells["fechaInicio"].Value = ultimoCronograma.FechaInicio.ToString("dd/MM/yyyy");
            Dgv_Cronograma.Rows[iIndice].Cells["fechaFinal"].Value = ultimoCronograma.FechaFin.ToString("dd/MM/yyyy");
            Dgv_Cronograma.Rows[iIndice].Cells["cantidadPersonal"].Value = ultimoCronograma.iCantidadPersonal;
            Dgv_Cronograma.Rows[iIndice].Cells["encargado"].Value = Cbo_Empleados.Text;
            Dgv_Cronograma.Rows[iIndice].Cells["estadoFase"].Value = Cbo_EstadoFase.Text;


        }


    }

}
  