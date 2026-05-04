using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
namespace Capa_Vista_CVRecetas
{
    public partial class Ver_Recetas : Form
    {
        string conexion = "DSN=bd_SIG;";

        public Ver_Recetas()
        {
            InitializeComponent();
            configurarDGV();
            cargarRecetas();
        }

        private void configurarDGV()
        {
            Dgv_ConsultarRE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_ConsultarRE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_ConsultarRE.MultiSelect = false;
            Dgv_ConsultarRE.ReadOnly = true;
            Dgv_ConsultarRE.AllowUserToAddRows = false;
            Dgv_ConsultarRE.AllowUserToDeleteRows = false;
            Dgv_ConsultarRE.RowHeadersVisible = false;
        }

        private void cargarRecetas()
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection(conexion))
                {
                    con.Open();

                    string query = @"
                        SELECT DISTINCT
                            m.Pk_Id_Materiales AS ID,
                            m.Nombre_Material AS Producto_Terminado,
                            b.Version_BOM AS Version,
                            b.Descripcion_BOM AS Descripcion,
                            b.Fecha_Creacion_BOM AS Fecha_Creacion
                        FROM Tbl_BOM b
                        INNER JOIN Tbl_BOM_Detalle d
                            ON b.Pk_Id_BOM = d.Fk_Id_BOM
                        INNER JOIN Tbl_Materiales m
                            ON b.Fk_Id_Material = m.Pk_Id_Materiales
                        INNER JOIN Tbl_Categoria_Material c
                            ON m.Fk_Id_Categoria = c.Pk_Id_Categoria_Material
                        INNER JOIN Tbl_Tipo_Material t
                            ON c.Fk_Tipo_Material = t.Pk_Id_Tipo_Material
                        WHERE t.Nombre_Tipo_Material = 'Producto Terminado';";

                    OdbcDataAdapter da = new OdbcDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Dgv_ConsultarRE.DataSource = dt;

                    // 🔥 FORMATO BONITO
                    if (Dgv_ConsultarRE.Columns.Count > 0)
                    {
                        Dgv_ConsultarRE.Columns["ID"].Visible = false;
                        Dgv_ConsultarRE.Columns["Producto_Terminado"].HeaderText = "Producto Terminado";
                        Dgv_ConsultarRE.Columns["Version"].HeaderText = "Versión BOM";
                        Dgv_ConsultarRE.Columns["Descripcion"].HeaderText = "Descripción";
                        Dgv_ConsultarRE.Columns["Fecha_Creacion"].HeaderText = "Fecha Creación";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar recetas: " + ex.Message);
            }
        }

    
    }
}
