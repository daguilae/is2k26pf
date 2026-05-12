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
    public partial class Frm_Entrega_Venta : Form
    {
        Cls_Emp_Transp_Controlador controlador = new Cls_Emp_Transp_Controlador();

        int iCodigoEntrega = -1;

        int iCodigoVentaOriginal = 0;
        int iCodigoTransporteOriginal = 0;

        string sDireccionOriginal = "";
        string sFechaOriginal = "";
        string sEstadoOriginal = "";

        public Frm_Entrega_Venta()
        {
            InitializeComponent();
        }

        private void Frm_Entrega_Venta_Load(object sender, EventArgs e)
        {
            fun_EstadoInicial();
            pro_CargarDatos2();

            Dgv_Entrega_Venta.Columns.Clear();
            Dgv_Entrega_Venta.Columns.Add("identregaventa", "ID Entrega de Venta");
            Dgv_Entrega_Venta.Columns.Add("idventa", "ID de la Venta");
            Dgv_Entrega_Venta.Columns.Add("nombre_prod", "Producto");
            Dgv_Entrega_Venta.Columns.Add("Cmp_Cantidad_Producto", "Cantidad");
            Dgv_Entrega_Venta.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Entrega_Venta.Columns.Add("direccion", "Direccion");
            Dgv_Entrega_Venta.Columns.Add("fecha", "Fecha");
            Dgv_Entrega_Venta.Columns.Add("estadoentrega", "Estado");

            Dgv_Entrega_Venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Entrega_Venta.AllowUserToAddRows = false;

            pro_DatosVentas();
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

        private void pro_DatosVentas()
        {
            try
            {
                DataTable tabla = controlador.fun_DatosVenta();

                Dgv_Entrega_Venta.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Entrega_Venta.Rows.Add();

                    Dgv_Entrega_Venta.Rows[iIndice].Cells["identregaventa"].Value = fila["codigo"];
                    Dgv_Entrega_Venta.Rows[iIndice].Cells["idventa"].Value = fila["venta"];
                    Dgv_Entrega_Venta.Rows[iIndice].Cells["nombre_prod"].Value = fila["producto"];
                    Dgv_Entrega_Venta.Rows[iIndice].Cells["Cmp_Cantidad_Producto"].Value = fila["cantidad"];
                    Dgv_Entrega_Venta.Rows[iIndice].Cells["idtransporte"].Value = fila["transporte"];
                    Dgv_Entrega_Venta.Rows[iIndice].Cells["direccion"].Value = fila["direccion"];
                    Dgv_Entrega_Venta.Rows[iIndice].Cells["fecha"].Value = fila["fecha"];
                    Dgv_Entrega_Venta.Rows[iIndice].Cells["estadoentrega"].Value = fila["estado"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int iCodigoVenta;
            int iCodigoTransporte;
            string sDireccion;
            string sFecha;
            string sEstado;

            if (string.IsNullOrWhiteSpace(Txt_ID_Venta.Text) ||
                string.IsNullOrWhiteSpace(Txt_ID_Transporte.Text) ||
                string.IsNullOrWhiteSpace(Txt_Direccion.Text) ||
                Cbo_Estado_Entrega.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_ID_Venta.Text, out iCodigoVenta))
            {
                MessageBox.Show("ID de Venta no es válido");
                return;
            }

            if (!int.TryParse(Txt_ID_Transporte.Text, out iCodigoTransporte))
            {
                MessageBox.Show("ID de Transporte no es válido");
                return;
            }

            if (controlador.fun_ExisteEntregaVenta(iCodigoVenta))
            {
                MessageBox.Show("Esta venta ya tiene una entrega registrada");
                return;
            }

            sDireccion = Txt_Direccion.Text.Trim();
            sEstado = Cbo_Estado_Entrega.Text;
            sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea registrar esta entrega de venta?",
                "Confirmar Registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.No) return;

            try
            {
                controlador.pro_GuardarVenta(
                    iCodigoVenta,
                    iCodigoTransporte,
                    sDireccion,
                    sFecha,
                    sEstado
                );

                MessageBox.Show("Entrega de venta registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Txt_ID_Venta.Clear();
                Txt_ID_Transporte.Clear();
                Txt_Direccion.Clear();
                DTP_Fecha.Value = DateTime.Now;
                Cbo_Estado_Entrega.SelectedIndex = 0;

                pro_DatosVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la entrega: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_Entrega_Venta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = Dgv_Entrega_Venta.Rows[e.RowIndex];

            if (fila == null) return;

                int iCodigoEntrega = Convert.ToInt32(fila.Cells["identregaventa"].Value);

                int iCodigoVenta = Convert.ToInt32(fila.Cells["idventa"].Value);
                int iCodigoTransporte = Convert.ToInt32(fila.Cells["idtransporte"].Value);
                string sDireccion = fila.Cells["direccion"].Value?.ToString() ?? "";
                string sFecha = fila.Cells["fecha"].Value?.ToString() ?? "";
                string sEstado = fila.Cells["estadoentrega"].Value?.ToString() ?? "";

                //PASAR LOS DATOS A LOS CONTROLES
                Txt_ID_Venta.Text = iCodigoVenta.ToString();
                Txt_ID_Transporte.Text = iCodigoTransporte.ToString();
                Txt_Direccion.Text = sDireccion;

                DTP_Fecha.Text = sFecha;
                Cbo_Estado_Entrega.Text = sEstado;

                // 4. GUARDAR VALORES ORIGINALES (Útil para bitácoras o validaciones de cambios)
                iCodigoVentaOriginal = iCodigoVenta;
                iCodigoTransporteOriginal = iCodigoTransporte;
                sDireccionOriginal = sDireccion;
                sFechaOriginal = sFecha;
                sEstadoOriginal = sEstado;

                // 5. GUARDAR EL ID DE LA ENTREGA (La llave primaria para el UPDATE/DELETE)
                this.iCodigoEntrega = iCodigoEntrega;

            //Habilitar combos
            Txt_ID_Transporte.Enabled = true;
            Txt_ID_Venta.Enabled = true;
            Txt_Direccion.Enabled = true;
            DTP_Fecha.Enabled = true;
            Cbo_Estado_Entrega.Enabled = true;

            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = true;

            Btn_Ingresar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;

        }

        private void pro_Actualizar(int iCodigoVenta, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                bool bCambio = false;

                // 1. VERIFICAR SI HUBO CAMBIOS 
                if (iCodigoVenta != iCodigoVentaOriginal ||
                    iCodigoTransporte != iCodigoTransporteOriginal ||
                    !sDireccion.Equals(sDireccionOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sFecha.Equals(sFechaOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sEstado.Equals(sEstadoOriginal, StringComparison.OrdinalIgnoreCase))
                {
                    controlador.pro_ModificarVenta(
                        this.iCodigoEntrega,
                        iCodigoVenta,
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
                    MessageBox.Show("Entrega actualizada correctamente");

                    // LIMPIAR CAMPOS
                    Txt_ID_Venta.Clear();
                    Txt_ID_Transporte.Clear();
                    Txt_Direccion.Clear();
                    DTP_Fecha.Value = DateTime.Now;
                    Cbo_Estado_Entrega.SelectedIndex = 0;

                    // REINICIAR ID
                    iCodigoEntrega = -1;

                    // RECARGAR GRID DE VENTAS
                    pro_DatosVentas();
                }
                else
                {
                    MessageBox.Show("No se ha cambiado ningún dato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar:");
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string sDireccion = Txt_Direccion.Text.Trim();
            string sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");
            string sEstado = Cbo_Estado_Entrega.Text;

            // 2. VALIDAR QUE HAYA UN REGISTRO SELECCIONADO (Desde el CellClick)
            if (iCodigoEntrega < 0)
            {
                MessageBox.Show("Seleccione primero una entrega");
                return;
            }

            // 3. VALIDAR CAMPOS VACÍOS
            if (string.IsNullOrWhiteSpace(Txt_ID_Venta.Text) ||
                string.IsNullOrWhiteSpace(Txt_ID_Transporte.Text) ||
                string.IsNullOrWhiteSpace(sDireccion))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            // 4. VALIDAR ID VENTA (Uso TryParse para evitar errores de formato)
            if (!int.TryParse(Txt_ID_Venta.Text, out int iCodigoVenta))
            {
                MessageBox.Show("Ingrese un ID de venta válido.");
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
            pro_Actualizar(
                iCodigoVenta,
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
                controlador.pro_EliminarVenta(iCodigoEntrega);
                MessageBox.Show("Dato eliminado correctamente");
                Txt_ID_Transporte.Clear();
                Txt_ID_Venta.Clear();
                Txt_Direccion.Clear();
                DTP_Fecha.Value = DateTime.Now;
                Cbo_Estado_Entrega.SelectedIndex = 0;

                // REINICIAR ID
                iCodigoEntrega = -1;

                // RECARGAR GRID
                pro_DatosVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Txt_ID_Transporte.Clear();
            Txt_ID_Venta.Clear();
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
            Txt_ID_Venta.Enabled = false;
            Txt_Direccion.Enabled = false;
            DTP_Fecha.Enabled = false;
            Cbo_Estado_Entrega.Enabled = false;
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Txt_ID_Transporte.Clear();
            Txt_ID_Venta.Clear();
            Txt_Direccion.Clear();
            DTP_Fecha.Value = DateTime.Now;
            Cbo_Estado_Entrega.SelectedIndex = 0;

            //Habilitar combos
            Txt_ID_Transporte.Enabled = true;
            Txt_ID_Venta.Enabled = true;
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
