using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Fase;

namespace Capa_Vista_Fases
{
    public partial class Frm_Fases_Produccion : Form
    {
        Cls_Controlador_Fase controlador = new Cls_Controlador_Fase();
        int iCodigoFase = -1;
        string sFaseOriginal = "";
        string sDescripcionOriginal = "";
        int iHorasOriginal = 0;

        public Frm_Fases_Produccion()
        {
            InitializeComponent();
        }

        private void Frm_Fases_Produccion_Load(object sender, EventArgs e)
        {
            pro_CargarDatos();
            Dgv_Fases.Columns.Clear();
            Dgv_Fases.Columns.Add("idFase", "Id Fase");
            Dgv_Fases.Columns.Add("nombreProducto", "Producto");
            Dgv_Fases.Columns.Add("faseProduccion", "Fase de Producción");
            Dgv_Fases.Columns.Add("descripcionFase", "Descripción de la Fase");
            Dgv_Fases.Columns.Add("horasHombres", "Horas Hombre");

            Dgv_Fases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Fases.ReadOnly = true;
            Dgv_Fases.AllowUserToAddRows = false;
        }
        private void pro_CargarDatos()
        {
            try
            {
                DataTable datos = controlador.fun_DatosProductos();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["codigoProducto"] = 0;
                    fila["Producto"] = "— Productos —";
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_Producto.DataSource = datos;
                    Cbo_Producto.DisplayMember = "Producto";
                    Cbo_Producto.ValueMember = "codigoProducto";
                }
                else
                {
                    Cbo_Producto.DataSource = null;
                    Cbo_Producto.Items.Clear();
                    Cbo_Producto.Items.Add("No hay productos finales");
                    Cbo_Producto.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los menús: " + ex.Message);
            }
        }

        private void pro_ObtenerFases(int iCodigoProducto)
        {
            try
            {
                DataTable tabla = controlador.fun_DatosFase(iCodigoProducto);
                Dgv_Fases.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Fases.Rows.Add();

                    Dgv_Fases.Rows[iIndice].Cells["idFase"].Value = fila["CodigoFase"];
                    Dgv_Fases.Rows[iIndice].Cells["nombreProducto"].Value = fila["Producto"];
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

        private void Cbo_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Producto.SelectedValue == null) return;
                if (Cbo_Producto.SelectedValue is DataRowView) return;

                int iCodigoProducto = Convert.ToInt32(Cbo_Producto.SelectedValue);

                if (iCodigoProducto > 0)
                {
                    pro_ObtenerFases(iCodigoProducto);
                }
                else
                {
                    Dgv_Fases.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las fases del producto: " + ex.Message);
            }
        }

        private void Dgv_Fases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = Dgv_Fases.Rows[e.RowIndex];
            if (fila == null) return;

            string sFase = fila.Cells["faseProduccion"].Value?.ToString() ?? "";
            string sDescripcion= fila.Cells["descripcionFase"].Value?.ToString() ?? "";
            string sHoras = fila.Cells["horasHombres"].Value?.ToString() ?? "";

            Txt_Fase.Text = sFase;
            Txt_Descripcion.Text = sDescripcion;
            Txt_Horas.Text = sHoras;

            sFaseOriginal = sFase;
            sDescripcionOriginal = sDescripcion;
            int.TryParse(sHoras, out iHorasOriginal);

            if (fila.Tag != null)
            {
                iCodigoFase = Convert.ToInt32(fila.Tag);
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string sFase = Txt_Fase.Text.Trim();
            string sDescripcion = Txt_Descripcion.Text.Trim();
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

            if (Cbo_Producto.SelectedValue == null || Convert.ToInt32(Cbo_Producto.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione un producto válido");
                return;
            }

            int iCodigoProducto = Convert.ToInt32(Cbo_Producto.SelectedValue);

            DialogResult resultado = MessageBox.Show(
                "¿Desea guardar la fase de producción?",
                "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            try
            {
                controlador.pro_GuardarFase(iCodigoProducto, sFase, sDescripcion, iHoras);
                MessageBox.Show("El registro de la fase se guardó correctamente");
                Txt_Fase.Clear();
                Txt_Descripcion.Clear();
                Txt_Horas.Clear();
                pro_ObtenerFases(iCodigoProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la receta" + ex.Message);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            int iCodigoProducto = Convert.ToInt32(Cbo_Producto.SelectedValue);
            if (iCodigoFase < 0)
            {
                MessageBox.Show("Seleccione primero la fila de la fase que desea eliminar");
                return;
            }
            DialogResult resultado = MessageBox.Show(
               "¿Desea eliminar el dato de la receta?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );
            if (resultado == DialogResult.No)
                return;
            try
            {
                controlador.pro_EliminarFase(iCodigoFase);
                MessageBox.Show("Dato eliminado correctamente de la receta");
                Txt_Fase.Clear();
                Txt_Descripcion.Clear();
                Txt_Horas.Clear();
                iCodigoFase = -1;
                pro_ObtenerFases(iCodigoProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            int iCodigoProducto = Convert.ToInt32(Cbo_Producto.SelectedValue);
            string sFase = Txt_Fase.Text.Trim();
            string sDescripcion = Txt_Descripcion.Text.Trim();
            string sHorasTexto = Txt_Horas.Text.Trim();

            int iHoras = 0;

            // Validar fila seleccionada
            if (iCodigoFase < 0)
            {
                MessageBox.Show("Seleccione primero la fila de la fase que desea actualizar");
                return;
            }

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(sFase) ||
                string.IsNullOrWhiteSpace(sDescripcion) ||
                string.IsNullOrWhiteSpace(sHorasTexto))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            // Validar número
            if (!int.TryParse(sHorasTexto, out iHoras))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                return;
            }

            // Validar positivo
            if (iHoras <= 0)
            {
                MessageBox.Show("Ingrese la cantidad de horas mayor a 0");
                return;
            }

            // Validar si hubo cambios
            if (sFase == sFaseOriginal &&
                sDescripcion == sDescripcionOriginal &&
                iHoras == iHorasOriginal)
            {
                MessageBox.Show("No se han realizado cambios");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea actualizar el registro de la fase?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            try
            {
                controlador.pro_ActualizarFase(iCodigoFase, sFase, sDescripcion, iHoras);
                MessageBox.Show("Fase actualizada correctamente");
                Txt_Fase.Clear();
                Txt_Descripcion.Clear();
                Txt_Horas.Clear();
                iCodigoFase = -1;
                pro_ObtenerFases(iCodigoProducto);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Fases reporte = new Frm_Reporte_Fases();
            reporte.Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            Txt_Fase.Clear();
            Txt_Descripcion.Clear();
            Txt_Horas.Clear();
            iCodigoFase = -1;
        }
    }
}
