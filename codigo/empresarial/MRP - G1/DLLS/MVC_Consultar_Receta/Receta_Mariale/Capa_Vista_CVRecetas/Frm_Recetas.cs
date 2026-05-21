using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Recetas;
using Capa_Vista_Fases;
using System.IO;
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
            // Hecho por: Maria Morales 0901-22-1226
            inicializarColumnas();
        }

        // Hecho por: Maria Morales 0901-22-1226
        private void inicializarColumnas()
        {
            Dgv_Fases.Columns.Clear();
            Dgv_Fases.Columns.Add("idFase", "Id Fase");
            Dgv_Fases.Columns.Add("faseProduccion", "Fase de Producción");
            Dgv_Fases.Columns.Add("descripcionFase", "Descripción de la Fase");
            Dgv_Fases.Columns.Add("horasHombres", "Horas Hombre");

            //Ruben Lopez 0901-20-4620
            Dgv_Recetas.Columns.Clear();
            Dgv_Recetas.Columns.Add("idMaterial", "ID Material");
            Dgv_Recetas.Columns.Add("material", "Material");
            Dgv_Recetas.Columns.Add("idUnidad", "ID Unidad");
            Dgv_Recetas.Columns.Add("unidad", "Unidad");
            Dgv_Recetas.Columns.Add("cantidad", "Cantidad");

            Dgv_Recetas.Columns["idMaterial"].Visible = false;
            Dgv_Recetas.Columns["idUnidad"].Visible = false;

            Dgv_Fases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Fases.ReadOnly = true;
            Dgv_Fases.AllowUserToAddRows = false;
            Dgv_Recetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Frm_Recetas_Load(object sender, EventArgs e)
        {
           
            pro_ObtenerFases(idBOMExistente);
        } 


        public void cargarCombos()
        {
            // Productos terminados
            Cbo_producto.DataSource = con.cargarProductos();
            Cbo_producto.DisplayMember = "Nombre_Material";
            Cbo_producto.ValueMember = "Pk_Id_Materiales";
            Cbo_producto.SelectedIndex = -1;

            //Ruben Lopez 0901-20-4620
            // Cargar Materiales (Asegúrate de tener este método en tu Controlador)
            Controlador_detalle_Materiales conDetalle = new Controlador_detalle_Materiales();
            Cbo_Material.DataSource = conDetalle.getMateriales(); // Llama al modelo obtenerMateriales()
            Cbo_Material.DisplayMember = "Nombre_Material";
            Cbo_Material.ValueMember = "Pk_Id_Materiales";
            Cbo_Material.SelectedIndex = -1;

            //Ruben Lopez 0901-20-4620
            // Cargar Unidades
            Cbo_Unidad.DataSource = conDetalle.getUnidades(); // Llama al modelo obtenerUnidades()
            Cbo_Unidad.DisplayMember = "Nombre_Unidad_Medida";
            Cbo_Unidad.ValueMember = "Pk_Id_Unidad_Medida";
            Cbo_Unidad.SelectedIndex = -1;

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

            //Ruben Lopez 0901-20-4620
            // Extraer los materiales de Dgv_Recetas
            try
            {
                // Verificar si idBomExistente es igual a 0
                // Si es igual a 0, se debe crear el BOM completo
                if (idBOMExistente == 0)
                {
                    //Ruben Lopez 0901-20-4620
                    //Validacion de datos de la consulta
                    if (Cbo_producto.SelectedValue == null || Cbo_estado.SelectedValue == null ||
                        string.IsNullOrWhiteSpace(Txt_descripcion.Text) || string.IsNullOrWhiteSpace(Txt_versionBOM.Text))
                    {
                        MessageBox.Show("Debe completar todos los campos de la pestaña 'Datos de la consulta'.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    //Ruben Lopez 0901-20-4620
                    //Validacion de detalle BOM
                    int filasRealesMateriales = 0;
                    foreach (DataGridViewRow row in Dgv_Recetas.Rows)
                    {
                        if (!row.IsNewRow) filasRealesMateriales++;
                    }
                    if (filasRealesMateriales == 0)
                    {
                        MessageBox.Show("No puede guardar una receta sin materiales. Agregue al menos un material en 'Detalle BOM'.", "Detalle Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (fasesNuevas.Count == 0 && Dgv_Fases.Rows.Count == 0)
                    {
                        MessageBox.Show("No puede guardar una receta sin fases de producción.", "Fases Vacías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Ruben Lopez 0901-20-4620
                    //Validacion fases de produccion
                    if (Dgv_Fases.Rows.Count == 0)
                    {
                        MessageBox.Show("No puede guardar una receta sin fases de producción. Agregue al menos una fase.", "Fases Vacías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    con.guardarBOMCompleto(descripcion, version, fecha, estado, idProducto, materialesNuevos, fasesNuevas);
                    MessageBox.Show("Receta guardada correctamente");
                    materialesNuevos.Clear();
                    fasesNuevas.Clear();
                }
                // En caso contrario, se guardan solo datos nuevos de detalle o fases
                else
                {
                    con.guardarDatosNuevos(idBOMExistente, materialesNuevos, fasesNuevas);
                    MessageBox.Show("Receta guardada correctamente");
                    materialesNuevos.Clear();
                    fasesNuevas.Clear();
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
        List<(int idMaterial, int idUnidad, decimal cantidad)> materialesNuevos = new List<(int, int, decimal)>();

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

            // Validar horas
            int iHoras;

            if (!int.TryParse(sHorasTexto, out iHoras) || iHoras <= 0)
            {
                MessageBox.Show(
                    "El campo Horas debe ser un número entero positivo mayor a 0.");

                return;
            }

            // VALIDAR FASE REPETIDA
            foreach (DataGridViewRow row in Dgv_Fases.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string faseExistente =
                    row.Cells["faseProduccion"].Value?.ToString().Trim() ?? "";

                if (faseExistente.Equals(
                    sFase,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Esa fase ya fue agregada.",
                        "Duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            // Agregar a lista
            fasesNuevas.Add(
                (sFase, sDescripcion, iHoras)
            );

            // Limpiar campos
            Txt_Fase.Clear();
            Txt_Descripcion_fases.Clear();
            Txt_Horas.Clear();

            // Actualizar grid
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
            // Verificar selección
            if (Dgv_Fases.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una fase para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow fila =
                Dgv_Fases.CurrentRow;

            DialogResult resultado =
                MessageBox.Show(
                    "¿Desea eliminar la fase seleccionada?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                // CASO 1:
                // BOM NUEVO
                if (idBOMExistente == 0)
                {
                    string sFase =
                        fila.Cells["faseProduccion"]
                        .Value?.ToString() ?? "";

                    // Eliminar de lista temporal
                    fasesNuevas.RemoveAll(
                        f => f.sFase.Equals(
                            sFase,
                            StringComparison.OrdinalIgnoreCase
                        )
                    );

                    // Eliminar del grid
                    Dgv_Fases.Rows.Remove(fila);

                    MessageBox.Show(
                        "Fase eliminada correctamente."
                    );
                }
                // CASO 2:
                // BOM EXISTENTE
                else
                {
                    int iCodigoFase =
                        Convert.ToInt32(
                            fila.Cells["idFase"].Value
                        );

                    // Eliminar de BD
                    controlador.eliminarFase(
                        iCodigoFase
                    );

                    // Eliminar visualmente
                    Dgv_Fases.Rows.Remove(fila);

                    MessageBox.Show(
                        "Fase eliminada correctamente."
                    );
                }

                // Limpiar campos
                Txt_Fase.Clear();
                Txt_Descripcion_fases.Clear();
                Txt_Horas.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la fase: " +
                    ex.Message
                );
            }
        }

        // Diego Monterroso - Boton Ayuda
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
                "Ayudas_BOM",
                "Ayuda_CrearBom",
                "Ayuda_BOM.chm"
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

        //Ruben Lopez 0901-20-4620
        private void Btn_agregarMat_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (Cbo_Material.SelectedValue == null ||
                Cbo_Unidad.SelectedValue == null ||
                string.IsNullOrWhiteSpace(Cbo_Cantridad.Text))
            {
                MessageBox.Show(
                    "Por favor, seleccione un Material, una Unidad y digite la Cantidad.",
                    "Faltan datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idMaterial = Convert.ToInt32(Cbo_Material.SelectedValue);
            string nombreMaterial = Cbo_Material.Text;
            int idUnidad = Convert.ToInt32(Cbo_Unidad.SelectedValue);
            string nombreUnidad = Cbo_Unidad.Text;
            decimal cantidad;

            if (!decimal.TryParse(Cbo_Cantridad.Text, out cantidad))
            {
                MessageBox.Show(
                    "Cantidad inválida.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor a cero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // VALIDAR DUPLICADOS EN EL GRID
            foreach (DataGridViewRow row in Dgv_Recetas.Rows)
            {
                if (row.IsNewRow) continue;

                int idExistente =
                    Convert.ToInt32(row.Cells["idMaterial"].Value);

                if (idExistente == idMaterial)
                {
                    MessageBox.Show(
                        "Ese material ya fue agregado.",
                        "Duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            // Agregar al grid
            Dgv_Recetas.Rows.Add(
                idMaterial,
                nombreMaterial,
                idUnidad,
                nombreUnidad,
                cantidad
            );

            // GUARDAR SOLO LOS NUEVOS
            materialesNuevos.Add(
                (idMaterial, idUnidad, cantidad)
            );

            // Limpiar controles
            Cbo_Material.SelectedIndex = -1;
            Cbo_Unidad.SelectedIndex = -1;
            Cbo_Cantridad.Text = "0";
        }

        //Ruben Lopez 0901-20-4620
        private void Btn_eliminarMat_Click(object sender, EventArgs e)
        {
            // Validar que exista una fila seleccionada
            if (Dgv_Recetas.CurrentRow != null)
            {
                Dgv_Recetas.Rows.Remove(Dgv_Recetas.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila del listado de materiales para eliminarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Hecho por: Maria Morales 0901-22-1226
        // PARA LAS RECETAS YA CARGADAS EN EL BOM

        public void cargarDesdeListado(int idBOMSeleccionado)
        {
            idBOM = idBOMSeleccionado;
            idBOMExistente = idBOMSeleccionado;

            // cargado de encabezado
            DataTable dt = con.obtenerBOMPorID(idBOM);

            if (dt.Rows.Count > 0)
            {
                Txt_descripcion.Text = dt.Rows[0]["Descripcion_BOM"].ToString();
                Txt_versionBOM.Text = dt.Rows[0]["Version_BOM"].ToString();
                dtp_fecha.Value = Convert.ToDateTime(dt.Rows[0]["Fecha_Creacion_BOM"]);
                Cbo_estado.SelectedValue = dt.Rows[0]["Fk_Id_Estado_BOM"];
                Cbo_producto.SelectedValue = dt.Rows[0]["Fk_Id_Material"];
            }

            // cargado de materiales
            Dgv_Recetas.Rows.Clear();

            DataTable dtDetalle = con.obtenerDetalleBOM(idBOM);

            foreach (DataRow row in dtDetalle.Rows)
            {
                Dgv_Recetas.Rows.Add(
                    row["Fk_Id_Materiales"],
                    row["Material"],
                    row["Fk_Id_Unidad_Medida"],
                    row["Unidad"],
                    row["Cantidad"]
                );
            }

            // cargado de fases
            pro_ObtenerFases(idBOM);
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            BOM_Reporte re = new BOM_Reporte();

            // FORZAR REFRESH
            re.Refresh();

            re.Show();
        }

        private void Btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}