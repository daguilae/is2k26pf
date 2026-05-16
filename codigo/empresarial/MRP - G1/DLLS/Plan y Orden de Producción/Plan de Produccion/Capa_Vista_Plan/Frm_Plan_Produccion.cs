using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Modelo_Plan;
using System.Data.Odbc;
using System.IO;
using Capa_Controlador_Plan;


namespace Capa_Vista_Plan
{
    public partial class Frm_Plan_Produccion : Form
    {
        Cls_Controlador_Ordenes ordenes = new Cls_Controlador_Ordenes();
        Cls_Controlador_Cronograma cronograma = new Cls_Controlador_Cronograma();
        Cls_Controlador_General controladorGeneral = new Cls_Controlador_General();

        int iCodigoPlan = 0;
        int iNoOrden = 0;
        int iCodigoPlanExistente = 0;
        DateTime fechaInicioOrden;
        DateTime fechaFinOrden;
        int iLeadTimeProducto = 0;
        int iIndiceEditar = -1;
        int iIdOrdenProduccionEditar = 0;

        private List<Cls_Sentencia_OrdenTemp> listaOrdenes = new List<Cls_Sentencia_OrdenTemp>();

        public Frm_Plan_Produccion(int codigoPlan)
        {
            InitializeComponent();
            Dgv_Orden_Pro.CellClick += Dgv_Orden_Pro_CellContentClick;
            Txt_Cantidad_Programada.TextChanged += Txt_Cantidad_Programada_TextChanged;
            iCodigoPlanExistente = codigoPlan;
            inicializarColumnas();
            cargarCombos();
        }
        //Cargar data grid orden Gerber Asturias
        private void inicializarColumnas()
        {
            Dgv_Orden_Pro.Columns.Clear();
            Dgv_Orden_Pro.Columns.Add("noOrden", "No.");


            Dgv_Orden_Pro.Columns.Add("idMaterial", "ID Material");
            Dgv_Orden_Pro.Columns.Add("idEstado", "ID Estado");


            Dgv_Orden_Pro.Columns.Add("material", "Material");
            Dgv_Orden_Pro.Columns.Add("estado", "Estado");
            Dgv_Orden_Pro.Columns.Add("cantidad", "Cantidad Programada");
            Dgv_Orden_Pro.Columns.Add("fechaInicio", "Fecha Inicio");
            Dgv_Orden_Pro.Columns.Add("fechaFin", "Fecha Fin");

            Dgv_Orden_Pro.Columns["idMaterial"].Visible = false;
            Dgv_Orden_Pro.Columns["idEstado"].Visible = false;


            Dgv_Orden_Pro.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            Dgv_Orden_Pro.AllowUserToAddRows = false;

            Dgv_Orden_Pro.ReadOnly = true;

            Dgv_Orden_Pro.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        public void cargarCombos()
        {

            Cbo_OrdenRecibida.DataSource = ordenes.listarOrdenes();
            Cbo_OrdenRecibida.DisplayMember = "Pk_Id_Orden_Recibida";
            Cbo_OrdenRecibida.ValueMember = "Pk_Id_Orden_Recibida";
            Cbo_OrdenRecibida.SelectedIndex = -1;
            Cbo_Estado_Orden.DataSource = ordenes.listarEstados();
            Cbo_Estado_Orden.DisplayMember = "Nombre_Estado_Plan_Produccion";
            Cbo_Estado_Orden.ValueMember = "Pk_Id_Estado_Plan_Produccion";
            Cbo_Estado_Orden.SelectedIndex = -1;
        }

        private void Frm_Plan_Produccion_Load(object sender, EventArgs e)
        {
            pro_OrdenesRecibidas();
            pro_EstadosPlan();
            pro_ObtenerOrdenes(iCodigoPlanExistente);
            pro_ObtenerEmpleados();
            pro_ObtenerEstado();
            pro_DatosPlan(iCodigoPlanExistente);
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

        private void pro_DatosPlan(int iCodigoPlan)
        {
            DataTable plan = cronograma.fun_OrdenesPlan(iCodigoPlan);
            if (plan.Rows.Count > 0)
            {
                DataRow fila = plan.Rows[0];
                Txt_DescripcionPlan.Text = fila["Descripcion"].ToString();
                Cbo_OrdenRecibida.SelectedValue = Convert.ToInt32(fila["NoOrdenRecibida"]);
                Dtp_Fecha.Value = Convert.ToDateTime(fila["Fecha"]);
                Cbo_EstadoPlan.Text = fila["EstadoPlan"].ToString();
            }
            if(iCodigoPlanExistente != 0)
            {
                Cbo_OrdenRecibida.Enabled = false;
            }
        }

        private void pro_OrdenesRecibidas()
        {
            try
            {
                DataTable datos = cronograma.fun_OrdenesRecibidas();
                if (iCodigoPlanExistente != 0)
                {
                    DataTable plan = cronograma.fun_OrdenesPlan(iCodigoPlanExistente);
                    if (plan.Rows.Count > 0)
                    {
                        int idOrdenActual = Convert.ToInt32(plan.Rows[0]["NoOrdenRecibida"]);
                        bool existe = datos.AsEnumerable().Any(r =>
                                r.Field<int>("NoOrdenRecibida") == idOrdenActual);

                        if (!existe)
                        {
                            DataRow nuevaFila = datos.NewRow();
                            nuevaFila["NoOrdenRecibida"] = idOrdenActual;
                            nuevaFila["CodigoOrden"] = "Orden Asociada";
                            datos.Rows.Add(nuevaFila);
                        }
                    }
                }

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
                    if (iCodigoPlanExistente == 0)
                    {
                        Cbo_OrdenRecibida.DataSource = null;
                        Cbo_OrdenRecibida.Items.Clear();
                        Cbo_OrdenRecibida.Items.Add("No hay órdenes sin planificar");
                        Cbo_OrdenRecibida.SelectedIndex = 0;

                        MessageBox.Show(
                            "Todas las órdenes recibidas ya tienen un plan de producción asignado.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
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

            try
            {
                if (iCodigoPlanExistente == 0)
                {
                    if (iNoPedido == 0 || iCodigoEstadoPlan == 0 || string.IsNullOrWhiteSpace(sDescripcionPlan))
                    {
                        MessageBox.Show("Debe completar todos los campos.");
                        return;
                    }

                    if (listaOrdenes.Count == 0)
                    {
                        MessageBox.Show("Debe agregar al menos una orden de producción");
                        return;
                    }

                    iCodigoPlan = controladorGeneral.pro_GuardarPlanCompleto(iNoPedido, sDescripcionPlan, iCodigoEstadoPlan, fechaPlan,
                        listaOrdenes);
                    iCodigoPlanExistente = iCodigoPlan;
                    MessageBox.Show("Plan y Órdenes de Producción guardados correctamente");
                    pro_ObtenerOrdenes(iCodigoPlan);
                    pro_DatosPlan(iCodigoPlan);

                }
                //Si existe un plan de producción y la lista de cronograma tiene datos, guardar en base de datos el cronograma
                else if (cronogramaFases != null && cronogramaFases.Count > 0)
                {
                    cronograma.proGuardarCronograma(iNoOrden, cronogramaFases);
                    MessageBox.Show("Cronograma de Fases Guardado Correctamente");
                    cronogramaFases.Clear();
                    Dgv_Cronograma.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }




        /* ------------------------- Métodos para el proceso de Cronograma de Fases  Anderson Trigueros ----------------------------*/

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Cronograma && iCodigoPlanExistente == 0)
            {
                e.Cancel = true;
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
                    Dgv_Cronograma.Rows[iIndice].Cells["fechaInicio"].Value =
                        Convert.ToDateTime(fila["FechaInicio"]).ToString("dd/MM/yyyy");
                    Dgv_Cronograma.Rows[iIndice].Cells["fechaFinal"].Value =
                        Convert.ToDateTime(fila["FechaFin"]).ToString("dd/MM/yyyy");
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

        private void pro_ObtenerOrdenesProduccion(int idOrdenRecibida)
        {
            try
            {
                DataTable tabla =
                    ordenes.obtenerOrdenesProduccionPorOrden(
                        idOrdenRecibida);

                Dgv_Orden_Pro.Rows.Clear();

                if (tabla.Rows.Count == 0)
                {
                    return;
                }

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice =
                        Dgv_Orden_Pro.Rows.Add();

                    Dgv_Orden_Pro.Rows[iIndice]
                        .Cells["noOrden"].Value =
                        fila["NoOrden"];

                    Dgv_Orden_Pro.Rows[iIndice]
                        .Cells["idMaterial"].Value =
                        fila["IdMaterial"];

                    Dgv_Orden_Pro.Rows[iIndice]
                        .Cells["idEstado"].Value =
                        fila["IdEstado"];

                    Dgv_Orden_Pro.Rows[iIndice]
                        .Cells["material"].Value =
                        fila["Material"];

                    Dgv_Orden_Pro.Rows[iIndice]
                        .Cells["estado"].Value =
                        fila["Estado"];

                    Dgv_Orden_Pro.Rows[iIndice]
                        .Cells["cantidad"].Value =
                        fila["Cantidad"];

                    Dgv_Orden_Pro.Rows[iIndice]
                        .Cells["fechaInicio"].Value =
                        Convert.ToDateTime(
                            fila["FechaInicio"])
                            .ToShortDateString();

                    Dgv_Orden_Pro.Rows[iIndice]
                        .Cells["fechaFin"].Value =
                        Convert.ToDateTime(
                            fila["FechaFin"])
                            .ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar órdenes: " +
                    ex.Message);
            }
        }

        private void Cbo_NoOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_NoOrden.SelectedValue == null) return;
                if (Cbo_NoOrden.SelectedValue is DataRowView) return;

                int iCodigoOrden = Convert.ToInt32(Cbo_NoOrden.SelectedValue);
                iNoOrden = iCodigoOrden;

                if (iCodigoOrden > 0)
                {
                    cronogramaFases.Clear();
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

            cronogramaFases.Add((iCodigoFase, iCodigoEncargado, fechaInicioFase, fechaFinalFase, iCantidadPersonal, iCodigoEstado));
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
            LimpiarCamposCronograma();
        }

        private void LimpiarCamposCronograma()
        {
            Txt_CantidadPersonal.Clear();
            Cbo_EstadoFase.SelectedIndex = 0;
            Cbo_Empleados.SelectedIndex = 0;
            Cbo_Fases.SelectedIndex = 0;
            Dtp_FechaInicio.Value = DateTime.Today;
            Dtp_FechaFin.Value = DateTime.Today;
        }

        private void Dgv_Cronograma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = Dgv_Cronograma.Rows[e.RowIndex];
            if (fila == null) return;

            string sFase = fila.Cells["faseProduccion"].Value.ToString() ?? "";
            string sCantidad = fila.Cells["cantidadPersonal"].Value?.ToString() ?? "";
            string sEstado = fila.Cells["estadoFase"].Value?.ToString() ?? "";
            string sEmpleado = fila.Cells["encargado"].Value?.ToString() ?? "";
            string fechaInicio = fila.Cells["fechaInicio"].Value?.ToString() ?? "";
            string fechaFinal = fila.Cells["fechaFinal"].Value?.ToString() ?? "";

            Cbo_Fases.Text = sFase;
            Cbo_Empleados.Text = sEmpleado;
            Cbo_EstadoFase.Text = sEstado;

            Txt_CantidadPersonal.Text = sCantidad;

            Dtp_FechaInicio.Value = Convert.ToDateTime(fechaInicio);
            Dtp_FechaFin.Value = Convert.ToDateTime(fechaFinal);

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Cronograma.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una fila.");
                    return;
                }
                int iCodigoCronograma = Convert.ToInt32(Dgv_Cronograma.CurrentRow.Tag);
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
                    MessageBox.Show("La cantidad de personal debe ser mayor a 0.");
                    return;
                }

                if (iCodigoEncargado == 0 || iCodigoEstado == 0)
                {
                    MessageBox.Show("Debe seleccionar todas las opciones.");
                    return;
                }

                cronograma.proActualizarCronograma(iCodigoCronograma, fechaInicioFase, fechaFinalFase, iCantidadPersonal,
                    iCodigoEncargado, iCodigoEstado);

                MessageBox.Show("Cronograma actualizado correctamente.");

                pro_ObtenerCronograma(iNoOrden);
                LimpiarCamposCronograma();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        /* ---------------------------------- Métodos para el proceso de Ordenes de Producción ----------------------------*/

        private void Lbl_NombreFase_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Material.SelectedItem == null)
                return;

            if (Cbo_Material.SelectedItem is DataRowView fila)
            {
                Txt_Cantidad_Programada.Text =
                    fila["Cantidad_Solicitada"].ToString();
                iLeadTimeProducto = Convert.ToInt32(fila["DiasFabricacion"]);
            }
        }

        private void Btn_agregarOrden_Click(object sender, EventArgs e)
        {
            if (Cbo_Material.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione un material.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (Cbo_Estado_Orden.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione un estado.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(
                Txt_Cantidad_Programada.Text))
            {
                MessageBox.Show(
                    "Ingrese una cantidad.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal cantidad;

            if (!decimal.TryParse(
                Txt_Cantidad_Programada.Text,
                out cantidad))
            {
                MessageBox.Show(
                    "La cantidad es inválida.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor a 0.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            DateTime fechaFin;

            if (!DateTime.TryParse(Txt_Fecha_Fin.Text, out fechaFin))
            {
                MessageBox.Show(
                    "La fecha fin es inválida.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (fechaFin < Dtp_Fecha_Inicio.Value)
            {
                MessageBox.Show(
                    "La fecha fin no puede ser menor a la fecha inicio.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            iNoOrden++;


            Cls_Sentencia_OrdenTemp orden = new Cls_Sentencia_OrdenTemp();

            orden.NoOrden = iNoOrden;

            orden.IdMaterial =
                Convert.ToInt32(
                    Cbo_Material.SelectedValue);

            orden.Material =
                Cbo_Material.Text;

            orden.IdEstado =
                Convert.ToInt32(
                    Cbo_Estado_Orden.SelectedValue);

            orden.Estado =
                Cbo_Estado_Orden.Text;

            orden.Cantidad =
                cantidad;

            orden.FechaInicio =
                Dtp_Fecha_Inicio.Value;

            orden.FechaFin = fechaFin;


            listaOrdenes.Add(orden);


            Dgv_Orden_Pro.Rows.Add(
                orden.NoOrden,
                orden.IdMaterial,
                orden.IdEstado,
                orden.Material,
                orden.Estado,
                orden.Cantidad,
                orden.FechaInicio.ToShortDateString(),
                orden.FechaFin.ToShortDateString()
            );


            limpiarCampos();
        }

        private void limpiarCampos()
        {
            Txt_Cantidad_Programada.Clear();

            Cbo_Material.SelectedIndex = -1;

            Cbo_Estado_Orden.SelectedIndex = -1;

            Dtp_Fecha_Inicio.Value = DateTime.Now;

            Txt_Fecha_Fin.Clear();

        }

        private void cargarGrid()
        {
            Dgv_Orden_Pro.Rows.Clear();

            foreach (var item in listaOrdenes)
            {
                Dgv_Orden_Pro.Rows.Add(
                    item.NoOrden,
                    item.IdMaterial,
                    item.IdEstado,
                    item.Material,
                    item.Estado,
                    item.Cantidad,
                    item.FechaInicio.ToShortDateString(),
                    item.FechaFin.ToShortDateString()
                );
            }
        }

        private void Cbo_OrdenRecibida_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Cbo_OrdenRecibida.SelectedIndex == -1)
                return;

            if (Cbo_OrdenRecibida.SelectedValue == null)
                return;

            int idOrden;

            if (int.TryParse(
                Cbo_OrdenRecibida.SelectedValue.ToString(),
                out idOrden))
            {
                Cbo_Material.DataSource =
                    ordenes.filtrarMateriales(idOrden);

                Cbo_Material.DisplayMember =
                    "Nombre_Material";

                Cbo_Material.ValueMember =
                    "Pk_Id_Materiales";

                Cbo_Material.SelectedIndex = -1;
                pro_ObtenerOrdenesProduccion(idOrden);
            }
        }

        /* ----------------- Anderson Trigueros ----------------------------*/
        private void Dtp_Fecha_Inicio_ValueChanged(object sender, EventArgs e)
        {
            if (iLeadTimeProducto == 0) return;

            decimal cantidadDecimal;
            if (!decimal.TryParse(Txt_Cantidad_Programada.Text, out cantidadDecimal))
            {
                return;
            }
            int cantidadSolicitada = Convert.ToInt32(cantidadDecimal);
            int totalDiasFabricacion = iLeadTimeProducto * cantidadSolicitada;
            Txt_Fecha_Fin.Text = Dtp_Fecha_Inicio.Value.AddDays(totalDiasFabricacion).ToString("dd/MM/yyyy");
        }

        private void Txt_Cantidad_Programada_TextChanged(object sender, EventArgs e)
        {
            if (iLeadTimeProducto == 0)
                return;

            decimal cantidadDecimal;

            if (!decimal.TryParse(
                Txt_Cantidad_Programada.Text,
                out cantidadDecimal))
            {
                return;
            }

            int cantidadSolicitada =
                Convert.ToInt32(cantidadDecimal);

            int totalDiasFabricacion =
                iLeadTimeProducto * cantidadSolicitada;

            Txt_Fecha_Fin.Text =
                Dtp_Fecha_Inicio.Value
                .AddDays(totalDiasFabricacion)
                .ToString("dd/MM/yyyy");
        }

        private void Dgv_Orden_Pro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                Dgv_Orden_Pro.Rows[e.RowIndex];

            iIndiceEditar = e.RowIndex;

            iIdOrdenProduccionEditar =
                Convert.ToInt32(
                    fila.Cells["noOrden"].Value);

            Cbo_Material.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["idMaterial"].Value);

            Cbo_Estado_Orden.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["idEstado"].Value);

            Txt_Cantidad_Programada.Text =
                fila.Cells["cantidad"].Value.ToString();

            Dtp_Fecha_Inicio.Value =
                Convert.ToDateTime(
                    fila.Cells["fechaInicio"].Value);

            Txt_Fecha_Fin.Text =
                Convert.ToDateTime(
                    fila.Cells["fechaFin"].Value)
                    .ToString("dd/MM/yyyy");
        }

        private void Btn_Actualizar_Orden_Click(object sender, EventArgs e)
        {
            if (iIdOrdenProduccionEditar == 0)
            {
                MessageBox.Show(
                    "Seleccione una orden.");
                return;
            }

            decimal cantidad;

            if (!decimal.TryParse(
                Txt_Cantidad_Programada.Text,
                out cantidad))
            {
                MessageBox.Show(
                    "Cantidad inválida.");
                return;
            }

            DateTime fechaFin;

            if (!DateTime.TryParse(
                Txt_Fecha_Fin.Text,
                out fechaFin))
            {
                MessageBox.Show(
                    "Fecha fin inválida.");
                return;
            }

            try
            {
                ordenes.modificarOrdenProduccion(
                    iIdOrdenProduccionEditar,
                    Convert.ToInt32(
                        Cbo_Material.SelectedValue),
                    Convert.ToInt32(
                        Cbo_Estado_Orden.SelectedValue),
                    cantidad,
                    Dtp_Fecha_Inicio.Value,
                    fechaFin);

                int idOrden =
                    Convert.ToInt32(
                        Cbo_OrdenRecibida.SelectedValue);

                pro_ObtenerOrdenesProduccion(idOrden);

                limpiarCampos();

                iIdOrdenProduccionEditar = 0;

                MessageBox.Show(
                    "Orden modificada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar: " +
                    ex.Message);
            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
           Frm_Reporte_Plan reporte = new Frm_Reporte_Plan();
            reporte.ShowDialog(); ;
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            string carpeta = Application.StartupPath;

            while (!Directory.Exists(Path.Combine(carpeta, "ayuda")) &&
                   Directory.GetParent(carpeta) != null)
            {
                carpeta = Directory.GetParent(carpeta).FullName;
            }

            string rutaAyuda = Path.Combine(
                carpeta,
                "ayuda",
                "MRP",
                "Ayuda_Plan_Producción",
                "Ayuda_tipo.chm"
            );

            if (File.Exists(rutaAyuda))
            {
                Help.ShowHelp(this, rutaAyuda, "Cliente.html");
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de ayuda:\n" + rutaAyuda,
                                "Ayuda",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


    }
}

  