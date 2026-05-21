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
    public partial class Frm_Entrega_Compra : Form
    {
        Cls_Emp_Transp_Controlador controlador = new Cls_Emp_Transp_Controlador();

        int iCodigoEntrega = -1;

        int iCodigoCompraOriginal = 0;
        int iCodigoTransporteOriginal = 0;

        string sDireccionOriginal = "";
        string sFechaOriginal = "";
        string sEstadoOriginal = "";

        public Frm_Entrega_Compra()
        {
            InitializeComponent();
        }

        private void Frm_Entrega_Compra_Load(object sender, EventArgs e)
        {
            fun_EstadoInicial();
            pro_CargarDatos();
            pro_CargarDatos2();
            pro_CargarDatos3();

            Dgv_Entrega_Compra.Columns.Clear();
            Dgv_Entrega_Compra.Columns.Add("identregacompra", "ID Entrega de Compra");
            Dgv_Entrega_Compra.Columns.Add("idcompra", "ID de Compra");
            Dgv_Entrega_Compra.Columns.Add("nombre_prod", "Producto");
            Dgv_Entrega_Compra.Columns.Add("cmp_cantidad", "Cantidad");
            Dgv_Entrega_Compra.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Entrega_Compra.Columns.Add("direccion", "Direccion");
            Dgv_Entrega_Compra.Columns.Add("fecha", "Fecha");
            Dgv_Entrega_Compra.Columns.Add("estadoentrega", "Estado");

            Dgv_Entrega_Compra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Entrega_Compra.AllowUserToAddRows = false;

            pro_DatosCompras();
        }

        private void pro_CargarDatos()
        {
            try
            {
                DataTable datos = controlador.fun_DatosIdCompra();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["pk_id_compra"] = 0;
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_ID_Compra.DataSource = datos;
                    Cbo_ID_Compra.DisplayMember = "pk_id_compra";
                    Cbo_ID_Compra.ValueMember = "pk_id_compra";
                }
                else
                {
                    Cbo_ID_Compra.DataSource = null;
                    Cbo_ID_Compra.Items.Clear();
                    Cbo_ID_Compra.Items.Add("No hay empresas disponibles");
                    Cbo_ID_Compra.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las compras: " + ex.Message);
            }
        }

        private void pro_CargarDatos3()
        {
            try
            {
                DataTable datos = controlador.fun_DatosIdTransporte();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["Pk_Id_Transporte"] = 0;
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_ID_Transporte.DataSource = datos;
                    Cbo_ID_Transporte.DisplayMember = "Pk_Id_Transporte";
                    Cbo_ID_Transporte.ValueMember = "Pk_Id_Transporte";
                }
                else
                {
                    Cbo_ID_Transporte.DataSource = null;
                    Cbo_ID_Transporte.Items.Clear();
                    Cbo_ID_Transporte.Items.Add("No hay empresas disponibles");
                    Cbo_ID_Transporte.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los transportes: " + ex.Message);
            }
        }

        private void pro_CargarDatos2()
        {
            Cbo_Estado_Entrega.DataSource = null;
            Cbo_Estado_Entrega.Items.Clear();

            Cbo_Estado_Entrega.Items.Add("Estado");

            Cbo_Estado_Entrega.Items.Add("Pendiente");
            Cbo_Estado_Entrega.Items.Add("En_Camino");
            Cbo_Estado_Entrega.Items.Add("Entregado");

            Cbo_Estado_Entrega.SelectedIndex = 0;
        }

        private void pro_DatosCompras()
        {
            try
            {
                DataTable tabla = controlador.fun_DatosCompra();
                Dgv_Entrega_Compra.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Entrega_Compra.Rows.Add();

                    Dgv_Entrega_Compra.Rows[iIndice].Cells["identregacompra"].Value = fila["codigo"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["idcompra"].Value = fila["compra"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["nombre_prod"].Value = fila["producto"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["cmp_cantidad"].Value = fila["cantidad"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["idtransporte"].Value = fila["transporte"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["direccion"].Value = fila["direccion"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["fecha"].Value = fila["fecha"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["estadoentrega"].Value = fila["estado"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int iCodigoCompra;
            int iCodigoTransporte;
            string sDireccion;
            string sFecha;
            string sEstado;

            // 2. VALIDAR CAMPOS VACÍOS
            if (string.IsNullOrWhiteSpace(Cbo_ID_Compra.Text) ||
                    string.IsNullOrWhiteSpace(Cbo_ID_Transporte.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Direccion.Text) ||
                    Cbo_Estado_Entrega.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Cbo_ID_Compra.Text, out iCodigoCompra))
            {
                MessageBox.Show("ID de Compra no es válido");
                return;
            }

            if (!int.TryParse(Cbo_ID_Transporte.Text, out iCodigoTransporte))
            {
                MessageBox.Show("ID de Transporte no es válido");
                return;
            }

            if (controlador.fun_ExisteEntregaCompra(iCodigoCompra))
            {
                MessageBox.Show("Esta orden de compra ya tiene una entrega registrada");
                return;
            }

            sDireccion = Txt_Direccion.Text.Trim();
            sEstado = Cbo_Estado_Entrega.Text;
            // Usamos Value.ToString para que MySQL reciba la fecha correctamente
            sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");

            // 4. CONFIRMACIÓN
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea registrar esta entrega de compra?",
                "Confirmar Registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.No) return;

            // 5. PROCESO DE GUARDADO
            try
            {
                // Llamada al método de tu controlador
                controlador.pro_GuardarCompra(
                    iCodigoCompra,
                    iCodigoTransporte,
                    sDireccion,
                    sFecha,
                    sEstado
                );

                // BITACORA
                Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();

                bitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    722,
                    "Se registró una entrega de compra",
                    true
                );

                MessageBox.Show("Entrega registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // LIMPIAR CAMPOS
                Cbo_ID_Transporte.SelectedIndex = 0;
                Cbo_ID_Compra.SelectedIndex = 0;
                Txt_Direccion.Clear();
                DTP_Fecha.Value = DateTime.Now;
                Cbo_Estado_Entrega.SelectedIndex = 0;

                // RECARGAR GRID
                pro_DatosCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la entrega: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_Entrega_Compra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = Dgv_Entrega_Compra.Rows[e.RowIndex];

            if (fila == null) return;

            // OBTENER DATOS
            int iCodigoEntrega = Convert.ToInt32(fila.Cells["identregacompra"].Value);
            int iCodigoCompra = Convert.ToInt32(fila.Cells["idcompra"].Value);
            int iCodigoTransporte = Convert.ToInt32(fila.Cells["idtransporte"].Value);
            string sDireccion = fila.Cells["direccion"].Value?.ToString() ?? "";
            string sFecha = fila.Cells["fecha"].Value?.ToString() ?? "";
            string sEstado = fila.Cells["estadoentrega"].Value?.ToString() ?? "";


            // PASAR A CONTROLES
            Cbo_ID_Transporte.Text = iCodigoTransporte.ToString();
            Cbo_ID_Compra.Text = iCodigoCompra.ToString();
            Txt_Direccion.Text = sDireccion;
            DTP_Fecha.Text = sFecha;

            Cbo_Estado_Entrega.Text = sEstado;

            // GUARDAR ORIGINALES
            iCodigoCompraOriginal = iCodigoCompra;
            iCodigoTransporteOriginal = iCodigoTransporte;
            sDireccionOriginal = sDireccion;
            sFechaOriginal = sFecha;
            sEstadoOriginal = sEstado;

            // GUARDAR ID
            this.iCodigoEntrega = iCodigoEntrega;

            //Habilitar combos
            Cbo_ID_Transporte.Enabled = true;
            Cbo_ID_Compra.Enabled = true;
            Txt_Direccion.Enabled = true;
            DTP_Fecha.Enabled = true;
            Cbo_Estado_Entrega.Enabled = true;

            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = true;

            Btn_Ingresar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        private void pro_Actualizar(int iCodigoCompra, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                bool bCambio = false;

                // VERIFICAR SI HUBO CAMBIOS
                if (iCodigoCompra != iCodigoCompraOriginal ||
                    iCodigoTransporte != iCodigoTransporteOriginal ||
                    !sDireccion.Equals(sDireccionOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sFecha.Equals(sFechaOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sEstado.Equals(sEstadoOriginal, StringComparison.OrdinalIgnoreCase))
                {
                    controlador.pro_ModificarCompra(
                        this.iCodigoEntrega,
                        iCodigoCompra,
                        iCodigoTransporte,
                        sDireccion,
                        sFecha,
                        sEstado
                    );

                    bCambio = true;
                }

                if (bCambio)
                {
                    MessageBox.Show("Entrega actualizada correctamente");

                    // LIMPIAR CAMPOS
                    Cbo_ID_Transporte.SelectedIndex = 0;
                    Cbo_ID_Compra.SelectedIndex = 0;
                    Txt_Direccion.Clear();
                    DTP_Fecha.Value = DateTime.Now;
                    Cbo_Estado_Entrega.SelectedIndex = 0;

                    // REINICIAR ID
                    iCodigoEntrega = -1;

                    // RECARGAR GRID
                    pro_DatosCompras();
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

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string sDireccion = Txt_Direccion.Text;
            string sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");
            string sEstado = Cbo_Estado_Entrega.Text;

            // VALIDAR SELECCIÓN
            if (iCodigoEntrega < 0)
            {
                MessageBox.Show("Seleccione primero una entrega");
                return;
            }

            // VALIDAR CAMPOS
            if (string.IsNullOrWhiteSpace(Cbo_ID_Transporte.Text) ||
                string.IsNullOrWhiteSpace(Cbo_ID_Compra.Text) ||
                string.IsNullOrWhiteSpace(sDireccion))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            // VALIDAR ID COMPRA
            if (!int.TryParse(Cbo_ID_Compra.Text, out int iCodigoCompra))
            {
                MessageBox.Show("Ingrese un ID de compra válido");
                return;
            }

            // VALIDAR ID TRANSPORTE
            if (!int.TryParse(Cbo_ID_Transporte.Text, out int iCodigoTransporte))
            {
                MessageBox.Show("Ingrese un ID de transporte válido");
                return;
            }

            // CONFIRMACIÓN
            DialogResult resultado = MessageBox.Show(
                "¿Desea actualizar la entrega?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            // LLAMAR MÉTODO ACTUALIZAR
            pro_Actualizar(
                iCodigoCompra,
                iCodigoTransporte,
                sDireccion,
                sFecha,
                sEstado
            );

            // BITACORA
            Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();

            bitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                722,
                "Se modificó la entrega de compra",
                true
            );
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (iCodigoEntrega < 0)
            {
                MessageBox.Show("Seleccione primero la fila del transporte que desea eliminar");
                return;
            }
            DialogResult resultado = MessageBox.Show(
               "¿Desea eliminar la entrega de la compra?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );
            if (resultado == DialogResult.No)
                return;
            try
            {
                controlador.pro_EliminarCompra(iCodigoEntrega);

                Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();

                bitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    722,
                    "Se eliminó una entrega de compra",
                    true
                );

                MessageBox.Show("Dato eliminado correctamente");
                Cbo_ID_Transporte.SelectedIndex = 0;
                Cbo_ID_Compra.SelectedIndex = 0;
                Txt_Direccion.Clear();
                DTP_Fecha.Value = DateTime.Now;
                Cbo_Estado_Entrega.SelectedIndex = 0;

                // REINICIAR ID
                iCodigoEntrega = -1;

                // RECARGAR GRID
                pro_DatosCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cbo_ID_Transporte.SelectedIndex = 0;
            Cbo_ID_Compra.SelectedIndex = 0;
            Txt_Direccion.Clear();
            DTP_Fecha.Value = DateTime.Now;
            Cbo_Estado_Entrega.SelectedIndex = 0;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;

            //ComboBox bloqueados
            Cbo_ID_Transporte.Enabled = false;
            Cbo_ID_Compra.Enabled = false;
            Txt_Direccion.Enabled = false;
            DTP_Fecha.Enabled = false;
            Cbo_Estado_Entrega.Enabled = false;
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Cbo_ID_Transporte.SelectedIndex = 0;
            Cbo_ID_Compra.SelectedIndex = 0;
            Txt_Direccion.Clear();
            DTP_Fecha.Value = DateTime.Now;
            Cbo_Estado_Entrega.SelectedIndex = 0;

            //Habilitar combos
            Cbo_ID_Transporte.Enabled = true;
            Cbo_ID_Compra.Enabled = true;
            Txt_Direccion.Enabled = true;
            DTP_Fecha.Enabled = true;
            Cbo_Estado_Entrega.Enabled = true;

            //Limpiar selección
            DTP_Fecha.Value = DateTime.Now;
            Cbo_Estado_Entrega.SelectedIndex = 0;

            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;

            Btn_Ingresar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Compra reporte = new Frm_Reporte_Compra();
            reporte.ShowDialog();
        }
    }
}
