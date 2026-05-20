using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Mov_Inv;
using Capa_Modelo_Mov_Inv;
using Capa_Modelo_Seguridad;
using CV_730_DSH_BRD;
using System.IO;
namespace Capa_Vista_Mov_Inv
{
    public partial class Frm_Movimientos_Inventario : Form
    {
        Cls_Controlador_Encabezado ctrl = new Cls_Controlador_Encabezado();

        public Frm_Movimientos_Inventario()
        {
            InitializeComponent();
            fun_CargarDGV();
            Cls_Privilegios privilegios = new Cls_Privilegios();

            Cls_Permiso_Aplicacion_Usuario permisos = privilegios.VerificarPermisos(728, 44);
            EstadoInicialBotones(permisos.Cmp_Ingresar_Permiso_Aplicacion_Usuario,
                //permisos.Cmp_Modificar_Permiso_Aplicacion_Usuario,
                //permisos.Cmp_Ingresar_Permiso_Aplicacion_Usuario,
                permisos.Cmp_Eliminar_Permiso_Aplicacion_Usuario,
                permisos.Cmp_Consultar_Permiso_Aplicacion_Usuario,
                permisos.Cmp_Imprimir_Permiso_Aplicacion_Usuario);

        }

        private void EstadoInicialBotones(
                  bool ingresar,
                  //bool modificar,
                  //bool guardar,
                  bool eliminar,
                  bool consultar,
                  bool imprimir)
        {
            Btn_Ingresar.Enabled = ingresar;
            //Btn_Editar.Enabled = false;
            Btn_Imprimir.Enabled = imprimir;
            Btn_Filtrar.Enabled = consultar;

         }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Frm_Encabezado_Transaccion Trans = new Frm_Encabezado_Transaccion();
            Trans.ShowDialog();
        }

        private void fun_CargarDGV()
        {
            try
            {
                DataTable dtMovimientos = ctrl.fun_CargarMovimientos();
                Dgv_Encabezado_Movimiento_Inventarios.DataSource = dtMovimientos;

                // Personalizar encabezados de columnas
                Dgv_Encabezado_Movimiento_Inventarios.Columns["ID"].HeaderText = "ID Movimiento";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["ID_Tipo"].HeaderText = "ID Tipo";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Tipo_Movimiento"].HeaderText = "Tipo Movimiento";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Fecha"].HeaderText = "Fecha";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Descripcion"].HeaderText = "Descripción";

                Dgv_Encabezado_Movimiento_Inventarios.AllowUserToAddRows = false;
                Dgv_Encabezado_Movimiento_Inventarios.ReadOnly = true;
                Dgv_Encabezado_Movimiento_Inventarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_Encabezado_Movimiento_Inventarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de doble clic en el DataGridView
        private void dgvEncabezados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Encabezado_Movimiento_Inventarios.Rows[e.RowIndex];

                // Extraer datos usando las columnas exactas del DGV
                int idMovimiento = Convert.ToInt32(fila.Cells["ID"].Value);
                int idTipo = Convert.ToInt32(fila.Cells["ID_Tipo"].Value);
                string tipoMovimiento = fila.Cells["Tipo_Movimiento"].Value?.ToString() ?? string.Empty;
                DateTime fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                string descripcion = fila.Cells["Descripcion"].Value?.ToString() ?? string.Empty;

                Frm_Encabezado_Transaccion frmDetalles = new Frm_Encabezado_Transaccion(
                    idMovimiento,
                    idTipo,
                    tipoMovimiento,
                    fecha,
                    descripcion
                );

                frmDetalles.ShowDialog();

                // Refrescar el DGV al cerrar
                fun_CargarDGV();
            }
        }
        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            fun_CargarDGV();
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            Frm_ReporteMovimientoInventario reporte = new Frm_ReporteMovimientoInventario();
            reporte.ShowDialog();
        }

        private void Btn_Filtrar_Click(object sender, EventArgs e)
        {
            DSH_BRD_FRM Consultas = new DSH_BRD_FRM();
            Consultas.ShowDialog();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta relativa donde está tu archivo CHM (igual que tu compañero)
                const string subRutaAyuda = @"ayuda\Empresarial\Equipo 2\Inventario\Ayuda_Encabezado_Mov_Inv.chm";

                string rutaEncontrada = null;
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);

                // Busca la carpeta hacia arriba (10 niveles)
                for (int i = 0; i < 10 && dir != null; i++, dir = dir.Parent)
                {
                    string candidata = Path.Combine(dir.FullName, subRutaAyuda);
                    if (File.Exists(candidata))
                    {
                        rutaEncontrada = candidata;
                        break;
                    }
                }
                if (rutaEncontrada != null)

                {
                    // Esta es la ruta INTERNA del archivo dentro del CHM
                    string rutaInterna = @"Ayuda_Encabezado_Movimiento_Inventario.html";

                    Help.ShowHelp(this, rutaEncontrada, HelpNavigator.Topic, rutaInterna);
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo de ayuda.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ayuda:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
