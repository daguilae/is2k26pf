using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Recetas;
using Capa_Vista_Fases;

namespace Capa_Vista_CVRecetas
{
    public partial class Frm_Recetas : Form
    {

        Controlador con = new Controlador();
        Controlador_Fases controlador = new Controlador_Fases();

        //Variables Goblas cesar santizo 0901-22-5215
        int idBOM = 0;
        int idBOMExistente = 0;

        public Frm_Recetas()
        {
            InitializeComponent();
            cargarCombos();

        }

        private void Frm_Recetas_Load(object sender, EventArgs e)
        {
            Dgv_Fases.Columns.Clear();
            Dgv_Fases.Columns.Add("idFase", "Id Fase");
            Dgv_Fases.Columns.Add("faseProduccion", "Fase de Producción");
            Dgv_Fases.Columns.Add("descripcionFase", "Descripción de la Fase");
            Dgv_Fases.Columns.Add("horasHombres", "Horas Hombre");

            Dgv_Fases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Fases.ReadOnly = true;
            Dgv_Fases.AllowUserToAddRows = false;

            pro_ObtenerFases(idBOMExistente);
        } 


        public void cargarCombos()
        {
            // Productos terminados
            Cbo_producto.DataSource = con.cargarProductos();
            Cbo_producto.DisplayMember = "Nombre_Material";
            Cbo_producto.ValueMember = "Pk_Id_Materiales";
            Cbo_producto.SelectedIndex = -1;

            // Estados
            Cbo_estado.DataSource = con.cargarEstados();
            Cbo_estado.DisplayMember = "Nombre_Estado_BOM";
            Cbo_estado.ValueMember = "Pk_Id_Estado_BOM";
            Cbo_estado.SelectedIndex = -1;
        }


