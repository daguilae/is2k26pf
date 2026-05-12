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

namespace Capa_Vista_Empresa_Transporte
{
    public partial class Frm_Entrega_Produccion : Form
    {
        Cls_Emp_Transp_Controlador controlador = new Cls_Emp_Transp_Controlador();

        int iCodigoEntrega = -1;

        int iCodigoProduccionOriginal = 0; 
        int iCodigoTransporteOriginal = 0;

        string sDireccionOriginal = "";
        string sFechaOriginal = "";
        string sEstadoOriginal = "";

        public Frm_Entrega_Produccion()
        {
            InitializeComponent();
        }

        private void Frm_Entrega_Produccion_Load(object sender, EventArgs e)
        {
            fun_EstadoInicial();
            pro_CargarDatos2();

            Dgv_Entrega_Produccion.Columns.Clear();
            Dgv_Entrega_Produccion.Columns.Add("identregaproduccion", "ID Entrega Produccion");
            Dgv_Entrega_Produccion.Columns.Add("idordenp", "ID Orden de Produccion");
            Dgv_Entrega_Produccion.Columns.Add("nombre_prod", "Producto");
            Dgv_Entrega_Produccion.Columns.Add("Cmp_Cantidad_Solicitada", "Cantidad");
            Dgv_Entrega_Produccion.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Entrega_Produccion.Columns.Add("direccion", "Direccion");
            Dgv_Entrega_Produccion.Columns.Add("fecha", "Fecha");
            Dgv_Entrega_Produccion.Columns.Add("estadoentrega", "Estado");

            Dgv_Entrega_Produccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Entrega_Produccion.AllowUserToAddRows = false;

            pro_DatosProduccion();
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

        private void pro_DatosProduccion()
        {
            try
            {
                DataTable tabla = controlador.fun_DatosProduccion();
                Dgv_Entrega_Produccion.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Entrega_Produccion.Rows.Add();

                    Dgv_Entrega_Produccion.Rows[iIndice].Cells["identregaproduccion"].Value = fila["codigo"];
                    Dgv_Entrega_Produccion.Rows[iIndice].Cells["idordenp"].Value = fila["produccion"];
                    Dgv_Entrega_Produccion.Rows[iIndice].Cells["nombre_prod"].Value = fila["producto"];
                    Dgv_Entrega_Produccion.Rows[iIndice].Cells["Cmp_Cantidad_Solicitada"].Value = fila["cantidad"];
                    Dgv_Entrega_Produccion.Rows[iIndice].Cells["idtransporte"].Value = fila["transporte"];
                    Dgv_Entrega_Produccion.Rows[iIndice].Cells["direccion"].Value = fila["direccion"];
                    Dgv_Entrega_Produccion.Rows[iIndice].Cells["fecha"].Value = fila["fecha"];
                    Dgv_Entrega_Produccion.Rows[iIndice].Cells["estadoentrega"].Value = fila["estado"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int iCodigoOrdenP;
            int iCodigoTransporte;
            string sDireccion;
            string sFecha;
            string sEstado;

            // 1. VALIDACIÓN DE CAMPOS
            if (string.IsNullOrWhiteSpace(Txt_ID_Produccion.Text) ||
                string.IsNullOrWhiteSpace(Txt_ID_Transporte.Text) ||
                string.IsNullOrWhiteSpace(Txt_Direccion.Text) ||
                Cbo_Estado_Entrega.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. PARSEO DE DATOS
            if (!int.TryParse(Txt_ID_Produccion.Text, out iCodigoOrdenP))
            {
                MessageBox.Show("ID de Orden de Producción no es válido");
                return;
            }

            if (!int.TryParse(Txt_ID_Transporte.Text, out iCodigoTransporte))
            {
                MessageBox.Show("ID de Transporte no es válido");
                return;
            }

            // 3. VALIDACIÓN DE EXISTENCIA (Evitar duplicados para la misma OrdenP)
            if (controlador.fun_ExisteEntregaProduccion(iCodigoOrdenP))
            {
                MessageBox.Show("Esta orden de producción ya tiene una entrega registrada");
                return;
            }

            // 4. CAPTURA DE VALORES
            sDireccion = Txt_Direccion.Text.Trim();
            sEstado = Cbo_Estado_Entrega.Text;
            sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");

            // 5. CONFIRMACIÓN
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea registrar esta entrega de producción?",
                "Confirmar Registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.No) return;

            // 6. EJECUCIÓN
            try
            {
                controlador.pro_GuardarProduccion(
                    iCodigoOrdenP,
                    iCodigoTransporte,
                    sDireccion,
                    sFecha,
                    sEstado
                );

                MessageBox.Show("Entrega de producción registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // LIMPIAR CAMPOS
                Txt_ID_Produccion.Clear();
                Txt_ID_Transporte.Clear();
                Txt_Direccion.Clear();
                DTP_Fecha.Value = DateTime.Now;
                Cbo_Estado_Entrega.SelectedIndex = 0;

                // ACTUALIZAR GRID
                pro_DatosProduccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la entrega: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_Entrega_Produccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Validar que no sea el encabezado
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = Dgv_Entrega_Produccion.Rows[e.RowIndex];

            if (fila == null) return;

            // 2. Obtener los valores de las celdas (usando los alias del SELECT)
            int iCodigoEntrega = Convert.ToInt32(fila.Cells["identregaproduccion"].Value);
            int iCodigoProduccion = Convert.ToInt32(fila.Cells["idordenp"].Value);
            int iCodigoTransporte = Convert.ToInt32(fila.Cells["idtransporte"].Value);
            string sDireccion = fila.Cells["direccion"].Value?.ToString() ?? "";
            string sFecha = fila.Cells["fecha"].Value?.ToString() ?? "";
            string sEstado = fila.Cells["estadoentrega"].Value?.ToString() ?? "";

            // 3. PASAR LOS DATOS A LOS CONTROLES (Usando Txt_ID_Produccion)
            Txt_ID_Produccion.Text = iCodigoProduccion.ToString();
            Txt_ID_Transporte.Text = iCodigoTransporte.ToString();
            Txt_Direccion.Text = sDireccion;

            DTP_Fecha.Text = sFecha;
            Cbo_Estado_Entrega.Text = sEstado;

            // 4. GUARDAR VALORES ORIGINALES (Para validación de cambios)
            iCodigoProduccionOriginal = iCodigoProduccion;
            iCodigoTransporteOriginal = iCodigoTransporte;
            sDireccionOriginal = sDireccion;
            sFechaOriginal = sFecha;
            sEstadoOriginal = sEstado;

            // 5. GUARDAR EL ID DE LA ENTREGA (Llave primaria para UPDATE)
            this.iCodigoEntrega = iCodigoEntrega;

            //Habilitar combos
            Txt_ID_Transporte.Enabled = true;
            Txt_ID_Produccion.Enabled = true;
            Txt_Direccion.Enabled = true;
            DTP_Fecha.Enabled = true;
            Cbo_Estado_Entrega.Enabled = true;

            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = true;

            Btn_Ingresar.Enabled = false;
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        private void pro_Actualizar(int iCodigoOrdenP, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                bool bCambio = false;

                // 1. VERIFICAR SI HUBO CAMBIOS (Usando las variables originales de producción)
                if (iCodigoOrdenP != iCodigoProduccionOriginal ||
                    iCodigoTransporte != iCodigoTransporteOriginal ||
                    !sDireccion.Equals(sDireccionOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sFecha.Equals(sFechaOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sEstado.Equals(sEstadoOriginal, StringComparison.OrdinalIgnoreCase))
                {
                    // 2. EJECUTAR MODIFICACIÓN
                    controlador.pro_ModificarProduccion(
                        this.iCodigoEntrega,
                        iCodigoOrdenP,
                        iCodigoTransporte,
                        sDireccion,
                        sFecha,
                        sEstado
                    );

                    bCambio = true;
                }

                // 3. RESULTADO DEL PROCESO
                if (bCambio)
                {
                    MessageBox.Show("Entrega de producción actualizada correctamente");

                    // LIMPIAR CAMPOS (Con tus nombres de controles)
                    Txt_ID_Produccion.Clear();
                    Txt_ID_Transporte.Clear();
                    Txt_Direccion.Clear();
                    DTP_Fecha.Value = DateTime.Now;
                    Cbo_Estado_Entrega.SelectedIndex = 0;

                    // REINICIAR ID DE SELECCIÓN
                    iCodigoEntrega = -1;

                    // RECARGAR GRID DE PRODUCCIÓN
                    pro_DatosProduccion();
                }
                else
                {
                    MessageBox.Show("No se ha cambiado ningún dato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la entrega de producción: " + ex.Message);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            // 1. CAPTURAR DATOS DE LOS CONTROLES
            string sDireccion = Txt_Direccion.Text.Trim();
            string sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");
            string sEstado = Cbo_Estado_Entrega.Text;

            // 2. VALIDAR QUE HAYA UN REGISTRO SELECCIONADO (Desde el CellClick)
            if (iCodigoEntrega < 0)
            {
                MessageBox.Show("Seleccione primero una entrega de producción en la tabla.");
                return;
            }

            // 3. VALIDAR CAMPOS VACÍOS
            if (string.IsNullOrWhiteSpace(Txt_ID_Produccion.Text) ||
                string.IsNullOrWhiteSpace(Txt_ID_Transporte.Text) ||
                string.IsNullOrWhiteSpace(sDireccion))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
                return;
            }

            // 4. VALIDAR ID ORDENP (Cambiado de iCodigoProduccion a iCodigoOrdenP)
            if (!int.TryParse(Txt_ID_Produccion.Text, out int iCodigoOrdenP))
            {
                MessageBox.Show("Ingrese un ID de orden de producción válido.");
                return;
            }

            // 5. VALIDAR ID TRANSPORTE
            if (!int.TryParse(Txt_ID_Transporte.Text, out int iCodigoTransporte))
            {
                MessageBox.Show("Ingrese un ID de transporte válido.");
                return;
            }

            // 6. CONFIRMACIÓN AL USUARIO
            DialogResult resultado = MessageBox.Show(
                "¿Desea actualizar la entrega?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            // 7. EJECUTAR LÓGICA DE ACTUALIZACIÓN
            // Asegúrate que tu método pro_Actualizar también reciba iCodigoOrdenP
            pro_Actualizar(
                iCodigoOrdenP,
                iCodigoTransporte,
                sDireccion,
                sFecha,
                sEstado
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
                // Llamada al método del controlador para Producción
                controlador.pro_EliminarProduccion(iCodigoEntrega);
                MessageBox.Show("Dato eliminado correctamente");

                // LIMPIAR CAMPOS (Usando tus nombres específicos)
                Txt_ID_Produccion.Clear();
                Txt_ID_Transporte.Clear();
                Txt_Direccion.Clear();
                DTP_Fecha.Value = DateTime.Now;
                Cbo_Estado_Entrega.SelectedIndex = 0;

                // REINICIAR ID DE SELECCIÓN
                iCodigoEntrega = -1;

                // RECARGAR GRID DE PRODUCCIÓN
                pro_DatosProduccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Txt_ID_Produccion.Clear();
            Txt_ID_Transporte.Clear();
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
            Txt_ID_Transporte.Enabled = false;
            Txt_ID_Produccion.Enabled = false;
            Txt_Direccion.Enabled = false;
            DTP_Fecha.Enabled = false;
            Cbo_Estado_Entrega.Enabled = false;
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Txt_ID_Produccion.Clear();
            Txt_ID_Transporte.Clear();
            Txt_Direccion.Clear();
            DTP_Fecha.Value = DateTime.Now;
            Cbo_Estado_Entrega.SelectedIndex = 0;

            //Habilitar combos
            Txt_ID_Transporte.Enabled = true;
            Txt_ID_Produccion.Enabled = true;
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
    }
}
