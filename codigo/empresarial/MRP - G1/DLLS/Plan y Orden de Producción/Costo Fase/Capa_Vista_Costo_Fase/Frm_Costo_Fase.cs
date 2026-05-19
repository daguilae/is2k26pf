using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Costo_Fase;
using Capa_Modelo_Costo_Fase;
using System.IO;
using Capa_Controlador_Seguridad;
using CrystalDecisions;


namespace Capa_Vista_Costo_Fase
{
    public partial class Frm_Costo_Fases : Form
    {
        Cls_Controlador controlador = new Cls_Controlador();
        Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();
        int idSeleccionado = 0;

        int idFaseOriginal;
        int idTipoCostoOriginal;
        decimal costoOriginal;

        public Frm_Costo_Fases()
        {
            InitializeComponent();
        }

     

        private void Gpb_Costo_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Costo_Fases_Load(object sender, EventArgs e)
        {
            Dgv_Costo_Fase.CellClick += Dgv_Costo_Fase_CellClick;
            Dgv_Costo_Fase.MultiSelect = false;

            Dgv_Costo_Fase.Columns.Clear();
            Dgv_Costo_Fase.Columns.Add("Costofase", "Id Costo");
            Dgv_Costo_Fase.Columns.Add("nombreProducto", "Producto / Material");
            Dgv_Costo_Fase.Columns.Add("faseProducto", "Fase Producto");
            Dgv_Costo_Fase.Columns.Add("tipoCosto", "Tipo de Costo");
            Dgv_Costo_Fase.Columns.Add("costo", "Costo");

            Dgv_Costo_Fase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Costo_Fase.AllowUserToAddRows = false;

            
            Cbo_Material.SelectedIndexChanged -= Cbo_Material_SelectedIndexChanged;

           
            Cbo_Fase.DataSource = null;
            Cbo_Fase.DisplayMember = "sNombreFase";
            Cbo_Fase.ValueMember = "iIdFase";

            
            Cbo_Material.DisplayMember = "sNombreMaterial";
            Cbo_Material.ValueMember = "iIdMaterial";
            Cbo_Material.DataSource = controlador.ObtenerMateriales();
            Cbo_Material.SelectedIndex = -1;

            Cbo_Material.SelectedIndexChanged += Cbo_Material_SelectedIndexChanged;

            Cbo_Tipo_Costo.DisplayMember = "sNombreTipoCosto";
            Cbo_Tipo_Costo.ValueMember = "iIdTipoCosto";
            Cbo_Tipo_Costo.DataSource = controlador.ObtenerTiposCosto();

            CargarGrid();
        }
        private void CargarGrid()
        {
            try
            {
                Dgv_Costo_Fase.Rows.Clear();

                List<Cls_Datos_Costo_Fase> listaCostos = controlador.ObtenerCostoFase();
                var listaMateriales = controlador.ObtenerMateriales();
                var listaTiposCosto = controlador.ObtenerTiposCosto();

                foreach (var item in listaCostos)
                {
                   
                    string nombreTipoCosto = listaTiposCosto.FirstOrDefault(tc => tc.iIdTipoCosto == item.iIdTipoCosto)?.sNombreTipoCosto ?? "General";

                   
                    string nombreProducto = "No asignado";
                    string nombreFase = "Fase " + item.iIdFase;

                    foreach (var mat in listaMateriales)
                    {
                        var fasesDeEsteMaterial = controlador.ObtenerFasesPorMaterial(mat.iIdMaterial);
                        var faseEncontrada = fasesDeEsteMaterial.FirstOrDefault(f => f.iIdFase == item.iIdFase);

                        if (faseEncontrada != null)
                        {
                            nombreProducto = mat.sNombreMaterial;
                            nombreFase = faseEncontrada.sNombreFase;
                            break;
                        }
                    }

                    
                    Dgv_Costo_Fase.Rows.Add(
                        item.iIdCostoFase,
                        nombreProducto,
                        nombreFase,
                        nombreTipoCosto,
                        item.dCosto
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla de costos: " + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Cbo_Material.SelectedIndex == -1 || Cbo_Fase.SelectedIndex == -1 || Cbo_Tipo_Costo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un Producto, una Fase y el Tipo de Costo.",
                                    "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                decimal valorDinero;
                if (!decimal.TryParse(Txt_Costos.Text, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out valorDinero))
                {
                    MessageBox.Show("Ingrese un monto de costo válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                Cls_Datos_Material matSel = Cbo_Material.SelectedItem as Cls_Datos_Material;
                List<Cls_Datos_Fase> fasesDelMaterial = controlador.ObtenerFasesPorMaterial(matSel.iIdMaterial);
                int idFase = fasesDelMaterial[Cbo_Fase.SelectedIndex].iIdFase;

               
                int idTipoCosto = Convert.ToInt32(Cbo_Tipo_Costo.SelectedValue);

               
                bool yaExiste = controlador.ValidarExisteCosto(idFase, idTipoCosto);

                if (yaExiste)
                {
                    MessageBox.Show($"El producto '{matSel.sNombreMaterial}' ya tiene asignado un precio para la fase '{Cbo_Fase.SelectedItem.ToString()}'.\n\nSi desea cambiar el precio, por favor seleccione el registro en la tabla inferior y utilice el botón 'Modificar'.",
                                    "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
               
                controlador.InsertarCostoFase(idFase, idTipoCosto, valorDinero);

                MessageBox.Show("Costo asignado exitosamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bitacora.RegistrarAccion(Cls_Usuario_Conectado.iIdUsuario, 740, "Costo Fase guardado", true);

                CargarGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar el costo: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            
            Cbo_Fase.SelectedIndex = 0;
            Cbo_Tipo_Costo.SelectedIndex = 0;
            Txt_Costos.Clear();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Debe seleccionar un registro de la tabla para modificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal nuevoCosto;
                if (!decimal.TryParse(Txt_Costos.Text, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out nuevoCosto))
                {
                    if (!decimal.TryParse(Txt_Costos.Text, out nuevoCosto))
                    {
                        MessageBox.Show("Ingrese un monto de costo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                
                Cls_Datos_Material matSel = Cbo_Material.SelectedItem as Cls_Datos_Material;
                List<Cls_Datos_Fase> fasesDelMaterial = controlador.ObtenerFasesPorMaterial(matSel.iIdMaterial);
                int idFase = fasesDelMaterial[Cbo_Fase.SelectedIndex].iIdFase;
               

                int idTipoCosto = (int)Cbo_Tipo_Costo.SelectedValue;

               
                controlador.ModificarCostoFase(idSeleccionado, idFase, idTipoCosto, nuevoCosto);

                MessageBox.Show("Registro actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bitacora.RegistrarAccion(Cls_Usuario_Conectado.iIdUsuario, 740, " Costo Fase Actualizado", true);

                CargarGrid();
                LimpiarCampos();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Debe seleccionar un registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Seguro que desea eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.No)
                    return;

                controlador.EliminarCostoFase(idSeleccionado);

                MessageBox.Show("Registro eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrid();
                LimpiarCampos();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void Dgv_Costo_Fase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Costo_Fase.Rows[e.RowIndex];

                
                idSeleccionado = Convert.ToInt32(fila.Cells[0].Value);

               
                string nombreProductoGrid = fila.Cells[1].Value.ToString();
                Cbo_Material.SelectedIndex = Cbo_Material.FindStringExact(nombreProductoGrid);

               
                string nombreFaseGrid = fila.Cells[2].Value.ToString();
                Cbo_Fase.SelectedIndex = Cbo_Fase.FindStringExact(nombreFaseGrid);

                
                string nombreTipoCostoGrid = fila.Cells[3].Value.ToString();
                Cbo_Tipo_Costo.SelectedIndex = Cbo_Tipo_Costo.FindStringExact(nombreTipoCostoGrid);

              
                if (fila.Cells[4].Value != null)
                {
                    decimal monto = Convert.ToDecimal(fila.Cells[4].Value);
                    Txt_Costos.Text = monto.ToString("0.##");
                }
            }
        }

        private void Txt_Costo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Costo_Fase reporte = new Frm_Reporte_Costo_Fase();
            reporte.ShowDialog();
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();
            CargarGrid();

          
            Cbo_Material.DataSource = controlador.ObtenerMateriales();
            Cbo_Tipo_Costo.DataSource = controlador.ObtenerTiposCosto();
            Cbo_Fase.DataSource = null; 

            MessageBox.Show("Formulario y datos actualizados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                "Ayuda_Costo",
                "Ayuda_Costo.chm"
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


        private void Cbo_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (Cbo_Material.SelectedIndex == -1 || Cbo_Material.SelectedItem == null)
                {
                    Cbo_Fase.DataSource = null;
                    Cbo_Fase.Items.Clear();
                    return;
                }

                
                Cls_Datos_Material materialSeleccionado = Cbo_Material.SelectedItem as Cls_Datos_Material;

                if (materialSeleccionado != null)
                {
                    int idMaterial = materialSeleccionado.iIdMaterial;

                    
                    List<Cls_Datos_Fase> fasesFiltradas = controlador.ObtenerFasesPorMaterial(idMaterial);

                   
                    Cbo_Fase.DataSource = null;
                    Cbo_Fase.Items.Clear();

                   
                    if (fasesFiltradas == null || fasesFiltradas.Count == 0)
                    {
                        MessageBox.Show("No hay fases asignadas para el producto seleccionado.",
                                        "Sin Fases Asignadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cbo_Fase.SelectedIndex = -1;
                        return;
                    }

                   
                    foreach (var fase in fasesFiltradas)
                    {
                        Cbo_Fase.Items.Add(fase.sNombreFase);
                    }

                    
                    Cbo_Fase.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar aplicar el filtro de fases: " + ex.Message,
                                "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
