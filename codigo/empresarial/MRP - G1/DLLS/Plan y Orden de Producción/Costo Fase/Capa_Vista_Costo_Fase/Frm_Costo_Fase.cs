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
using CrystalDecisions;


namespace Capa_Vista_Costo_Fase
{
    public partial class Frm_Costo_Fases : Form
    {
        Cls_Controlador controlador = new Cls_Controlador();
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
            Dgv_Costo_Fase.Columns.Add("faseProducto", "Fase Producto");
            Dgv_Costo_Fase.Columns.Add("tipoCosto", "Tipo de Costo");
            Dgv_Costo_Fase.Columns.Add("costo", "Costo");

            Dgv_Costo_Fase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Costo_Fase.AllowUserToAddRows = false;

            Cbo_Fase.DataSource = controlador.ObtenerFases();
            Cbo_Fase.DisplayMember = "sNombreFase";
            Cbo_Fase.ValueMember = "iIdFase";

            Cbo_Tipo_Costo.DataSource = controlador.ObtenerTiposCosto();
            Cbo_Tipo_Costo.DisplayMember = "sNombreTipoCosto";
            Cbo_Tipo_Costo.ValueMember = "iIdTipoCosto";

            CargarGrid();
        }
        private void CargarGrid()
        {
            Dgv_Costo_Fase.Rows.Clear();

            List<Cls_Datos_Costo_Fase> lista = controlador.ObtenerCostoFase();

            foreach (var item in lista)
            {
                Dgv_Costo_Fase.Rows.Add(
                    item.iIdCostoFase,
                    item.sNombreFase,
                    item.sNombreTipoCosto,
                    item.dCosto
                );
            }
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Cbo_Fase.SelectedIndex == -1 || Cbo_Tipo_Costo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione fase y tipo de costo.");
                    return;
                }

                
                decimal valorDinero;
                
                if (!decimal.TryParse(Txt_Costos.Text, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out valorDinero))
                {
                    MessageBox.Show("Ingrese un monto de costo válido en el campo Costo.");
                    return;
                }

                
                int idFase = (int)Cbo_Fase.SelectedValue;
                int idTipoCosto = (int)Cbo_Tipo_Costo.SelectedValue;

                
                controlador.InsertarCostoFase(idFase, idTipoCosto, valorDinero);

                MessageBox.Show("Guardado exitosamente");
                CargarGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            Txt_Costo.Clear();
            Cbo_Fase.SelectedIndex = 0;
            Cbo_Tipo_Costo.SelectedIndex = 0;
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

               
                int idFase = (int)Cbo_Fase.SelectedValue;
                int idTipoCosto = (int)Cbo_Tipo_Costo.SelectedValue;

                
                controlador.ModificarCostoFase(idSeleccionado, idFase, idTipoCosto, nuevoCosto);

                MessageBox.Show("Registro actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                CargarGrid();
                LimpiarCampos();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
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
                Txt_Costo.Text = idSeleccionado.ToString();

                
                Cbo_Fase.SelectedIndex = Cbo_Fase.FindStringExact(fila.Cells[1].Value.ToString());
                Cbo_Tipo_Costo.SelectedIndex = Cbo_Tipo_Costo.FindStringExact(fila.Cells[2].Value.ToString());

                
                if (fila.Cells[3].Value != null)
                {
                    decimal monto = Convert.ToDecimal(fila.Cells[3].Value);
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

           
            Cbo_Fase.DataSource = controlador.ObtenerFases();
            Cbo_Tipo_Costo.DataSource = controlador.ObtenerTiposCosto();

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
    }
}
