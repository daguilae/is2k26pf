// Arón Ricardo Esquit Silva 0901-22-13036 07/05/2026
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Orden_Material;
using Capa_Vista_Componente_Consultas;
using System.IO;

namespace Capa_Vista_Orden_Material
{
    public partial class Frm_Encabezado_Orden_Material : Form
    {
        Cls_Controlador_Encabezado_Orden_Material controlador = new Cls_Controlador_Encabezado_Orden_Material();
        private bool cargandoCombos = false;
        private bool cambiandoChecks = false;

        public Frm_Encabezado_Orden_Material()
        {
            InitializeComponent();
            this.Load += Frm_Encabezado_Orden_Material_Load;
        }

        private void Frm_Encabezado_Orden_Material_Load(object sender, EventArgs e)
        {
            Fun_Cargar_Combos();

            cbo_id_orden.SelectedIndex = -1;
            cbo_orden_produccion.SelectedIndex = -1;
            cbo_estado.SelectedIndex = -1;

            dtp_fecha_solicitud.ShowCheckBox = true;
            dtp_fecha_recibida.ShowCheckBox = true;

            dtp_fecha_solicitud.Value = DateTime.Now.AddMonths(-1);
            dtp_fecha_recibida.Value = DateTime.Now;

            dtp_fecha_solicitud.Checked = false;
            dtp_fecha_recibida.Checked = false;

            Fun_Cargar_Datos();
            Fun_Bloquear_Botones();
        }

        private void Fun_Cargar_Datos()
        {
            dtv_encabezado_orden_material.DataSource =
                controlador.Fun_Mostrar_Encabezado_Orden_Material();

            dtv_encabezado_orden_material.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dtv_encabezado_orden_material.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            dtv_encabezado_orden_material.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dtv_encabezado_orden_material.ReadOnly = true;

            dtv_encabezado_orden_material.AllowUserToAddRows = false;

            Fun_Agregar_Boton_Ver();
        }

        private void FiltrarOrdenes()
        {
            if (cargandoCombos)
                return;

            if (!chk_id_orden.Checked &&
                !chk_orden_produccion.Checked &&
                !chk_estado.Checked)
            {
                Fun_Cargar_Datos();
                return;
            }

            if (chk_id_orden.Checked && cbo_id_orden.SelectedValue is int)
            {
                int idOrden = Convert.ToInt32(cbo_id_orden.SelectedValue);

                dtv_encabezado_orden_material.DataSource =
                    controlador.Fun_Buscar_Encabezado_Orden_Material(idOrden);

                return;
            }

            if (chk_orden_produccion.Checked && cbo_orden_produccion.SelectedValue is int)
            {
                int idOrdenProduccion = Convert.ToInt32(cbo_orden_produccion.SelectedValue);

                dtv_encabezado_orden_material.DataSource =
                    controlador.Fun_Filtrar_Por_Orden_Produccion(idOrdenProduccion);

                return;
            }

            if (chk_estado.Checked && cbo_estado.SelectedValue is int)
            {
                int idEstado = Convert.ToInt32(cbo_estado.SelectedValue);

                dtv_encabezado_orden_material.DataSource =
                    controlador.Fun_Filtrar_Por_Estado(idEstado);

                return;
            }
        }



        private void Fun_Cargar_Combos()
        {
            cargandoCombos = true;

            cbo_id_orden.DataSource = controlador.Fun_Obtener_Id_Ordenes_Material();
            cbo_id_orden.DisplayMember = "ID_Orden";
            cbo_id_orden.ValueMember = "ID_Orden";
            cbo_id_orden.SelectedIndex = -1;

            cbo_estado.DataSource = controlador.Fun_Obtener_Estados_Orden_Material();
            cbo_estado.DisplayMember = "Nombre_Estado";
            cbo_estado.ValueMember = "Pk_Id_Estado_Orden_Material";
            cbo_estado.SelectedIndex = -1;

            cbo_orden_produccion.DataSource = controlador.Fun_Obtener_Ordenes_Produccion();
            cbo_orden_produccion.DisplayMember = "Orden_Produccion";
            cbo_orden_produccion.ValueMember = "Pk_Id_Orden_Produccion";
            cbo_orden_produccion.SelectedIndex = -1;

            cargandoCombos = false;
        }

        private void Fun_Bloquear_Botones()
        {
            Button[] botones =
            {
                Btn_ingresar,
                Btn_modificar,
                Btn_guardar,
                Btn_cancelar,
                Btn_eliminar
            };

            foreach (Button btn in botones)
            {
                btn.Enabled = false;
                btn.BackColor = Color.Gainsboro;
                btn.ForeColor = Color.DarkGray;
            }
        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void chk_id_orden_CheckedChanged(object sender, EventArgs e)
        {
            if (cambiandoChecks) return;

            if (chk_id_orden.Checked)
            {
                cambiandoChecks = true;
                chk_orden_produccion.Checked = false;
                chk_estado.Checked = false;
                cambiandoChecks = false;

                dtp_fecha_solicitud.Checked = false;
                dtp_fecha_recibida.Checked = false;
            }

            FiltrarOrdenes();
        }

        private void chk_orden_produccion_CheckedChanged(object sender, EventArgs e)
        {
            if (cambiandoChecks) return;

            if (chk_orden_produccion.Checked)
            {
                cambiandoChecks = true;
                chk_id_orden.Checked = false;
                chk_estado.Checked = false;
                cambiandoChecks = false;

                dtp_fecha_solicitud.Checked = false;
                dtp_fecha_recibida.Checked = false;
            }

            FiltrarOrdenes();
        }

        private void chk_estado_CheckedChanged(object sender, EventArgs e)
        {
            if (cambiandoChecks) return;

            if (chk_estado.Checked)
            {
                cambiandoChecks = true;
                chk_id_orden.Checked = false;
                chk_orden_produccion.Checked = false;
                cambiandoChecks = false;

                dtp_fecha_solicitud.Checked = false;
                dtp_fecha_recibida.Checked = false;
            }

            FiltrarOrdenes();
        }

        private void cbo_id_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_id_orden.Checked)
                FiltrarOrdenes();
        }

