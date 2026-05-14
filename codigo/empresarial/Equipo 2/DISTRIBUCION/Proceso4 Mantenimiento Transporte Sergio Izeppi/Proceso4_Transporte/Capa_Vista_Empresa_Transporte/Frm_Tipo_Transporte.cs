using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Emp_Transp;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Empresa_Transporte
{
    public partial class Frm_Tipo_Transporte : Form
    {
        Cls_Emp_Transp_Controlador controlador = new Cls_Emp_Transp_Controlador();

        int iCodigoTransporte = -1;

        string sTipoOriginal = "";
        string sPlacaOriginal = "";
        string sPilotoOriginal = "";
        string sEstadoOriginal = "";

        int iCapacidadOriginal = 0;
        int iEmpresaOriginal = 0;

        public Frm_Tipo_Transporte()
        {
            InitializeComponent();
        }


        private void Frm_Tipo_Transporte_Load(object sender, EventArgs e)
        {
            fun_EstadoInicial();
            pro_CargarDatos();
            pro_CargarDatos2();
            Dgv_Tipo_Transporte.Columns.Clear();
            Dgv_Tipo_Transporte.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Tipo_Transporte.Columns.Add("idempresa", "Nombre de la Empresa");
            Dgv_Tipo_Transporte.Columns.Add("tipotransporte", "Tipo de Transporte");
            Dgv_Tipo_Transporte.Columns.Add("placa", "Placa");
            Dgv_Tipo_Transporte.Columns.Add("nombrepiloto", "Nombre del Piloto");
            Dgv_Tipo_Transporte.Columns.Add("capacidad", "Capacidad");
            Dgv_Tipo_Transporte.Columns.Add("estadotransporte", "Estado del Transporte");

            Dgv_Tipo_Transporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tipo_Transporte.AllowUserToAddRows = false;

            pro_DatosTransporte();
        }

        private void pro_CargarDatos()
        {
            try
            {
                DataTable datos = controlador.fun_DatosEmpresa();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["codigoEmpresa"] = 0;
                    fila["Nombre"] = "Empresa";
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_Empresa.DataSource = datos;
                    Cbo_Empresa.DisplayMember = "Nombre";
                    Cbo_Empresa.ValueMember = "codigoEmpresa";
                }
                else
                {
                    Cbo_Empresa.DataSource = null;
                    Cbo_Empresa.Items.Clear();
                    Cbo_Empresa.Items.Add("No hay empresas disponibles");
                    Cbo_Empresa.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las empresas: " + ex.Message);
            }
        }

        private void pro_CargarDatos2()
        {
            Cbo_Estado_Transporte.DataSource = null;
            Cbo_Estado_Transporte.Items.Clear();

            Cbo_Estado_Transporte.Items.Add("Estado");

            Cbo_Estado_Transporte.Items.Add("Disponible");
            Cbo_Estado_Transporte.Items.Add("Ocupado");
            Cbo_Estado_Transporte.Items.Add("Mantenimiento");

            Cbo_Estado_Transporte.SelectedIndex = 0;
        }

        private void pro_DatosTransporte()
        {
            try
            {
                DataTable tabla = controlador.fun_DatosTransporte();
                Dgv_Tipo_Transporte.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Tipo_Transporte.Rows.Add();

                    Dgv_Tipo_Transporte.Rows[iIndice].Cells["idtransporte"].Value = fila["codigo"];
                    Dgv_Tipo_Transporte.Rows[iIndice].Cells["idempresa"].Value = fila["empresa"];
                    Dgv_Tipo_Transporte.Rows[iIndice].Cells["tipotransporte"].Value = fila["tipo"];
                    Dgv_Tipo_Transporte.Rows[iIndice].Cells["placa"].Value = fila["placa"];
                    Dgv_Tipo_Transporte.Rows[iIndice].Cells["nombrepiloto"].Value = fila["piloto"];
                    Dgv_Tipo_Transporte.Rows[iIndice].Cells["capacidad"].Value = fila["capacidad"];
                    Dgv_Tipo_Transporte.Rows[iIndice].Cells["estadotransporte"].Value = fila["estado"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Guardar1_Click_1(object sender, EventArgs e)
        {
            string sTipoTransp = Txt_TipoTransporte.Text;
            string sPlaca = Txt_Placa.Text;
            string sNombreP = Txt_Piloto.Text;
            string sEstado = Cbo_Estado_Transporte.Text;

            // VALIDAR CAMPOS VACÍOS
            if (string.IsNullOrWhiteSpace(sTipoTransp) ||
                string.IsNullOrWhiteSpace(sPlaca) ||
                string.IsNullOrWhiteSpace(sNombreP) ||
                string.IsNullOrWhiteSpace(Txt_Capacidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            // VALIDAR SOLO LETRAS Y NÚMEROS
            Regex regex = new Regex(@"^[a-zA-Z0-9\s]+$");

            if (!regex.IsMatch(sTipoTransp) || !regex.IsMatch(sNombreP))
            {
                MessageBox.Show("No puede ingresar caracteres especiales");
                return;
            }

            // VALIDAR CAPACIDAD
            if (!int.TryParse(Txt_Capacidad.Text, out int iCapacidad))
            {
                MessageBox.Show("Ingrese una capacidad válida");
                return;
            }

            if (iCapacidad <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor a 0");
                return;
            }

            // OBTENER EMPRESA
            int iCodigoEmpresa = 0;

            if (Cbo_Empresa.SelectedValue != null &&
                !(Cbo_Empresa.SelectedValue is DataRowView))
            {
                iCodigoEmpresa = Convert.ToInt32(Cbo_Empresa.SelectedValue);
            }
            else
            {
                MessageBox.Show("Seleccione una empresa válida");
                return;
            }

            // CONFIRMACIÓN
            DialogResult resultado = MessageBox.Show(
                "¿Desea guardar el transporte?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            try
            {
                controlador.pro_GuardarTransporte(
                    iCodigoEmpresa,
                    sTipoTransp,
                    sPlaca,
                    sNombreP,
                    iCapacidad,
                    sEstado
                );

                // BITACORA
                Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();

                bitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    723,
                    "Se guardo un transpore",
                    true
                );

                MessageBox.Show("Transporte guardado correctamente");

                // LIMPIAR CAMPOS
                Txt_TipoTransporte.Clear();
                Txt_Placa.Clear();
                Txt_Piloto.Clear();
                Txt_Capacidad.Clear();

                Cbo_Empresa.SelectedIndex = 0;
                Cbo_Estado_Transporte.SelectedIndex = 0;

                // RECARGAR GRID
                pro_DatosTransporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void Dgv_Tipo_Transporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = Dgv_Tipo_Transporte.Rows[e.RowIndex];

            if (fila == null) return;

            // OBTENER DATOS
            int iCodigoTransporte = Convert.ToInt32(fila.Cells["idtransporte"].Value);

            string sEmpresa = fila.Cells["idempresa"].Value?.ToString() ?? "";
            string sTipoTransp = fila.Cells["tipotransporte"].Value?.ToString() ?? "";
            string sPlaca = fila.Cells["placa"].Value?.ToString() ?? "";
            string sNombreP = fila.Cells["nombrepiloto"].Value?.ToString() ?? "";
            string sEstado = fila.Cells["estadotransporte"].Value?.ToString() ?? "";

            int iCapacidad = 0;
            int.TryParse(fila.Cells["capacidad"].Value?.ToString(), out iCapacidad);

            // PASAR A CONTROLES
            Cbo_Empresa.Text = sEmpresa;
            Txt_TipoTransporte.Text = sTipoTransp;
            Txt_Placa.Text = sPlaca;
            Txt_Piloto.Text = sNombreP;
            Txt_Capacidad.Text = iCapacidad.ToString();

            Cbo_Estado_Transporte.Text = sEstado;

            // GUARDAR ORIGINALES
            sTipoOriginal = sTipoTransp;
            sPlacaOriginal = sPlaca;
            sPilotoOriginal = sNombreP;

            iCapacidadOriginal = iCapacidad;

            sEstadoOriginal = sEstado;

            // GUARDAR ID
            this.iCodigoTransporte = iCodigoTransporte;

            Cbo_Empresa.Enabled = true;
            Txt_TipoTransporte.Enabled = true;
            Txt_Placa.Enabled = true;
            Txt_Piloto.Enabled = true;
            Txt_Capacidad.Enabled = true;

            Cbo_Estado_Transporte.Enabled = true;

            Btn_Guardar1.Enabled = false;
            Btn_Cancelar.Enabled = true;

            Btn_Ingresar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

            string sTipo = Txt_TipoTransporte.Text;
            string sPlaca = Txt_Placa.Text;
            string sPiloto = Txt_Piloto.Text;
            string sEstado = Cbo_Estado_Transporte.Text;

            // VALIDAR SELECCIÓN
            if (iCodigoTransporte < 0)
            {
                MessageBox.Show("Seleccione primero un transporte");
                return;
            }

            // VALIDAR CAMPOS
            if (string.IsNullOrWhiteSpace(sTipo) ||
                string.IsNullOrWhiteSpace(sPlaca) ||
                string.IsNullOrWhiteSpace(sPiloto) ||
                string.IsNullOrWhiteSpace(Txt_Capacidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            // VALIDAR CAPACIDAD
            if (!int.TryParse(Txt_Capacidad.Text, out int iCapacidad))
            {
                MessageBox.Show("Ingrese una capacidad válida");
                return;
            }

            if (iCapacidad <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor a 0");
                return;
            }

            // CONFIRMACIÓN
            DialogResult resultado = MessageBox.Show(
                "¿Desea actualizar el transporte?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            pro_Actualizar(
                sTipo,
                sPlaca,
                sPiloto,
                iCapacidad,
                sEstado
            );

            // BITACORA
            Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();

            bitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                723,
                "Se modificó un transporte",
                true
            );
        }

        private void pro_Actualizar(string sTipo, string sPlaca, string sPiloto, int iCapacidad, string sEstado)
        {
            try
            {
                int iCodigoEmpresa = Convert.ToInt32(Cbo_Empresa.SelectedValue);

                if (iCodigoEmpresa <= 0)
                {
                    MessageBox.Show("Seleccione una empresa válida");
                    return;
                }

                bool bCambio = false;

                // VERIFICAR SI HUBO CAMBIOS
                if (!sTipo.Equals(sTipoOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sPlaca.Equals(sPlacaOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sPiloto.Equals(sPilotoOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sEstado.Equals(sEstadoOriginal, StringComparison.OrdinalIgnoreCase) ||
                    iCapacidad != iCapacidadOriginal ||
                    iCodigoEmpresa != iEmpresaOriginal)
                {
                    controlador.pro_ModificarTransporte(
                        iCodigoTransporte,
                        iCodigoEmpresa,
                        sTipo,
                        sPlaca,
                        sPiloto,
                        iCapacidad,
                        sEstado
                    );

                    bCambio = true;
                }

                if (bCambio)
                {
                    MessageBox.Show("Transporte actualizado correctamente");

                    // LIMPIAR CAMPOS
                    Txt_TipoTransporte.Clear();
                    Txt_Placa.Clear();
                    Txt_Piloto.Clear();
                    Txt_Capacidad.Clear();

                    Cbo_Empresa.SelectedIndex = 0;
                    Cbo_Estado_Transporte.SelectedIndex = 0;


                    iCodigoTransporte = -1;

                    pro_DatosTransporte();
                }
                else
                {
                    MessageBox.Show("No se ha cambiado ningún dato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (iCodigoTransporte < 0)
            {
                MessageBox.Show("Seleccione primero la fila del transporte que desea eliminar");
                return;
            }
            DialogResult resultado = MessageBox.Show(
               "¿Desea eliminar el transporte?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );
            if (resultado == DialogResult.No)
                return;
            try
            {
                controlador.pro_EliminarTransporte(iCodigoTransporte);

                // BITACORA
                Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();

                bitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    721,
                    "Se elimino un transporte",
                    true
                );

                MessageBox.Show("Transporte eliminado correctamente");
                Txt_TipoTransporte.Clear();
                Txt_Placa.Clear();
                Txt_Piloto.Clear();
                Txt_Capacidad.Clear();

                Cbo_Empresa.SelectedIndex = 0;
                Cbo_Estado_Transporte.SelectedIndex = 0;


                pro_DatosTransporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Txt_TipoTransporte.Clear();
            Txt_Placa.Clear();
            Txt_Piloto.Clear();
            Txt_Capacidad.Clear();

            Cbo_Empresa.SelectedIndex = 0;
            Cbo_Estado_Transporte.SelectedIndex = 0;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Txt_TipoTransporte.Clear();
            Txt_Placa.Clear();
            Txt_Piloto.Clear();
            Txt_Capacidad.Clear();

            Cbo_Empresa.SelectedIndex = 0;
            Cbo_Estado_Transporte.SelectedIndex = 0;

            //Habilitar combos
            Cbo_Empresa.Enabled = true;
            Txt_TipoTransporte.Enabled = true;
            Txt_Placa.Enabled = true;
            Txt_Piloto.Enabled = true;
            Txt_Capacidad.Enabled = true;

            //Limpiar selección
            Cbo_Estado_Transporte.SelectedIndex = 0;

            Btn_Guardar1.Enabled = true;
            Btn_Cancelar.Enabled = true;

            Btn_Ingresar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

        }

        private void fun_EstadoInicial()
        {
            //Habilitados
            Btn_Ingresar.Enabled = true;
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir.Enabled = true;

            //Deshabilitados
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Guardar1.Enabled = false;
            Btn_Cancelar.Enabled = false;

            //ComboBox bloqueados
            Cbo_Empresa.Enabled = false;
            Txt_TipoTransporte.Enabled = false;
            Txt_Placa.Enabled = false;
            Txt_Piloto.Enabled = false;
            Txt_Capacidad.Enabled = false;
            Cbo_Estado_Transporte.Enabled = false;
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Trans reporte = new Frm_Reporte_Trans();
            reporte.ShowDialog();
        }

    }
}
