using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Balance;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Balance
{
    public partial class Frm_Balance_Menu : Form
    {
        Cls_BalanceControlador controlador = new Cls_BalanceControlador();
        private bool _canIngresar, _canConsultar, _canModificar, _canEliminar, _canImprimir;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public Frm_Balance_Menu()
        {
            InitializeComponent();
            Dtp_Inicio.Format = DateTimePickerFormat.Short;
            Dtp_Final.Format = DateTimePickerFormat.Short;
            fun_AplicarPermisos();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            DateTime inicio = Dtp_Inicio.Value.Date;
            DateTime fin = Dtp_Final.Value.Date;
           
                    

            if (inicio > fin)
            {
                MessageBox.Show("La fecha inicio no puede ser mayor que la fecha fin.");
                return;
            }

            try
            {
                DataTable dt = controlador.ObtenerAntiguedadSaldos(inicio, fin);

                // Aquí está lo importante:
                //dataGridView1.DataSource = dt;
            }
             
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar antigüedad de saldos: " + ex.Message);
            }
}
        private void fun_AplicarPermisos()
        {
            int idUsuario = Cls_Usuario_Conectado.iIdUsuario;
            var usuarioCtrl = new Cls_Usuario_Controlador();
            var permisoUsuario = new Cls_Permiso_Usuario_Controlador();

            // Módulo y aplicación específicos
            int idAplicacion = permisoUsuario.ObtenerIdAplicacionPorNombre("Balance de antiguedades CXC");
            if (idAplicacion <= 0) idAplicacion = 733;
            int idModulo = permisoUsuario.ObtenerIdModuloPorNombre("Logistica");
            int idPerfil = usuarioCtrl.ObtenerIdPerfilDeUsuario(idUsuario);

            var permisos = Cls_Aplicacion_Permisos.ObtenerPermisosCombinados(
                idUsuario, idAplicacion, idModulo, idPerfil);



            if (!permisos.ingresar && !permisos.consultar &&
                !permisos.modificar && !permisos.eliminar &&
                !permisos.imprimir)
            {
                MessageBox.Show("El usuario no tiene permisos asignados para esta aplicación.",
                                "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _canIngresar = permisos.ingresar;
            _canConsultar = permisos.consultar;
            _canModificar = permisos.modificar;
            _canEliminar = permisos.eliminar;
            _canImprimir = permisos.imprimir;


            // Asignar permisos
            _canIngresar = permisos.ingresar;
            _canConsultar = permisos.consultar;
            _canModificar = permisos.modificar;
            _canEliminar = permisos.eliminar;
            _canImprimir = permisos.imprimir;

            // Asignar permisos a controles
           
            if (Btn_Reporte != null) Btn_Reporte.Enabled = _canImprimir;

            // DataGridView y combos visibles si puede consultar

        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            if (!_canImprimir)
            {
                MessageBox.Show(
                    "No tiene permisos para imprimir",
                    "Permisos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DateTime desde = Dtp_Inicio.Value.Date;
                DateTime hasta = Dtp_Final.Value.Date;

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.");
                    return;
                }

                try
                {
                    // 1) Traer datos (usa el controlador que ya tienes arriba)
                    DataTable dt = controlador.ObtenerAntiguedadSaldos(desde, hasta);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para el rango seleccionado.");
                        return;
                    }

                // 2) Pasar a DataSet tipado (XSD)
                var ds = new DataSet1();
                ds.AntiguedadSaldos.Clear();

                foreach (DataRow r in dt.Rows)
                {
                    ds.AntiguedadSaldos.ImportRow(r);
                }


                // 3) Reporte
                var rpt = new Rpt_Balance_Menu(); // tu .rpt
                    rpt.SetDataSource(ds);

                // 4) Mostrar en el viewer (ASEGÚRATE que este sea el CrystalReportViewer)
                
                crystalReportViewer1.ReportSource = rpt;
                    crystalReportViewer1.RefreshReport();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar reporte: " + ex.Message);
                }
            }
        }
    }

 