        private void cbo_orden_produccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_orden_produccion.Checked)
                FiltrarOrdenes();
        }

        private void cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_estado.Checked)
                FiltrarOrdenes();
        }

        private void FiltrarPorFechas()
        {
            if (!dtp_fecha_solicitud.Checked || !dtp_fecha_recibida.Checked)
            {
                Fun_Cargar_Datos();
                return;
            }

            cambiandoChecks = true;
            chk_id_orden.Checked = false;
            chk_orden_produccion.Checked = false;
            chk_estado.Checked = false;
            cambiandoChecks = false;

            string fechaInicio = dtp_fecha_solicitud.Value.ToString("yyyy-MM-dd");
            string fechaFin = dtp_fecha_recibida.Value.ToString("yyyy-MM-dd");

            dtv_encabezado_orden_material.DataSource =
                controlador.Fun_Filtrar_Por_Fechas(fechaInicio, fechaFin);
        }

        private void dtp_fecha_recibida_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFechas();
        }

        private void dtp_fecha_solicitud_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFechas();
        }

        private void Fun_Seleccionar_Fila(int indice)
        {
            if (dtv_encabezado_orden_material.Rows.Count == 0)
                return;

            dtv_encabezado_orden_material.ClearSelection();
            dtv_encabezado_orden_material.Rows[indice].Selected = true;
            dtv_encabezado_orden_material.CurrentCell =
                dtv_encabezado_orden_material.Rows[indice].Cells[0];
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            Fun_Cargar_Datos();
        }

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            Fun_Seleccionar_Fila(0);
        }

        private void Btn_fin_Click(object sender, EventArgs e)
        {
            int ultimaFila = dtv_encabezado_orden_material.Rows.Count - 1;
            Fun_Seleccionar_Fila(ultimaFila);
        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            if (dtv_encabezado_orden_material.CurrentRow == null)
                return;

            int filaActual = dtv_encabezado_orden_material.CurrentRow.Index;

            if (filaActual > 0)
                Fun_Seleccionar_Fila(filaActual - 1);
        }

        private void Btn_sig_Click(object sender, EventArgs e)
        {
            if (dtv_encabezado_orden_material.CurrentRow == null)
                return;

            int filaActual = dtv_encabezado_orden_material.CurrentRow.Index;
            int ultimaFila = dtv_encabezado_orden_material.Rows.Count - 1;

            if (filaActual < ultimaFila)
                Fun_Seleccionar_Fila(filaActual + 1);
        }

        private void Btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fun_Agregar_Boton_Ver()
        {
            if (dtv_encabezado_orden_material.Columns.Contains("VerDetalle"))
                return;

            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
            btnVer.Name = "VerDetalle";
            btnVer.HeaderText = "Acciones";
            btnVer.Text = "Ver";
            btnVer.UseColumnTextForButtonValue = true;

            dtv_encabezado_orden_material.Columns.Add(btnVer);
        }

        private void dtv_encabezado_orden_material_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dtv_encabezado_orden_material.Columns[e.ColumnIndex].Name == "VerDetalle")
            {
                int idOrden = Convert.ToInt32(
                    dtv_encabezado_orden_material.Rows[e.RowIndex]
                    .Cells["ID_Orden"].Value
                );

                Frm_Detalle_Orden_Material frmDetalle =
                    new Frm_Detalle_Orden_Material(idOrden);

                frmDetalle.ShowDialog();
            }
        }

        private void Btn_detalle_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Orden_Material frmDetalle =
                new Frm_Detalle_Orden_Material();

            frmDetalle.ShowDialog();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Orden frm = new Frm_Reporte_Orden();
            frm.ShowDialog();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            string[] sArr = { "Encabezado_Orden_Material" };

            using (var f = new Frm_Consulta_Simple(sArr))
            {
                this.Hide();
                f.ShowDialog(this);
                this.Show();
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                const string subRutaAyuda = @"DLLS\Orden_Material\Ayuda_Orden_Material\Encabezado Orden Material\Ayuda_EncOrdMat.chm";
                string rutaEncontrada = null;

                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);

                for (int i = 0; i < 10 && dir != null; i++, dir = dir.Parent)
                {
                    string candidata = Path.Combine(dir.FullName, subRutaAyuda);
                    if (File.Exists(candidata))
                    {
                        rutaEncontrada = candidata;
                        break;
                    }
                }
                string respaldo = @"C:\Users\arone\OneDrive\Escritorio\is2k26pf\codigo\empresarial\MRP - G1\DLLS\Orden_Material\Ayuda_Orden_Material\Encabezado Orden Material\Ayuda_EncOrdMat.chm";
                if (rutaEncontrada == null && File.Exists(respaldo))
                    rutaEncontrada = respaldo;

                if (rutaEncontrada != null)
                {
                    Help.ShowHelp(this, rutaEncontrada, HelpNavigator.Topic, "index.html");
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