        private void btn_produccion_Click_1(object sender, EventArgs e)
        {
            Frm_Fases_Produccion m = new Frm_Fases_Produccion();
            m.Show();
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {

        }

        //Recargar los datos Cesar Santizo 0901-22-5215
        public void recargarDatos()
        {
            if (Cbo_producto.SelectedValue == null)
            return;

            int idProducto = Convert.ToInt32(Cbo_producto.SelectedValue);


            DataTable dtBOM = con.cargarBOM(idProducto);

            if (dtBOM.Rows.Count > 0)
            {
                idBOM = Convert.ToInt32(dtBOM.Rows[0]["Pk_Id_BOM"]);

                Txt_descripcion.Text = dtBOM.Rows[0]["Descripcion_BOM"].ToString();
                Txt_versionBOM.Text = dtBOM.Rows[0]["Version_BOM"].ToString();
                dtp_fecha.Value = Convert.ToDateTime(dtBOM.Rows[0]["Fecha_Creacion_BOM"]);
                Cbo_estado.SelectedValue = dtBOM.Rows[0]["Fk_Id_Estado_BOM"];
            }

            // dgv_detalle.DataSource = con.cargarBOMGrid(idProducto);
        }
        private void btn_reporte_Click(object sender, EventArgs e)
        {
            BOM_Reporte m = new BOM_Reporte();
            m.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
        //boton de guardar cesar santizo 0901-22-5215 (para guardar receta)
        private void Btn_guardar_Click_1(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(Cbo_producto.SelectedValue);
            string descripcion = Txt_descripcion.Text;
            string version = Txt_versionBOM.Text;
            DateTime fecha = dtp_fecha.Value;
            int estado = Convert.ToInt32(Cbo_estado.SelectedValue);
            try
            {
                // Verificar si idBomExistente es igual a 0
                // Si es igual a 0, se debe crear el BOM completo
                if (idBOMExistente == 0)
                {
                    con.guardarBOMCompleto(descripcion, version, fecha, estado, idProducto, fasesNuevas);
                    MessageBox.Show("Receta guardada correctamente");
                }
                // En caso contrario, se guardan solo datos nuevos de detalle o fases
                else
                {
                    con.guardarDatosNuevos(idBOMExistente, fasesNuevas);
                    MessageBox.Show("Receta guardada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void Btn_eliminar_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (idBOM == 0)
                {
                    MessageBox.Show("Seleccione una receta para eliminar");
                    return;
                }

                DialogResult resp = MessageBox.Show(
                    "¿Está seguro que desea eliminar esta receta?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resp == DialogResult.Yes)
                {
                    con.eliminarBOM(idBOM);

                    MessageBox.Show("Receta eliminada correctamente");

                    // limpiar campos
                    Txt_descripcion.Clear();
                    Txt_versionBOM.Clear();
                    dtp_fecha.Value = DateTime.Now;
                    Cbo_estado.SelectedIndex = -1;
                    // dgv_detalle.DataSource = null;

                    idBOM = 0;

                    recargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        //boton editar Cesar santizo 0901-22-5215
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (idBOM == 0)
                    {
                        MessageBox.Show("Primero consulte una receta");
                        return;
                    }

                    string descripcion = Txt_descripcion.Text;
                    string version = Txt_versionBOM.Text;
                    DateTime fecha = dtp_fecha.Value;
                    int estado = Convert.ToInt32(Cbo_estado.SelectedValue);

                    con.editarBOM(idBOM, descripcion, version, fecha, estado);

                    MessageBox.Show("Receta actualizada correctamente");
                    recargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar: " + ex.Message);
                }
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (Cbo_producto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            int idProducto;
            if (!int.TryParse(Cbo_producto.SelectedValue.ToString(), out idProducto))
                return;


            DataTable dtBOM = con.cargarBOM(idProducto);

            if (dtBOM.Rows.Count == 0)
            {
                MessageBox.Show("Este producto no tiene BOM registrada");
                idBOMExistente = 0;

                // limpiar campos
                Txt_descripcion.Clear();
                Txt_versionBOM.Clear();
                dtp_fecha.Value = DateTime.Now;
                Cbo_estado.SelectedIndex = -1;
                //   dgv_detalle.DataSource = null;

                return;
            }


            idBOM = Convert.ToInt32(dtBOM.Rows[0]["Pk_Id_BOM"]);
            idBOMExistente = idBOM;

            Txt_descripcion.Text = dtBOM.Rows[0]["Descripcion_BOM"].ToString();
            Txt_versionBOM.Text = dtBOM.Rows[0]["Version_BOM"].ToString();
            dtp_fecha.Value = Convert.ToDateTime(dtBOM.Rows[0]["Fecha_Creacion_BOM"]);
            Cbo_estado.SelectedValue = dtBOM.Rows[0]["Fk_Id_Estado_BOM"];


            DataTable dtGrid = con.cargarBOMGrid(idProducto);
            pro_ObtenerFases(idBOM);
            // dgv_detalle.DataSource = dtGrid;
        }

        //-------------------- Funciones para el proceso de Fases de Producción ----------------------------//
        // Anderson Trigueros

        List<(string nombre, string descripcion, int horas)> datosFases = new List<(string, string, int)>();
        List<(string sFase, string sDescripcion, int iHoras)> fasesNuevas = new List<(string, string, int)>();

        private void pro_ObtenerFases(int iCodigoBOM)
        {
            try
            {
                DataTable tabla = controlador.fun_DatosFase(iCodigoBOM);
                Dgv_Fases.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Fases.Rows.Add();

                    Dgv_Fases.Rows[iIndice].Cells["idFase"].Value = fila["CodigoFase"];
                    Dgv_Fases.Rows[iIndice].Cells["faseProduccion"].Value = fila["Fase"];
                    Dgv_Fases.Rows[iIndice].Cells["descripcionFase"].Value = fila["Descripcion"];
                    Dgv_Fases.Rows[iIndice].Cells["horasHombres"].Value = fila["Horas"];
                    Dgv_Fases.Rows[iIndice].Tag = fila["CodigoFase"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGridFases()
        {
            var ultimaFase = fasesNuevas[fasesNuevas.Count - 1];

            int iIndice = Dgv_Fases.Rows.Add();

            Dgv_Fases.Rows[iIndice].Cells["idFase"].Value = null;
            Dgv_Fases.Rows[iIndice].Cells["faseProduccion"].Value = ultimaFase.sFase;
            Dgv_Fases.Rows[iIndice].Cells["descripcionFase"].Value = ultimaFase.sDescripcion;
            Dgv_Fases.Rows[iIndice].Cells["horasHombres"].Value = ultimaFase.iHoras;
        }

        private void Btn_agregar_fases_Click(object sender, EventArgs e)
        {
            string sFase = Txt_Fase.Text.Trim();
            string sDescripcion = Txt_Descripcion_fases.Text.Trim();
            string sHorasTexto = Txt_Horas.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(sFase) ||
                string.IsNullOrEmpty(sDescripcion) ||
                string.IsNullOrEmpty(sHorasTexto))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            // Validar que la hora ingresada sea valida
            int iHoras;
            if (!int.TryParse(sHorasTexto, out iHoras) || iHoras <= 0)
            {
                MessageBox.Show("El campo Horas debe ser un número entero positivo mayor a 0.");
                return;
            }

            fasesNuevas.Add((sFase, sDescripcion, iHoras));
            Txt_Fase.Clear();
            Txt_Descripcion_fases.Clear();
            Txt_Horas.Clear();
            ActualizarGridFases();

        }

        private void Dgv_Fases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = Dgv_Fases.Rows[e.RowIndex];
            if (fila == null) return;

            string sFase = fila.Cells["faseProduccion"].Value?.ToString() ?? "";
            string sDescripcion = fila.Cells["descripcionFase"].Value?.ToString() ?? "";
            string sHoras = fila.Cells["horasHombres"].Value?.ToString() ?? "";

            Txt_Fase.Text = sFase;
            Txt_Descripcion_fases.Text = sDescripcion;
            Txt_Horas.Text = sHoras;
        }

        private void btn_eliminar_fases_Click(object sender, EventArgs e)
        {

        }
    }
}