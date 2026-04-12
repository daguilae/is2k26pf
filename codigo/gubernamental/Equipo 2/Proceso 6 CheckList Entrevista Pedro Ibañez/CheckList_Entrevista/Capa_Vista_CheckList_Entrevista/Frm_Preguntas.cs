using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CheckList_Entrevista;
namespace Capa_Vista_CheckList_Entrevista
{
    public partial class Frm_Preguntas : Form
    {
        public Frm_Preguntas(Frm_CheckList checklist)
        {
            InitializeComponent();
            chklst = checklist;
            cargar_preguntas();
            fun_CargarCombos();
        }

        Cls_Controlador_CheckList ctrl = new Cls_Controlador_CheckList();
        Frm_CheckList chklst;

        string sMensajeError = "";

        private void fun_CargarCombos()
        {
            //ComboBox Id Pregunta
            DataTable dtIDpregunta = ctrl.fun_CargarIdsPreguntas();
            Cbo_Pregunta_Id.DataSource = dtIDpregunta;
            Cbo_Pregunta_Id.DisplayMember = "PreguntaCompleta";
            Cbo_Pregunta_Id.ValueMember = "pk_pregunta_id";
            Cbo_Pregunta_Id.SelectedIndex = -1;
            //ComboBox Nivel Pregunta
            DataTable dtNivelpregunta = new DataTable();

            dtNivelpregunta.Columns.Add("Value", typeof(int));
            dtNivelpregunta.Columns.Add("Display", typeof(string));

            dtNivelpregunta.Rows.Add(1, "Nivel 1");
            dtNivelpregunta.Rows.Add(2, "Nivel 2");
            dtNivelpregunta.Rows.Add(3, "Nivel 3");

            //DataTable dtNivelpregunta = ctrl.fun_CargarNivelPreguntas();
            Cbo_Nivel_Pregunta.DataSource = dtNivelpregunta;
            Cbo_Nivel_Pregunta.DisplayMember = "Display";
            Cbo_Nivel_Pregunta.ValueMember = "Value";
            Cbo_Nivel_Pregunta.SelectedIndex = -1;
        }

        private void cargar_preguntas()
        {
            
            DataTable dtpreguntas = ctrl.fun_datos_pregunta();
            DGV_PREGUNTAS_REP.DataSource = dtpreguntas;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Filtrar_Click(object sender, EventArgs e)
        {
            int iIdPregunta = 0;
            int.TryParse(Cbo_Pregunta_Id.SelectedValue?.ToString(), out iIdPregunta);

            DataTable dtPreguntasFiltradas = ctrl.fun_ConsultarPorIdPreguntas(iIdPregunta);

            sMensajeError = ctrl.sMensaje;

            if (dtPreguntasFiltradas == null)
            {
                MessageBox.Show(sMensajeError,"ERROR", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                DGV_PREGUNTAS_REP.DataSource = null;
                DGV_PREGUNTAS_REP.DataSource = dtPreguntasFiltradas;
            }

           
        }

        private void BTN_FILTRAR_NV_Click(object sender, EventArgs e)
        {
            int iNvPregunta = 0;
            int.TryParse(Cbo_Nivel_Pregunta.SelectedValue?.ToString(), out iNvPregunta);

            DataTable dtPreguntasFiltradasNV = ctrl.fun_ConsultarPorNVPreguntas(iNvPregunta);

            sMensajeError = ctrl.sMensaje;

            if (dtPreguntasFiltradasNV == null)
            {
                MessageBox.Show(sMensajeError);
            }
            else
            {
                DGV_PREGUNTAS_REP.DataSource = null;
                DGV_PREGUNTAS_REP.DataSource = dtPreguntasFiltradasNV;
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
             if (DGV_PREGUNTAS_REP.CurrentRow != null)
    {
        int fila = DGV_PREGUNTAS_REP.CurrentRow.Index;

            chklst.AgregarPregunta(

            DGV_PREGUNTAS_REP.Rows[fila].Cells["pk_pregunta_id"].Value.ToString(),

            DGV_PREGUNTAS_REP.Rows[fila].Cells["Cmp_Enunciado_Pregunta"].Value.ToString(),

            DGV_PREGUNTAS_REP.Rows[fila].Cells["Cmp_Nivel"].Value.ToString()

        );
    }
    else
    {
        MessageBox.Show("Seleccione una fila","Aviso",MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
    }
        }

        private void BTN_RECARGAR_Click(object sender, EventArgs e)
        {
            Cbo_Pregunta_Id.SelectedIndex = -1;
            Cbo_Nivel_Pregunta.SelectedIndex = -1;
            cargar_preguntas();
            fun_CargarCombos();
        }
    }
}
